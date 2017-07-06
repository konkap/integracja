namespace Zadanie3
{
    partial class Form1
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
            this.but_polacz = new System.Windows.Forms.Button();
            this.tB_zapytanie = new System.Windows.Forms.TextBox();
            this.but_zapytanie = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tB_serwer = new System.Windows.Forms.TextBox();
            this.tB_baza = new System.Windows.Forms.TextBox();
            this.tB_login = new System.Windows.Forms.TextBox();
            this.tB_haslo = new System.Windows.Forms.TextBox();
            this.lab_serwer = new System.Windows.Forms.Label();
            this.lab_baza = new System.Windows.Forms.Label();
            this.lab_login = new System.Windows.Forms.Label();
            this.lab_haslo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_polacz
            // 
            this.but_polacz.Location = new System.Drawing.Point(12, 12);
            this.but_polacz.Name = "but_polacz";
            this.but_polacz.Size = new System.Drawing.Size(146, 22);
            this.but_polacz.TabIndex = 0;
            this.but_polacz.Text = "Połącz";
            this.but_polacz.UseVisualStyleBackColor = true;
            this.but_polacz.Click += new System.EventHandler(this.but_polacz_Click);
            // 
            // tB_zapytanie
            // 
            this.tB_zapytanie.Location = new System.Drawing.Point(214, 12);
            this.tB_zapytanie.Name = "tB_zapytanie";
            this.tB_zapytanie.Size = new System.Drawing.Size(382, 20);
            this.tB_zapytanie.TabIndex = 1;
            // 
            // but_zapytanie
            // 
            this.but_zapytanie.Location = new System.Drawing.Point(602, 10);
            this.but_zapytanie.Name = "but_zapytanie";
            this.but_zapytanie.Size = new System.Drawing.Size(108, 22);
            this.but_zapytanie.TabIndex = 2;
            this.but_zapytanie.Text = "Zapytanie";
            this.but_zapytanie.UseVisualStyleBackColor = true;
            this.but_zapytanie.Click += new System.EventHandler(this.but_zapytanie_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(214, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // tB_serwer
            // 
            this.tB_serwer.Location = new System.Drawing.Point(58, 50);
            this.tB_serwer.Name = "tB_serwer";
            this.tB_serwer.Size = new System.Drawing.Size(100, 20);
            this.tB_serwer.TabIndex = 4;
            this.tB_serwer.Text = "localhost";
            // 
            // tB_baza
            // 
            this.tB_baza.Location = new System.Drawing.Point(58, 76);
            this.tB_baza.Name = "tB_baza";
            this.tB_baza.Size = new System.Drawing.Size(100, 20);
            this.tB_baza.TabIndex = 5;
            this.tB_baza.Text = "sakila";
            // 
            // tB_login
            // 
            this.tB_login.Location = new System.Drawing.Point(58, 104);
            this.tB_login.Name = "tB_login";
            this.tB_login.Size = new System.Drawing.Size(100, 20);
            this.tB_login.TabIndex = 6;
            this.tB_login.Text = "root";
            // 
            // tB_haslo
            // 
            this.tB_haslo.Location = new System.Drawing.Point(58, 130);
            this.tB_haslo.Name = "tB_haslo";
            this.tB_haslo.PasswordChar = '*';
            this.tB_haslo.Size = new System.Drawing.Size(100, 20);
            this.tB_haslo.TabIndex = 7;
            this.tB_haslo.Text = "Password1!";
            // 
            // lab_serwer
            // 
            this.lab_serwer.AutoSize = true;
            this.lab_serwer.Location = new System.Drawing.Point(9, 53);
            this.lab_serwer.Name = "lab_serwer";
            this.lab_serwer.Size = new System.Drawing.Size(43, 13);
            this.lab_serwer.TabIndex = 8;
            this.lab_serwer.Text = "Serwer:";
            // 
            // lab_baza
            // 
            this.lab_baza.AutoSize = true;
            this.lab_baza.Location = new System.Drawing.Point(9, 79);
            this.lab_baza.Name = "lab_baza";
            this.lab_baza.Size = new System.Drawing.Size(34, 13);
            this.lab_baza.TabIndex = 9;
            this.lab_baza.Text = "Baza:";
            // 
            // lab_login
            // 
            this.lab_login.AutoSize = true;
            this.lab_login.Location = new System.Drawing.Point(10, 107);
            this.lab_login.Name = "lab_login";
            this.lab_login.Size = new System.Drawing.Size(36, 13);
            this.lab_login.TabIndex = 10;
            this.lab_login.Text = "Login:";
            // 
            // lab_haslo
            // 
            this.lab_haslo.AutoSize = true;
            this.lab_haslo.Location = new System.Drawing.Point(9, 133);
            this.lab_haslo.Name = "lab_haslo";
            this.lab_haslo.Size = new System.Drawing.Size(39, 13);
            this.lab_haslo.TabIndex = 11;
            this.lab_haslo.Text = "Hasło:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 324);
            this.Controls.Add(this.lab_haslo);
            this.Controls.Add(this.lab_login);
            this.Controls.Add(this.lab_baza);
            this.Controls.Add(this.lab_serwer);
            this.Controls.Add(this.tB_haslo);
            this.Controls.Add(this.tB_login);
            this.Controls.Add(this.tB_baza);
            this.Controls.Add(this.tB_serwer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_zapytanie);
            this.Controls.Add(this.tB_zapytanie);
            this.Controls.Add(this.but_polacz);
            this.Name = "Form1";
            this.Text = "Klient MySQL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_polacz;
        private System.Windows.Forms.TextBox tB_zapytanie;
        private System.Windows.Forms.Button but_zapytanie;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tB_serwer;
        private System.Windows.Forms.TextBox tB_baza;
        private System.Windows.Forms.TextBox tB_login;
        private System.Windows.Forms.TextBox tB_haslo;
        private System.Windows.Forms.Label lab_serwer;
        private System.Windows.Forms.Label lab_baza;
        private System.Windows.Forms.Label lab_login;
        private System.Windows.Forms.Label lab_haslo;
    }
}

