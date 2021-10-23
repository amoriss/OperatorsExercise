using System;

namespace OperatorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b; 
            if(a==17 && b==4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius {radius} " +
                $"is: {AreaOfCircle(radius)}"); 


        }
        public static double AreaOfCircle(double radius)
        {
          
            var pi = Math.PI * Math.Pow(radius,2);
            return Math.Round(pi,2);
        }
    }
}
