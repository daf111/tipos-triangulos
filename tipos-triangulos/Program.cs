using System;

namespace tipos_triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lados = cargaDeLados(); //Entrada de Datos

            if (esTriangulo(lados)) //Validación
            {
                Console.WriteLine(tipoDeTriangulo(lados)); //Algoritmo y salida
            }
            else
            {
                Console.WriteLine("No ha ingresado un triángulo");
            }
        }

        static int[] cargaDeLados()
        {
            return new int[] { 1, 2, 1 };
        }

        static void ordenarDeFormaDescendente(int[] lados)
        {
            for (int i = 0; i < (lados.Length - 1); i++)
            {
                for (int j = (i + 1); j < lados.Length; j++)
                {
                    if (lados[i] < lados[j])
                    {
                        int aux = lados[j];
                        lados[j] = lados[i];
                        lados[i] = aux;
                    }
                }
            }
        }
        static bool esTriangulo(int[] lados)
        {
            ordenarDeFormaDescendente(lados);

            return (lados[1] + lados[2]) > lados[0];
        }

        static string tipoDeTriangulo(int[] lados)
        {
            if (lados[0] == lados[1] && lados[1] == lados[2])
            {
                return "Es un triangulo equilatero";
            }
            else if (lados[0] == lados[1] || lados[1] == lados[2] || lados[0] == lados[2])
            {
                return "Es un triangulo isosceles";

            }
            else
            {
                return "Es un triangulo escaleno";
            }
        }
    }
}
