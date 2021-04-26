using System;

namespace ArrayClosestAssendorEfficient
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] { 4, 3, 1, 4, -1, 2, 1, 5, 7 }));//7,1,1,4,1,2,1,1,0
        }
        public static int[] solution(int[] A)
        {
            /*  / is the null number
             * rightarr=7 2 1 4 1 2 1 1 /
             * leftarr= / 1 1 / 1 2 1 / /
             * result = 7 1 1 4 1 2 1 1 / is the minimum btwn left and right assendors
             */
            int[] result = new int[A.Length];
            int []S = new int[A.Length];
            int SizeOfS = 0;
            int[]leftarr= new int[A.Length];
            int[]rightarr= new int[A.Length];
            int isNull = Int32.MaxValue;
            // Iterate through the input array and add each value enco
            // to stack. Pop elements off the stack when you find a la
            // in the input array.
            for (int i = 0; i < A.Length; i++)
            {
                // Check stack and remove every element that is smaller
                // than your current value (e.g. when stack contains 4
                // and you reach 4 you will pop all values off the sta

                while (SizeOfS > 0 && A[S[SizeOfS - 1]] <= A[i])
                    {
                        SizeOfS--;
                    }
                    if (SizeOfS == 0)
                        leftarr[i] = isNull;
                    else
                        leftarr[i] = i - S[SizeOfS - 1];
                    S[SizeOfS] = i;
                    SizeOfS++;
                  
            }
            SizeOfS = 0;
            for (int i = A.Length-1; i >=0; i--)
            {
                while (SizeOfS > 0 && A[S[SizeOfS - 1]] <= A[i])
                {
                    SizeOfS--;
                }
                    if (SizeOfS == 0)
                        rightarr[i] = isNull;
                    else
                        rightarr[i] = S[SizeOfS - 1]-i;
                    S[SizeOfS] = i;
                    SizeOfS++;
                
            }
            //compare the right and left assendors and get the smallest of the two
            for (int i = 0; i < A.Length; i++)
            {
                if (leftarr[i] < rightarr[i])
                    result[i] = leftarr[i];
                else result[i] = rightarr[i];
                //if the value is null
                if (result[i] == isNull)
                    result[i] = 0;

            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return result;
        }
    }
}
