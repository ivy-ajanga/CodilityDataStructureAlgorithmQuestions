using System;

namespace ConvertToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 7;
            Console.WriteLine(solution(A,B));
        }
        public static int solution(int A, int B)
        {
            int countbit = 0;
            long multipleNo =(long) (A * B);
            string binaryrep = Convert.ToString(multipleNo, 2);
            Console.WriteLine(binaryrep);
            for (int i = 0; i < binaryrep.Length; i++)
            {
                if (binaryrep[i] == '1') countbit++;
            }
            return countbit;
        }
    }
}
