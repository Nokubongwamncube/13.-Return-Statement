using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the cube of the number you entered is ");
            Console.WriteLine(Cube(userInput));

            Console.ReadLine();

        }
    static int Cube(int x)
        {
            return x * x * x;

        }



    }

}
