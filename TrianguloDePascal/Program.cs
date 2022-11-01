using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloDePascal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // perguntar ao user q profundidade e pega o input
            Console.WriteLine("Informe a profundidade que deseja que o triângulo possua");
            int profundidade = int.Parse(Console.ReadLine());

            Console.WriteLine(Pascal(profundidade));

            Console.ReadKey();
        }
                
        public static long[][] TrianguloDePascal(long depth)
        {
            int profundidade = Convert.ToInt32(depth);

            // Allocate the array in a triangle form!
            long[][] triangulo = new long[profundidade + 1][];

            for (int linha = 0; linha < profundidade; linha++)
            {
                triangulo[linha] = new long[linha + 1];
            }

            // Calculate the Pascal's triangle
            triangulo[0][0] = 1;

            for (int linha = 0; linha < profundidade - 1; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    triangulo[linha + 1][coluna] += triangulo[linha][coluna];
                    triangulo[linha + 1][coluna + 1] += triangulo[linha][coluna];
                }
            }

            // Print the Pascal's triangle
            for (int linha = 0; linha < profundidade; linha++)
            {
                Console.Write("".PadLeft((profundidade - linha) * 2));
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("{0,3} ", triangulo[linha][coluna]);
                }
                Console.WriteLine();
            }

            return triangulo;
        }

        public static long[][] Pascal(int linhas)
        {
            // Jagged Array - número de linhas é fixo mas o de colunas pode variar
            long[][] triangulo = new long[linhas][];

            // Cada linha-Array recebe um array com a Qt de Elementos = linha + 1 (proporcional à PROFUNDIDADE da linha)
            for (int linha = 0; linha < linhas; linha++){
                triangulo[linha] = new long[linha + 1];
            }

            triangulo[0][0] = 1;
            for (int linha = 1; linha < linhas; linha++){
                triangulo[linha][0] = 1; 
                triangulo[linha][linha] = 1;
                for (int coluna = 1; coluna < linha; coluna++){
                    triangulo[linha][coluna] = triangulo[linha - 1][coluna - 1] + triangulo[linha - 1][coluna];
                }
            }

            // Print the Pascal's triangle
            for (int linha = 0; linha < linhas; linha++)
            {
                Console.Write("".PadLeft((linhas - linha) * 2));
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("{0,3} ", triangulo[linha][coluna]);
                }
                Console.WriteLine();
            }

            return triangulo;
        }
    } 
}
