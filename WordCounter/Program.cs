using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
           //programm kuvab mitu sõna on lauses "Hello World"
            string helloworld = "Hello World";

            //while


            int wordcounter = 1;

            /*while(i < helloworld.Length)
            {
                if(helloworld[i] == ' ')
                {
                    wordcounter++;
                }

                i++;
            }*/

            for(int i = 0; i < helloworld.Length; i++)
            {
                if (helloworld[i] == ' ')
                {
                    wordcounter++;
                }
            }

            Console.WriteLine($"Lauses {helloworld} on {wordcounter} sõna");

        }
    }
}
