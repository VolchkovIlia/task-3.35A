using System;
using System.Runtime.InteropServices;

public class MainClass
{
    public static void Main()
    {
        int a, b, c, d, e, f;
    restart:
        Console.WriteLine("Размер поля 8*8");
        Console.WriteLine("Введите координаты белой фигуры:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Координаты хода белой фигуры:");
        e = int.Parse(Console.ReadLine());
        f = int.Parse(Console.ReadLine());
        Console.WriteLine("Координаты чёрной фигуры:");
        c = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        if (a > 8 || b > 8 || c > 8 || d > 8 || e > 8 || f > 8)
        {
            Console.WriteLine("Превышен размер поля");
            Console.WriteLine("Повторите ввод данных");
            goto restart;
        }
        else
        {
            if (a == c || b == d)
            {
                Console.WriteLine("Ладья({0},{1}) угрожает полю({2},{3})", a, b, c, d);
            }
            else
            {
                Console.WriteLine("Ладья({0},{1})  не угрожает полю({2},{3})", a, b, c, d);
            }

            if ((c - a) * (f - b) - (d - b) * (e - a) == 0 & (a - c) * (e - c) + (b - d) * (f - d) <= 0)
            {
                Console.WriteLine("Чёрная фигура представляет угрозу белой фигуре");
            }
            else
            {
                Console.WriteLine("Чёрная фигура не представляет угрозу белой фигуре");
            }
        }
    }
}
