using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class ItemsDto
    {

        public int ItemId { get; set; }
        public String ItemName { get; set; }
        public int Price { get; set; }
        public ItemsDto(int itemId, String ItemName, int price)
        {
            this.ItemId = itemId;
            this.ItemName = ItemName;
            this.Price = price;
        }
    }
}
