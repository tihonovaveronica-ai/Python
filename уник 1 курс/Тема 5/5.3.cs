using System;
//Задача 5.3
class Program
{
    static void Main()
    {
        int n=vv_len("Введите длину массива: ");
        float[] mass=vv_mass(n);
        res(mass,n);
    }
    static int vv_len(string name)
    {
        while (true)
        {
            //ф-ция для ввода целого числа с проверкой
            Console.Write(name);
            string n=Console.ReadLine();
            if (int.TryParse(n,out int nn) && nn>=3)
            {
                return nn;
            }
            Console.WriteLine("Ошибка. Введите целое число больше 2.");
        }
    }
    static float vv_vch(string name)
    {
        while (true)
        {
            //ф-ция для ввода вещественного числа с проверкой
            Console.Write(name);
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
       float[] mas=new float[n];
       for(int i=0;i<n;i++)
        {
            mas[i]=vv_vch("Введите значение элемента массива: ");
        }
        return mas;
    }
    static void res(float[] mass,int n)
    {
        //ф-ция для расчета и вывода результата
        int col=0;
        float summ=0f;
        for (int i=1;i<n-1;i++)
        {
            if (mass[i]<((mass[i-1]+mass[i+1])/2))
            {
                col+=1;
                summ+=mass[i];
            }
        }
        Console.WriteLine($"Массив: [{string.Join(", ", mass)}]");
        Console.WriteLine($"Найдено элементов: {col}, их сумма = {summ}");
    }
}