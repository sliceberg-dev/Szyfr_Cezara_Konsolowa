using System;
using static System.Net.Mime.MediaTypeNames;

// Prosty program implementujący szyfr Cezara (kodowanie/dekodowanie)
Console.WriteLine("Szyfr Cezara");

Console.Write("Podaj tekst: ");
string input = Console.ReadLine() ?? string.Empty;
int shift;
while (true)
{
    Console.Write("Podaj przesunięcie (liczba całkowita): ");
    string? s = Console.ReadLine();
    if (int.TryParse(s, out shift))
    {
        break;
    }

    Console.WriteLine("Nieprawidłowa liczba. Spróbuj ponownie.");
}
string output = Caesar(input, shift);

Console.WriteLine();
Console.WriteLine("Wynik:");
Console.WriteLine(output);


static string Caesar(string text, int shift)
{
    char[] result = new char[text.Length];
    for (int i = 0; i < text.Length; i++)
    {
        char c = text[i];
        char baseChar = char.IsUpper(c) ? 'A' : 'a';
        result[i] = (char)(baseChar + (c - baseChar + shift) % 26);

    }
    return new string(result);
}


