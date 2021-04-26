using System;

namespace KOctalRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution1(new int[] {1,5,6 }));
        }
        public static int solution1(int[] A)
        {
            int count = 0;
            string binaryrep = "";
            string[] binary = new string[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
               binaryrep = Convert.ToString(A[i], 2);
                binary[i] = binaryrep;
            }
            string b = "";
            for (int i = 0; i < binary.Length; i++)
            {
                b = binary[i];
                for (int j = 0; j < b.Length; j++)
                {
                    if (b[j] == '1') count++;
                }
                   
            }
            return count;
        }
        
    }
}
