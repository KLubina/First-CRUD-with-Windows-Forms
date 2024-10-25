# Erklärung der Begriffe und Typen im Code

## 1. `using System;`
- **`using`**: Schlüsselwort - Wird verwendet, um Namespaces hinzuzufügen.
- **`System`**: Namespace - Eine Sammlung von Klassen und anderen Typen, die in der Bibliothek definiert sind.
- **`;`**: Terminator - Das Semikolon zeigt das Ende einer Anweisung an.

## 2. `namespace ErsterRechner`
- **`namespace`**: Schlüsselwort - Definiert einen Geltungsbereich, in dem Klassen, Schnittstellen, Strukturen und andere Datentypen deklariert werden.
- **`ErsterRechner`**: Identifier - Der Name des Namespaces, eine benutzerdefinierte Bezeichnung.

## 3. `public partial class Form1 : Form`
- **`public`**: Zugriffsmodifikator - Gibt an, dass die Klasse von überall zugänglich ist.
- **`partial`**: Schlüsselwort - Teilt eine Klasse in mehrere Dateien auf.
- **`class`**: Schlüsselwort - Deklariert eine Klasse.
- **`Form1`**: Identifier - Der Name der Klasse.
- **`:`**: Vererbung - Zeigt an, dass die Klasse `Form1` von einer anderen Klasse erbt.
- **`Form`**: Basisklasse - Die Klasse, von der `Form1` erbt.

## 4. `public Form1()`
- **`public`**: Zugriffsmodifikator - Der Konstruktor ist öffentlich zugänglich.
- **`Form1()`**: Konstruktor - Eine Methode, die verwendet wird, um Objekte der Klasse zu initialisieren.

## 5. `InitializeComponent();`
- **`InitializeComponent`**: Methodenname - Ruft eine Methode auf, die die visuelle Benutzeroberfläche initialisiert.
- **`;`**: Terminator - Beendet die Anweisung.

## 6. `private void label1_Click(object sender, EventArgs e)`
- **`private`**: Zugriffsmodifikator - Nur innerhalb der Klasse zugänglich.
- **`void`**: Rückgabewert - Gibt an, dass die Methode keinen Wert zurückgibt.
- **`label1_Click`**: Methodenname - Benutzerdefinierter Name für eine Ereignismethode.
- **`object sender`**: Parameter - Der Sender des Ereignisses.
- **`EventArgs e`**: Parameter - Ereignisdaten.

## 7. `if (int.TryParse(byte_input.Text, out int inputNumber))`
- **`if`**: Schlüsselwort - Leitet eine Bedingung ein.
- **`int`**: Datentyp - Ganzzahliger Typ.
- **`TryParse`**: Methode - Versucht, einen Text in einen Integer zu konvertieren.
- **`byte_input.Text`**: Eigenschaft - Greift auf den Text in der `byte_input` TextBox zu.
- **`out`**: Schlüsselwort - Gibt den konvertierten Wert über den Parameter zurück.
- **`inputNumber`**: Variable - Enthält den konvertierten Integer-Wert.

## 8. `MessageBox.Show("Text")`
- **`MessageBox`**: Klasse - Dient zum Anzeigen von Meldungen.
- **`Show`**: Methode - Zeigt eine Nachricht an.

## 9. Operatoren
- **`>=`**: Operator - Größer oder gleich.
- **`<=`**: Operator - Kleiner oder gleich.
- **`*`**: Operator - Multiplikation.
- **`&&`**: Logischer Operator - Logisches UND.

## 10. Parameter `(object sender, EventArgs e)`
- **`object`**: Datentyp - Basis-Datentyp für alle Klassen in C#.
- **`EventArgs`**: Klasse - Enthält Ereignisdaten.
- **`sender`**: Parameter - Der Ursprung des Ereignisses.
- **`e`**: Parameter - Enthält die Ereignisdaten.
