using System;
using System.Diagnostics.Contracts;
using System.Collections.Generic;
//задача 6.17
class Program
{
    static void Main()
    {
        List <int> n=vv_mass("Введите последовательность целых чисел: ");
        res(n);
    }
    static List<int> vv_mass(string name)
    {
        while (true)
        {
            //ф-ция для ввода массива с проверкой
            Console.Write(name);
            string s=Console.ReadLine();
            if (s == null)
            {
                Console.WriteLine("Ошибка. Введите последовательность целых чисел.");
                continue;
            }
            string[] s1=s.Split(' ');
            var chisla=new List<int>(s1.Length);
            bool proverka=true;
            foreach(string n in s1)
            {
                if(int.TryParse(n,out int nn))
                    chisla.Add(nn);
                else
                {
                    proverka=false;
                    break;
                }
            }
            if (proverka)
                return chisla;
            Console.WriteLine("Ошибка. Введите последовательность целых чисел.");
        }
    }
    static void res(List<int> n)
    {
        //ф-ция для формирования и вывода результата
        List<int> res=new List<int>(n.Count);
        res.Add(n[0]);
        for (int i=1; i<n.Count; i++)
            res.Add(res[i-1]+n[i]);
        Console.WriteLine($"Результативная последовательность: [{string.Join(", ",res)}]");
    }
}