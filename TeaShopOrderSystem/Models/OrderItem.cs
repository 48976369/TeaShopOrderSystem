using System;

namespace TeaShopOrderSystem.Models
{
    public class OrderItem
    {
        public string DrinkName { get; set; }
        public string Size { get; set; }
        public string Sugar { get; set; }
        public string Ice { get; set; }
        public string Toppings { get; set; }
        public int Quantity { get; set; }
        public int UnitPrice { get; set; }
        public int Subtotal { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(string drinkName, string size, string sugar, string ice, string toppings, int quantity, int unitPrice)
        {
            DrinkName = drinkName;
            Size = size;
            Sugar = sugar;
            Ice = ice;
            Toppings = toppings;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Subtotal = quantity * unitPrice;
        }
    }
}