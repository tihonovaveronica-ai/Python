#Задача 4.18
def vv_ch(name):
    #ф-ция для ввода числа с проверкой
    while True:
        n=input(f"{name}")
        try:
            nn=int(n)
            if nn>0:
                return nn
            else:
                print("Ошибка. Введите целое число  больше 0.")
        except:
            print("Ошибка. Введите целое число больше 0.")
def pascal(n):
    #ф-ция для вывода треугольника
    for i in range(n):
        x=1
        print(x,end='')
        for j in range(1,i+1):
            x=x*(i-j+1)//j
            print(x,end='')
        print()
n=vv_ch("Введите число: ")
pascal(n)