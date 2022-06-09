
namespace BibliotekaProjekt
{
    partial class Bibliotekarze
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
            this.bibliotekarzTel = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.bibliotekarzHaslo = new System.Windows.Forms.TextBox();
            this.bibliotekarzNazwisko = new System.Windows.Forms.TextBox();
            this.bibliotekarzImie = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.widokBibliotekarze = new System.Windows.Forms.DataGridView();
            this.bibliotekarzActionButton = new System.Windows.Forms.Button();
            this.bibliotekarzDeleteButton = new System.Windows.Forms.Button();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.bibliotekarzLogin = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.bibliotekarzAddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widokBibliotekarze)).BeginInit();
            this.SuspendLayout();
            // 
            // bibliotekarzTel
            // 
            this.bibliotekarzTel.Location = new System.Drawing.Point(21, 334);
            this.bibliotekarzTel.Name = "bibliotekarzTel";
            this.bibliotekarzTel.Size = new System.Drawing.Size(240, 23);
            this.bibliotekarzTel.TabIndex = 45;
            this.bibliotekarzTel.Visible = false;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefon.Location = new System.Drawing.Point(21, 314);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(99, 17);
            this.labelTelefon.TabIndex = 44;
            this.labelTelefon.Text = "Numer telefonu";
            this.labelTelefon.Visible = false;
            // 
            // bibliotekarzHaslo
            // 
            this.bibliotekarzHaslo.Location = new System.Drawing.Point(21, 281);
            this.bibliotekarzHaslo.Name = "bibliotekarzHaslo";
            this.bibliotekarzHaslo.Size = new System.Drawing.Size(240, 23);
            this.bibliotekarzHaslo.TabIndex = 44;
            this.bibliotekarzHaslo.Visible = false;
            // 
            // bibliotekarzNazwisko
            // 
            this.bibliotekarzNazwisko.Location = new System.Drawing.Point(21, 173);
            this.bibliotekarzNazwisko.Name = "bibliotekarzNazwisko";
            this.bibliotekarzNazwisko.Size = new System.Drawing.Size(240, 23);
            this.bibliotekarzNazwisko.TabIndex = 42;
            this.bibliotekarzNazwisko.Visible = false;
            // 
            // bibliotekarzImie
            // 
            this.bibliotekarzImie.Location = new System.Drawing.Point(21, 120);
            this.bibliotekarzImie.Name = "bibliotekarzImie";
            this.bibliotekarzImie.Size = new System.Drawing.Size(240, 23);
            this.bibliotekarzImie.TabIndex = 41;
            this.bibliotekarzImie.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(21, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 35);
            this.button4.TabIndex = 39;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // widokBibliotekarze
            // 
            this.widokBibliotekarze.AllowUserToAddRows = false;
            this.widokBibliotekarze.AllowUserToDeleteRows = false;
            this.widokBibliotekarze.AllowUserToOrderColumns = true;
            this.widokBibliotekarze.AllowUserToResizeColumns = false;
            this.widokBibliotekarze.AllowUserToResizeRows = false;
            this.widokBibliotekarze.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.widokBibliotekarze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokBibliotekarze.Location = new System.Drawing.Point(366, 12);
            this.widokBibliotekarze.MultiSelect = false;
            this.widokBibliotekarze.Name = "widokBibliotekarze";
            this.widokBibliotekarze.ReadOnly = true;
            this.widokBibliotekarze.RowHeadersVisible = false;
            this.widokBibliotekarze.RowTemplate.Height = 25;
            this.widokBibliotekarze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokBibliotekarze.Size = new System.Drawing.Size(506, 343);
            this.widokBibliotekarze.TabIndex = 37;
            this.widokBibliotekarze.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.widokBibliotekarze_CellContentClick);
            // 
            // bibliotekarzActionButton
            // 
            this.bibliotekarzActionButton.Location = new System.Drawing.Point(21, 361);
            this.bibliotekarzActionButton.Name = "bibliotekarzActionButton";
            this.bibliotekarzActionButton.Size = new System.Drawing.Size(240, 35);
            this.bibliotekarzActionButton.TabIndex = 35;
            this.bibliotekarzActionButton.Text = "Dodaj";
            this.bibliotekarzActionButton.UseVisualStyleBackColor = true;
            this.bibliotekarzActionButton.Visible = false;
            // 
            // bibliotekarzDeleteButton
            // 
            this.bibliotekarzDeleteButton.Location = new System.Drawing.Point(632, 361);
            this.bibliotekarzDeleteButton.Name = "bibliotekarzDeleteButton";
            this.bibliotekarzDeleteButton.Size = new System.Drawing.Size(240, 35);
            this.bibliotekarzDeleteButton.TabIndex = 34;
            this.bibliotekarzDeleteButton.Text = "Usuń bibliotekarza";
            this.bibliotekarzDeleteButton.UseVisualStyleBackColor = true;
            this.bibliotekarzDeleteButton.Click += new System.EventHandler(this.bibliotekarzDeleteButton_Click);
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHaslo.Location = new System.Drawing.Point(21, 261);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(41, 17);
            this.labelHaslo.TabIndex = 33;
            this.labelHaslo.Text = "Hasło";
            this.labelHaslo.Visible = false;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNazwisko.Location = new System.Drawing.Point(21, 155);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(63, 17);
            this.labelNazwisko.TabIndex = 32;
            this.labelNazwisko.Text = "Nazwisko";
            this.labelNazwisko.Visible = false;
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImie.Location = new System.Drawing.Point(21, 102);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(32, 17);
            this.labelImie.TabIndex = 31;
            this.labelImie.Text = "Imię";
            this.labelImie.Visible = false;
            // 
            // bibliotekarzLogin
            // 
            this.bibliotekarzLogin.Location = new System.Drawing.Point(21, 226);
            this.bibliotekarzLogin.Name = "bibliotekarzLogin";
            this.bibliotekarzLogin.Size = new System.Drawing.Size(240, 23);
            this.bibliotekarzLogin.TabIndex = 43;
            this.bibliotekarzLogin.Visible = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLogin.Location = new System.Drawing.Point(21, 208);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(120, 17);
            this.labelLogin.TabIndex = 47;
            this.labelLogin.Text = "Nazwa użytkownika";
            this.labelLogin.Visible = false;
            // 
            // bibliotekarzAddButton
            // 
            this.bibliotekarzAddButton.Location = new System.Drawing.Point(366, 361);
            this.bibliotekarzAddButton.Name = "bibliotekarzAddButton";
            this.bibliotekarzAddButton.Size = new System.Drawing.Size(240, 35);
            this.bibliotekarzAddButton.TabIndex = 48;
            this.bibliotekarzAddButton.Text = "Dodaj bibliotekarza";
            this.bibliotekarzAddButton.UseVisualStyleBackColor = true;
            this.bibliotekarzAddButton.Click += new System.EventHandler(this.bibliotekarzAddButton_Click);
            // 
            // Bibliotekarze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 407);
            this.Controls.Add(this.bibliotekarzAddButton);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.bibliotekarzLogin);
            this.Controls.Add(this.bibliotekarzTel);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.bibliotekarzHaslo);
            this.Controls.Add(this.bibliotekarzNazwisko);
            this.Controls.Add(this.bibliotekarzImie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.widokBibliotekarze);
            this.Controls.Add(this.bibliotekarzActionButton);
            this.Controls.Add(this.bibliotekarzDeleteButton);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.labelImie);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 446);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 446);
            this.Name = "Bibliotekarze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sytem biblioteczny - Bibliotekarze";
            this.Load += new System.EventHandler(this.Bibliotekarze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokBibliotekarze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bibliotekarzTel;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox bibliotekarzHaslo;
        private System.Windows.Forms.TextBox bibliotekarzNazwisko;
        private System.Windows.Forms.TextBox bibliotekarzImie;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView widokBibliotekarze;
        private System.Windows.Forms.Button bibliotekarzDeleteButton;
        private System.Windows.Forms.Label labelHaslo;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox bibliotekarzLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button bibliotekarzAddButton;
        private System.Windows.Forms.Button bibliotekarzActionButton;
    }
}