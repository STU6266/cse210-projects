using System.Collections.Generic;

namespace OrderSystem
{
    public class Order
    {
        // Private Membervariablen
        private List<Product> products;
        private Customer customer;

        // Konstruktor
        public Order(Customer customer)
        {
            // TODO: Initialisiere die products-Liste und setze den customer
        }

        // Methoden

        // Fügt ein Produkt zur Bestellung hinzu
        public void AddProduct(Product product)
        {
            // TODO: Produkt der Liste hinzufügen
        }

        // Berechnet die Gesamtkosten der Bestellung inkl. Versandkosten
        // Versandkosten: $5 bei USA, ansonsten $35
        public double CalculateTotalCost()
        {
            // TODO: Summe der Produktkosten + Versandkosten berechnen
            return 0.0;
        }

        // Gibt ein Packing Label zurück (Liste von Produktname und Produkt-ID)
        public string GetPackingLabel()
        {
            // TODO: Erstelle einen String mit Produktname und Produkt-ID für jedes Produkt
            return string.Empty;
        }

        // Gibt ein Shipping Label zurück (Name und Adresse des Kunden)
        public string GetShippingLabel()
        {
            // TODO: Erstelle einen String mit dem Namen des Kunden und der vollständigen Adresse
            return string.Empty;
        }
    }
}
