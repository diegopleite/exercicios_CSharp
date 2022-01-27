using System;

namespace ExercicioMatrizes {
    class Program {
        static void Main(string[] args) {

            Console.Write("Insira o numero de linhas da matriz: ");
            int lin = int.Parse(Console.ReadLine());
            Console.Write("Insira o numero de colunas da matriz: ");
            int col = int.Parse(Console.ReadLine());

            int[,] mat = new int[lin, col];
            
            for (int i = 0; i < lin; i++) {
                Console.WriteLine("Insira os {0} numeros da linha {1}", col, (i+1));
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < col; j++) {
                    mat[i, j] = int.Parse(values[j]);                    
                }                
            }
            
            Console.WriteLine("matriz: ");
            for (int i = 0; i < lin; i++) {                
                for (int j = 0; j < col; j++) {
                    Console.Write(mat[i, j] + " ");
                    if ((j+1) == col) {
                        Console.WriteLine("\n");
                    }
                }
            }

            Console.WriteLine("Escolha um numero da Matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < lin; i++) {
                for (int j = 0; j < col; j++) {
                    if (num == mat[i,j]) {
                        Console.WriteLine("Posição: " + i + "," + j);
                        if (i > 0) {
                            Console.WriteLine("cima: " + mat[(i-1),j]);
                        }
                        if ((j+1) < col) {
                            Console.WriteLine("direita: " + mat[i,(j+1)]);
                        }
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat[i,(j-1)]);
                        }
                        if ((i+1) < lin) {
                            Console.WriteLine("Baixo: " + mat[(i+1),j]);
                        }
                    }
                    
                }
            }

        }
    }
}
