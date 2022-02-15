using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Program
    {
        static void Main(string[] args)
        {

            Product[] products = new Product[]
            {
                new Product{ProductID = 1, ProductName="Bread", Price=123},
                new Product{ProductID = 1, ProductName="Bread", Price=123},
                new Product{ProductID = 1, ProductName="Bread", Price=123},
                new Product{ProductID = 1, ProductName="Bread", Price=123},
                new Product{ProductID = 1, ProductName="Bread", Price=123}
            };

            var result = from e in products
                         select e.ProductName;
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------");
            var result3 = from e in products
                          where e.Price > 50
                         select e;
            foreach (Product item in result3)
            {
                Console.WriteLine(item.ProductID);
            Console.WriteLine(item.ProductName);
            Console.WriteLine(item.Price);
        }
            Console.WriteLine("--------------------");

            var result2 = from e in products
                      select e;
        foreach (Product item in result2)
        {
            
            Console.WriteLine(item.ProductName);
            Console.WriteLine(item.Price);
        }

    }
    }


class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int Price{ get; set; }
}
