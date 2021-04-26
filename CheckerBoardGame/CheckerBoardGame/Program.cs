using System;

namespace CheckerBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new string[] {"..X...","......",  "....X.", ".X....", "..X.X.", "...O.." }));//2
            Console.WriteLine(solution(new string[] { "X....", ".X...", "..O..", "...X.", "....."}));//0
        }
        public static int solution(string[] B)
        {
            //loop through the board
            //while on an element o check its upleft and upright
            //if X and the upleft/upright of X is empty(.)
            //count moves
            //stop when jafar can no longer move further
            int count = 0;
            
            int row = 0;
            int col = 0;
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B[i].Length; j++)
                {
                    if (B[i][j] == 'O')
                    {
                        row = i;
                        col = j;
                    }      
                }             
            }  
            return possibleMoves(B, row, col, count);
        }
        public static int possibleMoves(string[] B, int i, int j,int count)
        {
            int max = 0;
            max = count;
            if (i - 1 >= 0 && j - 1 >= 0 && B[i - 1][j - 1] == 'X' && i - 2 >= 0 && j - 2 >= 0 && B[i - 2][j - 2] == '.')
            {

                max = Math.Max(max, possibleMoves(B,i-2,j-2,count+1));
            }
            if (i - 1 >= 0 && j + 1 < B.Length - 1 && B[i - 1][j + 1] == 'X' && i - 2 >= 0 && j + 2 < B.Length - 2 && B[i - 2][j + 2] == '.')
            {
                max = Math.Max(max, possibleMoves(B, i-2, j+2, count+1));
            }
            
            return max;
        }

        
    }
}
