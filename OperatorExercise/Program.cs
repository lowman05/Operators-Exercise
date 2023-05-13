using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {


        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = (a / b);
            int remainder = (a % b);

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");

            AreaOfCircle();



            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k);
        }
        public static void AreaOfCircle()
        {
            var radius = double.Parse(Console.ReadLine());
            double area = (Math.PI * Math.Pow(radius, 2));
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");
                
        }



        }
        
        
    }

