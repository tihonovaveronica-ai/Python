#Задача 3.3
def vc_ch(name):
    #ф-ция для ввода целого числа с проверкой
    while True:
        n=input(f'{name}')
        try:
            nn=int(n)
            return nn
        except:
            print("Ошибка. Введите целое число")
def pop_v_gr(n,a1,a2):
    #ф-ция проверки попадания числа в промежуток
    return (a1<=n<=a2)
def vv_gr():
    #ф-ция для ввода границ
    a1=vc_ch("Введите начало диапазона: ")
    while True:
        a2=vc_ch("Введите конец диапазона: ")
        if a2>a1: return[a1,a2]
        else: print("Ошибка. Конец диапазона должен быть больше начала")
def res(n1,n2,n3,a1,a2,nn):
    print(f'Из чисел {n1},{n2},{n3}')
    print(f'В диапазон [{a1},{a2}]')
    print(f'Попадают следующие числа:{nn}')

n1=vc_ch("Введите первое число: ")
n2=vc_ch("Введите второе число: ")
n3=vc_ch("Введите третье число: ")
a1,a2=vv_gr()
nn=[n for n in (n1,n2,n3) if pop_v_gr(n,a1,a2)]
nn=', '.join(map(str,nn))
res(n1,n2,n3,a1,a2,nn)