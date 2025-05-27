using Sistema;

Empleado e = new Empleado();

e.FechaIngreso = new DateTime(2020, 1, 1);
e.FechaNacimiento = new DateTime(1975, 02, 27);

Console.WriteLine("Edad: " + e.Edad());
Console.WriteLine("Años para jubilarse: " + e.AñosParaJubilarse());
Console.WriteLine("Antiguedad: "+e.Antiguedad());