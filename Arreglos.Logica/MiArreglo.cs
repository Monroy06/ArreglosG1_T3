using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {


        //Atributos o campos 
        private int _tope;
        private int[] _arreglo;


        // constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        //Propiedades 
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;
        //Metodos 
        //Metodo llenar 
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();
            for (int i = 0; i < _tope - 1; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);

            }
            _tope=N;
        }


        // Metodos ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Arreglo vacio";
            }
            String cadena = string.Empty;
            int contador = 0;
            for (int i = 0; i < _tope; i++)
            {
                cadena += $"[{i}]={_arreglo[i]}\n";
                contador++;
                if (contador < 9)
                {
                    contador = 0;
                    cadena += "\n";
                }
                
            }
            return cadena;

        }
    }
}
