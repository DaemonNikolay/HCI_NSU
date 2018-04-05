class SelfTest:
    def AutoTest(self, number):
        import os

        number = str(number)
        listFiles = []

        for root, dirs, files in os.walk(r"Answers"):
            for file in files:
                if file.endswith(".txt"):
                    if file.find(number) != -1:
                        listFiles.append(os.path.join(root, file))

        answersFile = open(r"Teacher\answerTest" + number + ".txt", "r", encoding = "UTF8")

        answers = []
        for element in answersFile.readlines():
            temp = element.replace("\n", "").lower().replace(" ", "").replace(";", "")
            if len(temp) > 0:
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
                # if (str(instance).find("№") != -1):
                #     print("\t" + answers[j] + "\t" + instance)
                # else:
                #     print(answers[j] + "\t" + instance + "\t|\t" + str(answers[j] == instance))
                # print(instance)
                try:
                    if (answers[j] == instance and str(instance).find("№") == -1):
                        student["CountTrueAnswer"] += 1
                        # print(answers[j] + "\t" + instance)
                except:
                    pass

                j += 1
            # print("\n---\n")
            student["CountTrueAnswer"] = str((student["CountTrueAnswer"] / 25) * 100) + "%"
            trueAnswer.append(student)


        return trueAnswer
