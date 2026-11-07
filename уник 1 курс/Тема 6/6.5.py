#задача 6.5
def vv_mass(name):
    #ф-ция для ввода массива с проверкой
    while True:
        try:
            s= input(name).split()
            return [int(x) for x in s]
        except EOFError:
            print("Ошибка. Введите последовательность целых чисел.")
        except ValueError:
            print("Ошибка. Введите последовательность целых чисел.")
def res(mass1,mass2):
    #ф-ция для формирования и вывода результата
    mass=mass1+mass2
    mass=sorted(mass)
    print(f"Упорядоченные по возрастанию и объединенные последовательности:[{', '.join(map(str,mass))}]")
mass1=vv_mass("Введите первую последовательность целых чисел: ")
mass2=vv_mass("Введите вторую последовательность целых чисел: ")
res(mass1,mass2)