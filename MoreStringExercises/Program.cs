using System;

namespace MoreStringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab sõna "racecar" tagurpidi

            string racecar = "racecar";

            for (int i = racecar.Length - 1; i >= 0; i--)
            {
                Console.Write(racecar[i]);
            }

        }
    }
}
