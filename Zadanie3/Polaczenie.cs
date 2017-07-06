using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data;
using System.Data;
namespace Zadanie3
{
    class Polaczenie
    {
        private MySqlConnection polaczenie;
        string serwer;
        string bazaDanych;
        string login;
        string haslo;

        public Polaczenie(string serwer, string bazaDanych, string login, string haslo) 
        {
            this.serwer = serwer;
            this.bazaDanych = bazaDanych;
            this.login = login;
            this.haslo = haslo;     
        }
  
        private bool sprawdzaniePolaczenia(string serwer, string bazaDanych, string login, string haslo)
        {
            string daneLogowania = "SERVER=" + serwer + ";" + "DATABASE=" +
                bazaDanych + ";" + "UID=" + login + ";" + "PASSWORD=" + haslo + ";";
            polaczenie = new MySqlConnection(daneLogowania);
            try
            {
                polaczenie.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void polaczenieZBaza()
        {
            if (sprawdzaniePolaczenia(serwer, bazaDanych, login, haslo))
                MessageBox.Show("Połączenie zostało wykonane");
            else
                MessageBox.Show("Nie można nawiązać połącznia");
        }

        public void wyswietlanieDanych(DataGridView data, string zapytanie)
        {
            if (sprawdzaniePolaczenia(serwer, bazaDanych, login, haslo))
            {
                MySqlCommand cmd = new MySqlCommand(zapytanie, polaczenie);
                MySqlDataAdapter odczytanie = new MySqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                try
                {
                    odczytanie.Fill(DS);
                    data.DataSource = DS.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem z zapytaniem");
                }
                
            }
        }
    }
}
