def vv_ch(name):
    #ф-ция для ввода числа с проверкой
    while True:
        n=input(name)
        try:
            nn=int(n)
            if nn>0:
                return nn
        except ValueError:
                print("Ошибка. Введите целое число больше 0.")

def vv_str(n):
    #ф-ция для ввода строк
    stroki=[]
    for i in range(n):
        stroki+=input(f"Введите {i+1} строку: ")
    return stroki

def res(n):
    #ф-ция для формирования и вывода результата 
    stroki=vv_str(n)
    print("Исходные строки: ")
    for i in len(stroki):
        print(f"{i+1} строка: {stroki[i]}")
    strunic=set(stroki)
    print("Уникальные строки: ")
    for i in strunic:
         print(f"{stroki.index(i)+1} строка: {i}")
         
n=vv_ch("Введите количество строк: ")
res(n)