using EspacioCalculadora;

Calculadora c = new Calculadora();

int opc = 0;
double val = 0;
ConsoleColor bg = Console.BackgroundColor;
ConsoleColor fg = Console.ForegroundColor;
while (opc != 6)
{
    Console.Clear();
    Console.WriteLine("=====================");
    Console.WriteLine(" 1 - Sumar");
    Console.WriteLine(" 2 - Restar");
    Console.WriteLine(" 3 - Multiplicar");
    Console.WriteLine(" 4 - Dividir");
    Console.WriteLine(" 5 - Limpiar");
    Console.WriteLine(" 6 - Salir");
    Console.WriteLine("=====================");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("Valor: '" + c.Resultado + "'");
    Console.ForegroundColor = fg;
    Console.BackgroundColor = bg;
    opc = LeerEntero("Ingresá la opción");

    if (opc <= 4)
    {
        val = LeerDouble("Ingresa el operando");
    }

    switch (opc)
    {
        case 1:
            c.Sumar(val);
            break;
        case 2:
            c.Restar(val);
            break;
        case 3:
            c.Multiplicar(val);
            break;
        case 4:
            if (Math.Abs(val) <= 0.00000000001) // Cota de error, para que el usuario no se haga el listo y ponga un 0.0000....0
            {
                PrintError("No se puede hacer una división por cero...");
                Pausa();
                break;
            }
            c.Dividir(val);
            break;
        case 5:
            c.Limpiar();
            break;
        default:
            PrintError("Opción incorrecta...");
            Pausa();
            break;
    }

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
        PrintError("Error, no ingresaste un entero...");
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
