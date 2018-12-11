using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEnshu
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public OrderDto(int orderId, int itemId, int customerId, int quantity, DateTime date)
        {
            this.OrderId = orderId;
            this.ItemId = itemId;
            this.CustomerId = customerId;
            this.Quantity = quantity;
            this.Date = date;
        }
    }
}
