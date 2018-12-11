using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    public class ItemsDto
    {

        public int ItemId { get; set; }
        public String ItemName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }


        public ItemsDto(int itemId, String itemName, int price,int stock)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
            this.Price = price;
            this.Stock = stock;
        }
    }
}
