Create a Class called Products with Productid, Product Name, Price. Accept 10 Products, sort them based on the price, and display the sorted Products


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Assignment4
{
    class Product
    {
        public int Id;
        Dictionary<string, Double> Products = new Dictionary<string, double>();

        public void GetData()
        {
            Console.WriteLine("Enter 10 Products : ");
            for (int i = 0; i < 10; i++)
            {
                Id = i +1;
                Console.WriteLine($"Enter the Details of Product  {Id} :");
                Products.Add(Console.ReadLine() , double.Parse(Console.ReadLine()));
            }
        }
        public void Sortdata()
        {
            Console.WriteLine("After Sorting the Product by Price :");
            foreach (KeyValuePair<string, Double> Price in Products.OrderBy(key => key.Value))
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


Output:-
    Enter 10 Products :
Enter the Details of Product  1:
TV
999
Enter the Details of Product  2:
Radio
1500
Enter the Details of Product  3:
SmartPhone
600
Enter the Details of Product  4:
laptop
1000
Enter the Details of Product  5:
fridge
40000
Enter the Details of Product  6:
mac
89000
Enter the Details of Product  7:
keyboard
400
Enter the Details of Product  8:
mouse
100
Enter the Details of Product  9:
Android
888
Enter the Details of Product  10:
Iphone
50000
After Sorting the Product by Price :
Product: mouse, Value: 100
Product: keyboard, Value: 400
Product: SmartPhone, Value: 600
Product: Android, Value: 888
Product: TV, Value: 999
Product: laptop, Value: 1000
Product: Radio, Value: 1500
Product: fridge, Value: 40000
Product: Iphone, Value: 50000
Product: mac, Value: 89000

C:\Users\HK65862\source\repos\Assignment4\Assignment4\bin\Debug\netcoreapp3.1\Assignment4.exe (process 6132) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .

