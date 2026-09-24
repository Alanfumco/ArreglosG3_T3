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

        //Metodo llenar
        public void Llenar()
        {
            Llenar(1,100);
        }

        //Metodo Llenar con parametros
        public void Llenar(int minimo, int maximo)
        {
            Random random = new Random();
            for (int i=0; i < N; i++)
            {
                _arreglo[i] = random.Next(minimo, maximo);
            }
            _tope = N;
        }

        //Metodo ordenar (Burbuja)

        public void Ordenar()
        {
            Ordenar(true);
        }
        public void Ordenar(bool ascendente)
        {
            for (int i = 0; i < _tope - 1; i++)
            {
                for (int j = i + 1; j < _tope; j++)
                {
                    if (ascendente)
                    {
                        if (_arreglo[i] > _arreglo[j])
                        {
                            Cambiar(ref _arreglo[i], ref _arreglo[j]);
                        }
                        else
                        {
                            if (_arreglo[i] < _arreglo[j])
                            {
                                Cambiar(ref _arreglo[i], ref _arreglo[j]);
                            }
                        }
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

        //Metodo agregar 
        public void Agregar(int numero)
        {
            if(EstaLleno)
            {
                throw new Exception("El arreglo está lleno.");
            }
            _arreglo[_tope] = numero;
            _tope++;
        }

        //Metodo insertar
        public void Insertar(int numero, int posicion)
        {
            if (EstaLleno)
            {
                throw new Exception("El arreglo está lleno.");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if(posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = _tope; i > posicion; i--)
            {
                _arreglo[i] = _arreglo[i - 1];
            }
            _arreglo[posicion] = numero;
            _tope++;
        }

        //Metodo eliminar
        public void Eliminar(int posicion)
        {
            if (EstaVacio)
            {
                throw new Exception("El arreglo está vacío.");
            }
            if (posicion < 0)
            {
                posicion = 0;
            }
            if (posicion > _tope)
            {
                posicion = _tope;
            }
            for (int i = posicion; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }
            _tope--;
        }

        //Metodo ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                Console.WriteLine("El arreglo está vacío.");

            }
            int contador = 0;
            string salida = string.Empty;
            contador++;
            for (int i=0; i<_tope; i++)
            {
                salida += $"{_arreglo[i]}\t";
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
