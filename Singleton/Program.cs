using System;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Parallel.Invoke(
                () => FirstPrint(),
                () => SecondPrint()
                );

            Console.ReadLine();
        }

        private static void SecondPrint()
        {
            Singleton Second = Singleton.GetInstance;
            Second.PrintDetails("Second Print");
        }

        private static void FirstPrint()
        {
            Singleton First = Singleton.GetInstance;
            First.PrintDetails("First Print");
        }
    }
}
