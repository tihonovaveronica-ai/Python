using System;
using System.Globalization;
//Задача 4.18
class Program
{
    static void Main(string[] args)
    {
       int n=vv_ch("Введите число: ");
       pascal(n);
    }
    static int vv_ch(string name)
    {
        //ф-ция для ввода числа с проверкой
        while (true)
        {
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (int.TryParse(n,out int nn) && nn>0)
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите целое число  больше 0.");
        }
    }
    static void pascal(int n)
    {
        //ф-ция для вывода треугольника
        for (int i=0;i<n;i++)
        {
            int x =1;
            Console.Write(x);
            for (int j=1; j<=i;j++)
            {
                x=x*(i-j+1)/j;
                Console.Write($" {x}");
            }
            Console.WriteLine();
        }
    } 
}