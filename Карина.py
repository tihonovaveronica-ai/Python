delimiters = " .,!?;:-()[]{}\"'«»"

n = int(input())
lines = []
for i in range(n):
    lines.append(input())

for line in lines:
    words = []
    current_word = ""

    for ch in line:
        if ch not in delimiters:
            current_word += ch
        else:
            if current_word != "":
                words.append(current_word)
                current_word = ""

    if current_word != "":
        words.append(current_word)

    print("Исходная строка:", line)
    print("Количество слов:", len(words))
    print("Слова:", ", ".join(words))
    print("-" * 30)