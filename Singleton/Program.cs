using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton First = Singleton.GetInstance;
            First.PrintDetails("First Print");

            Singleton Second = Singleton.GetInstance;
            Second.PrintDetails("Second Print");

            Console.ReadLine();
        }
    }
}
