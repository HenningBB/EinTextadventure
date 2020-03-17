using System;

namespace EinTextadventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string antwort;
            Console.WriteLine("Herzlich Willkommen zum Wald-Spaziergang!");
            Console.WriteLine("Vor sich sehen sie zwei Wege.");
            Console.WriteLine("Das Schild das an der Abzweigung steht besagt das einer länger als der andere ist.");
            Console.WriteLine("Wähle nun den Weg den du gehen willst:");
            Console.WriteLine("Den langen Weg(1) oder den kurzen Weg(2)[Bitte gebe die Zahl des gewählten Weges ein!]");
            antwort = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            switch (antwort)
            {
                case "1":
                    //weg 1
                    Console.WriteLine("Langer Weg");
                    break;
                case "2":
                    //weg 2
                    Console.WriteLine("Kurzer Weg");
                    break;
                default:

                    break;
            }
            Console.ReadLine();
        }
    }
}
