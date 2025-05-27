using EspacioCalculadora;

Calculadora c = new Calculadora();


int opc = 0;

while (true)
{
    Console.WriteLine("=====================");
    Console.WriteLine(" 1 - Sumar");
    Console.WriteLine(" 2 - Restar");
    Console.WriteLine(" 3 - Multiplicar");
    Console.WriteLine(" 4 - Dividir");
    Console.WriteLine(" 5 - Limpiar");
    Console.WriteLine(" 6 - Salir");
    Console.WriteLine("=====================");


}



static string LeerString(string texto = "Ingresa una cadena")
{
    Console.Write($"\n{texto}\n> ");
    string ret = Console.ReadLine();
    return ret ?? "";
}

static int LeerEntero(string texto = "Ingresá un número entero")
{
    int ret = 0;
    while (true)
    {
        Console.WriteLine(texto);
        Console.Write("> ");
        string s = Console.ReadLine();
        if (int.TryParse(s is null ? "" : s, out ret))
        {
            return ret;
        }
        PrintError("Error, no ingresaste un número...");
    }
}

static double LeerDouble(string texto = "Ingresá un número")
{
    double ret = 0;
    while (true)
    {
        Console.WriteLine(texto);
        Console.Write("> ");
        string s = Console.ReadLine();
        if (double.TryParse(s is null ? "" : s, out ret))
        {
            return ret;
        }
        PrintError("Error, no ingresaste un número...");
    }
}

static void Pausa()
{
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Pulsa una tecla para continuar...");
    Console.ReadKey();
    Console.ForegroundColor = old;
}
static void PrintError(string text = "Opcion invalida...")
{
    ConsoleColor old = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(text);
    Console.ForegroundColor = old;
}
