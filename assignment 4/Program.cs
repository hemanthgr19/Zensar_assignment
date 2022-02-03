 Write a program to find the Sum and the Average points scored by the teams in the IPL. Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores
 from the user. The function should then display the Average and Sum of the scores
--------------------------------------------------------------------------------------------------------------------
using System;

namespace Assignment4
{
    class Cricket
    {
        int sum = 0, avg;

        public void pointsCalculation(int no_of_matches)
        {
            int[] Score = new int[20];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter Match{0} score :", i + 1);
                Score[i] = Convert.ToInt32(Console.ReadLine());
                sum += Score[i];
            }
            avg = sum / no_of_matches;
            Console.WriteLine($"The No_of matches in IPL is: {no_of_matches}");
            Console.WriteLine($"The Total score of the matches: {sum}");
            Console.WriteLine($"The Average of Score of The Matches: {avg}");



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Cricket c = new Cricket();
            Console.WriteLine("Enter no of matches:");
            int x = Convert.ToInt32(Console.ReadLine());
            c.pointsCalculation(x);
            
        }
    }
}


Output:-
    Enter no of matches:
4
Enter Match1 score :
22
Enter Match2 score :
128
Enter Match3 score :
754
Enter Match4 score :
234
The No_of matches in IPL is: 4
The Total score of the matches: 1138
The Average of Score of The Matches: 284


C:\Users\HK65862\source\repos\Assignment4\Assignment4\bin\Debug\netcoreapp3.1\Assignment4.exe (process 17496) exited with code 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
