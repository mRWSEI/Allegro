using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegroOffers
{
    class AllegroItem
    {
        public long productId;
        public string itemName;
        public decimal priceItem;
        public decimal priceDelivery;
        public bool freeDelivery;
        public long sellerId;
        public bool company;
        public bool superSeller;
        public int stockQuantity;
    }
}
