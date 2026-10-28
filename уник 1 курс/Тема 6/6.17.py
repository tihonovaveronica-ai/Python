#задача 6.17
def vv_mass(name):
    #ф-ция для ввода массива с проверкой
    while True:
        s=input(name).split()
        try:
            s1=[int(x) for x in s]
            return s1
        except:
            print("Ошибка.Введите последовательность целых чисел.")
def res(n):
    #ф-ция для формирования и вывода результата
    res=[n[0]]*len(n)
    for i in range(1,len(n)):
        res[i]=res[i-1]+n[i]
    print(f"Результативная последовательность: {', '.join(map(str,res))}")
n=vv_mass("Введите последовательность целых чисел: ")
res(n)