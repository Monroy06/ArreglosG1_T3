using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");

Console.WriteLine("Arreglo ");
MiArreglo oMiArreglo = new MiArreglo(5);

try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);


    Console.WriteLine(oMiArreglo);
    Console.WriteLine("Eliminar 500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("Eliminar 500 en posicion 1");
    Console.ReadKey();
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);



}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);

}



//oMiArreglo.Llenar(1, 20);

//Console.WriteLine("Arreglo Desordenado");
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo Ordenado Ascendenete");
//oMiArreglo.Ordenar();
//Console.WriteLine(oMiArreglo);

//Console.WriteLine("Arreglo Ordenado Descendenete");
//oMiArreglo.Ordenar(false);
//Console.WriteLine(oMiArreglo);

Console.ReadKey();