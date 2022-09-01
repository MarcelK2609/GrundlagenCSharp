//Aufgabe1
Console.WriteLine(" .-.");
Console.WriteLine("(o o)");
Console.WriteLine("| O |");
Console.WriteLine("|   |");
Console.WriteLine("'~~~'");
Console.WriteLine("  ");
Console.WriteLine("  ");
Console.WriteLine("  ");

//Aufgabe2
string Vorname;
string Nachname;
int Alter;

Vorname = "Marcel";
Nachname = "Kroschke";
Alter = 17;

Console.WriteLine($"Vorname:{Vorname}");
Console.WriteLine($"Nachname:{Nachname}");
Console.WriteLine($"Alter:{Alter}");
Console.WriteLine($"{Nachname} {Vorname} Ist {Alter} Jahre alt");
Console.WriteLine("  ");
Console.WriteLine("  ");
Console.WriteLine("  ");

//Aufgabe3
string Vorname1;
string Alter1;
string Klasse1;


Console.WriteLine("Name?");
Vorname1 = Console.ReadLine();
Console.WriteLine("Alter?");
Alter1 = Console.ReadLine();
Console.WriteLine("klasse?");
Klasse1 = Console.ReadLine();

Console.WriteLine($"{Vorname1} ist {Alter1} Jahre alt und besucht die {Klasse1} des Georg-Simon-Ohm Berufskollegs");