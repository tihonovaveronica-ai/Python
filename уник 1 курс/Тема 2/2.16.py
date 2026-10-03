#Задача 2.16 
from math import pi
from math import tan
def vc_ch(name):
    #ф-ция для ввода целого числа
    n=int(input(f'{name}'))
    return n

def vv_ch(name):
    #ф-ция для ввода вещественного числа
    n=float(input(f'{name}'))
    return n

def plos(n,a):
    #ф-ция для вычисления площади
    s=(n*a**2)/(4*tan(pi/n))
    return s

def res(a,n,s):
    #ф-цтя для вывода результата
    print(f'Длинна стороны многоугольника={a}')
    print(f'Количество сторон правильного многоугольника={n}')
    print(f'Площадь правильного многоугольника={s}')

a=vv_ch('Введите длинну стороны многоугольника: ')
n=vc_ch('Введите количество сторон многоугольника: ')
s=plos(n,a)
res(a,n,s)