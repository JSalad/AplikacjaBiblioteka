
namespace BibliotekaProjekt
{
    partial class Czytelnicy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.czytelnikActionButton = new System.Windows.Forms.Button();
            this.widokCzytelnicy = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.czytelnikImie = new System.Windows.Forms.TextBox();
            this.czytelnikNazwisko = new System.Windows.Forms.TextBox();
            this.czytelnikTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.widokCzytelnicy)).BeginInit();
            this.SuspendLayout();
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImie.Location = new System.Drawing.Point(21, 208);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(32, 17);
            this.labelImie.TabIndex = 1;
            this.labelImie.Text = "Imię";
            this.labelImie.Visible = false;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNazwisko.Location = new System.Drawing.Point(21, 261);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(63, 17);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko";
            this.labelNazwisko.Visible = false;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefon.Location = new System.Drawing.Point(21, 314);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(99, 17);
            this.labelTelefon.TabIndex = 3;
            this.labelTelefon.Text = "Numer telefonu";
            this.labelTelefon.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Usuń czytelnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dodaj czytelnika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // czytelnikActionButton
            // 
            this.czytelnikActionButton.Location = new System.Drawing.Point(21, 361);
            this.czytelnikActionButton.Name = "czytelnikActionButton";
            this.czytelnikActionButton.Size = new System.Drawing.Size(240, 35);
            this.czytelnikActionButton.TabIndex = 6;
            this.czytelnikActionButton.Text = "Dodaj";
            this.czytelnikActionButton.UseVisualStyleBackColor = true;
            this.czytelnikActionButton.Visible = false;
            this.czytelnikActionButton.Click += new System.EventHandler(this.czytelnikActionButton_Click);
            // 
            // widokCzytelnicy
            // 
            this.widokCzytelnicy.AllowUserToAddRows = false;
            this.widokCzytelnicy.AllowUserToDeleteRows = false;
            this.widokCzytelnicy.AllowUserToOrderColumns = true;
            this.widokCzytelnicy.AllowUserToResizeColumns = false;
            this.widokCzytelnicy.AllowUserToResizeRows = false;
            this.widokCzytelnicy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.widokCzytelnicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokCzytelnicy.Location = new System.Drawing.Point(366, 12);
            this.widokCzytelnicy.MultiSelect = false;
            this.widokCzytelnicy.Name = "widokCzytelnicy";
            this.widokCzytelnicy.ReadOnly = true;
            this.widokCzytelnicy.RowHeadersVisible = false;
            this.widokCzytelnicy.RowTemplate.Height = 25;
            this.widokCzytelnicy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokCzytelnicy.ShowCellErrors = false;
            this.widokCzytelnicy.ShowCellToolTips = false;
            this.widokCzytelnicy.ShowEditingIcon = false;
            this.widokCzytelnicy.ShowRowErrors = false;
            this.widokCzytelnicy.Size = new System.Drawing.Size(506, 343);
            this.widokCzytelnicy.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(21, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // czytelnikImie
            // 
            this.czytelnikImie.Location = new System.Drawing.Point(21, 226);
            this.czytelnikImie.Name = "czytelnikImie";
            this.czytelnikImie.Size = new System.Drawing.Size(240, 23);
            this.czytelnikImie.TabIndex = 11;
            this.czytelnikImie.Visible = false;
            // 
            // czytelnikNazwisko
            // 
            this.czytelnikNazwisko.Location = new System.Drawing.Point(21, 281);
            this.czytelnikNazwisko.Name = "czytelnikNazwisko";
            this.czytelnikNazwisko.Size = new System.Drawing.Size(240, 23);
            this.czytelnikNazwisko.TabIndex = 12;
            this.czytelnikNazwisko.Visible = false;
            // 
            // czytelnikTel
            // 
            this.czytelnikTel.Location = new System.Drawing.Point(21, 334);
            this.czytelnikTel.Name = "czytelnikTel";
            this.czytelnikTel.Size = new System.Drawing.Size(240, 23);
            this.czytelnikTel.TabIndex = 13;
            this.czytelnikTel.Visible = false;
            // 
            // Czytelnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 407);
            this.Controls.Add(this.czytelnikTel);
            this.Controls.Add(this.czytelnikNazwisko);
            this.Controls.Add(this.czytelnikImie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.widokCzytelnicy);
            this.Controls.Add(this.czytelnikActionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.MaximumSize = new System.Drawing.Size(900, 446);
            this.MinimumSize = new System.Drawing.Size(900, 446);
            this.Name = "Czytelnicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Czytelnicy";
            this.Load += new System.EventHandler(this.Czytelnicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokCzytelnicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button czytelnikActionButton;
        private System.Windows.Forms.DataGridView widokCzytelnicy;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox czytelnikImie;
        private System.Windows.Forms.TextBox czytelnikNazwisko;
        private System.Windows.Forms.TextBox czytelnikTel;
    }
}