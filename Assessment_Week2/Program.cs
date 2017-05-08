using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many stars you want displayed: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n\n\n You have chosen to display {0} stars", n);
        }
    }
}
