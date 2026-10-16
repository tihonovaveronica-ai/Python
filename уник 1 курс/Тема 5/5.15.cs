using System;
using System.Data;
//Задача 5.15
class Program
{
    static void Main(string[] args)
    {
        int ln=vv_len("Введите количество элементов массива: ");
        int ma=vv_ch("Введите максимальное значение элемента массива: ");
        int mш=vv_ch("Введите минимальное значение элемента массива: ");
        int[] mass=creat_mass(ln,ma,mi);
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
    static int[] creat_mass(int n, int ma,int mi)
    {
        Random rnd = new Random();
        int[] mass=[0]*n;
        for(int i=0; i<n;i++)
        {
            mass[i]=rnd.Next(mi, ma +1);
        }
        return mass;
    }
}