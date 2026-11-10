using Arreglos.Logica;







//Console.WriteLine("Operaciones de pila");

//Console.WriteLine("Arreglo ");
MiArreglo oMiArreglo = new MiArreglo(100);


try
{
    Console.WriteLine("\nArreglo\n");
    oMiArreglo.Llenar();
    Console.WriteLine(oMiArreglo);
    Console.ReadKey();

    Console.WriteLine("\nPares\n");
    var verPares = oMiArreglo.ObtenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();

    Console.WriteLine("\nPares ordenados\n");
    verPares.Ordenar(true);
    Console.WriteLine(verPares);
    Console.ReadKey();

}
catch (Exception)
{

    throw;
}

//try
//{
//    oMiArreglo.Agregar(7);
//    oMiArreglo.Agregar(-2);
//    oMiArreglo.Agregar(8);

//    Console.WriteLine(oMiArreglo);
//    Console.WriteLine("Insertar 500 en posición 1");
//    Console.ReadKey();
//    oMiArreglo.Insertar(500, 1);
//    Console.WriteLine(oMiArreglo);

//    Console.WriteLine("Eliminar 500 en posición 1");
//    Console.ReadKey();
//    oMiArreglo.Eliminar(1);
//    Console.WriteLine(oMiArreglo);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}



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