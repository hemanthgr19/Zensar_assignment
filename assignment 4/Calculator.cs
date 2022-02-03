using System;
using System.Collections.Generic;

namespace CalculateConcession
{
    public class Concession
    {
        int TotalFare = 500;
        int Age;

        public void CalculateConcession1()
        {
            Console.WriteLine("Enter Age of Citizen : ");
            Age = Convert.ToInt32(Console.ReadLine());



            if (Age <= 5)
            {
                Console.WriteLine("Little Champs-Free Ticket");
            }
            else if (Age > 60)
            {
                double CalculatedFare = TotalFare * 0.03;
                double Fare = TotalFare - CalculatedFare;
                Console.WriteLine("Senior Citizen has to pay:Rs.{0}", Fare);
            }
            else
            {
                Console.WriteLine("Ticked Booked with a payment of Rs.{0}", TotalFare);
            }
        }



    }
}





