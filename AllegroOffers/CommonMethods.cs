using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllegroOffers
{
    public partial class Form1
    {
        private void SearchItem()
        {
            try
            {
                rest = new AllegroRest();
                //var z = rest.GetTokenK();
                var x = rest.GetTokenJ().Result;
                MessageBox.Show(String.Format("Access Token: {0}", rest.accessToken));

                AllegroOffers.Rootobject searchResponse = rest.requestSearchItem(textBoxProductName.Text);
                GetItemsCollection(searchResponse);
                searchResponse.categories.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetItemsCollection(Rootobject ItemsClass)
        {

        }
    }
}
