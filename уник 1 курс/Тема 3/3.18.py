#Задача 3.18
def vc_ch(name):
    #ф-ция для ввода целого числа с проверкой
    while True:
        n=input(f'{name}')
        try:
            nn=int(n)
            if 1<=nn<=8:
                return nn
            else:
                print("Ошибка. Число должно быть в промежутке от 1 до 8")
        except:
            print("Ошибка. Введите целое число")
def vv_cor(name):
    cor1=vc_ch(f"Введите номер строки {name} клетки: ")
    cor2=vc_ch(f"Введите номер столбца {name} клетки: ")
    return [cor1,cor2]
def res(cor11,cor21,cor12,cor22):
    if (cor11+cor21)%2==(cor12+cor22)%2:
        print("Клетки одного цвета")
    else:
        print("Клетки разного цвета")

cor11,cor21=vv_cor("первой")
cor12,cor22=vv_cor("второй")
res(cor11,cor21,cor12,cor22)