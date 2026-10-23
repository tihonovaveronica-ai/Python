using System;
//using System.Data;
//using System.Reflection.Metadata;
//Задача 5.16
class Program
{
    static void Main(string[] args)
    {
        int ln=vv_len("Введите количество элементов массива: ");
        float[] mass=vv_mass(ln);
        float x=vv_vch("Введите контрольное число: ");
        res(mass,x);
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
    static float vv_vch(string name)
    {
        while (true)
        {
            //ф-ция для ввода целого числа с проверкой
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (float.TryParse(n,out float nn))
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите число.");
        }
    }
    static float[] vv_mass(int n)
    {
       //ф-ция для ввода элементов массива
       float[] mas=new float[n];
       for(int i=0;i<n;i++)
        {
            mas[i]=vv_vch($"Введите значение {i+1} элемента массива: ");
        }
        return mas;
    }
    static void res(float[] mass,float x)
    {
        //ф-ция для проверки и вывода результата
        Console.WriteLine($"Исходный массив: [{string.Join(", ",mass)}]");
        Console.WriteLine($"Контрольное число: {x}");
        bool istr=false;
        for(int i=0;i<mass.Length;i++)
        {
            for (int j=i+1;j<mass.Length;j++)
            {
                if(mass[i]*mass[j]==x)
                {
                    Console.WriteLine($"Из {i+1} и {j+1} элемента получает контрольное число.");
                    istr=true;
                    break;
                }
            }
        }
        
        if (!istr)
        {
            Console.WriteLine("Нет нужных значений в массиве!");
        }
    }
}