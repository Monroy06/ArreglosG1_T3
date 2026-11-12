using Arreglos.Logica;







//Console.WriteLine("Operaciones de pila");

//Console.WriteLine("Arreglo ");
MiArreglo oMiArreglo = new MiArreglo(50000);


try
{
    Console.WriteLine("\nArreglo\n");
    var tiempo1 = DateTime.Now;
    oMiArreglo.Llenar(1, 999999);
    Console.WriteLine(oMiArreglo);
    var tiempo2 = DateTime.Now;

    var restaTiempo = tiempo2 - tiempo1;

    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos");
    Console.ReadKey();

    //Console.WriteLine("\nPares\n");
    //var verPares = oMiArreglo.ObtenerPares();
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    //Console.WriteLine("\nPares Ordenados\n");
    //verPares.Ordenar();
    //Console.WriteLine(verPares);
    //Console.ReadKey();

    Console.WriteLine("\nPrimos\n");
    var tiempo3 = DateTime.Now;
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    var tiempo4 = DateTime.Now;
    var restatiempo2 = tiempo4 - tiempo3;
    Console.WriteLine($"\nTiempo transcurrido: {restatiempo2.Minutes} minutos, {restatiempo2.Seconds} segundos, {restatiempo2.Milliseconds} milisegundos, {restatiempo2.Nanoseconds} nanosegundos");
    Console.ReadKey();

    Console.WriteLine("\nPrimos Ordenados\n");
    var tiempo5 = DateTime.Now;
    verPrimos.Ordenar();
    Console.WriteLine(verPrimos);
    var tiempo6 = DateTime.Now;
    var restatiempo3 = tiempo6 - tiempo5;
    Console.WriteLine($"\nTiempo transcurrido: {restatiempo3.Minutes} minutos, {restatiempo3.Seconds} segundos, {restatiempo3.Milliseconds} milisegundos, {restatiempo3.Nanoseconds} nanosegundos");
    Console.ReadKey();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
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