using System;

namespace Sistema;

public class Empleado
{

    ///////////////////////////////////////////////////// Fields
    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil = 's';
    private DateTime fechaIngreso;
    private double sueldoBasico = 0;
    private Cargos cargo = Cargos.Auxiliar;


    ///////////////////////////////////////////////////// Encapsulamiento
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaNacimiento { get => FechaNacimiento; set => fechaNacimiento = value; }
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

    public bool EsCasado()
    {
        return estadoCivil == 'c';
    }

    public double Salario()
    {
        int ant = Antiguedad();

        double adicional = (sueldoBasico * (ant < 20 ? ant : 25))/ 100;
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }
        if (EsCasado())
        {
            adicional += 150000;
        }
        return sueldoBasico + adicional;

        /*Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
    Adicional. Para ello el Adicional contempla la antigüedad en años, el
    cargo y si es casado:
    i) 1 % del sueldo básico por cada año de antigüedad hasta los
    20 años, a partir de este, el porcentaje se fija en 25%.
    ii) Si el cargo es Ingeniero o Especialista, el Adicional se
    incrementa en un 50%.
    iii) Si es casado al Adicional se le aumenta $150.000.
    Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
    $650.000, el Adicional es 65.0000 * 0.15 = 97.500. Si además el
    cargo es Ingeniero o Especialista, se incrementa el Adicional en
    un 50%. Esto es: 97.500* 1.50 = 146.250. Si a su vez es casado
    el Adicional será: 146.250+ 150.000= 296.250
    */
    }

}