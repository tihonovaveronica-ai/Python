#Задача 4.3
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
            print("Ошибка. Введите целое число  больше 0.")
def res(n):
    #ф-ция для вывода треугольника
    for i in range(1,n+1):
        s=''.join(str(t) for t in range(1,i+1))
        print(s+s[-2::-1])
    
n=vv_ch("Введите высоту треугольника: ")
res(n)