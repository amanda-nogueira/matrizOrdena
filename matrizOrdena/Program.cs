using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizOrdena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração 
            char[,] aux = new char[4, 4]; //matriz auxiliar
            char[,] mat4x4 = new char[4, 4] { { 'O', 'Q', '*', 'I'},
                                              { 'E', '*', 'E', 'S'},
                                              { 'R', 'E', 'U', 'T'},
                                              { 'A', '*', '*', 'S'} };

            // Título
            Console.WriteLine("### Ordenar a matriz ###");

            // Entrada / Atribuição de valores na matriz.
            // mat[lin,col] 
            /*  mat4x4[0, 0] = 'O';
              mat4x4[0, 1] = 'Q';
              mat4x4[0, 2] = '*';
              mat4x4[0, 3] = 'I'; */

            // Exibição antes de ordernar
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n Palavras ANTES de ordenar. \n\n");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" | {0} ", mat4x4[i, j]);
                }
                Console.WriteLine("| \n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pressione uma tecla para ver a solução...");
            Console.ReadKey();
            Console.Clear();
            // Algoritmo de Ordenação - Solução
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {

                    aux[i, j] = mat4x4[i, j];
                    mat4x4[i, j] = mat4x4[j, i];
                    mat4x4[j, i] = aux[i, j];
                }
            }
            aux[0, 0] = mat4x4[0, 0];
            mat4x4[0, 0] = mat4x4[3, 3];
            mat4x4[3, 3] = aux[0, 0];

            aux[0, 0] = mat4x4[1, 1];
            mat4x4[1, 1] = mat4x4[2, 2];
            mat4x4[2, 2] = aux[0, 0];

            // Saída
            Console.ForegroundColor = ConsoleColor.White; // Cor da fonte 
            //Console.BackgroundColor = ConsoleColor.White; // Cor do fundo branco
            Console.Write("\n\n Palavras Ordenadas \n\n");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" | {0} ", mat4x4[i, j]);
                }
                Console.WriteLine("| \n"); 
            }
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
