using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace BibliotekaProjekt
{
    public partial class Bibliotekarze : Form
    {
        public string currentEdit = "";

        private int UserId = 0;

        public void setUserId(int id)
        {
            UserId = id;
        }

        public int getUserId()
        {
            return UserId;
        }

        public Bibliotekarze()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            widokBibliotekarze.SelectionChanged -= new System.EventHandler(this.widokBibliotekarze_SelectionChanged);

            Database db = new Database();
            Dictionary<string, string> Parameters = new Dictionary<string, string>();

            DataTable data = db.Query("SELECT idBibliotekarz,Login,Imie,Nazwisko,Telefon FROM Bibliotekarz", Parameters);

            widokBibliotekarze.DataSource = data;
            if(data != null && data.Rows.Count > 0)
            {
                widokBibliotekarze.Columns[0].HeaderText = "ID";
                widokBibliotekarze.Columns[1].HeaderText = "Nazwa użytkownika";
                widokBibliotekarze.Columns[2].HeaderText = "Imię";
                widokBibliotekarze.Columns[3].HeaderText = "Nazwisko";
                widokBibliotekarze.Columns[4].HeaderText = "Telefon";

                widokBibliotekarze.ClearSelection();
                widokBibliotekarze.SelectionChanged += new System.EventHandler(this.widokBibliotekarze_SelectionChanged);
            }

        }

        //powrot na glowna
        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.setUserId(this.getUserId());
            stronaglowna.Show();
            this.Hide();
        }

        private void Bibliotekarze_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void widokBibliotekarze_SelectionChanged(object sender, EventArgs e)
        {
            if (widokBibliotekarze.SelectedRows.Count > 0)
            {
                currentEdit = widokBibliotekarze.SelectedRows[0].Cells[0].Value.ToString();
                bibliotekarzEditButton_Click();
            }
        }

        //dodaj nowego
        private void createNew(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("Imie", bibliotekarzImie.Text);
            Parameters.Add("Nazwisko", bibliotekarzNazwisko.Text);
            Parameters.Add("Login", bibliotekarzLogin.Text);
            Parameters.Add("Haslo", bibliotekarzHaslo.Text);
            Parameters.Add("Telefon", bibliotekarzTel.Text);

            int result = db.Exec("INSERT INTO Bibliotekarz (Imie, Nazwisko, Login, Haslo, Telefon) VALUES (@Imie, @Nazwisko, @Login, @Haslo, @Telefon)", Parameters);

            if (result > 0)
            {
                bibliotekarzImie.Text = "";
                bibliotekarzNazwisko.Text = "";
                bibliotekarzLogin.Text = "";
                bibliotekarzHaslo.Text = "";
                bibliotekarzTel.Text = "";

                MessageBox.Show("Pomyślnie dodano nowego bibliotekarza");
            }

            loadData();
        }

        //edytuj istniejacego
        private void edit(object sender, EventArgs e)
        {
            Database db = new Database();

            if(bibliotekarzHaslo.TextLength > 0)
            {
                Dictionary<string, string> Parameters = new Dictionary<string, string>();
                Parameters.Add("Imie", bibliotekarzImie.Text);
                Parameters.Add("Nazwisko", bibliotekarzNazwisko.Text);
                Parameters.Add("Login", bibliotekarzLogin.Text);
                Parameters.Add("Haslo", bibliotekarzHaslo.Text);
                Parameters.Add("Telefon", bibliotekarzTel.Text);
                Parameters.Add("id", currentEdit);

                int result = db.Exec("UPDATE Bibliotekarz SET Imie=@Imie, Nazwisko=@Nazwisko, Login=@Login, Haslo=@Haslo, Telefon=@Telefon WHERE idBibliotekarz=@id", Parameters);

                if (result > 0)
                {
                    MessageBox.Show("Bibliotekarz został zaktualizowany");
                }
                else
                {
                    MessageBox.Show("Nie udało się zaktualizować bibliotekarza");
                }
            }
            else
            {
                Dictionary<string, string> Parameters = new Dictionary<string, string>();
                Parameters.Add("Imie", bibliotekarzImie.Text);
                Parameters.Add("Nazwisko", bibliotekarzNazwisko.Text);
                Parameters.Add("Login", bibliotekarzLogin.Text);
                Parameters.Add("Telefon", bibliotekarzTel.Text);
                Parameters.Add("id", currentEdit);

                int result = db.Exec("UPDATE Bibliotekarz SET Imie=@Imie, Nazwisko=@Nazwisko, Login=@Login, Telefon=@Telefon WHERE idBibliotekarz=@id", Parameters);

                if (result > 0)
                {
                    MessageBox.Show("Bibliotekarz został zaktualizowany");
                }
                else
                {
                    MessageBox.Show("Nie udało się zaktualizować bibliotekarza");
                }
            }



            loadData();
        }

        private void bibliotekarzDeleteButton_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("id", currentEdit);

            int result = db.Exec("DELETE FROM Bibliotekarz WHERE idBibliotekarz=@id", Parameters);

            if (result > 0)
            {
                MessageBox.Show("Bibliotekarz został usunięty");
            }
            else
            {
                MessageBox.Show("Nie udało się usunąć bibliotekarza");
            }

            hideForm(this, null);
            loadData();
        }

        private void bibliotekarzAddButton_Click(object sender, EventArgs e)
        {
            labelImie.Visible = true;
            bibliotekarzImie.Visible = true;
            bibliotekarzImie.Text = "";

            labelNazwisko.Visible = true;
            bibliotekarzNazwisko.Visible = true;
            bibliotekarzNazwisko.Text = "";

            labelLogin.Visible = true;
            bibliotekarzLogin.Visible = true;
            bibliotekarzLogin.Text = "";

            labelHaslo.Visible = true;
            bibliotekarzHaslo.Visible = true;
            bibliotekarzHaslo.Text = "";

            labelTelefon.Visible = true;
            bibliotekarzTel.Visible = true;
            bibliotekarzTel.Text = "";

            bibliotekarzActionButton.Visible = true;
            bibliotekarzActionButton.Text = "Dodaj nowego bibliotekarza";
            bibliotekarzActionButton.Click -= new System.EventHandler(edit);
            bibliotekarzActionButton.Click += new System.EventHandler(createNew);
        }

        private void hideForm(object sender, EventArgs e)
        {
            labelImie.Visible = false;
            bibliotekarzImie.Visible = false;
            bibliotekarzImie.Text = "";

            labelNazwisko.Visible = false;
            bibliotekarzNazwisko.Visible = false;
            bibliotekarzNazwisko.Text = "";

            labelLogin.Visible = false;
            bibliotekarzLogin.Visible = false;
            bibliotekarzLogin.Text = "";

            labelHaslo.Visible = false;
            bibliotekarzHaslo.Visible = false;
            bibliotekarzHaslo.Text = "";

            labelTelefon.Visible = false;
            bibliotekarzTel.Visible = false;
            bibliotekarzTel.Text = "";

            bibliotekarzActionButton.Visible = false;
        }

        private void bibliotekarzEditButton_Click()
        {
            labelImie.Visible = true;
            bibliotekarzImie.Visible = true;
            bibliotekarzImie.Text = widokBibliotekarze.SelectedRows[0].Cells[2].Value.ToString();

            labelNazwisko.Visible = true;
            bibliotekarzNazwisko.Visible = true;
            bibliotekarzNazwisko.Text = widokBibliotekarze.SelectedRows[0].Cells[3].Value.ToString();

            labelLogin.Visible = true;
            bibliotekarzLogin.Visible = true;
            bibliotekarzLogin.Text = widokBibliotekarze.SelectedRows[0].Cells[1].Value.ToString();


            labelHaslo.Visible = true;
            bibliotekarzHaslo.Visible = true;

            labelTelefon.Visible = true;
            bibliotekarzTel.Visible = true;
            bibliotekarzTel.Text = widokBibliotekarze.SelectedRows[0].Cells[4].Value.ToString();


            bibliotekarzActionButton.Visible = true;
            bibliotekarzActionButton.Text = "Zapisz zmiany";
            bibliotekarzActionButton.Click -= new System.EventHandler(createNew);
            bibliotekarzActionButton.Click += new System.EventHandler(edit);
        }

        private void widokBibliotekarze_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

