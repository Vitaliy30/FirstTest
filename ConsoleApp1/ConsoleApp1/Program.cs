using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i != 999)
            {
                int count = i;
                int x = 0;
                int y = 0;
                if (count >= 100)
                {
                    int buffer = count;
                    x = buffer % 10;
                    count = count / 10;
                }
                if (count >= 10)
                {
                    int buffer = count;
                    y = buffer % 10;
                    count = count / 10;
                }
                int e = count + x + y;
                if (e == 15)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
