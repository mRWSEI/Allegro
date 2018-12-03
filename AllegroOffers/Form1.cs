using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AllegroOffers
{
    public partial class Form1 :Form
    {
        AllegroRest rest;

        public Form1()
        {
            //http://www.altcontroldelete.pl/artykuly/c-wpf-oraz-sqlite-razem-w-jednym-projekcie/


            InitializeComponent();

            DBMethods db = new DBMethods();
            if(!db.CheckDBExists())
            {
                throw new Exception("Błąd podłączenia bazy danych");
            }

            // inicjalizacja grida
            dataGridViewDB.AutoGenerateColumns = true;
            dataGridViewDB.DataSource = db.InitBinding();
            dataGridViewDB.DataMember = "Table";

        }

        private void btnSearchRequest_Click(object sender, EventArgs e)
        {
            SearchItem();
        }

        #region Events
        /// <summary>
        /// Pozwala wprowadzać jedynie liczby i kropki do pól z ceną
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if(e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
