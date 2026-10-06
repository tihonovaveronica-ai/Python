#Задача 4.18
def vv_ch(name):
    #ф-ция для ввода числа с проверкой
    n=input(f"{name}")
    while True:
        try:
            nn=int(n)
            if nn>0:
                return nn
            else:
                print("Ошибка. Введите целое число  больше 0.")
        except:
            print("Ошибка. Введите целое число больше 0.")
def 
