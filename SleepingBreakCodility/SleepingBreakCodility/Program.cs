using System;

namespace SleepingBreakCodility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string S =  "Sun 10:00 - 20:00"+ "/" +
                        "Fri 05:00 - 10:00"+ "/" +
                        "Fri 16:30 - 23:50" + "/" +
                        "Sat 10:00 - 24:00" + "/" +
                        "Sun 01:00 - 04:00" + "/" +
                        "Sat 02:00 - 06:00" + "/" +
                        "Tue 03:30 - 18:15" + "/" +
                        "Tue 19:00 - 20:00" + "/" +
                        "Wed 04:25 - 15:14" + "/" +
                        "Wed 15:14 - 22:40" + "/" +
                        "Thu 00:00 - 23:59" + "/" +
                        "Mon 05:00 - 13:00" + "/" +
                        "Mon 15:00 - 21:00 ";
            Console.WriteLine(solution(S));
        }
        public static int solution (string S)
        {
            //get days
            string[] D = S.Split('/');
            int N = D.Length;
            int[] startTime = new int[N];
            int[] endTime = new int[N];
            int Dmultiplier = 0;
            int minDay = 1440;
            for (int i = 0; i < D.Length; i++)
            {
                if (D[i].Contains("Mon"))
                    Dmultiplier = 0;
                else if (D[i].Contains("Tue"))
                    Dmultiplier = minDay;
                else if (D[i].Contains("Wed"))
                    Dmultiplier = minDay*2;
                else if (D[i].Contains("Thur"))
                    Dmultiplier = minDay*3;
                else if (D[i].Contains("Fri"))
                    Dmultiplier = minDay*4;
                else if (D[i].Contains("Sat"))
                    Dmultiplier = minDay*5;
                else
                    Dmultiplier = minDay * 6;

                char[] splitter = { ' ', '-', ';' };
                string[] SplitDays = D[i].Split(splitter);
                startTime[i]= Int32.Parse(SplitDays[1]) * 60 + Int32.Parse(SplitDays[2]) + Dmultiplier;
                endTime[i] = Int32.Parse(SplitDays[3]) * 60 + Int32.Parse(SplitDays[24]) + Dmultiplier;
            }
            int temp;
            for (int i = 0; i <N; i++)
            {
                for (int j = 0; j < N-1; j++)
                {
                    if(startTime[j]>endTime[j+1])
                    {
                        temp = startTime[j + 1];
                        startTime[j + 1] = startTime[j];
                        startTime[j] = temp;

                        temp = endTime[j + 1];
                        endTime[j + 1] = endTime[j];
                        endTime[j] = temp;

                    }
                }
            }
            int max = startTime[0];
            int tempMax = 0;

            for (int i = 0; i < N-1; i++)
            {
                tempMax = startTime[i + 1] - endTime[i];
                max = Math.Max(max, tempMax);
            }
            tempMax = minDay * 7 - endTime[N - 1];
            max = Math.Max(max, tempMax);
            return max;
        }
    }
}
