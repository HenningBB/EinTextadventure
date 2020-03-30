namespace EinTextadventure
{
    public class AnfangsSzene : ISzene
    {

        public int Ergebnis { get; set; }
        public string Inhalt
        {
            get
            {
                return "Herzlich Willkommen zum Wald-Spaziergang!" +
                    " \nVor dir siehst du zwei Wege. Das Schild das an der Abzweigung steht besagt das einer länger als der andere ist." +
                    " \nWähle nun den Weg den du gehen willst:" +
                    "\nDen langen Weg(1) oder den kurzen Weg(2)[Bitte gebe die Zahl des gewählten Weges ein!]";
            }
        }
    }
}
