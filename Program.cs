using System;

namespace UC2DailyWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagePerHr = 20;
            int Wage = 0,empHr=0;
            Random random = new Random();
            int value = random.Next(0,2);//only generate value bt 0-2 means 0,1
            //0 is for present 
            //1 is for absent
            if(value==0)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            Wage = wagePerHr * empHr;
            Console.WriteLine("Total Wage Of The Day :" + Wage);
        }
    }
}
