using System;

namespace Sistema;

public class Empleado
{

    ///////////////////////////////////////////////////// Fields
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldoBasico;
    private Cargos cargo;


    ///////////////////////////////////////////////////// Encapsulamiento
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get =>apellido; set => apellido = value;}
    public DateTime FechaNacimiento{ get => FechaNacimiento; set => fechaNacimiento = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargo { get => cargo; set => cargo = value; }

    ////////////////////////////////////////////////////////////////////
    public enum Cargos
    {
        Auxiliar, Administrativo, Ingeniero, Especialista, Investigador
    }

    ////////////////////////////////////////////////////////////////////
    public int Antiguedad()
    {
        return DateTime.Now.Year - this.FechaIngreso.Year;
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