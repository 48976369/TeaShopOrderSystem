using System;

namespace TeaShopOrderSystem.Models
{
    public class OrderRecord
    {
        public string OrderId { get; set; }
        public DateTime OrderTime { get; set; }
        public string DrinkName { get; set; }
        public string Size { get; set; }
        public string Sugar { get; set; }
        public string Ice { get; set; }
        public string Toppings { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }
        public int Total { get; set; }

        public OrderRecord()
        {
        }

        public OrderRecord(string orderId, DateTime orderTime, string drinkName, string size, string sugar, string ice, string toppings, int quantity, int subtotal, int total)
        {
            OrderId = orderId;
            OrderTime = orderTime;
            DrinkName = drinkName;
            Size = size;
            Sugar = sugar;
            Ice = ice;
            Toppings = toppings;
            Quantity = quantity;
            Subtotal = subtotal;
            Total = total;
        }
    }
}