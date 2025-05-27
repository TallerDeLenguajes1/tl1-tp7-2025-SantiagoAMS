namespace Sistema;

public class Empleado{
    string nombre;
    string apellido;
    datetime fechaNacimiento;
    char estadoCivil;
    datetime fechaIngreso;
    double sueldoBasico;
    Cargo c;
    public enum Cargo{
        DUEÑO, VENDEDOR, SECRETARIO, SERENO, COMPRADOR
    }

    
}