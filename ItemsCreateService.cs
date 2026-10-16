
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sep2026.ElectronicShop
{
    public class ItemsCreateService
    {
        public static List<ItemDto> Items = new List<ItemDto>();

        public void ItemCreate(string name,string brand, string model,decimal purprice,decimal saleprice,int quantity)
        {
            int maxId = 0;

            if (Items.Count > 0)
            {
                maxId = Items.Max(x => x.Id);
            }

            ItemDto item = new ItemDto
            {
                Id = maxId + 1,
                Name = name,
                BrandName = brand,
                ModelNo = model,
                PurPrice = purprice,
                SalePrice = saleprice,
                Quantity = quantity
            };

            Items.Add(item);
            Console.WriteLine("Product Added Successfully!");
        }

        
        public void ShowItem()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("No Products Available!");
                return;
            }

            foreach (var item in Items)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Brand: {item.BrandName}");
                Console.WriteLine($"Model: {item.ModelNo}");
                Console.WriteLine($"Purchase Price: {item.PurPrice}");
                Console.WriteLine($"Sale Price: {item.SalePrice}");
                Console.WriteLine($"Quantity: {item.Quantity}");
            }
        }
        public void SearchItem(string name)
        {
            bool found = false;

            foreach (var item in Items)
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine();;
                    Console.WriteLine($"Name: {item.Name}");
                    Console.WriteLine($"Brand: {item.BrandName}");
                    Console.WriteLine($"Model: {item.ModelNo}");
                    Console.WriteLine($"Purchase Price: {item.PurPrice}");
                    Console.WriteLine($"Sale Price: {item.SalePrice}");
                    Console.WriteLine($"Quantity: {item.Quantity}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Product Not Found!");
            }
        }

        public void CalculateInventoryValue()
        {
            decimal totalValue = 0;

            foreach (var item in Items)
            {
                totalValue += item.PurPrice * item.Quantity;
            }

            Console.WriteLine($"Total Inventory Value: {totalValue} MMK");
        }

    }
}
