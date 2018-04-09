class SelfTest:
    def AutoTest(self, number, flag):
        import os

        number = str(number)
        listFiles = []

        for root, dirs, files in os.walk(r"Answers"):
            for file in files:
                if file.endswith(".txt"):
                    if file.find(number) != -1:
                        listFiles.append(os.path.join(root, file))

        answersFile = open(r"Teacher\answerTest" + number + ".txt", "r", encoding = "UTF8")

        countItems = 0
        answers = []
        for element in answersFile.readlines():
            temp = element.replace("\n", "").lower().replace(" ", "").replace(";", "")
            if len(temp) > 0:
                if (temp[0:2][1] == "."):
                    countItems += 1
                answers.append(temp)

        answersFile.close()

        result = []
        for element in listFiles:
            file = open(element, "r")
            result.append(file.readlines())
            file.close()

        validation = []
        for element in result:
            temp = []
            for instance in element:
                cleaningSpecSymbols = str(instance)\
                    .replace("\n", "")\
                    .lower()\
                    .replace(" ", "")\
                    .replace("\t", "").replace(";", "")\
                    .replace("№.", "")

                if len(cleaningSpecSymbols) > 0:
                    temp.append(cleaningSpecSymbols)
            validation.append(temp)

        trueAnswer = []
        # for i in range(0, len(answers) - 1):
        for element in validation:
            j = 0
            student = {"name": element[0], "CountTrueAnswer": 0}
            for instance in element:
                if (flag):
                    if (str(instance).find("№") != -1):
                        print("\t" + answers[j] + "\t" + instance)
                        Separator()

                    else:
                        print(answers[j] + "\t" + instance + "\t|\t" + str(answers[j] == instance))
                        Separator()

                try:
                    if (answers[j] == instance and str(instance).find("№") == -1):
                        student["CountTrueAnswer"] += 1
                        # print(answers[j] + "\t" + instance)
                except:
                    pass

                j += 1

            temp = round((student["CountTrueAnswer"] / countItems * 100), 2)

            student["CountTrueAnswer"] = str(temp) + "%"
            trueAnswer.append(student)

        return trueAnswer


def Separator():
    print("\n*****\n")