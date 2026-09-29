using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

Console.WriteLine("Arreglo ");
MiArreglo oMiArreglo = new MiArreglo(10);
oMiArreglo.Llenar(1, 20);


Console.WriteLine("Arreglo Desordenado");
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo Ordenado Ascendenete");
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo Ordenado Descendenete");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);

Console.ReadKey();