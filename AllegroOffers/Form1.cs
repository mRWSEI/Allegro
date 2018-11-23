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
            listBoxDB.BindingContext = BindingContext;
            DBMethods db = new DBMethods();
            if(db.CheckDBExists())
            {

            }
            

            listBoxDB.DataSource = db.InitBinding();
            
        }

        private void btnSearchRequest_Click(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void SearchItem()
        {
            try
            {
                rest = new AllegroRest();
                var x = rest.GetTokenJ().Result;
                //MessageBox.Show(String.Format("Access Token: {0}", rest.accessToken));

                AllegroOffers.Rootobject searchResponse = rest.requestSearchItem(textBoxKey.Text);
                searchResponse.categories.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
