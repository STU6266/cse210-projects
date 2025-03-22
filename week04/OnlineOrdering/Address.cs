namespace OrderSystem
{
    public class Address
    {
        // Private Membervariablen
        private string street;
        private string city;
        private string stateOrProvince;
        private string country;

        // Konstruktor
        public Address(string street, string city, string stateOrProvince, string country)
        {
            // TODO: Initialisiere die Membervariablen
        }

        // Methoden

        // Prüft, ob die Adresse in den USA liegt
        public bool IsInUSA()
        {
            // TODO: Überprüfe, ob country "USA" entspricht und gib true oder false zurück
            return false;
        }

        // Gibt die vollständige Adresse als formatierten String zurück
        public string GetFullAddress()
        {
            // TODO: Alle Felder zu einem String zusammenfügen (z. B. mit Zeilenumbrüchen)
            return string.Empty;
        }
    }
}
