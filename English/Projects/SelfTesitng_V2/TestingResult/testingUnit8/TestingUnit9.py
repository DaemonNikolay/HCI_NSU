def yesOrNoTesting():
    from prettytable import PrettyTable
    import os

    contents = ParsingFoundFiles()
    separator = "~" * 5
    countAll = CountAll()

    pathToDetailedReport = "./Results/Unit9/"
    pathToSmallReports = "./SmallReport/"

    if os.path.exists(pathToDetailedReport):
        for the_file in os.listdir(pathToDetailedReport):
            file_path = os.path.join(pathToDetailedReport, the_file)
            try:
                if os.path.isfile(file_path):
                    os.unlink(file_path)
                    # elif os.path.isdir(file_path): shutil.rmtree(file_path)
            except Exception as e:
                print(e)

    tableSmallReport = PrettyTable()
    tableSmallReport.field_names = ["Студент", "Группа", "Оценка"]

    for element in contents:
        i = 0
        tempName = ""
        countTrue = 0
        nameFileReport = ""

        tableDetailedReport = PrettyTable()
        tableDetailedReport.field_names = ["Номер", "Итог", "Полученный ответ", "Ожидаемый ответ"]

        for instance in element:

            if i >= 0 and i <= 2:
                tempName += str(instance).split(": ")[1] + " "
                i += 1
                continue

            nameFileReport = pathToDetailedReport + tempName + "DetailedReport_Unit9.txt"
            actualAnswer = str(instance).split(". ")

            if (actualAnswer[0][0] == "1"):
                expectedAnswer = CorrectAnsersTaskOne().get(actualAnswer[0])
                yesOrNo = "+" if actualAnswer[1].find(expectedAnswer) != -1 else "-"
                if yesOrNo.find("+") != -1:
                    countTrue += 1

            elif (actualAnswer[0][0] == "2"):
                expectedAnswer = CorrectAnsersTaskTwo().get(actualAnswer[0])
                yesOrNo = ""
                for oneOf in list(expectedAnswer):
                    if actualAnswer[1].find(oneOf) != -1:
                        yesOrNo += "+"
                        countTrue += 1
                    else:
                        yesOrNo += "-"

            elif (actualAnswer[0][0] == "3"):
                expectedAnswer = CorrectAnsersTaskThree().get(actualAnswer[0])
                yesOrNo = "+" if actualAnswer[1] == expectedAnswer else "-"

                if yesOrNo.find("+") != -1:
                    countTrue += 1

            else:
                yesOrNo = -1
                expectedAnswer = -1

            tableDetailedReport.add_row([actualAnswer[0], yesOrNo, actualAnswer[1], expectedAnswer])
            tableDetailedReport.add_row([separator, separator, separator, separator])

        result = round(countTrue * 100 / countAll, 1)
        pointAndMark = str(result) + "% = " + str(GenerationMark(result))

        tableSmallReport.add_row([str(element[0]).split(": ")[1] + " " + str(element[1]).split(": ")[1],
                                  str(element[2]).split(": ")[1],
                                  pointAndMark])
        tableSmallReport.add_row([separator, separator, separator])

        if not os.path.exists(pathToDetailedReport):
            os.makedirs(pathToDetailedReport)
        file = open(nameFileReport, "w", encoding = "UTF8")
        file.write(tempName + "(" + pointAndMark + ")" + "\n\n")
        file.write(str(tableDetailedReport))
        file.close()

    if not os.path.exists(pathToSmallReports):
        os.makedirs(pathToSmallReports)
    file = open((pathToSmallReports + "Results_Unit9.txt"), "w", encoding = "UTF8")
    file.write(str(tableSmallReport))
    file.close()


def CountAll():
    countAll = 0

    for element in CorrectAnsersTaskOne():
        if isinstance(CorrectAnsersTaskOne().get(element), list):
            countAll += (len(CorrectAnsersTaskThree().get(element)))
        else:
            countAll += 1

    for element in CorrectAnsersTaskTwo():
        if isinstance(CorrectAnsersTaskTwo().get(element), list):
            countAll += (len(CorrectAnsersTaskTwo().get(element)))
        else:
            countAll += 1

    for element in CorrectAnsersTaskThree():
        if isinstance(CorrectAnsersTaskThree().get(element), list):
            countAll += (len(CorrectAnsersTaskThree().get(element)))
        else:
            countAll += 1

    return countAll


def CorrectAnsersTaskOne():  # 12
    return {"1.1.1": "rinte",
            "1.1.2": "eyboar",
            "1.1.3": "mbosse",
            "1.2.1": "agnifie",
            "1.2.2": "eade",
            "1.3.1": "rgonomi",
            "1.3.2": "xpande",
            "1.3.3": "scree",
            "1.4.1": "neumati",
            "1.4.2": "daptiv",
            "1.5.1": "oic",
            "1.5.2": "yegaz",
            }


def CorrectAnsersTaskTwo():  # 13
    return {"2.1": ["braille printer",
                    "braille keyboard",
                    "braille embosser",
                    "screen magnifier",
                    "screen reader",
                    "voice recognition system"],
            "2.2": ["ergonomic keyboard",
                    "expanded keyboard",
                    "screen keyboard",
                    "pneumatic switch",
                    "adaptive switch",
                    "eyegaze system",
                    "voice recognition system"]}


def CorrectAnsersTaskThree():  # 28
    return {"3.1": "Visual alerts",
            "3.2": "Textphones",
            "3.3": "Electronic notetakers"}


def SearchFiles():
    import os

    listFiles = []
    for root, dirs, files in os.walk(r"Answers"):
        for file in files:
            if file.endswith(".txt"):
                if file.find("unit_9") != -1:
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


def GenerationMark(mark):
    temp = float(mark)
    if (temp >= 90):
        return 5
    elif (temp >= 75):
        return 4
    elif (temp >= 51):
        return 3
    else:
        return 2


yesOrNoTesting()
