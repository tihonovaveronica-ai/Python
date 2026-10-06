using System;
using System.Runtime.CompilerServices;
//Задача 4.9
class Program
{
    static void Main(string[] args)
    {
        int n=vv_ch("Введите число: ");
        string it=res(n);
        Console.WriteLine($"{n} => {it}");
    }
    static int vv_ch(string name)
    {
        //ф-ция для ввода числа с проверкой
        while (true)
        {
            Console.Write($"{name}");
            string s=Console.ReadLine();
            if (int.TryParse(s,out int nn) && nn>0)
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите натуральное число.");
        }
    }
    static string res(int ch)
    {
        //ф-ция для вывода результата
        string itog="";
        while (ch>0)
        {
           string name=(ch%10) switch
            {
               0 => "Ноль ",
               1 => "Один ",
               2 =>  "Два ",
               3 =>  "Три ",
               4 =>  "Четыре ",
               5 =>  "Пять ",
               6 =>  "Шесть ",
               7 =>  "Семь ",
               8 =>  "Восемь ",
               9 =>  "Девять "
            };
            ch/=10;
            itog=name+itog;
        }
        return itog;
    }
}