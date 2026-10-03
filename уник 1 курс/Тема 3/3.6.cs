using System;
using System.Threading.Tasks.Dataflow;
//Задача 3.6
class Program
{
    static void Main(string[] args)
    {
       int n1=vv_ch("Введите первое число: ");
       int n2=vv_ch("Введите второе число: ");
       int n3=vv_ch("Введите третье число: ");
       Console.WriteLine($"Числа {n1},{n2},{n3}");
       if (progr(n1,n2,n3))
        {
           Console.WriteLine("ЯВЛЯЮТСЯ последовательными членами арифметической прогрессии"); 
        }
        else
        {
            Console.WriteLine("НЕ ЯВЛЯЮТСЯ последовательными членами арифметической прогрессии");
        }
    }
    static int vv_ch(string name)
    {
        //Ф-ция для ввода целого числа с проверкой 
        while (true)
        {
        Console.Write($"{name}");
        string n=Console.ReadLine();
        if (int.TryParse(n,out int nn))
            {
                return nn; 
            }  
        Console.WriteLine("Ошибка. Введите целое число.");
        }
    }
    static bool progr(int n1,int n2,int n3)
    {
      if (n1>n2) (n1,n2)=(n2,n1);
      if (n2>n3) (n2,n3)=(n3,n2);
      if (n1>n2) (n1,n2)=(n2,n1);
      bool res=(n2-n1)==(n3-n2);
      return res;
    }
}