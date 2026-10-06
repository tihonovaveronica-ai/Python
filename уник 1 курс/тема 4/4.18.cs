using System;
//Задача 4.18
class Program
{
    static void Main(string[] args)
    {
       int n=vv_ch("Введите число: ");
       pascal(n)
    }
    static int vv_ch(string name)
    {
        //ф-ция для ввода числа с проверкой
        Console.Write($"{name}");
        string n=Console.ReadLine();
        while (true)
        {
            if (int.TryParse(n,out int nn) && nn>0)
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите целое число  больше 0.");
        }
    }
}