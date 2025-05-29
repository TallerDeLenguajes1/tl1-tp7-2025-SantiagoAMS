using Sistema;

Empleado a = new Empleado();
Empleado b = new Empleado();
Empleado c = new Empleado();

a.FechaIngreso = new DateTime(2025-14, 1, 1);
a.FechaNacimiento = new DateTime(2025 - 52, 02, 27);
a.SueldoBasico = 90000000;
a.Cargo = Empleado.Cargos.Auxiliar;
a.Apellido = "Messi";
a.Nombre = "Cristiano";
a.EstadoCivil = 'c';

b.FechaIngreso = new DateTime(2025-20, 1, 1);
b.FechaNacimiento = new DateTime(2025 - 61, 02, 27);
b.SueldoBasico = 650000;
b.Cargo = Empleado.Cargos.Ingeniero;
b.Apellido = "Gentile";
b.Nombre = "Nate";
b.EstadoCivil = 's';

c.FechaIngreso = new DateTime(2025-16, 1, 1);
c.FechaNacimiento = new DateTime(2025 - 45, 02, 27);
c.SueldoBasico = 650000;
c.Cargo = Empleado.Cargos.Especialista;
c.EstadoCivil = 'c';
c.Apellido = "Kojimba";
c.Nombre = "Fideo";

Empleado[] empleados = { a, b, c };
Empleado proxJub = null;
double sum = 0;

foreach (Empleado e in empleados)
{
    sum += e.Salario();
    proxJub ??= e;
    if (proxJub != e) {
        if (e.FechaNacimiento < proxJub.FechaNacimiento)
        {
            proxJub = e;
        }    
    }
}

if (proxJub != null)
{

    Console.WriteLine("Empleado mas proximo a jubilarse:");
    Console.WriteLine($"\tNombre: {proxJub.Apellido}, {proxJub.Nombre}");
    Console.WriteLine($"\tEdad: {proxJub.Edad()}");
    Console.WriteLine($"\tAntiguedad: {proxJub.Antiguedad()}");
    Console.WriteLine($"\tPara jubilarse: {proxJub.AñosParaJubilarse()} años");
    Console.WriteLine($"\tSalario: ${proxJub.Salario().ToString("#,##.00")}");
}

Console.WriteLine($"\nCantidad a pagarle a todos los empleados: ${sum.ToString("#,##.00")}");