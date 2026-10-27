#задача 6.5
def vv_mass(name):
    #ф-ция для ввода массива с проверкой
    while True:
        s=input(name).split()
        try:
            s1=[int(x) for x in s]
            return s1
        except:
            print("Ошибка.Введите последовательность целых чисел.")
def res(mass1,mass2):
    #ф-ция для формирования и вывода результата
    mass=mass1+mass2
    mass=sorted(mass)
    print(f"Упорядоченные по возрастанию и объединенные последовательности:{mass}")
mass1=vv_mass("Введите первую последовательность целых чисел: ")
mass2=vv_mass("Введите вторую последовательность целых чисел: ")
res(mass1,mass2)