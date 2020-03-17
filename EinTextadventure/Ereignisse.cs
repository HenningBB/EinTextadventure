using System;
using System.Collections.Generic;
using System.Text;

namespace EinTextadventure
{
    public class Ereignisse
    {
        string weg;
        public Ereignisse()
        {
        }

        public void start()
        {
            Console.WriteLine("Herzlich Willkommen zum Wald-Spaziergang!");
            Console.WriteLine("Vor sich sehen sie zwei Wege.");
            Console.WriteLine("Das Schild das an der Abzweigung steht besagt das einer länger als der andere ist.");
            Console.WriteLine("Wähle nun den Weg den du gehen willst:");
           
        }

        public void punkt1()
        {
            
            Console.WriteLine("Den langen Weg(1) oder den kurzen Weg(2)[Bitte gebe die Zahl des gewählten Weges ein!]");
            weg = Console.ReadKey().KeyChar.ToString();
            Console.WriteLine();
            switch (weg)
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
                    Console.WriteLine("Falsche Eingabe!");
                    punkt1();
                    break;
            }
        }
    }
}
