using System;

namespace ExercícioExtra.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("====Agencia Espacial Brasileira==== ");
            Console.Write("\n====Tupiniquim I Project====");
            Console.ReadLine();

            int X = 0;
            int Y = 0;
            char roboPosicao = '0';

            Console.Write("Insira as coordenadas (Ex: 5 5): ");
            string[] XY = Console.ReadLine().Split(' ');
            X = int.Parse(XY[0]);
            Y = int.Parse(XY[1]);

            int[] arrayX = new int[X];
            int[] arrayY = new int[Y];

            int roboX = 1;
            int roboY = 1;

            Console.Write($"{arrayX.Length}, {arrayY.Length}\n");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Posição do robo {i} (Ex: 5 5 N):");
                string[] tokens = Console.ReadLine().Split(' ');
                roboX = int.Parse(tokens[0]);
                roboY = int.Parse(tokens[1]);
                roboPosicao = char.Parse(tokens[2]);
                Console.WriteLine($"Posição atualizada do Robo {i}: " + roboX + ", " + roboY + ", " + roboPosicao);
                Console.ReadLine();

                Console.WriteLine("Insira o conjunto de comandos (E: esquerda, D: direita, M: reto): ");
                string comando = Console.ReadLine();
                char[] arr;
                arr = comando.ToCharArray();

                for (int k = 0; k < arr.Length; k++)
                {
                    switch (arr.GetValue(k))
                    {
                        case 'E': //ESQUERDA
                            if (roboPosicao == 'N')
                            {
                                roboPosicao = 'O';
                            }
                            else if (roboPosicao == 'O')
                            {
                                roboPosicao = 'S';
                            }
                            else if (roboPosicao == 'S')
                            {
                                roboPosicao = 'L';
                            }
                            else if (roboPosicao == 'L')
                            {
                                roboPosicao = 'N';
                            }
                            break;

                        case 'D': //DIREITA
                            if (roboPosicao == 'N')
                            {
                                roboPosicao = 'L';
                            }
                            else if (roboPosicao == 'O')
                            {
                                roboPosicao = 'N';
                            }
                            else if (roboPosicao == 'S')
                            {
                                roboPosicao = 'O';
                            }
                            else if (roboPosicao == 'L')
                            {
                                roboPosicao = 'S';
                            }
                            break;

                        case 'M': //FRENTE
                            if (roboPosicao == 'N')
                            {
                                roboY = roboY + 1;
                            }
                            else if (roboPosicao == 'O')
                            {
                                roboX = roboX - 1;
                            }
                            else if (roboPosicao == 'S')
                            {
                                roboY = roboY - 1;
                            }
                            else if (roboPosicao == 'L')
                            {
                                roboX = roboX + 1;
                            }
                            break;
                    }
                }
                Console.WriteLine("Posição nova do Robo: Posição X: " + roboX + ", Posição Y: " + roboY + ", Posição Bússola: " + roboPosicao);
                Console.WriteLine("\nPosicionamento foi um sucesso!");
                Console.ReadLine();
                
            }
        }
    }
}

