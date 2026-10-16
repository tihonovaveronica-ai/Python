using System;
using Microsoft.Win32.SafeHandles;
//Задача 5.10
class Program
{
    static void Main(string[] args)
    {
        int ln1=vv_len("Введите количество элементов исходного массива: ");
        int[] mass1=vv_mass(ln1,"исходного");
        int ln2=vv_len("Введите количество элементов массива разрешенных значений: ");
        int[] mass2=vv_mass(ln2,"разрешенного");
        res(mass1,mass2);
    }
    static int vv_ch(string name)
    {
        while (true)
        {
            //ф-ция для ввода целого числа с проверкой
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (int.TryParse(n,out int nn))
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите целое число.");
        }
    }
    static int vv_len(string name)
    {
        while (true)
        {
            //ф-ция для ввода целого натурального числа с проверкой
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (int.TryParse(n,out int nn) && nn>0)
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите целое число больше 0.");
        }
    }
    static int[] vv_mass(int n,string num)
    {
       //ф-ция для ввода элементов массива
       int[] mas=[];
       for(int i=0;i<n;i++)
        {
            mas[i]=vv_ch($"Введите значение {i+1} элемента {num} массива: ");
        }
    }
    static void res(int[] mass1,int[] mass2)
    {
        
    }
}