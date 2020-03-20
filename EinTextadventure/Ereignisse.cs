using System;
using System.Collections.Generic;
using System.Text;

namespace EinTextadventure
{
    public class Ereignisse
    {
        string weg;
        string gabelung;
        public Ereignisse()
        {
        }

        public void start()
        {
            Console.WriteLine("Herzlich Willkommen zum Wald-Spaziergang!");
            Console.WriteLine("Vor sich sehen sie zwei Wege.");
            Console.WriteLine("Das Schild das an der Abzweigung steht besagt das einer länger als der andere ist.");
            Console.WriteLine("Wähle nun den Weg den du gehen willst:");
            EntscheidungsPunktEins();
            Console.WriteLine("Du gehst den Weg entlang.");
            Console.WriteLine("Ab und zu blendet dich die Sonne, wenn sie nicht durch die Baumwipfel geblockt wird.");
            Console.WriteLine("In der Ferne zwitschern die Vögel.");
        }

        public void Laufen()
        {
            if (weg == "1") //langer Weg
            {
                Console.WriteLine("Auf einmal steht ein Hund vor dir.");
                Console.WriteLine("Er schaut dich an und wackelt mit seinem Schweif.");
                Console.WriteLine("Bevor du reagieren kannst rennt er in den Wald.");
                Console.WriteLine("Du siehst wie er kurz nach den ersten Bäumen nicht mehr zu sehen ist.");
                Console.WriteLine("Bei näherer Betrachtung scheint er wie vom Erdboden verschluckt.");
                EntscheidungsPunktZwei_Eins();
            }
            else//kurzer Weg
            {

            }
        }

        private void EntscheidungsPunktEins()
        {
            
            Console.WriteLine("Den langen Weg(1) oder den kurzen Weg(2)[Bitte gebe die Zahl des gewählten Weges ein!]");
           weg = Console.ReadKey().KeyChar.ToString();
            switch (weg)
            {
                case "1":
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    EntscheidungsPunktEins();
                    break;
            }

        }

        private void EntscheidungsPunktZwei_Eins()
        {
            Console.WriteLine("Schaust du nun nach wo er abgebllieben ist[1] oder gehst du weiter spazieren[2]?.");
            gabelung = Console.ReadKey().KeyChar.ToString();
            switch (gabelung)
            {
                case "1":
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    EntscheidungsPunktZwei_Eins();
                    break;
            }
        }

        public void EntscheidungsPunktDrei()
        {

        }
    }
}
