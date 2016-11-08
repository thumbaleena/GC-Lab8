using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList PlayerList = new ArrayList();
            Console.WriteLine("Welcome to the Batting Average Calcultor!");
            int TimesBatted = 0;
            while (true)
            {
                Console.Write("Enter number of times at bat: ");
                TimesBatted = int.Parse(Console.ReadLine());
                int[] Batted = new int[TimesBatted];
                for (int i = 0; i < TimesBatted; i++)
                {
                    Console.WriteLine("Result for at-bat {0}: ", i);
                    Batted[i] = int.Parse(Console.ReadLine());
                }

                int Count = 0;
                int Sum = 0;
                double SluggingPercentage = 0;
                double BattingAverage = 0;

                for (int i = 0; i < TimesBatted; i++)
                {
                    if (Batted[i] >= 1) Count++;
                    Sum = Sum + Batted[i];
                }

                SluggingPercentage = (double) Sum/TimesBatted;
                BattingAverage = (double) Count/TimesBatted;

                PlayerList.Add(TimesBatted);

                Console.WriteLine("Another batter? (y/n)");
                string Continue = Console.ReadLine();
                if (Continue.ToLower() == "no")
                    break;
            }
            for (int i = 0; i < PlayerList.Count; i++)
            {
                Console.WriteLine("Results for player {0}", i);

                foreach (int element in (int[])PlayerList[i])
                {
                    Console.Write(" {0} ", element);

                }
                Console.WriteLine("\n===================");
            }
        }
    }
}
