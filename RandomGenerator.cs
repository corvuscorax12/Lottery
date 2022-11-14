using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lotto
{
    class RandomGenerator 
    {
        int maxDraw;
        int maxVal;

        List<int> tonightsNumbers;

        void lotteryWheel()
        {
            // Code From https://stackoverflow.com/a/14473371


            Random rBall =  new Random();
            int ball;
            tonightsNumbers = new List<int>();
            
            for (int i = 0; i <= maxDraw; i++)
            {
                ball = rBall.Next(1,maxVal);
                Console.WriteLine("{0},{1}", i, ball);
                if (!tonightsNumbers.Contains(ball))
                    tonightsNumbers.Add(ball);
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WHoops");
                    Console.ForegroundColor = ConsoleColor.White;
                    i--;
                }
            }

        }
       public List<int> TonightsNumbers
        {
            get { return tonightsNumbers; }
        }
        
        public RandomGenerator(int MaxDraw,int MaxVal) 
        {
            maxDraw = MaxDraw;
            maxVal = MaxVal;
            lotteryWheel();
        }

        
    
    }
}
