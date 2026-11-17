using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
class Program
{
    static void Main()
    {
      int x=vv_ch("Введите номер слова: ");
      int y=vv_ch("Введите номер слова: ");
      int n=vv_ch("введите количесвто строк: ");
      res(x,y,n);
    }
    static int vv_ch(string name)
    {
        //ф-ция для ввода числа с проверкой
        while (true)
        {
            Console.Write(name);
            string s=Console.ReadLine();
            if(int.TryParse(s,out int nn) && nn>0)
                return nn;
            Console.WriteLine("Ошибка. Введите целое число больше 0.");
        }
    }
    static string[] vv_str(int n)
    {
        //ф-ция для ввода строк
        string[] stroci=new string[n];
        for (int i=0; i<n; i++)
        {
            Console.Write($"Введите {i+1} строку: ");
            stroci[i]=Console.ReadLine();
        }
        return stroci;
    }
    static void res(int x,int y,int n)
    {
        string[] stroci=vv_str(n);
        char[] sep = { ' ', '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };
        foreach(string s in stroci)
        {
            Console.WriteLine(s);
            string[] words=s.Split(sep,StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(words.Count);
            if(x>words.Count || y>words.Count)
                Console.WriteLine(s);
            if (string.IsNullOrEmpty(s)) 
                return s;
            
        }
    }
}