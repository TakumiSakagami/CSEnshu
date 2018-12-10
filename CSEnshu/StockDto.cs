using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    class StockDto
    {
        public int ItemId { get; set; }
        public int Stock { get; set; }

        public StockDto(int itemId, int stock)
        {
            this.ItemId = itemId;
            this.Stock = stock;
        }
    }
}
