using System;

namespace EinTextadventure
{
    class Program
    {

        static void Main(string[] args)
        {
            Ereignisse ereignisse = new Ereignisse();
            ereignisse.start();
            ereignisse.punkt1();         
            Console.ReadLine();
        }
    }
}
