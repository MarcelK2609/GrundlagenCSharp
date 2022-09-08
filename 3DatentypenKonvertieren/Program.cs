//Aufgabe 1
int Short = 16;
int Int = 32;
int Long = 64;
int Float = 32;
int Double = 64;
int Decimal = 128;

Console.WriteLine($"Short: {Short} Bit / MinValue: {short.MinValue} / MaxValue: {short.MaxValue}");
Console.WriteLine($"int: {Int} Bit / MinValue: {int.MinValue} / MaxValue: {int.MaxValue}");
Console.WriteLine($"long: {Long} Bit / MinValue: {long.MinValue} / MaxValue: {long.MaxValue}");
Console.WriteLine($"float: {Float} Bit / MinValue: {float.MinValue} / MaxValue: {float.MaxValue}");
Console.WriteLine($"double: {Double} Bit/ MinValue: {double.MinValue} / MaxValue: {double.MaxValue}");
Console.WriteLine($"decimal: {Decimal} Bit/ MinValue: {decimal.MinValue} / MaxValue: {decimal.MaxValue}");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

//Aufgabe 2
int Alter = 17;
string Vorname = "Marcel";
bool Ist_CSharp_Die_Erste_Programmiersprache_Die_sie_Lernen = true;
Console.WriteLine($"Vorname: {Vorname}");
Console.WriteLine($"Alter: {Alter}");
Console.WriteLine($"Ist C# Die erste Programmiersprache die sie lernen?: {Ist_CSharp_Die_Erste_Programmiersprache_Die_sie_Lernen}");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

//Aufgabe 3
int DollarZahl = 36;
char Dollar = (char)DollarZahl;
Console.WriteLine($"{Dollar}");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");

//Aufgabe 4
Console.WriteLine("Zufällige zahl");
string Value1 = Console.ReadLine();
Console.WriteLine("Zufällige Dezimalzahl");
string Value2 = Console.ReadLine();

short Konvertiert1 = Convert.ToInt16(Value1);
double Konvertiert2 = Convert.ToDouble(Value2);

Console.WriteLine($"Erfolgreich {Konvertiert1} zu {typeof(short)} konvertiert");
Console.WriteLine($"Erfolgreich {Konvertiert2} zu {typeof(double)} konvertiert");
Console.ReadLine();