using System;

namespace EinTextadventure
{
    class Program
    {

        static void Main(string[] args)
        {
            Erzaehler erzaehler = new Erzaehler();
            bool enden = false;
            while (!enden)
            {
                Console.Write(erzaehler.spieleSzene()+"\n");
                erzaehler.ladeErgebnis(Convert.ToInt32(Console.ReadKey().KeyChar.ToString()));
                enden = true;
            }
        }
    }
}
