using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Product
{
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public string Manufacturer { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"Product Code: {ProductCode}\nProduct Name: {ProductName}\nManufacturer: {Manufacturer}\nPrice: {Price}\nDescription: {Description}\n";
    }
}

class Program
{
    static List<Product> products = new List<Product>();
    const string fileName = "products.txt";

    static void Main(string[] args)
    {
        LoadDataFromFile();

        while (true)
        {
            Console.WriteLine("Product Management System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display All Products");
            Console.WriteLine("3. Search Product");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        DisplayAllProducts();
                        break;
                    case 3:
                        SearchProduct();
                        break;
                    case 4:
                        SaveDataToFile();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static void AddProduct()
    {
        Console.WriteLine("Enter Product Details:");
        Console.Write("Product Code: ");
        string code = Console.ReadLine();
        Console.Write("Product Name: ");
        string name = Console.ReadLine();
        Console.Write("Manufacturer: ");
        string manufacturer = Console.ReadLine();
        Console.Write("Price: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal price))
        {
            Console.Write("Description: ");
            string description = Console.ReadLine();
            products.Add(new Product
            {
                ProductCode = code,
                ProductName = name,
                Manufacturer = manufacturer,
                Price = price,
                Description = description
            });
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid price. Please try again.");
        }
    }

    static void DisplayAllProducts()
    {
        Console.WriteLine("List of All Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    static void SearchProduct()
    {
        Console.Write("Enter a search keyword: ");
        string keyword = Console.ReadLine().ToLower();
        var searchResults = products.Where(p => p.ProductCode.ToLower().Contains(keyword) ||
                                                p.ProductName.ToLower().Contains(keyword) ||
                                                p.Manufacturer.ToLower().Contains(keyword) ||
                                                p.Description.ToLower().Contains(keyword));
        if (searchResults.Any())
        {
            Console.WriteLine("Search Results:");
            foreach (var product in searchResults)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine("No matching products found.");
        }
    }

    static void LoadDataFromFile()
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (data.Length == 5)
                {
                    products.Add(new Product
                    {
                        ProductCode = data[0],
                        ProductName = data[1],
                        Manufacturer = data[2],
                        Price = decimal.Parse(data[3]),
                        Description = data[4]
                    });
                }
            }
            Console.WriteLine("Data loaded from file.");
        }
        else
        {
            Console.WriteLine("No existing data file found.");
        }
    }

    static void SaveDataToFile()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var product in products)
            {
                writer.WriteLine($"{product.ProductCode}|{product.ProductName}|{product.Manufacturer}|{product.Price}|{product.Description}");
            }
            Console.WriteLine("Data saved to file.");
        }
    }
}