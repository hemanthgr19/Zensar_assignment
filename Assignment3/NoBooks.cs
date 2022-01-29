using System;
using System.Collections.Generic;
using System.Text;

namespace BookTrainTicket
{
    struct book
    {
        
        public string title;
        public string author;


       
    }
    class NoBooks
    {
        public static void Main()
        {
            int bookss = 10;
            book[] books = new book[bookss];
            int i, j, n = 1, k = 1;
            Console.WriteLine("Insert The Information of Two Books.");

            /// those are the trails i have done it as experemental it is also working

            //Console.Write("Enter the No.Books you want to Enter:");
            //n = Convert.ToInt32(Console.ReadLine());
            //book[] bookss = new book[n];
            for (j = 0; j <= n; j++)
            {
                Console.WriteLine("Information of book : {0} ", k);

                Console.Write("Input name of the book : ");
                books[j].title = Console.ReadLine();

                Console.Write("Input the author : ");
                books[j].author = Console.ReadLine();
                k++;
                Console.WriteLine();
            }

            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}: Title = {1},  Author = {2}", i + 1, books[i].title, books[i].author);
                Console.WriteLine();
            }
            //   for (i = 1; i <= n+1; i++)
            //   {
            //       Console.WriteLine("Information of book: {0}", a);
            //       Console.Write("Input name of the book : ");
            //       books[i].title = Console.ReadLine();
            //       Console.Write("Input Name of the Author: ");
            //       books[i].author = Console.ReadLine();
            //       a++;
            //       Console.WriteLine();

            //   }

            //   for(j = 0;j <=n;j++)
            //{
            //   Console.WriteLine("{0}: Title = {1},  Author = {2}", j+1, books[j].title, books[j].author);
            //   Console.WriteLine();
            //}

        }
    }
}
