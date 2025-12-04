using System.Collections.Generic;
using System;

namespace ExeMatrizes12
{
    internal class Program
    {
        static int EncontraNumPorCoordenada(Posição pos, List<Posição> list, int[] nums)
        {
            int num = 0;
            int contagem = list.Count;
            List<int> indice = new List<int>();
            for (int i = 0; i < contagem; i++)
            {
                pos = list[i];
                if (nums[0] == pos.Linha && nums[1] == pos.Coluna)
                {
                    num = pos.Valor;
                    break;
                }

            }
            return num;
        }

        static void Main(string[] args)
        {

            //Digita o tamanho da matriz e amazena
            Console.Write("Digite o tamanho da matriz: ");
            string[] tamanho = Console.ReadLine().Split('x');
            int n = int.Parse(tamanho[0]);
            int m = int.Parse(tamanho[1]);
            int[,] mat = new int[n, m];
            /*int a = mat.Length;
            int b = mat.Rank;
            int c = mat.GetLength(0);*/

            Console.WriteLine($"O formato da Matriz será {n}x{m}");


            //Abre para o usuario digitar as linhas/colunas
            for (int i = 0; i < n; i++)
            {
                int y = i + 1;
                int r = n - y;

                Console.WriteLine($"\n{y}ª Linha ({r} restantes): ");
                for (int j = 0; j < m; j++)
                {
                    int z = j + 1;
                    Console.Write($"Digite o {z}º número: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }

            }//Fim


            //Mostra a matriz na tela
            Console.WriteLine("\nMatriz: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j] + "\t");

                }
            }//Fim


            //Solicita o número em questão
            Console.Write("\n\nDigite um número na matriz: ");
            int num = int.Parse(Console.ReadLine());

            //Listas para encontrar as posições de todos os numeros da matriz
            Posição pos = new Posição();
            List<Posição> list = new List<Posição>();



            //Laço para armazenar as coordenadas e valor de cada número em um objeto
            for (int i = 0; i < n; i++)
            {
                for (int j = 0;j < m;j++)
                {

                    int valor = mat[i,j];
                    pos = new Posição(i, j, valor);
                    list.Add(pos);

                }
            }//Fim


            //Identifica o tanto de números que possuem iguais ao informado em 'num'
            int contagem = list.Count;
            List<int> indice = new List<int>();
            for (int i = 0; i < contagem; i++)
            {
                pos = list[i];
                if (pos.Valor == num)
                {
                    indice.Add(i);
                }

            }//Fim



            //Imprime a posição dos numeros que são iguais ao informado e os ao redor dele
            contagem = indice.Count;
            for (int i = 0;i < contagem; i++)
            {
                pos = list[indice[i]];
                Console.WriteLine("\nPosição " + list[indice[i]].Linha + "," + list[indice[i]].Coluna + ":");
                if (pos.Linha == 0)
                {

                }
                else
                {
                    int[] nums = { (pos.Linha - 1), pos.Coluna };
                    int numero = EncontraNumPorCoordenada(pos, list, nums);
                    Console.WriteLine("Up: " + numero);
                }
                if (pos.Linha == (n - 1))
                {

                }
                else
                {
                    int[] nums = { (pos.Linha + 1), pos.Coluna };
                    int numero = EncontraNumPorCoordenada(pos, list, nums);
                    Console.WriteLine("Down: " + numero);
                }
                if (pos.Coluna == 0)
                {
                }
                else
                {
                    int[] nums = { pos.Linha, (pos.Coluna - 1) };
                    int numero = EncontraNumPorCoordenada(pos, list, nums);
                    Console.WriteLine("Left: "+numero);
                }
                if(pos.Coluna == (m-1))
                {
                }
                else
                {
                    int[] nums = { pos.Linha, (pos.Coluna + 1) };
                    int numero = EncontraNumPorCoordenada(pos, list, nums);
                    Console.WriteLine("Right: "+numero);
                }


            }

            //Imprime na tela as coordenadas eo lado dos valores da matriz
            Console.WriteLine("\n\nMatriz com as coordenadas: \n");
            foreach (var a in list)
            {
                if (a.Coluna == (m-1))
                {
                    Console.WriteLine(a);

                }
                else
                {

                    Console.Write(a + " | ");
                }

            }

            /*Observações digitadas durante o desenvolvimento para ajudar a não perder o raciocinio
             * 
             * Sobre Linhas: Se a pos.Linha for igual a 0 ou igual a n (variavel da linha)
             não mostrar UP para igual a 0 e DOWN para igual a n
            
             Colunas: Se pos.Coluna for igual a 0 ou iguaL A m (variavel coluna)
             Não mostrar Left para == 0 || não mostrar Right para == m
            
             
             */

        }//main
    }
}