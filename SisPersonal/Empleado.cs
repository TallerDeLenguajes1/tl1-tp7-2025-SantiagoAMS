using System;

namespace Sistema;

public class Empleado
{
    public string nombre;
    public string apellido;
    public DateTime fechaNacimiento;
    public char estadoCivil;
    public DateTime fechaIngreso;
    public double sueldoBasico;
    public Cargos c;

    public enum Cargos
    {
        Auxiliar, Administrativo, Ingeniero, Especialista, Investigador
    }

    public int Antiguedad()
    {
        return DateTime.Now.Year - this.fechaIngreso.Year;
    }

    public int Edad()
    {
        return (DateTime.Now.Subtract(this.fechaNacimiento)).Days / 365;
    }

    public int AñosParaJubilarse()
    {
        return 65 - Edad();
    }

}