using System;


namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] R = { 2, 1, 0, 2 };
            int[] C = { 0, 2, 1, 2 };
            int N = 3;
            solution(N, R, C);

            int[] A = { 2, 3, 2, 3, 1, 1, 3, 1 };
            int[] B = { 3, 3, 1, 1, 1, 2, 2, 3 };
            int P = 5;
            solution(P, A, B);
        }
        public static void solution (int N, int[]R, int []C)
        {
            //create a board for the game
            int[,] field = new int[N,N];
            //fill the board with the bombs
            for (int i = 0; i < R.Length; i++)
            {
                field[R[i], C[i]] = 11;
            }
            int bomb = 0;
            //where there is no bomb count the neighbouring bombs as you update the board
            for (int i = 0; i <=N-1;  i++)
            {
                for (int k = 0; k<=N-1; k++)
                {
                   
                    if (field[i,k] != 11)
                    {
                        if (i - 1 >= 0 && field[i - 1, k] ==11 )
                        {
                            bomb++;
                        }
                        if (i - 1 >= 0 && k - 1 >= 0 && field[i - 1, k - 1] == 11)
                        {
                            bomb++;
                        }
                        if (i - 1 >=0 && k + 1 < N && field[i - 1, k + 1] == 11)
                        {
                            bomb++;
                        }
                        if (k - 1 >= 0 && field[i, k - 1] == 11)
                        {
                            bomb++;
                        }
                        if (i + 1 < N && k - 1 >= 0 && field[i + 1, k - 1] == 11)
                        {
                            bomb++;
                        }
                        if (i + 1 < N && field[i + 1, k] == 11)
                        {
                            bomb++;
                        }
                        if (i + 1 < N && k + 1 < N && field[i + 1, k + 1] == 11)
                        {
                            bomb++;
                        }
                        if (k + 1 < N && field[i, k + 1] == 11)
                        {
                            bomb++;
                        }
                        field[i,k] = bomb;
                        bomb = 0;
                        
                    } 
                }
              
            }
            string final = "";
            string [] finalarr = new string[N];
            for (int i = 0; i <=N-1; i++)
            {
                for (int k = 0; k <=N-1; k++)
                {
                    if(field[i,k]==11)
                    {
                        final += "B";
                    }
                    else
                    {
                        final += Convert.ToString(field[i,k]);
                    }
                   
                }
                finalarr[i] = final;
                final = "";
            }
            foreach (var item in finalarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
