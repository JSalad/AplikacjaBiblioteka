using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace BibliotekaProjekt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StronaGlowna main = new StronaGlowna();


            string login = textLogin.Text;
            string password = textPassword.Text;

            if (login == "")
            {
            MessageBox.Show("Proszę podać nazwę użytkownika");
            return;
            }

            if (password == "")
            {
            MessageBox.Show("Proszę podać hasło");
                return;
            }

            Database db = new Database();

            Dictionary<string, string> Parameters = new Dictionary<string, string>();
            Parameters.Add("Login", login);
            Parameters.Add("Haslo", password);

            DataTable data = db.Query("SELECT * FROM Bibliotekarz WHERE Login=@Login AND Haslo=@Haslo", Parameters);

            try
            {
                if(data.Rows.Count > 0)
                {
                    main.setUserId(data.Rows[0].Field<int>(0));
                    this.Hide();
                    main.Show();

                }
                else
                {
                   MessageBox.Show("Podane dane logowania są nieprawidłowe");
                }
            } catch(Exception ex){
                MessageBox.Show(ex.Message);
            }            

        }
    }
}
