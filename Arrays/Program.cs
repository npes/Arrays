using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "orange" };
            Console.WriteLine("Fruits array has length of: " + fruits.Length);


            Console.WriteLine("Fruits array contains");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            foreach (string fruit in fruits) // foreach is only for strings
            {
                Console.WriteLine(fruit);
                Console.WriteLine(fruit.GetType()); //the type of element in array
            }

            Console.ReadLine();
        }
    }
}
