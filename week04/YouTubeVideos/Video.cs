using System.Collections.Generic;

namespace VideoProjekt
{
    public class Video
    {
        // Private Membervariablen
        private string title;
        private string author;
        private int length; // Länge in Sekunden
        private List<Comment> comments;

        // Konstruktor
        public Video(string title, string author, int length)
        {
            // TODO: Initialisiere die Membervariablen
        }

        // Methoden

        // Fügt einen Kommentar hinzu
        public void AddComment(Comment comment)
        {
            // TODO: Kommentar zur Liste hinzufügen
        }

        // Gibt die Anzahl der Kommentare zurück
        public int GetNumberOfComments()
        {
            // TODO: Anzahl der Kommentare zurückgeben
            return 0;
        }

        // Gibt die Videodetails inkl. Kommentaren aus
        public void DisplayVideoDetails()
        {
            // TODO: Videodetails und Kommentare anzeigen
        }
    }
}
