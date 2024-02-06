class Program
{
    static void Main(string[] args)
    {
        Estudiante estudiante = new Estudiante("Juan", 20, "Masculino", "Calle 123", "Matemáticas", 90.5);
        Empleado empleado = new Empleado("Maria", 30, "Femenino", "Calle 456", "Desarrollador", 50000);

        // Mostrar datos de Estudiante
        Console.WriteLine("Datos del Estudiante:");
        Console.WriteLine($"Nombre: {estudiante.Nombre}");
        Console.WriteLine($"Edad: {estudiante.Edad}");
        Console.WriteLine($"Curso: {estudiante.Curso}");
        estudiante.Estudiar();
        estudiante.MostrarCalificacion();
        Console.WriteLine();

        // Mostrar datos de Empleado
        Console.WriteLine("Datos del Empleado:");
        Console.WriteLine($"Nombre: {empleado.Nombre}");
        Console.WriteLine($"Edad: {empleado.Edad}");
        Console.WriteLine($"Cargo: {empleado.Cargo}");
        empleado.Trabajar();
        empleado.MostrarSalario();

        Console.ReadLine();
    }
}
C: \Users\edelr\source\repos\EjercicioHerencia\EjercicioHerencia\Program.cs