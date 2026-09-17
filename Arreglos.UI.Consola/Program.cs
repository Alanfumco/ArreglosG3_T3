using ArraglosLogica;

Console.WriteLine("Arreglos "),

    MiArreglo oMyArreglo = new(100);

oMyArreglo.Llenar(1, 100);

Console.WriteLine("\nArreglo desordenado: ");
Console.WriteLine(oMyArreglo);

Console.WriteLine("\nArreglo ordenado: ");
oMyArreglo.Ordenar();
Console.WriteLine(oMyArreglo);

Console.ReadKey();
