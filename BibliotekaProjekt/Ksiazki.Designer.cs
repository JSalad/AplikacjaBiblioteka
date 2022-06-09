
namespace BibliotekaProjekt
{
    partial class Ksiazki
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
            this.ksiazkiIsbn = new System.Windows.Forms.TextBox();
            this.ksiazkiGatunek = new System.Windows.Forms.TextBox();
            this.ksiazkiAutor = new System.Windows.Forms.TextBox();
            this.ksiazkiTytul = new System.Windows.Forms.TextBox();
            this.widokKsiazki = new System.Windows.Forms.DataGridView();
            this.ksiazkiActionButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.labelGatunek = new System.Windows.Forms.Label();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelTytul = new System.Windows.Forms.Label();
            this.ksiazkiRok = new System.Windows.Forms.TextBox();
            this.labelRok = new System.Windows.Forms.Label();
            this.labelIlosc = new System.Windows.Forms.Label();
            this.ksiazkiIlosc = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widokKsiazki)).BeginInit();
            this.SuspendLayout();
            // 
            // ksiazkiIsbn
            // 
            this.ksiazkiIsbn.Location = new System.Drawing.Point(21, 226);
            this.ksiazkiIsbn.Name = "ksiazkiIsbn";
            this.ksiazkiIsbn.Size = new System.Drawing.Size(240, 23);
            this.ksiazkiIsbn.TabIndex = 27;
            // 
            // ksiazkiGatunek
            // 
            this.ksiazkiGatunek.Location = new System.Drawing.Point(21, 173);
            this.ksiazkiGatunek.Name = "ksiazkiGatunek";
            this.ksiazkiGatunek.Size = new System.Drawing.Size(240, 23);
            this.ksiazkiGatunek.TabIndex = 26;
            // 
            // ksiazkiAutor
            // 
            this.ksiazkiAutor.Location = new System.Drawing.Point(21, 120);
            this.ksiazkiAutor.Name = "ksiazkiAutor";
            this.ksiazkiAutor.Size = new System.Drawing.Size(240, 23);
            this.ksiazkiAutor.TabIndex = 25;
            // 
            // ksiazkiTytul
            // 
            this.ksiazkiTytul.Location = new System.Drawing.Point(21, 67);
            this.ksiazkiTytul.Name = "ksiazkiTytul";
            this.ksiazkiTytul.Size = new System.Drawing.Size(240, 23);
            this.ksiazkiTytul.TabIndex = 24;
            // 
            // widokKsiazki
            // 
            this.widokKsiazki.AllowUserToAddRows = false;
            this.widokKsiazki.AllowUserToDeleteRows = false;
            this.widokKsiazki.AllowUserToResizeColumns = false;
            this.widokKsiazki.AllowUserToResizeRows = false;
            this.widokKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.widokKsiazki.Location = new System.Drawing.Point(366, 12);
            this.widokKsiazki.MultiSelect = false;
            this.widokKsiazki.Name = "widokKsiazki";
            this.widokKsiazki.ReadOnly = true;
            this.widokKsiazki.RowHeadersVisible = false;
            this.widokKsiazki.RowTemplate.Height = 25;
            this.widokKsiazki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.widokKsiazki.Size = new System.Drawing.Size(506, 343);
            this.widokKsiazki.TabIndex = 21;
            // 
            // ksiazkiActionButton
            // 
            this.ksiazkiActionButton.Location = new System.Drawing.Point(21, 361);
            this.ksiazkiActionButton.Name = "ksiazkiActionButton";
            this.ksiazkiActionButton.Size = new System.Drawing.Size(240, 35);
            this.ksiazkiActionButton.TabIndex = 20;
            this.ksiazkiActionButton.Text = "Dodaj";
            this.ksiazkiActionButton.UseVisualStyleBackColor = true;
            this.ksiazkiActionButton.Click += new System.EventHandler(this.ksiazkiActionButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Dodaj książke";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Usuń książke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIsbn.Location = new System.Drawing.Point(21, 208);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(79, 17);
            this.labelIsbn.TabIndex = 17;
            this.labelIsbn.Text = "Numer ISBN";
            // 
            // labelGatunek
            // 
            this.labelGatunek.AutoSize = true;
            this.labelGatunek.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGatunek.Location = new System.Drawing.Point(21, 155);
            this.labelGatunek.Name = "labelGatunek";
            this.labelGatunek.Size = new System.Drawing.Size(55, 17);
            this.labelGatunek.TabIndex = 16;
            this.labelGatunek.Text = "Gatunek";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAutor.Location = new System.Drawing.Point(21, 102);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(40, 17);
            this.labelAutor.TabIndex = 15;
            this.labelAutor.Text = "Autor";
            // 
            // labelTytul
            // 
            this.labelTytul.AutoSize = true;
            this.labelTytul.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTytul.Location = new System.Drawing.Point(21, 49);
            this.labelTytul.Name = "labelTytul";
            this.labelTytul.Size = new System.Drawing.Size(34, 17);
            this.labelTytul.TabIndex = 14;
            this.labelTytul.Text = "Tytuł";
            // 
            // ksiazkiRok
            // 
            this.ksiazkiRok.Location = new System.Drawing.Point(21, 281);
            this.ksiazkiRok.Name = "ksiazkiRok";
            this.ksiazkiRok.Size = new System.Drawing.Size(240, 23);
            this.ksiazkiRok.TabIndex = 29;
            // 
            // labelRok
            // 
            this.labelRok.AutoSize = true;
            this.labelRok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRok.Location = new System.Drawing.Point(21, 261);
            this.labelRok.Name = "labelRok";
            this.labelRok.Size = new System.Drawing.Size(81, 17);
            this.labelRok.TabIndex = 28;
            this.labelRok.Text = "Rok wydania";
            // 
            // labelIlosc
            // 
            this.labelIlosc.AutoSize = true;
            this.labelIlosc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIlosc.Location = new System.Drawing.Point(21, 314);
            this.labelIlosc.Name = "labelIlosc";
            this.labelIlosc.Size = new System.Drawing.Size(34, 17);
            this.labelIlosc.TabIndex = 30;
            this.labelIlosc.Text = "Ilosc";
            // 
            // ksiazkiIlosc
            // 
            this.ksiazkiIlosc.Location = new System.Drawing.Point(21, 334);
            this.ksiazkiIlosc.Name = "ksiazkiIlosc";
            this.ksiazkiIlosc.Size = new System.Drawing.Size(240, 23);
            this.ksiazkiIlosc.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(21, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 35);
            this.button4.TabIndex = 23;
            this.button4.Text = "Powrót";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Ksiazki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 407);
            this.Controls.Add(this.ksiazkiIlosc);
            this.Controls.Add(this.labelIlosc);
            this.Controls.Add(this.ksiazkiRok);
            this.Controls.Add(this.labelRok);
            this.Controls.Add(this.ksiazkiIsbn);
            this.Controls.Add(this.ksiazkiGatunek);
            this.Controls.Add(this.ksiazkiAutor);
            this.Controls.Add(this.ksiazkiTytul);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.widokKsiazki);
            this.Controls.Add(this.ksiazkiActionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelIsbn);
            this.Controls.Add(this.labelGatunek);
            this.Controls.Add(this.labelAutor);
            this.Controls.Add(this.labelTytul);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ksiazki";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ksiazki";
            this.Load += new System.EventHandler(this.Ksiazki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widokKsiazki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ksiazkiIsbn;
        private System.Windows.Forms.TextBox ksiazkiGatunek;
        private System.Windows.Forms.TextBox ksiazkiAutor;
        private System.Windows.Forms.TextBox ksiazkiTytul;
        private System.Windows.Forms.DataGridView widokKsiazki;
        private System.Windows.Forms.Button ksiazkiActionButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelGatunek;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelTytul;
        private System.Windows.Forms.TextBox ksiazkiRok;
        private System.Windows.Forms.Label labelRok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ksiazkiIlosc;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Gatunek;
        private System.Windows.Forms.Label labelIlosc;
    }
}