﻿using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, m, d, r, r1, r2;
            y = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            r1 = (1404 - y - 1) * 365;
            if(m<=6)
            r2 = 365 - (m - 1) * 31 + d;
            else
                r2 = 365 - (186 + (m - 7) * 30 + d);
            r = r1 + r2;
            Console.WriteLine(r);
            y = r / 365;
            m = (r % 365) / 30;
            d = (r % 365) % 30;
            Console.WriteLine("Y=" + y + "" + "m" + m + "" + "d" + d);
            Console.ReadLine();

        }
    }
}
