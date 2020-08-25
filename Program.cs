using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //------EXERCISE 1 ----------
            //17/4 is a 4 remainder 1

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod} ");



            //----------EXERCISE 2-------------


          


            //-----EXERCISE 3 --------------


            //ALLOWS USER TO INPUT THE RADIUS

            Console.WriteLine("Please enter a number to find the PI?");
            var radius = double.Parse(Console.ReadLine());


            //CALCULATE AREA
            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a Circle with radius of {radius} is {areaOfCircle}");
           
            
        }
           public static double CalculateArea( double radius)
        {
            return Math.PI * (radius * radius);

        }
        }


            
    }
