
using System;

public class Estudiante : Persona
{
    public string Carrera { get; set; }
    public string Matricula { get; set; }

    public Estudiante(string nombre, int edad, string ciudad, string carrera, string matricula)
        : base(nombre, edad, ciudad)
    {
        Carrera = carrera;
        Matricula = matricula;
    }

    // Método para mostrar la información completa del estudiante
    public void MostrarInformacionCompleta()
    {
        MostrarInformacion();
        Console.WriteLine($"Carrera: {Carrera}, Matrícula: {Matricula}");
    }
}

// Ejemplo de uso de las clases
public class Program
{
    public static void Main(string[] args)
    {
        Persona persona = new Persona("Ana", 30, "Madrid");
        persona.MostrarInformacion();

        Estudiante estudiante = new Estudiante("Carlos", 22, "Barcelona", "Ingeniería", "2023001");
        estudiante.MostrarInformacionCompleta();
    }
}
