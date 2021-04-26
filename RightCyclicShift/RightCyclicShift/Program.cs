using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine(solution(9736));
    }
    public static int solution(int N)
    {
        int largest = N;
        int shift = 0;
        int temp = N;
        for (int i = 1; i < 30; ++i)
        {
            int index = (temp & 1);
            temp = ((temp >> 1) & 0x3fffffff | (index << 29) & 0x3fffffff);
            if (temp > largest)
            {
                largest = temp;
                shift = i;
            }
        }
        return shift;
    }
}