import SelfTest
from prettytable import PrettyTable


def GenerationMark(markToProcent):
    temp = float(markToProcent.replace("%", ""))
    if (temp > 95):
        return 5
    elif (temp > 71):
        return 4
    elif (temp > 51):
        return 3
    else:
        return 2


def Separator():
    return "\n" + "-" * 10 + "\n"


def PrintResult(numberTest, flag):
    tableResult = PrettyTable()
    tableResult.field_names = ["Студент", "Результат", "Оценка"]

    instance = SelfTest.SelfTest().AutoTest(numberTest, flag)

    nameTest = "Номер теста № " + str(numberTest)
    print(nameTest)
    file = open(nameTest + ".txt", "w", encoding = "UTF8")
    file.write(nameTest + "\n\n")

    for element in instance:
        temp = GenerationMark(element["CountTrueAnswer"])
        tableResult.add_row([element["name"], element["CountTrueAnswer"], temp])
        separator = "-" * 7
        tableResult.add_row([separator, separator, separator])

    tableResult = str(tableResult)
    file.write(tableResult)
    file.close()
    print(tableResult)


tableResult = PrettyTable()
tableResult.field_names = ["Студент", "Результат", "Оценка"]

file = open("Result_SelfTesting_V1.txt", "w", encoding = "UTF8")

for i in range(5, 8):
    PrintResult(i, False)

file.close()
