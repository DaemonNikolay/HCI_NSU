file_input = open("text.txt", "r", encoding = "UTF8")
line = file_input.readline()

code = {"з": "п",  # шаг 1
        "в": "е",
        "б": "р",
        "с": "в",
        "д": "о",
        "а": "с",
        "ю": "и",
        "р": "т",
        "у": "ы",
        "и": "а",
        "п": "ь",
        "л": "к",  # шаг 2
        "ё": "л",
        "ч": "х",
        "ж": "ш",
        "ц": "ю",
        "г": "я",
        "щ": "д",
        "к": "м",
        "о": "ч",
        "м": "н",
        "е": "у",
        "ш": "ж",  # шаг 3
        "й": "й",
        "ф": "г",
        "ъ": "з",
        "я": "б",
        "х": "э",
        }
print()
while line:
    for element in line:
        if element in code:
            print("\x1b[31m" + code[element] + "\x1b[0m", end = "")
        else:
            print(element, end = "")
    line = file_input.readline()
print()
file_input.close()


# перевоспитывать
# звбвсдазюрусирп
