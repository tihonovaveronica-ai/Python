using System;

class Program
{
    static void Main()
    {
        string naz1;
        float v1;
        float a1;
        planet(out string naz1, out float v1, out float a1,"1")
    }
    static float fl_ch(string name)
    {
        //Ф-ция для ввода вещественного числа
        Console.Write($"{name}");
        float n=float.Parse(Console.ReadLine());
        return n;
    }
    static void planet(out string naz, out float v,out float a,string name,string[] args)
    {
       ///Ф-ция для ввода данных о планете
        Console.WriteLine($"Введите даные о планете номер {name}");
        Console.Write("Введите название планет: ");
        string naz=Console.ReadLine();
        float v=fl_ch("Введите начальную скорость: ")
        float a=fl_ch("Введите ускорение: ")
    }
}