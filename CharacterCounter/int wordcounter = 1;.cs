using System;

namespace CharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi ja perekonnanime
            //programm kuvab kasutaja eesnime ja perekonnanime pikkust kokku
            //Lenght

            Console.WriteLine("Sisesta eesnimi: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname}{lastname}";

            int charCounter = 0;
            foreach (char c in fullname)
            {
                charCounter++;
            }

            Console.WriteLine(charCounter);

        }
}
