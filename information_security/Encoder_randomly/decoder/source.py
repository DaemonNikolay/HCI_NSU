def stylingSymbolStepOne(symbol):
    return "\x1b[31m" + str(symbol) + "\x1b[0m"


def stylingSymbolStepTwo(symbol):
    return "\x1b[34m" + str(symbol) + "\x1b[0m"


def stylingSymbolStepThree(symbol):
    return "\x1b[32m" + str(symbol) + "\x1b[0m"


file_input = open("text.txt", "r", encoding = "UTF8")
line = file_input.readline()

code = {"з": stylingSymbolStepOne("п"),  # шаг 1
        "в": stylingSymbolStepOne("е"),
        "б": stylingSymbolStepOne("р"),
        "с": stylingSymbolStepOne("в"),
        "д": stylingSymbolStepOne("о"),
        "а": stylingSymbolStepOne("с"),
        "ю": stylingSymbolStepOne("и"),
        "р": stylingSymbolStepOne("т"),
        "у": stylingSymbolStepOne("ы"),
        "и": stylingSymbolStepOne("а"),
        "п": stylingSymbolStepOne("ь"),
        "л": stylingSymbolStepTwo("к"),  # шаг 2
        "ё": stylingSymbolStepTwo("л"),
        "ч": stylingSymbolStepTwo("х"),
        "ж": stylingSymbolStepTwo("ш"),
        "ц": stylingSymbolStepTwo("ю"),
        "г": stylingSymbolStepTwo("я"),
        "щ": stylingSymbolStepTwo("д"),
        "к": stylingSymbolStepTwo("м"),
        "о": stylingSymbolStepTwo("ч"),
        "м": stylingSymbolStepTwo("н"),
        "е": stylingSymbolStepTwo("у"),
        "ш": stylingSymbolStepThree("ж"),  # шаг 3
        "й": stylingSymbolStepThree("й"),
        "ф": stylingSymbolStepThree("г"),
        "ъ": stylingSymbolStepThree("з"),
        "я": stylingSymbolStepThree("б"),
        "х": stylingSymbolStepThree("э"),
        }

encodeText = []
print()
while line:
    for element in line:
        if element in code:
            # print("\x1b[31m" + code[element] + "\x1b[0m", end = "")
            # print(code[element], end = "")
            encodeText += code[element]
        elif (element == ','):
            encodeText += element + "\n"
        else:
            encodeText += element
            # print(element, end = "")
    line = file_input.readline()
print()
file_input.close()

result = "".join(encodeText).split(" ")
for element in result:
    print(element, end = " ")
print()

# перевоспитывать
# звбвсдазюрусирп
