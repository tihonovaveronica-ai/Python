#Задача 4.3
def vv_ch(name):
    while True:
        n=input(f"{name}")
        try:
            nn=int(n)
            return nn
        except:
            print("Ошибка. Введите целое число.")
def res(n):
    for i in range(1,n+1):
        s=''.join(str(t) for t in range(1,i+1))
        print(s+s[-2::-1])
    
n=vv_ch("Введите высоту треугольника: ")
res(n)