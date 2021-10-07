using System;

namespace SubstituateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //pragramm asendab kõik "a" tähed kasutaja nimes tärniga "*"
            //programm kuvab tulemust konsoolis

            Console.WriteLine("Sisesta eesnimi: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string lastname = Console.ReadLine();
            string fullname = $"{firstname} {lastname}";

            fullname = fullname.Replace('a', '*');
            Console.WriteLine(fullname);


        }
    }
}
