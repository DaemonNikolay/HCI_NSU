def yesOrNoTesting():
    from prettytable import PrettyTable
    import os

    contents = ParsingFoundFiles()
    separator = "~" * 5
    countAll = CountAll()

    pathToDetailedReport = "./Results/Unit10/"
    pathToSmallReports = "./SmallReport/"

    if os.path.exists(pathToDetailedReport):
        for the_file in os.listdir(pathToDetailedReport):
            file_path = os.path.join(pathToDetailedReport, the_file)
            try:
                if os.path.isfile(file_path):
                    os.unlink(file_path)
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

            nameFileReport = pathToDetailedReport + tempName + "DetailedReport_Unit10.txt"
            actualAnswer = str(instance).split(". ")

            if (len(actualAnswer) == 1):
                print(actualAnswer)
                break

            # print(tempName)
            if (actualAnswer[0][0] == "1"):
                expectedAnswer = CorrectAnsersTaskOne().get(actualAnswer[0])
                yesOrNo = "+" if actualAnswer[1] == expectedAnswer else "-"
                if yesOrNo.find("+") != -1:
                    countTrue += 1

            elif (actualAnswer[0][0] == "2"):
                expectedAnswer = CorrectAnsersTaskTwo().get(actualAnswer[0])
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

    print(pathToSmallReports + "Results_Unit10.txt")
    file = open((pathToSmallReports + "Results_Unit10.txt"), "w", encoding = "UTF8")
    file.write(str(tableSmallReport))
    file.close()


def CountAll():
    countAll = 0

    for element in CorrectAnsersTaskOne():
        if isinstance(CorrectAnsersTaskOne().get(element), list):
            countAll += (len(CorrectAnsersTaskOne().get(element)))
        else:
            countAll += 1

    for element in CorrectAnsersTaskTwo():
        if isinstance(CorrectAnsersTaskTwo().get(element), list):
            countAll += (len(CorrectAnsersTaskTwo().get(element)))
        else:
            countAll += 1

    return countAll


def CorrectAnsersTaskOne():
    return {"1.1": "hard",
            "1.2": "external",
            "1.3": "capacity",
            "1.4": "storage",
            "1.5": "holds",
            "1.6": "back up",
            "1.7": "portable",
            "1.8": "formatted",
            "1.9": "platters",
            "1.10": "don't",
            "1.11": "head crash",
            "1.12": "read/write",
            "1.13": "shouldn't",
            "1.14": "should"}


def CorrectAnsersTaskTwo():
    return {"2.1": "seek time",
            "2.2": "Access time",
            "2.3": "Transfer rate",
            "2.4": "tracks; sectors",
            "2.4 second": "tracks; sectors",
            "2.5": "directory",
            "2.6": "partition"}


def SearchFiles():
    import os

    listFiles = []
    for root, dirs, files in os.walk(r"Answers"):
        for file in files:
            if file.endswith(".txt"):
                if file.find("unit_10") != -1:
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
            if (len(tempContents) == 7):
                tempContents[6] = "1.4." + tempContents[6][3:]

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
