using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
//задача 6.11
class Program
{
    const string alphabet="абвгдежзийклмнопрстуфхцчшщъыьэюя";
    static void Main()
    {
        string key=vv_key("Введите ключ: ");
        string direction=vv_dir("Введите направление шифрования: ");
        Console.Write("Введите текст на русском языке(без «ё»): ");
        string text = Console.ReadLine();
        res(key,text,direction);
    }
    static string vv_key(string name)
    {
        //ф-ция для ввода ключа с проверкой
        while (true)
        {
            Console.Write(name);
            string s=Console.ReadLine();
            if (s == null)
            {
                Console.WriteLine("Ошибка: ключ должен состоять из русских букв (без «ё»).");
                continue;
            }
            bool proverka=true;
            foreach(char c in s)
            {
                if(alphabet.IndexOf(char.ToLower(c))<0)
                {
                    proverka=false;
                    break;
                }
            }
            if (proverka)
                return s;
            Console.WriteLine("Ошибка: ключ должен состоять из русских букв (без «ё»).");
        }
    }
    static string vv_dir(string name)
    {
        //ф-ция для ввода направления с проверкой
        while(true)
        {
            Console.Write(name);
            string s=Console.ReadLine();
            if (s == "CRYP" || s == "DECR") 
                return s;
            Console.WriteLine("Ошибка: введите CRYP или DECR.");
        }
    }
    static void res(string key,string text,string direction)
    {
        //ф-ция для формирования и вывода результата
        var res=new List<char>();
        string alph2="абвгдежзийклмнопрстуфхцчшщъыьэюяабвгдежзийклмнопрстуфхцчшщъыьэюя";
        int ind=0;
        foreach(char c in text)
        {
            char lower=char.ToLower(c);
            if(alphabet.IndexOf(lower)<0)
            {
                res.Add(c);
                continue;
            }
            int sdvig=ind%key.Length;
            char newchar;
            if(direction=="CRYP")
                newchar=alph2[alphabet.IndexOf(lower)+alphabet.IndexOf(key[sdvig])];
            else
                newchar=alph2[alphabet.IndexOf(lower)+32-alphabet.IndexOf(key[sdvig])];

            if (char.IsUpper(c))
                newchar = char.ToUpper(newchar);
            res.Add(newchar);
            ind++;
        }
        Console.WriteLine(new string(res.ToArray()));
    }
}