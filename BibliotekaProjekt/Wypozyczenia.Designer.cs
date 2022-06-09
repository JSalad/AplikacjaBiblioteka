
namespace BibliotekaProjekt
{
    partial class Wypozyczenia
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
            this.button4 = new System.Windows.Forms.Button();
            this.widokWypozyczenia = new System.Windows.Forms.DataGridView();
            this.buttonAddWypozyczenie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.wypozyczenieKsiazka = new System.Windows.Forms.ComboBox();
            this.labelKsiazka1 = new System.Windows.Forms.Label();
            this.wypozyczenieCzytelnik = new System.Windows.Forms.ComboBox();
            this.labelCzytelnik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widokWypozyczenia)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(21, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 40);
            this.button4.TabIndex = 39;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // widokWypozyczenia
            // 
            this.widokWypozyczenia.AllowUserToAddRows = false;
            this.widokWypozyczenia.AllowUserToDeleteRows = false;
            this.widokWypozyczenia.AllowUserToResizeColumns = false;
            this.widokWypozyczenia.AllowUserToResizeRows = false;
            this.widokWypozyczenia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokWypozyczenia.Location = new System.Drawing.Point(366, 14);
            this.widokWypozyczenia.MultiSelect = false;
            this.widokWypozyczenia.Name = "widokWypozyczenia";
            this.widokWypozyczenia.ReadOnly = true;
            this.widokWypozyczenia.RowHeadersVisible = false;
            this.widokWypozyczenia.RowTemplate.Height = 25;
            this.widokWypozyczenia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokWypozyczenia.ShowCellErrors = false;
            this.widokWypozyczenia.ShowCellToolTips = false;
            this.widokWypozyczenia.ShowEditingIcon = false;
            this.widokWypozyczenia.ShowRowErrors = false;
            this.widokWypozyczenia.Size = new System.Drawing.Size(506, 389);
            this.widokWypozyczenia.TabIndex = 37;
            // 
            // buttonAddWypozyczenie
            // 
            this.buttonAddWypozyczenie.Location = new System.Drawing.Point(21, 409);
            this.buttonAddWypozyczenie.Name = "buttonAddWypozyczenie";
            this.buttonAddWypozyczenie.Size = new System.Drawing.Size(240, 40);
            this.buttonAddWypozyczenie.TabIndex = 36;
            this.buttonAddWypozyczenie.Text = "Wypożycz";
            this.buttonAddWypozyczenie.UseVisualStyleBackColor = true;
            this.buttonAddWypozyczenie.Visible = false;
            this.buttonAddWypozyczenie.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 40);
            this.button2.TabIndex = 35;
            this.button2.Text = "Wypożycz książke";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 40);
            this.button1.TabIndex = 34;
            this.button1.Text = "Zwróć książke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wypozyczenieKsiazka
            // 
            this.wypozyczenieKsiazka.FormattingEnabled = true;
            this.wypozyczenieKsiazka.Location = new System.Drawing.Point(21, 379);
            this.wypozyczenieKsiazka.Name = "wypozyczenieKsiazka";
            this.wypozyczenieKsiazka.Size = new System.Drawing.Size(240, 25);
            this.wypozyczenieKsiazka.TabIndex = 40;
            this.wypozyczenieKsiazka.Visible = false;
            // 
            // labelKsiazka1
            // 
            this.labelKsiazka1.AutoSize = true;
            this.labelKsiazka1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelKsiazka1.Location = new System.Drawing.Point(21, 356);
            this.labelKsiazka1.Name = "labelKsiazka1";
            this.labelKsiazka1.Size = new System.Drawing.Size(51, 17);
            this.labelKsiazka1.TabIndex = 45;
            this.labelKsiazka1.Text = "Książka";
            this.labelKsiazka1.Visible = false;
            // 
            // wypozyczenieCzytelnik
            // 
            this.wypozyczenieCzytelnik.FormattingEnabled = true;
            this.wypozyczenieCzytelnik.Location = new System.Drawing.Point(21, 318);
            this.wypozyczenieCzytelnik.Name = "wypozyczenieCzytelnik";
            this.wypozyczenieCzytelnik.Size = new System.Drawing.Size(240, 25);
            this.wypozyczenieCzytelnik.TabIndex = 46;
            this.wypozyczenieCzytelnik.Visible = false;
            // 
            // labelCzytelnik
            // 
            this.labelCzytelnik.AutoSize = true;
            this.labelCzytelnik.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCzytelnik.Location = new System.Drawing.Point(21, 296);
            this.labelCzytelnik.Name = "labelCzytelnik";
            this.labelCzytelnik.Size = new System.Drawing.Size(58, 17);
            this.labelCzytelnik.TabIndex = 47;
            this.labelCzytelnik.Text = "Czytelnik";
            this.labelCzytelnik.Visible = false;
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.labelCzytelnik);
            this.Controls.Add(this.wypozyczenieCzytelnik);
            this.Controls.Add(this.labelKsiazka1);
            this.Controls.Add(this.wypozyczenieKsiazka);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.widokWypozyczenia);
            this.Controls.Add(this.buttonAddWypozyczenie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Wypozyczenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypozyczenia";
            this.Load += new System.EventHandler(this.Wypozyczenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokWypozyczenia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView widokWypozyczenia;
        private System.Windows.Forms.Button buttonAddWypozyczenie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ksiazka;
        private System.Windows.Forms.Label labelKsiazka1;
        private System.Windows.Forms.Label labekKsiazka;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelCzytelnik;
        private System.Windows.Forms.ComboBox wypozyczenieCzytelnik;
        private System.Windows.Forms.ComboBox wypozyczenieKsiazka;
    }
}