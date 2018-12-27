using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                //show token
                //MessageBox.Show(String.Format("Access Token: {0}", rest.accessToken));

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
            var items = ItemsClass.items.regular;
            foreach (var item in items)
            {
                AllegroItem itemObj = new AllegroItem();
                itemObj.freeDelivery = Convert.ToBoolean(item.delivery.availableForFree);
                itemObj.productId = Convert.ToInt64(item.id);
                itemObj.itemName = item.name;

                //delivery
                itemObj.freeDelivery = item.delivery.availableForFree;
                itemObj.priceDelivery = Convert.ToDecimal(item.delivery.lowestPrice.amount.Replace(".",","));

                //seller
                itemObj.company = item.seller.company;
                itemObj.superSeller = item.seller.superSeller;
                itemObj.sellerId = Convert.ToInt64(item.seller.id);

                itemObj.priceItem = Convert.ToDecimal(item.sellingMode.price.amount.Replace(".",","));
                itemObj.stockQuantity = Convert.ToInt32(item.stock.available);

                allegroItems.Add(itemObj);
                dt = ConvertToDataTable(allegroItems);
            }
        }

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}
