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

            /* 1
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

            // ARRAYS
            //Array 1
            // ? How to change the number of item in an array at run time 
            int [] numbers = new int[6]; // array
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

            //Array  2
            // new array by declaring array and initialize values at the time of declaration
            int[] num2 = new int[] {45,34,67,89,90,34,13,24}; // array
            string[] names = new string[] { "Jane", "Mercy", "leah", "milly" };  // array

            //for loop on the num2 
            for (int i = 0; i < num2.Length; i++)
            {
                Console.WriteLine(num2[i]);
            }
            Console.ReadLine();

            // foreach loop on names array to print out each value held by arraya(names)
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            // Array 3
            // Reversing array first becomes last n last becomes first

            string zig = "I like criticism." + "It makes you strong ";

            // char - data type for character  ToCharArray() - is a helper method  , every data type has helper method assigned to it 
            char[] stringChar = zig.ToCharArray();
            Array.Reverse(stringChar);

            foreach (char zigChar in stringChar)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();


        }
    }
}
