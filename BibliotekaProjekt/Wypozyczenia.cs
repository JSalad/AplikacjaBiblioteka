using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotekaProjekt
{
    public partial class Wypozyczenia : Form
    {
        int cenaZaDzien = 3;

        private int UserId = 0;

        public void setUserId(int id)
        {
            UserId = id;
        }
        //s
        public int getUserId()
        {
            return UserId;
        }

        public Wypozyczenia()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            Database db = new Database();
            Dictionary<string, string> Parameters = new Dictionary<string, string>();

            DataTable data = db.Query("SELECT idWypozyczenia, Ksiazki.Tytul, CONCAT(Czytelnik.Imie, ' ', Czytelnik.Nazwisko), CONCAT(Bibliotekarz1.Imie, ' ', Bibliotekarz1.Nazwisko), dataWypozyczenia, DATE_ADD(dataWypozyczenia, INTERVAL 2 WEEK) FROM Wypozyczenia " +
                                                                                     "LEFT JOIN Ksiazki ON Wypozyczenia.idKsiazka = Ksiazki.idKsiazki " +
                                                                                     "LEFT JOIN Czytelnik ON Wypozyczenia.IdCzytelnik = Czytelnik.idCzytelnik " +
                                                                                     "LEFT JOIN Bibliotekarz as Bibliotekarz1 ON Wypozyczenia.osobaWypozyczajaca = Bibliotekarz1.idBibliotekarz " +
                                                                                     "WHERE ISNULL(dataOdbioru)", Parameters);

            widokWypozyczenia.DataSource = data;
            if (data != null && data.Rows.Count > 0)
            {
                widokWypozyczenia.Columns[0].HeaderText = "ID";
                widokWypozyczenia.Columns[1].HeaderText = "Ksiazka";
                widokWypozyczenia.Columns[2].HeaderText = "Czytelnik";
                widokWypozyczenia.Columns[3].HeaderText = "Wypozyczył";
                widokWypozyczenia.Columns[4].HeaderText = "Data wypożyczenia";
                widokWypozyczenia.Columns[5].HeaderText = "Termin zwrotu";

                widokWypozyczenia.ClearSelection();
            }
        }

        private void Wypozyczenia_Load(object sender, EventArgs e)
        {
            loadData();


            Database db = new Database();
            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            MySqlDataReader reader = db.Query2("SELECT Tytul, idKSiazki FROM Ksiazki Where Ilosc > 0", Parameters);

            while (reader.Read())
            {
                wypozyczenieKsiazka.Items.Add(reader["Tytul"].ToString());
            }
            reader.Close();
            db.Close();

            Database db1 = new Database();
            MySqlDataReader reader1 = db1.Query2("SELECT CONCAT(Imie, ' ', Nazwisko) as Nazwa FROM Czytelnik", Parameters);
            while (reader1.Read())
            {
                wypozyczenieCzytelnik.Items.Add(reader1["Nazwa"].ToString());
            }
            reader1.Close();
            db1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ksiazka = wypozyczenieKsiazka.SelectedItem.ToString();
            string czytelnik_s = wypozyczenieCzytelnik.SelectedItem.ToString();
            string[] czytelnik = czytelnik_s.Split(" ");

            Database db_q = new Database();
            Dictionary<string, string> Parameters_q = new Dictionary<string, string>();
            Parameters_q.Add("Tytul", ksiazka);

            MySqlDataReader query = db_q.Query2("SELECT Ilosc FROM Ksiazki Where Tytul=@Tytul LIMIT 1", Parameters_q);
            int ksiazka_ilosc = 0;
            while (query.Read())
            {
                ksiazka_ilosc = Convert.ToInt32(query["Ilosc"]);
                if(ksiazka_ilosc < 1)
                {
                    MessageBox.Show("Nie ma już dostępnych egzemplarzy wskazanej książki");
                    return;
                }
            }
            query.Close();
            db_q.Close();



            Database db = new Database();
            Dictionary<string, string> Parameters = new Dictionary<string, string>();

            Parameters.Add("User", Convert.ToString(this.getUserId()));
            Parameters.Add("Tytul", ksiazka);
            Parameters.Add("Imie", czytelnik[0]);
            Parameters.Add("Nazwisko", czytelnik[1]);

            int result = db.Exec("INSERT INTO Wypozyczenia (idKsiazka, idCzytelnik, OsobaWypozyczajaca, dataWypozyczenia) VALUES ((SELECT idKsiazki FROM Ksiazki WHERE Tytul=@Tytul),(SELECT idCzytelnik FROM Czytelnik WHERE Imie=@Imie AND Nazwisko=@Nazwisko),@User, current_date())", Parameters);


            if (result > 0)
            {
                db.Close();
                Database db_e = new Database();
                Dictionary<string, string> Parameters_exec = new Dictionary<string, string>();

                Parameters_exec.Add("Ilosc", Convert.ToString(ksiazka_ilosc - 1));
                Parameters_exec.Add("Tytul", ksiazka);
                db_e.Exec("UPDATE Ksiazki SET Ilosc=@Ilosc WHERE Tytul=@Tytul", Parameters_exec);
                db_e.Close();


                MessageBox.Show("Książka została wypożyczona");
            }

            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.setUserId(this.getUserId());
            stronaglowna.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelCzytelnik.Visible = true;
            labelKsiazka1.Visible = true;
            wypozyczenieCzytelnik.Visible = true;
            wypozyczenieKsiazka.Visible = true;
            buttonAddWypozyczenie.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idWypozyczenie = Convert.ToInt32(widokWypozyczenia.SelectedRows[0].Cells[0].Value);
            string ksiazka = widokWypozyczenia.SelectedRows[0].Cells[1].Value.ToString();

            Database db_q = new Database();
            Dictionary<string, string> Parameters_query = new Dictionary<string, string>();
            Parameters_query.Add("idWypozyczenia", idWypozyczenie.ToString());

            MySqlDataReader query = db_q.Query2("SELECT * FROM Wypozyczenia WHERE idWypozyczenia=@idWypozyczenia", Parameters_query);
            DateTime dataWypozyczenia = new DateTime();
            try
            {
                while (query.Read())
                {
                    DateTime now = DateTime.Now;
                    dataWypozyczenia = DateTime.Parse(query["dataWypozyczenia"].ToString()).AddDays(14);

                    int compare = DateTime.Compare(dataWypozyczenia, now);

                    if (compare < 0)
                    {
                        int difference = Convert.ToInt32((dataWypozyczenia - now).TotalDays);
                        if (difference < 0)
                        {
                            difference = difference * -1;
                        }


                        DialogResult dialogResult = MessageBox.Show("Podana książka została oddana po terminie zwrotu. Wymagane jest pobranie opłaty w wysokości: " + (cenaZaDzien * difference) + " eurogąbek za spóźnienie " + difference + " dni", "Wymagana opłata", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Database db_e = new Database();
                            Dictionary<string, string> Parameters_exec = new Dictionary<string, string>();
                            Parameters_exec.Add("Tytul", ksiazka);

                            db_e.Exec("UPDATE Ksiazki SET Ilosc=Ilosc+1 WHERE Tytul=@Tytul", Parameters_exec);
                            db_e.Close();


                            Database db = new Database();
                            Dictionary<string, string> Parameters = new Dictionary<string, string>();
                            Parameters.Add("Osoba", this.getUserId().ToString());
                            Parameters.Add("Id", idWypozyczenie.ToString());

                            db.Exec("UPDATE Wypozyczenia SET osobaOdbierajaca=@Osoba, dataOdbioru=current_date() WHERE idWypozyczenia=@Id", Parameters);
                            db.Close();

                            MessageBox.Show("Książka została zwrócona");

                            db_q.Close();

                            loadData();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            db_q.Close();
                        }

                    }
                    else
                    {
                        Database db_e = new Database();
                        Dictionary<string, string> Parameters_exec = new Dictionary<string, string>();
                        Parameters_exec.Add("Tytul", ksiazka);

                        db_e.Exec("UPDATE Ksiazki SET Ilosc=Ilosc+1 WHERE Tytul=@Tytul", Parameters_exec);
                        db_e.Close();


                        Database db = new Database();
                        Dictionary<string, string> Parameters = new Dictionary<string, string>();
                        Parameters.Add("Osoba", this.getUserId().ToString());
                        Parameters.Add("Id", idWypozyczenie.ToString());

                        db.Exec("UPDATE Wypozyczenia SET osobaOdbierajaca=@Osoba, dataOdbioru=current_date() WHERE idWypozyczenia=@Id", Parameters);
                        db.Close();

                        MessageBox.Show("Książka została zwrócona");

                        loadData();
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

            query.Close();






        }
    }
}
 


