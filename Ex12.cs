using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Ex12.Entities;

namespace Ex12
{
    public class Ex12
    {
        public void Executar()
        {
            List<Product> list = new List<Product>();

            System.Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Product #{i + 1} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    System.Console.Write("Customs free: ");
                    double customsFree = double.Parse(Console.ReadLine());

                    list.Add(new ImportedProduct(name, price, customsFree));
                }
                else if (ch == 'c')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    list.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    System.Console.Write("Name: ");
                    string name = Console.ReadLine();

                    System.Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    System.Console.Write("Manugacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
            }

            System.Console.WriteLine("PRICE TAGS: ");
            foreach (Product p in list)
            {
                System.Console.WriteLine(p.PriceTag());
            }
        }
    }
}