using System;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
//задача 6.13
class Program
{
    static void Main()
    {
      int n=vv_ch("Введите число: ");
      res(n);
    }
    static int vv_ch(string name)
    {
        while (true)
        {
            //ф-ция для ввода целого натурального числа с проверкой
            Console.Write(name);
            string s=Console.ReadLine();
            if(int.TryParse(s,out int nn) && nn>0)
                return nn;
            Console.WriteLine("Ошибка. Введите целое число больше 0.");
        }
    }
    static void res(int n)
    {
       //ф-ция для формирования и вывода результата
       var chisla=new Dictionary<char, string>
       {
            ['0'] = "Ноль",
            ['1'] = "Один",
            ['2'] = "Два",
            ['3'] = "Три",
            ['4'] = "Четыре",
            ['5'] = "Пять",
            ['6'] = "Шесть",
            ['7'] = "Семь",
            ['8'] = "Восемь",
            ['9'] = "Девять"
       } ;
       string nn=n.ToString();
       var res=new  List<string>();
       foreach(char c in nn)
            res.Add(chisla[c]);
        Console.WriteLine(string.Join(" ",res));
    }
}