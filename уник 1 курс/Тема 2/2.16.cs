using System;
//Задача 2.16
class Program
{
    static void Main(string[] args)
    {
      double a=vv_ch("Введите длину стороны многоугольника: ");
      int n=vc_ch("Введите количество сторон многоугольника: ");
      double s=plos(a,n);
      pr_res(n,a,s);
      Console.ReadKey();  
    }
    static public int vc_ch(string name)
    {
        // Ф-ция для ввода целого числа
        Console.Write($"{name}");
        int n=int.Parse(Console.ReadLine());
        return n;
    }
    static public double vv_ch(string name)
    {
       // Ф-ция для ввода вещественного числа
        Console.Write($"{name}");
        double n=double.Parse(Console.ReadLine());
        return n; 
    }
    static public double plos(double a, int n)
    {
        //Ф-ция для вычисления площади
        return (n*a*a)/(4*Math.Tan(Math.PI/n));
    }
    static public void pr_res(int n, double a, double s)
    {
        //Ф-ция для вывода результата
        Console.WriteLine($"Длина стороны многоугольника = {a}");
        Console.WriteLine($"Количество сторон правильного многоугольника = {n}");
        Console.WriteLine($"Площадь правильного многоугольника = {s}");
    }
}