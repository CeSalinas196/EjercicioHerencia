
public class Persona
{

    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Genero { get; set; }
    public string Direccion { get; set; }


    public Persona(string nombre, int edad, string genero, string direccion)
    {
        Nombre = nombre;
        Edad = edad;
        Genero = genero;
        Direccion = direccion;
    }
}

public class Estudiante : Persona
{
    public string Curso { get; set; }
    public double Calificacion { get; set; }

    public void Estudiar()
    {
        Console.WriteLine($"{Nombre} está estudiando {Curso}.");
    }

    public void MostrarCalificacion()
    {
        Console.WriteLine($"{Nombre} tiene una calificación de {Calificacion}.");
    }


    public Estudiante(string nombre, int edad, string genero, string direccion, string curso, double calificacion)
        : base(nombre, edad, genero, direccion)
    {
        Curso = curso;
        Calificacion = calificacion;
    }
}


public class Empleado : Persona
{

    public string Cargo { get; set; }
    public double Salario { get; set; }

    public void Trabajar()
    {
        Console.WriteLine($"{Nombre} está trabajando como {Cargo}.");
    }

    public void MostrarSalario()
    {
        Console.WriteLine($"{Nombre} tiene un salario de {Salario:C}.");
    }

    public Empleado(string nombre, int edad, string genero, string direccion, string cargo, double salario)
        : base(nombre, edad, genero, direccion)
    {
        Cargo = cargo;
        Salario = salario;
    }
}
