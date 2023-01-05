// See https://aka.ms/new-console-template for more information
// .NET 6
//Console.WriteLine("Hello, World!");

//.NET 5
using System;
using System.Text;
using System.Threading.Tasks;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            /*
            // for iteration  (with in static void Main(string[] args))
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i);
                // if  break-is used to exit a program 
                if (i == 7)
                {
                    Console.WriteLine(" Hey 7");
                    //break;
                }
            }
            Console.ReadLine();
            */

            // Arrays

            int [] numbers = new int[6];
            numbers[0] = 57;
            numbers[1] = 64;
            numbers[2] = 10;
            numbers[3] = 20;
            numbers[4] = 44;
            numbers[5] = 99;

            Console.WriteLine(numbers[1]);
            // .length - length of array
            Console.WriteLine(numbers.Length);
            Console.ReadLine();


        }
    }
}
