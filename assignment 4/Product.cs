using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment4
{
    class Product
    {
        public int Id;
        public string Name;
        Dictionary<string, Double> Products = new Dictionary<string, double>();

        public void GetData()
        {
            Console.WriteLine("Enter 10 Products : ");
            for (int i = 0; i < 10; i++)
            {
                Products.Add(Console.ReadLine() , double.Parse(Console.ReadLine()));
            }
        }
        public void Sortdata()
        {
            Console.WriteLine("After Sorting the Product by Price :");
            foreach (KeyValuePair<string, Double> Price in Product1.OrderBy(key => key.Value))
            {
                Console.WriteLine("Product: {0}, Value: {1}", Price.Key, Price.Value);
            }
        }
    }

    class Programs
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.GetData();
            p.Sortdata();
        }
    }
}
