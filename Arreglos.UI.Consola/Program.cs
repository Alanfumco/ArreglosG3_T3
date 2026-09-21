using ArreglosLogica;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Arreglos ");

        MiArreglo oMyArreglo = new(100);

        oMyArreglo.Llenar(1, 100);

        Console.WriteLine("\nArreglo desordenado: ");
        Console.WriteLine(oMyArreglo);

        Console.WriteLine("\nArreglo ordenado ascendente: ");
        oMyArreglo.Ordenar(true);
        Console.WriteLine(oMyArreglo);

        Console.WriteLine("\nArreglo ordenado descendente: ");
        oMyArreglo.Ordenar(false);
        Console.WriteLine(oMyArreglo);

        Console.ReadKey();
    }
}