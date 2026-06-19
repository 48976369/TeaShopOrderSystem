using System;
using System.Collections.Generic;
using System.IO;
using TeaShopOrderSystem.Models;

namespace TeaShopOrderSystem.Services
{
    public class FileService
    {
        private static readonly string DataFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        private static readonly string DrinksFile =
            Path.Combine(DataFolder, "drinks.csv");
        private static readonly string OrdersFile =
            Path.Combine(DataFolder, "orders.csv");
        public static List<Drink> LoadDrinks()
        {
            List<Drink> drinks = new List<Drink>();

            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }

            if (!File.Exists(DrinksFile))
            {
                CreateDefaultDrinksFile();
            }

            string[] lines = File.ReadAllLines(DrinksFile);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] parts = lines[i].Split(',');

                if (parts.Length < 5)
                {
                    continue;
                }

                string id = parts[0];
                string name = parts[1];
                string category = parts[2];

                int basePrice = 0;
                int.TryParse(parts[3], out basePrice);

                bool available = false;
                bool.TryParse(parts[4], out available);

                Drink drink = new Drink(id, name, category, basePrice, available);
                drinks.Add(drink);
            }

            return drinks;
        }

        public static void SaveDrinks(List<Drink> drinks)
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }

            List<string> lines = new List<string>();

            lines.Add("Id,Name,Category,BasePrice,Available");

            foreach (Drink drink in drinks)
            {
                string line = drink.Id + "," +
                              drink.Name + "," +
                              drink.Category + "," +
                              drink.BasePrice + "," +
                              drink.Available;

                lines.Add(line);
            }

            File.WriteAllLines(DrinksFile, lines);
        }

        private static void CreateDefaultDrinksFile()
        {
            List<string> lines = new List<string>();

            lines.Add("Id,Name,Category,BasePrice,Available");
            lines.Add("D001,珍珠奶茶,奶茶類,55,true");
            lines.Add("D002,紅茶,茶類,30,true");
            lines.Add("D003,綠茶,茶類,30,true");
            lines.Add("D004,烏龍茶,茶類,35,true");
            lines.Add("D005,多多綠茶,果茶類,45,true");
            lines.Add("D006,布丁奶茶,奶茶類,60,true");
            lines.Add("D007,檸檬紅茶,果茶類,45,true");
            lines.Add("D008,冬瓜茶,茶類,30,true");

            File.WriteAllLines(DrinksFile, lines);
        }
        public static void SaveOrderRecords(List<OrderRecord> records)
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }

            bool fileExists = File.Exists(OrdersFile);

            List<string> lines = new List<string>();

            if (!fileExists)
            {
                lines.Add("OrderId,OrderTime,DrinkName,Size,Sugar,Ice,Toppings,Quantity,Subtotal,Total");
            }

            foreach (OrderRecord record in records)
            {
                string line = record.OrderId + "," +
                              record.OrderTime.ToString("yyyy/MM/dd HH:mm:ss") + "," +
                              record.DrinkName + "," +
                              record.Size + "," +
                              record.Sugar + "," +
                              record.Ice + "," +
                              record.Toppings + "," +
                              record.Quantity + "," +
                              record.Subtotal + "," +
                              record.Total;

                lines.Add(line);
            }

            File.AppendAllLines(OrdersFile, lines);
        }
        public static List<OrderRecord> LoadOrderRecords()
        {
            List<OrderRecord> records = new List<OrderRecord>();

            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }

            if (!File.Exists(OrdersFile))
            {
                return records;
            }

            string[] lines = File.ReadAllLines(OrdersFile);

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    continue;
                }

                string[] parts = lines[i].Split(',');

                if (parts.Length < 10)
                {
                    continue;
                }

                string orderId = parts[0];

                DateTime orderTime;
                DateTime.TryParse(parts[1], out orderTime);

                string drinkName = parts[2];
                string size = parts[3];
                string sugar = parts[4];
                string ice = parts[5];
                string toppings = parts[6];

                int quantity = 0;
                int.TryParse(parts[7], out quantity);

                int subtotal = 0;
                int.TryParse(parts[8], out subtotal);

                int total = 0;
                int.TryParse(parts[9], out total);

                OrderRecord record = new OrderRecord(
                    orderId,
                    orderTime,
                    drinkName,
                    size,
                    sugar,
                    ice,
                    toppings,
                    quantity,
                    subtotal,
                    total
                );

                records.Add(record);
            }

            return records;
        }
    }

}