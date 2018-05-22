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
            if(len(tempContents) == 7):
                tempContents[6] = "1.4." + tempContents[6][3:]

        contents.append(tempContents)
        file.close()

    return contents


result = ParsingFoundFiles()

print(result)