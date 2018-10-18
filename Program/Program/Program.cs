using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    using ClassLibrary1;

    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("Enter 1 to create Fibbonachi/ 2 to check the number");
            int a = int.Parse(Console.ReadLine());

            if (a == 1)
            {
                for (int i = 0; i < 20; i++)
                {

                    Console.WriteLine(class1.Fibon(i));


                }
                Console.ReadLine();
            }
            else if (a == 2)
            {
                for (int d = 0; d < 5; d++)
                {
                    Console.WriteLine("Enter the number");
                    int b = int.Parse(Console.ReadLine());
                    if (class1.Number(b))
                    {
                        Console.WriteLine("Is prime");
                    }
                    else
                    {
                        Console.WriteLine("Is not prime");
                    }
                }Console.ReadLine();
            }
              
              
        }
    }
}