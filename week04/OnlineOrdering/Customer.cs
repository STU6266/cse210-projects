namespace OrderSystem
{
    public class Customer
    {
        // Private Membervariablen
        private string name;
        private Address address;

        // Konstruktor
        public Customer(string name, Address address)
        {
            // TODO: Initialisiere die Membervariablen
        }

        // Methoden

        // Gibt zurück, ob der Kunde in den USA wohnt (unter Verwendung der Address-Methode)
        public bool LivesInUSA()
        {
            // TODO: Nutze address.IsInUSA() und gib das Ergebnis zurück
            return false;
        }

        // Zusätzliche Getter und Setter falls benötigt
    }
}
