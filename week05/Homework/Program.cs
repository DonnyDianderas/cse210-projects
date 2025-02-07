using System;

class Program
{
    static void Main(string[] args)
    {
        {
        
        Assignment tarea1 = new("Samuel Bennett", "Multiplicación");
        Console.WriteLine(tarea1.ObtenerResumen());

        MathAssignment tarea2 = new("Roberto Rodriguez", "Fracciones", "7.3", "8-19");
        Console.WriteLine(tarea2.ObtenerResumen());
        Console.WriteLine(tarea2.ObtenerListaDeEjercicios());

        WritingAssignment tarea3 = new("Mary Waters", "Historia Europea", "Las causas de la Segunda Guerra Mundial");
        Console.WriteLine(tarea3.ObtenerResumen());
        Console.WriteLine(tarea3.ObtenerInformacionEscrita());
    }
    }
}