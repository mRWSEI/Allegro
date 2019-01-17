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

        List<AllegroItem> allegroItems = new List<AllegroItem>();
        DataTable dt;

        public Form1()
        {
            //http://www.altcontroldelete.pl/artykuly/c-wpf-oraz-sqlite-razem-w-jednym-projekcie/


            InitializeComponent();
            /*
            dataGridViewAllegro.AutoGenerateColumns = true;
            dataGridViewAllegro.AutoSize = true;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Knight";
            dataGridViewAllegro.Columns.Add(column);

            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.Name = "Selected";
            dataGridViewAllegro.Columns.Add(c);
            */
            dataGridViewAllegro.AutoGenerateColumns = true;
            dataGridViewAllegro.DataSource = allegroItems;



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
            //dataGridViewAllegro.DataSource = null;
            Task T = Task.Run(() => SearchItem());
            //SearchItem();


            //check null
            //dataGridViewAllegro.DataSource = allegroItems;
            //var bindingList = new BindingList<AllegroItem>(allegroItems);
            //var source = new BindingSource(bindingList, null);

            //dataGridViewAllegro.DataSource = null;
            //dataGridViewAllegro.Columns.Clear();

            //DataGridTextBoxColumn csName = new DataGridTextBoxColumn();
            //csName.HeaderText = "naglowek";
            //csName.Cell
            /*
            DataGridViewTextBoxColumn csRandom = new DataGridViewTextBoxColumn();
                          
            csRandom.DataPropertyName = "productId";  // Public property name (as defined in the object)
            csRandom.HeaderText = "Random Number";      // Header name
            csRandom.DefaultCellStyle.Format = "#.#000";    // Format 
            dataGridViewAllegro.Columns.Add(csRandom);
            */
            //dataGridViewAllegro.DataSource = allegroItems.ToArray();
            //dataGridViewAllegro.Invoke(new Action(() => { dataGridViewAllegro.DataSource = dt; }));
            //dataGridViewAllegro.DataSource = result;
            //dataGridViewAllegro.DataSource = dt;
            T.ContinueWith((t) =>
            {
                dataGridViewAllegro.DataSource = dt;
            }, TaskScheduler.FromCurrentSynchronizationContext());

            //dataGridViewAllegro.Refresh(); 
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
