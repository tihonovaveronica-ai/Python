using System;
using System.Runtime.Serialization.Formatters;
//Задача 5.3
class Program
{
    static void Main(string[] args)
    {
        int n=vv_ch("Введите длину массива: ");
        float[] mass=vv_mass(n);
        res(mass,n);
    }
    static int vv_ch(string name)
    {
        while (true)
        {
            //ф-ция для ввода целого числа с проверкой
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (int.TryParse(n,out int nn) && nn>0)
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите целое число больше 0.");
        }
    }
    static float vv_vch(string name)
    {
        while (true)
        {
            //ф-ция для ввода вещественного числа с проверкой
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (float.TryParse(n,out float nn))
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите вещественное число.");
        }
    }
    static float[] vv_mass(int n)
    {
       //ф-ция для ввода элементов массива
       float[] mas=[];
       for(int i=0;i<n;i++)
        {
            mas[i]=vv_vch("Введите значение элемента массива: ");
        }
    }
    static void res(float[] mass,int n)
    {
        //ф-ция для расчета и вывода результата
        int col=0;
        float summ=0.0;
        for (int i=0;i<=n;i++)
        {
            
        }
    }
}