using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.Add("3", "5", "ana", "245"));
            Console.ReadLine();
        }
    }
}
