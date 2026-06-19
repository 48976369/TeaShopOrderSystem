using System;

namespace TeaShopOrderSystem.Models
{
    public class Drink
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int BasePrice { get; set; }
        public bool Available { get; set; }

        public Drink()
        {
        }

        public Drink(string id, string name, string category, int basePrice, bool available)
        {
            Id = id;
            Name = name;
            Category = category;
            BasePrice = basePrice;
            Available = available;
        }
    }
}