using System;
//Задача 5.23
class Program
{
    static void Main(string[] args)
    {
        int n=vv_nch("Введите количество строк: ");
        int m=vv_nch("Введите количество столбцов: ");
        res(n,m);
    }
    static int vv_nch(string name)
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
    static void res(int n,int m)
    {
        
    }
}