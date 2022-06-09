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
    public partial class Ksiazki : Form
    {
        string currentEdit;

        private int UserId = 0;

        public void setUserId(int id)
        {
            UserId = id;
        }

        public int getUserId()
        {
            return UserId;
        }
        public Ksiazki()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            widokKsiazki.SelectionChanged -= new System.EventHandler(this.widokKsiazki_SelectionChanged);

            Database db = new Database();
            Dictionary<string, string> Parameters = new Dictionary<string, string>();

            DataTable data = db.Query("SELECT * FROM Ksiazki", Parameters);

            widokKsiazki.DataSource = data;
            if (data != null && data.Rows.Count > 0)
            {
                widokKsiazki.Columns[0].HeaderText = "ID";
                widokKsiazki.Columns[1].HeaderText = "Tytuł";
                widokKsiazki.Columns[2].HeaderText = "Autor";
                widokKsiazki.Columns[3].HeaderText = "Gatunek";
                widokKsiazki.Columns[4].HeaderText = "ISBN";
                widokKsiazki.Columns[5].HeaderText = "Rok Wydania";
                widokKsiazki.Columns[6].HeaderText = "Ilość";

                widokKsiazki.ClearSelection();
                widokKsiazki.SelectionChanged += new System.EventHandler(this.widokKsiazki_SelectionChanged);
            }
        }

        private void widokKsiazki_SelectionChanged(object sender, EventArgs e)
        {
            if (widokKsiazki.SelectedRows.Count > 0)
            {
                currentEdit = widokKsiazki.SelectedRows[0].Cells[0].Value.ToString();
                ksiazkiActionButton.Click -= new System.EventHandler(this.edit);
                ksiazkiEditButton();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StronaGlowna stronaglowna = new StronaGlowna();
            stronaglowna.setUserId(this.getUserId());
            stronaglowna.Show();
            this.Hide();
        }

        private void Ksiazki_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void ksiazkiEditButton()
        {
            labelTytul.Visible = true;
            ksiazkiTytul.Visible = true;
            ksiazkiTytul.Text = widokKsiazki.SelectedRows[0].Cells[1].Value.ToString();

            labelAutor.Visible = true;
            ksiazkiAutor.Visible = true;
            ksiazkiAutor.Text = widokKsiazki.SelectedRows[0].Cells[2].Value.ToString();

            labelGatunek.Visible = true;
            ksiazkiGatunek.Visible = true;
            ksiazkiGatunek.Text = widokKsiazki.SelectedRows[0].Cells[3].Value.ToString();

            labelIsbn.Visible = true;
            ksiazkiIsbn.Visible = true;
            ksiazkiIsbn.Text = widokKsiazki.SelectedRows[0].Cells[4].Value.ToString();

            labelRok.Visible = true;
            ksiazkiRok.Visible = true;
            ksiazkiRok.Text = widokKsiazki.SelectedRows[0].Cells[5].Value.ToString();

            labelIlosc.Visible = true;
            ksiazkiIlosc.Visible = true;
            ksiazkiIlosc.Text = widokKsiazki.SelectedRows[0].Cells[6].Value.ToString();

            ksiazkiActionButton.Visible = true;
            ksiazkiActionButton.Text = "Zapisz zmiany";
            ksiazkiActionButton.Click -= new System.EventHandler(this.createNew);
            ksiazkiActionButton.Click += new System.EventHandler(this.edit);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelTytul.Visible = true;
            ksiazkiTytul.Visible = true;
            ksiazkiTytul.Text = "";

            labelAutor.Visible = true;
            ksiazkiAutor.Visible = true;
            ksiazkiAutor.Text = "";

            labelGatunek.Visible = true;
            ksiazkiGatunek.Visible = true;
            ksiazkiGatunek.Text = "";

            labelIsbn.Visible = true;
            ksiazkiIsbn.Visible = true;
            ksiazkiIsbn.Text = "";

            labelRok.Visible = true;
            ksiazkiRok.Visible = true;
            ksiazkiRok.Text = "";

            labelIlosc.Visible = true;
            ksiazkiIlosc.Visible = true;
            ksiazkiIlosc.Text = "";

            ksiazkiActionButton.Visible = true;
            ksiazkiActionButton.Text = "Dodaj";
            ksiazkiActionButton.Click += new System.EventHandler(this.createNew);
            ksiazkiActionButton.Click -= new System.EventHandler(this.edit);
        }

        private void createNew(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("Tytul", ksiazkiTytul.Text);
            Parameters.Add("Autor", ksiazkiAutor.Text);
            Parameters.Add("Gatunek", ksiazkiGatunek.Text);
            Parameters.Add("ISBN", ksiazkiIsbn.Text);
            Parameters.Add("RokWydania", ksiazkiRok.Text);
            Parameters.Add("Ilosc", ksiazkiIlosc.Text);

            int result = db.Exec("INSERT INTO Ksiazki (Tytul, Autor, Gatunek, ISBN, RokWydania, Ilosc) VALUES (@Tytul, @Autor, @Gatunek, @ISBN, @RokWydania, @Ilosc)", Parameters);

            if (result > 0)
            {
                ksiazkiTytul.Text = "";
                ksiazkiAutor.Text = "";
                ksiazkiGatunek.Text = "";
                ksiazkiIsbn.Text = "";
                ksiazkiRok.Text = "";
                ksiazkiIlosc.Text = "";

                MessageBox.Show("Pomyślnie dodano nową książke");
            }

            loadData();
        }

        private void edit(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("Tytul", ksiazkiTytul.Text);
            Parameters.Add("Autor", ksiazkiAutor.Text);
            Parameters.Add("Gatunek", ksiazkiGatunek.Text);
            Parameters.Add("ISBN", ksiazkiIsbn.Text);
            Parameters.Add("RokWydania", ksiazkiRok.Text);
            Parameters.Add("Ilosc", ksiazkiIlosc.Text);
            Parameters.Add("id", currentEdit);

            int result = db.Exec("UPDATE Ksiazki SET Tytul=@Tytul, Autor=@Autor, Gatunek=@Gatunek, ISBN=@ISBN, RokWydania=@RokWydania, Ilosc=@Ilosc WHERE idKsiazki=@id", Parameters);

            if (result > 0)
            {
                ksiazkiTytul.Text = "";
                ksiazkiAutor.Text = "";
                ksiazkiGatunek.Text = "";
                ksiazkiIsbn.Text = "";
                ksiazkiRok.Text = "";
                ksiazkiIlosc.Text = "";

                MessageBox.Show("Pomyślnie zapisano zmiany dla wskazanej książki");
            }

            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("id", currentEdit);

            int result = db.Exec("DELETE FROM Ksiazki WHERE idKsiazki=@id", Parameters);

            if (result > 0)
            {
                MessageBox.Show("Książka została usunięta");
            }
            else
            {
                MessageBox.Show("Nie udało się usunąć książki");
            }

            hideForm(this, null);
            loadData();

        }

        private void widokKsiazki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hideForm(object sender, EventArgs e)
        {
            labelTytul.Visible = false;
            ksiazkiTytul.Visible = false;
            ksiazkiTytul.Text = "";

            labelAutor.Visible = false;
            ksiazkiAutor.Visible = false;
            ksiazkiAutor.Text = "";

            labelGatunek.Visible = false;
            ksiazkiGatunek.Visible = false;
            ksiazkiGatunek.Text = "";

            labelIsbn.Visible = false;
            ksiazkiIsbn.Visible = false;
            ksiazkiIsbn.Text = "";

            labelRok.Visible = false;
            ksiazkiRok.Visible = false;
            ksiazkiRok.Text = "";

            labelIlosc.Visible = false;
            ksiazkiIlosc.Visible = false;
            ksiazkiIlosc.Text = "";

            ksiazkiActionButton.Visible = false;
        }

        private void ksiazkiActionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
