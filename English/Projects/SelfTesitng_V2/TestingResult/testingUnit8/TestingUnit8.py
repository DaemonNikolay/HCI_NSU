def ResultTesting():
    from prettytable import PrettyTable

    contents = ParsingFoundFiles()

    for element in contents:
        i = 0
        tempName = ""

        tableResult = PrettyTable()
        tableResult.field_names = ["№", "Итог", "Полученный ответ", "Ожидаемый ответ"]

        for instance in element:
            if i >= 0 and i <= 2:
                tempName += instance[i] + " "
                i += 1
                continue
            nameFileReport = tempName + "DetailedReport_Unit8.txt"

            actualAnswer = str(instance).split(". ")

            if (actualAnswer[0][0] == "1"):
                expectedAnswer = CorrectAnsersTaskOne().get(actualAnswer[0])
                result = "+" if actualAnswer[1] == expectedAnswer else "-"

            elif (actualAnswer[0][0] == "2"):
                expectedAnswer = CorrectAnsersTaskTwo().get(actualAnswer[0])
                result = "+" if actualAnswer[1] == expectedAnswer else "-"

            elif (actualAnswer[0][0] == "3"):
                expectedAnswer = CorrectAnsersTaskThree().get(actualAnswer[0])
                result = ""
                for oneOf in expectedAnswer:
                    if actualAnswer[1].find(oneOf) != -1:
                        result += "+"
                    else:
                        result += "-"

            elif (actualAnswer[0][0] == "4"):
                expectedAnswer = CorrectAnsersTaskFour().get(actualAnswer[0])
                result = "+" if actualAnswer[1] == expectedAnswer else "-"

            else:
                result = -1
                expectedAnswer = -1

            tableResult.add_row([actualAnswer[0], result, actualAnswer[1], expectedAnswer])


            # file = open(nameFileReport, "w", encoding = "UTF8")
            # file.close()
        print(tableResult)


def CorrectAnsersTaskOne():
    return {"1.1": "laser",
            "1.2": "plotter",
            "1.3": "thermal transfer",
            "1.4": "inkjet",
            "1.5": "imagesetter",
            "1.6": "dot-matrix",
            "1.7": "platesetter"}


def CorrectAnsersTaskTwo():
    return {"2.1": "more expensive",
            "2.2": "better",
            "2.3": "smaller",
            "2.4": "noisier",
            "2.5": "less convenient"}


def CorrectAnsersTaskThree():
    return {"3.1": ["such as", "for instance"],
            "3.2": ["to begin with", "then", "finally"],
            "3.3": ["since", "because"]}


def CorrectAnsersTaskFour():
    return {"": ""}


def SearchFiles():
    import os

    listFiles = []
    for root, dirs, files in os.walk(r"Answers"):
        for file in files:
            if file.endswith(".txt"):
                if file.find("unit_8") != -1:
                    listFiles.append(os.path.join(root, file))

    return listFiles


def ParsingFoundFiles():
    contents = []
    listFiles = SearchFiles()

    for element in listFiles:
        file = open(element, "r")
        tempContents = []

        for instance in file.readlines():
            tempContents.append(instance.replace("\n", ""))

        contents.append(tempContents)
        file.close()

    return contents


ResultTesting()
