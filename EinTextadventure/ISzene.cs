using System;
using System.Collections.Generic;
using System.Text;

namespace EinTextadventure
{
    public interface ISzene
    {
        int ID { get; set; }
        int Ergebnis { get; set; }
        string Inhalt { get; set; }
    }
}
