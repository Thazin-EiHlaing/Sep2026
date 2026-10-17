// See https://aka.ms/new-console-template for more information
using Sep2026.ElectronicShop;
using System.Linq.Expressions;

Console.WriteLine("Electronic Mall");

ItemsCreateService service = new ItemsCreateService();
  
Start:
            Console.WriteLine();
            Console.WriteLine("1.Add New Product");
            Console.WriteLine("2.Display All Products");
            Console.WriteLine("3.Search Product");
            Console.WriteLine("4.Calculate Inventory Value");
            Console.WriteLine("5.Exit");
            Console.Write("Choose Option: ");
            Console.WriteLine();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine() ?? "ီDefault Name";

                    Console.Write("Enter Brand Name: ");
                    string brand = Console.ReadLine() ?? "Default brand";

                    Console.Write("Enter Model Number: ");
                    string model = Console.ReadLine() ?? "Default model";

                    Console.Write("Enter Purchase Price: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal purprice))
                    {
                        Console.WriteLine("Invalid Purchase Price!");
                        goto Start;
                    }

                    Console.Write("Enter Sale Price: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal saleprice))
                    {
                        Console.WriteLine("Invalid Sale Price!");
                        goto Start;
                    }

                    Console.Write("Enter Quantity: ");
                    if (!int.TryParse(Console.ReadLine(), out int quantity))
                    {
                        Console.WriteLine("Invalid Quantity!");
                        goto Start;
                    }
                    service.ItemCreate(name,brand,model,purprice,saleprice,quantity);
                    goto Start;

                case "2":
                    service.ShowItem();
                    goto Start;


                case "3":
                    Console.Write("Enter Product Name: ");
                    string searchName = Console.ReadLine();
                    service.SearchItem(searchName);

                    goto Start;

                case "4":
                    service.CalculateInventoryValue();
                    goto Start;

                case "5":

                    return;

                default:
                    Console.WriteLine("Invalid Option!");
                    goto Start;
            }