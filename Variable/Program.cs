using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.WriteLine();

            //integers (whole # )
            int score; // declare "score" is an integer
            score = 0; // init. "score" to be 0
            int enemyPoints;
            enemyPoints = 100;
            Console.WriteLine("Score: " + score); // display score
            score = score + enemyPoints;
            Console.WriteLine("Score: " + score);
            Console.WriteLine();

            //floating points (Real numbers)
            float lapTime; //declare
            lapTime = 0.0f; //init.
            Console.WriteLine(lapTime);
            lapTime = 65.357f;
            Console.WriteLine(lapTime);
            Console.WriteLine();

            //string (text)
            string title; //declare
            title = "Newbie"; // init.
            Console.WriteLine("Title: " + title);
            Console.WriteLine();
            title = "Pro";
            Console.WriteLine("Title: " + title);


            Console.ReadKey(true);
        }
    }
}
