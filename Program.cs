



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduce tu fecha de nacimiento (formato: yyyy-MM-dd): ");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime fechaNacimiento))
        {
            Console.WriteLine($"Naciste un {fechaNacimiento.ToString("dddd")}");
        }
        else
        {
            Console.WriteLine("Formato de fecha inválido. Usa el formato yyyy-MM-dd.");
        }
    }
}