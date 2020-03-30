namespace EinTextadventure
{
    public class Erzaehler : IErzaehler
    {
        private int zaehler = 0;
        public ISzene aktuelleSzene { get; set; }
        public Erzaehler()
        {
            aktuelleSzene = new AnfangsSzene();
        }

        public string spieleSzene()
        {
            return aktuelleSzene.Inhalt;
        }
        public void ladeErgebnis(int eingabe)
        {
            aktuelleSzene.Ergebnis = eingabe;
        }
    }
}
