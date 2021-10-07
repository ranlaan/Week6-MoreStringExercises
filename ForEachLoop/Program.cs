using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõnade "Hello world" pikkust Lenght omaduse kasutamata
            string helloW = "Hello World!";
            int charCounter = 0;

            foreach(char c in helloW)
            {
                charCounter++;
            }

            Console.WriteLine($"lause {helloW} pikkus on {charCounter}.");
        }
    }
}
