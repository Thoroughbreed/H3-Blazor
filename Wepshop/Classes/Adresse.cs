namespace Wepshop.Classes
{
    public class Data
    {
        public string navn { get; set; }
        public string href { get; set; }
        public string postnr { get; set; }
        public string postnrnavn { get; set; }
    }

    public class Adresse
    {
        public string type { get; set; }
        public string tekst { get; set; }
        public string forslagstekst { get; set; }
        public int caretpos { get; set; }
        public Data data { get; set; }
    }
}