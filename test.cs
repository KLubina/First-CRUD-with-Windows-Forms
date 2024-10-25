using System;

namespace MyApp
{
    // Definiert eine Klasse namens 'Test'
    public class Test
    {
        // Ein privates Feld, das nur innerhalb der Klasse zugänglich ist
        private string message;

        // Ein öffentlicher Konstruktor, der aufgerufen wird, wenn eine Instanz der Klasse erstellt wird
        public Test(string initialMessage)
        {
            // Initialisiert das private Feld 'message' mit dem übergebenen Wert
            message = initialMessage;
        }

        // Eine öffentliche Methode, die das aktuelle Message-Feld zurückgibt
        public string GetMessage()
        {
            return message;
        }

        // Eine öffentliche Methode, um das Message-Feld zu ändern
        public void SetMessage(string newMessage)
        {
            message = newMessage;
        }

        // Eine öffentliche Methode, die das Message-Feld auf die Konsole ausgibt
        public void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }

    // Die Hauptmethode, die beim Programmstart ausgeführt wird
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellt eine neue Instanz der 'Test'-Klasse mit einer anfänglichen Nachricht
            Test myTest = new Test("Hallo, Welt!");

            // Ruft die PrintMessage-Methode auf, um die Nachricht auf die Konsole zu drucken
            myTest.PrintMessage();

            // Ändert die Nachricht und druckt sie erneut
            myTest.SetMessage("Neue Nachricht!");
            myTest.PrintMessage();
        }
    }
}
