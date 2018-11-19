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
        public Form1()
        {
            //http://www.altcontroldelete.pl/artykuly/c-wpf-oraz-sqlite-razem-w-jednym-projekcie/


            InitializeComponent();
            //service = new AllegroWebApi();// inicjalizacja obiektu service
            //service.GetItems();
            listBoxDB.BindingContext = BindingContext;
            DBMethods db = new DBMethods();
            listBoxDB.DataSource = db.InitBinding();

            string response = null;
            try
            {
                AllegroRest rest = new AllegroRest();
                //var a = rest.GetAccessToken();
                //var z = rest.GetTokenK();
                var x = rest.GetTokenJ().Result;
                //MessageBox.Show(String.Format("Access Token: {0}", rest.accessToken));

                //System.Threading.Thread.Sleep(5000);
                var z = rest.makeRequest();
                //JSONObject flight = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONObject>(response);
                //JSONObject deserializedProduct = JsonConvert.DeserializeObject<JSONObject>(response);



            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
