using System;

namespace ProgramtoprintlastNlines
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = "str1\nstr2\nstr3\nstr4\nstr5\nstr6\nstr7" +
                   "\nstr8\nstr9\nstr10\nstr11\nstr12\nstr13" +
                   "\nstr14\nstr15\nstr16\nstr17\nstr18\nstr19" +
                   "\nstr20\nstr21\nstr22\nstr23\nstr24\nstr25";
            int n = 10;
            LastNLines(s1, n);
        }
        public static void LastNLines(string str, int n)
        {
           
            string[] split = str.Split("\n");
            if (split.Length==0)
            {
                Console.WriteLine("No N characters");
            }
            if(split.Length>=n)
            {
                for (int i = split.Length-n; i < split.Length; i++)
                {
                    Console.WriteLine(split[i]);
                }
            }
            else
            {
                for (int i = 0; i < split.Length; i++)
                {
                    Console.WriteLine(split[i]);
                }
            }
          
        }
    }
}
