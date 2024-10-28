using System;

public class Persona
{
    // Atributos de la clase Persona
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Ciudad { get; set; }

    // Constructor para inicializar los atributos
    public Persona(string nombre, int edad, string ciudad)
    {
        Nombre = nombre;
        Edad = edad;
        Ciudad = ciudad;
    }

    // Método para mostrar la información de la persona
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, Ciudad: {Ciudad}");
    }

    // Método para calcular la edad en años
    public int CalcularEdad()
    {
        return Edad;
    }
}
