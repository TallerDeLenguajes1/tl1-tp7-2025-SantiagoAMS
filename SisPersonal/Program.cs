using Sistema;

Empleado a = new Empleado();
Empleado b = new Empleado();
Empleado c = new Empleado();

a.FechaIngreso = new DateTime(2025-15, 1, 1);
a.FechaNacimiento = new DateTime(2025 - 55, 02, 27);
a.SueldoBasico = 650000;

b.FechaIngreso = new DateTime(2025-15, 1, 1);
b.FechaNacimiento = new DateTime(2025 - 55, 02, 27);
b.SueldoBasico = 650000;
b.Cargo = Empleado.Cargos.Ingeniero;

c.FechaIngreso = new DateTime(2025-15, 1, 1);
c.FechaNacimiento = new DateTime(2025 - 55, 02, 27);
c.SueldoBasico = 650000;
c.Cargo = Empleado.Cargos.Ingeniero;
c.EstadoCivil = 'c';

Console.WriteLine($"Empleado A:\n\tEdad:\t{a.Edad()}\n\tAntigu:\t{a.Antiguedad()}\n\tSalario:\t${a.Salario().ToString("##,#.00")}");
Console.WriteLine($"Empleado B:\n\tEdad:\t{b.Edad()}\n\tAntigu:\t{b.Antiguedad()}\n\tSalario:\t${b.Salario().ToString("##,#.00")}");
Console.WriteLine($"Empleado C:\n\tEdad:\t{c.Edad()}\n\tAntigu:\t{c.Antiguedad()}\n\tSalario:\t${c.Salario().ToString("##,#.00")}");
