using System;
using System.Collections.Generic;
using System.Text;

namespace ArreglosLogica
{
    public class MiArreglo
    {
        //Campos o atributos
        private int _tope;
        private int[] _arreglo;

        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[n];
            _tope = 0;
        }

        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Metodos
        //Metodo Llenar
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for (int i=0; i < N; i++)
            {
                arreglo[i] = random.Next(minimo, maximo);
            }
            _tope = N;
        }

        //Metodo ordenar (Burbuja)
        public void Ordenar()
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if(_arreglo[i] > _arreglo[j])
                    {
                        Cambiar(ref _arreglo[i], ref _arreglo[j]);
                    }
                }
            }
        }

        //Metodo Cambiar
        public void Cambiar(ref int a, ref int b)
        {
            int auxiliar = a;
            a = b;
            b = auxiliar;

        }

        //Metodo ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                Console.WriteLine("El arreglo está vacío.");

            }
            int contador = 0;
            contador++;
            for (int i=0; i<_tope; i++)
            {
                salida += $"{arreglo[i]}\t";
                if(contador > 9)
                {
                    contador = 0;
                    salida += "\n";
                }
            }
            return salida;

        }
    }
}
