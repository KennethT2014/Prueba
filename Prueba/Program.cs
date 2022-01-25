using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los dígitos de su cédula");
            int[] cedula = new int[14];
            int Contas, Sumados;
            Contas = 0;
            Sumados = 0;
            for (int i=0; i<cedula.Length; i++)
            {
                cedula[i] = Convert.ToInt32(Console.ReadLine());

                if(cedula[i]%2 == 0)
                {
                    Contas++;
                }
                else
                {
                    Sumados = Sumados + cedula[i];
                }

                if (cedula[i] < 0)
                {
                    i = cedula.Length;
                    Console.WriteLine("El programa dejó de recibir datos, los números negativos son invalidos");
                }
            }

            for(int i=0; i<cedula.Length; i++)
            {
                Console.WriteLine(cedula[i]);
            }

            Console.WriteLine($"La cantidad de números pars es: {Contas}");
            Console.WriteLine($"La sumatoria de números impares es: {Sumados}");

            int M;
            int[,] matiz = new int[,]
            {
                {1, 2, 7 },
                {3, 4, 8 },
                {5, 6, 9 }
            };

            Console.Clear();
            int F1 = matiz.GetLength(0);
            int C1 = matiz.GetLength(1);
            for (M=0; M< matiz.Length; M++)
            {
                for(int k = 0; k < matiz.Length; k++)
                {
                    if (matiz[M, k] == 7)
                    {
                        Console.WriteLine(matiz[M, k]);
                    }

                    if(matiz[M, k] == 8)
                    {
                        Console.WriteLine(matiz[M, k]);
                    }

                    if(matiz[M, k] == 9)
                    {
                        Console.WriteLine(matiz[M, k]);
                    }
                }
            }
        }
    }
}
