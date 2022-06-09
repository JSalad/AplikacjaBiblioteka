using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BibliotekaProjekt
{
    public partial class Czytelnicy : Form
    {
        string currentEdit = "";

        private int UserId = 0;

        public void setUserId(int id)
        {
            UserId = id;
        }

        public int getUserId()
        {
            return UserId;
        }

        public Czytelnicy()
        {
            InitializeComponent();
        }

        private void Czytelnicy_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void loadData()
        {

            widokCzytelnicy.SelectionChanged -= new System.EventHandler(this.widokCzytelnicy_SelectionChanged);

            Database db = new Database();
            Dictionary<string, string> Parameters = new Dictionary<string, string>();

            DataTable data = db.Query("SELECT * FROM Czytelnik", Parameters);

            widokCzytelnicy.DataSource = data;
            if (data != null && data.Rows.Count > 0)
            {
                widokCzytelnicy.Columns[0].HeaderText = "ID";
                widokCzytelnicy.Columns[1].HeaderText = "Imię";
                widokCzytelnicy.Columns[2].HeaderText = "Nazwisko";
                widokCzytelnicy.Columns[3].HeaderText = "Telefon";

                widokCzytelnicy.ClearSelection();
                widokCzytelnicy.SelectionChanged += new System.EventHandler(this.widokCzytelnicy_SelectionChanged);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.setUserId(this.getUserId());
            stronaglowna.Show();
            this.Hide();
        }

        //dodaj w sensie sama zmiana w formularzu
        private void button2_Click(object sender, EventArgs e)
        {
            labelImie.Visible = true;
            czytelnikImie.Visible = true;
            czytelnikImie.Text = "";

            labelNazwisko.Visible = true;
            czytelnikNazwisko.Visible = true;
            czytelnikNazwisko.Text = "";

            labelTelefon.Visible = true;
            czytelnikTel.Visible = true;
            czytelnikTel.Text = "";


            czytelnikActionButton.Visible = true;
            czytelnikActionButton.Text = "Dodaj";
            czytelnikActionButton.Click += new System.EventHandler(createNew);
            czytelnikActionButton.Click -= new System.EventHandler(edit);
        }

        private void czytelnicyEditButton_Click()
        {
            labelImie.Visible = true;
            czytelnikImie.Visible = true;
            czytelnikImie.Text = widokCzytelnicy.SelectedRows[0].Cells[1].Value.ToString();

            labelNazwisko.Visible = true;
            czytelnikNazwisko.Visible = true;
            czytelnikNazwisko.Text = widokCzytelnicy.SelectedRows[0].Cells[2].Value.ToString();

            labelTelefon.Visible = true;
            czytelnikTel.Visible = true;
            czytelnikTel.Text = widokCzytelnicy.SelectedRows[0].Cells[3].Value.ToString();


            czytelnikActionButton.Visible = true;
            czytelnikActionButton.Text = "Zapisz zmiany";
            czytelnikActionButton.Click -= new System.EventHandler(createNew);
            czytelnikActionButton.Click += new System.EventHandler(edit);
        }

        private void createNew(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("Imie", czytelnikImie.Text);
            Parameters.Add("Nazwisko", czytelnikNazwisko.Text);
            Parameters.Add("Telefon", czytelnikTel.Text);

            int result = db.Exec("INSERT INTO Czytelnik (Imie, Nazwisko, Telefon) VALUES (@Imie, @Nazwisko, @Telefon)", Parameters);
            loadData();

            if (result > 0)
            {
                czytelnikImie.Text = "";
                czytelnikNazwisko.Text = "";
                czytelnikTel.Text = "";

                MessageBox.Show("Pomyślnie dodano nowego czytelnika");
            }

            loadData();
        }

        private void edit(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("Imie", czytelnikImie.Text);
            Parameters.Add("Nazwisko", czytelnikNazwisko.Text);
            Parameters.Add("Telefon", czytelnikTel.Text);
            Parameters.Add("id", currentEdit);

            int result = db.Exec("UPDATE Czytelnik SET Imie=@Imie, Nazwisko=@Nazwisko, Telefon=@Telefon WHERE idCzytelnik=@id", Parameters);

            if (result > 0)
            {
                MessageBox.Show("Czytelnik został zaktualizowany");
            }
            else
            {
                MessageBox.Show("Nie udało się zaktualizować czytelnika");
            }

            loadData();
        }

        private void widokCzytelnicy_SelectionChanged(object sender, EventArgs e)
        {
            if (widokCzytelnicy.SelectedRows.Count > 0)
            {
                currentEdit = widokCzytelnicy.SelectedRows[0].Cells[0].Value.ToString();
                czytelnicyEditButton_Click();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("id", currentEdit);

            int result = db.Exec("DELETE FROM Czytelnik WHERE idCzytelnik=@id", Parameters);

            if (result > 0)
            {
                MessageBox.Show("Czytelnik został usunięty");
            }
            else
            {
                MessageBox.Show("Nie udało się usunąć czytelnika");
            }

            hideForm(this, null);
            loadData();
        }

        private void hideForm(object sender, EventArgs e)
        {
            labelImie.Visible = false;
            czytelnikImie.Visible = false;
            czytelnikImie.Text = "";

            labelNazwisko.Visible = false;
            czytelnikNazwisko.Visible = false;
            czytelnikNazwisko.Text = "";

            labelTelefon.Visible = false;
            czytelnikTel.Visible = false;
            czytelnikTel.Text = "";

            czytelnikActionButton.Visible = false;
        }

        private void czytelnikActionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
