using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using Microsoft.VisualBasic;
class Program
{
    static char[] sep = { ' ', '.', ',', ';', ':', '!', '?', '-', '(', ')', '[', ']', '{', '}', '"', '\'' }; //возможные разделители
    static void Main()
    {
      int x=vv_ch("Введите номер слова: ");
      int y=vv_ch("Введите номер слова: ");
      int n=vv_ch("введите количество строк: ");
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
    static bool IsSep(char c) => Array.IndexOf(sep, c) >= 0;    //ф-ция для проверки: разделительный символ или нет
    static void res(int x,int y,int n)
    {
        //ф-ция для формирования и вывода результата
        string[] stroci=vv_str(n);
        foreach(string s in stroci)
        {
            Console.WriteLine($"Исходная строка: {s}");
            string result=s;
            if (!string.IsNullOrEmpty(s))
            {
                //обработка ненулевых строк
                var chasti=new List<string>();
                var ucazatel=new List<int>();
                for(int pos=0;pos<s.Length;)
                {
                    int start=pos;
                    bool IsSepS=IsSep(s[pos]);
                    while(pos<s.Length && IsSep(s[pos])==IsSepS)
                        pos++;
                    if(!IsSepS)
                        ucazatel.Add(chasti.Count);
                    chasti.Add(s.Substring(start,pos-start));
                }
                Console.WriteLine($"Количество слов: {ucazatel.Count}");
                if(x<=ucazatel.Count && y<=ucazatel.Count)
                {
                    //меняем слова x и y местами
                    (chasti[ucazatel[x-1]],chasti[ucazatel[y-1]])=(chasti[ucazatel[y-1]],chasti[ucazatel[x-1]]);
                    result=string.Concat(chasti);
                }
                Console.WriteLine($"Результирующая строка: {result}");
            }
            else
            {
                //обработка нулевых/пустых строк
                Console.WriteLine("Количество слов в этой строке: 0");
                Console.WriteLine($"Результирующая строка: {result}");
            }
        }
    }
}