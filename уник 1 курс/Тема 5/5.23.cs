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
                return nn;
            Console.WriteLine("Ошибка. Введите целое число больше 0.");
        }
    }
    static void res(int n,int m)
    {
        int[,] mass=new int[n,m];
        int top=0,bottom=n-1,left=0,right=m-1,num=1;
        while (top<=bottom && left<=right)
        {
            //Заполнение массива "спиралью"
            for (int j=left; j<=right; j++)
                mass[top,j]=num++;
            top++;
            for (int i=top; i<=bottom; i++)
                mass[i,right]=num++;
            right--;
            if (top<=bottom)
            {
                for (int j=right; j>=left; j--)
                    mass[bottom,j]=num++;
                bottom--;
            }
            if (left<=right)
            {
                for (int i=bottom; i>=top; i--)
                    mass[i,left]=num++;
                left++;
            }
        }
        for (int i=0;i<n;i++)
        {
            for (int j=0; j<m; j++)
                {
                    if (j>0) Console.Write(", ");
                        Console.Write(mass[i,j]);
                }
            Console.WriteLine();
        }
    }
}