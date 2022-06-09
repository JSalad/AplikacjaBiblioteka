using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BibliotekaProjekt
{
    public partial class StronaGlowna : Form
    {
        private int UserId = 0;

        public void setUserId(int id)
        {
            UserId = id;
        }

        public int getUserId()
        {
            return UserId;
        }

        public StronaGlowna()
        {
            InitializeComponent();
            //is.setUserId(3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.setUserId(0);
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Czytelnicy czytelnicy = new Czytelnicy();
            czytelnicy.setUserId(this.getUserId());
            czytelnicy.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Wypozyczenia wypozyczenia = new Wypozyczenia();
            wypozyczenia.setUserId(this.getUserId());
            wypozyczenia.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bibliotekarze bibliotekarze = new Bibliotekarze();
            bibliotekarze.setUserId(this.getUserId());
            bibliotekarze.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ksiazki ksiazki = new Ksiazki();
            ksiazki.setUserId(this.getUserId());
            ksiazki.Show();
            this.Hide();
        }
    }
}
