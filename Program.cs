using System;
using tendencias_lab_final.Class;

namespace tendencias_lab_final
{
    class Program
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Primer numero (base) ");
        int basea = int.Parse(Console.ReadLine()));
        System.Console.WriteLine("El exponente: ");
        int exponente = int.Parse(Console.ReadLine());
        System.Console.WriteLine( Class.Calculator.Potencia(basea, exponente));
    }
    }
}
