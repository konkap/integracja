using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        Polaczenie polacz;

        public Form1()
        {
            InitializeComponent();
        }

        private void but_zapytanie_Click(object sender, EventArgs e)
        {
            polacz.wyswietlanieDanych(dataGridView1, tB_zapytanie.Text); 
        }

        private void but_polacz_Click(object sender, EventArgs e)
        {
            polacz = new Polaczenie(tB_serwer.Text, tB_baza.Text, tB_login.Text, tB_haslo.Text);
            polacz.polaczenieZBaza(); 
        }
    }
}
