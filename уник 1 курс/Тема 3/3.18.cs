using System;
//Задача 3.18
class Program
{
    static void Main(string[] args)
    {
        int cor11;
        int cor12;
        vv_cor("первой",out cor11, out cor12);
        int cor21;
        int cor22;
        vv_cor("второй",out cor21,out cor22);
        res(cor11,cor12,cor21,cor22);
    }
    static int vv_ch(string name)
    {
        //Ф-ция для ввода целого числа с проверкой 
        while (true)
        {
            Console.Write($"{name}");
            string n=Console.ReadLine();
            if (int.TryParse(n,out int nn) && nn>=1 && nn<=8)
                {
                    return nn; 
                }  
            Console.WriteLine("Ошибка. Введите целое число в промежутке от 1 до 8.");
        }
    }
    static void vv_cor(string names, out int cor1,out int cor2)
    {
        //Ф-ция для ввода координат клеток
        cor1=vv_ch($"Введите номер строки {names} клетки: ");
        cor2=vv_ch($"Введите номер столбца {names} клетки: ");
    }
    static void res(int cor11,int cor12,int cor21,int cor22)
    {
        if ((cor11+cor12)%2==(cor21+cor22)%2) 
        {
            Console.WriteLine("Клетки одного цвета");
        }
        
        else 
        {
            Console.WriteLine("Клетки разного цвета");
        }
    }
}