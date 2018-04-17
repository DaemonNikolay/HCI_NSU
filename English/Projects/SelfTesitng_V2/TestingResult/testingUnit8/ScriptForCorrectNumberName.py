import os

listFiles = []
for root, dirs, files in os.walk(r"./Answers/"):
    for file in files:
        if file.endswith(".txt"):
            if file.find("unit_8") != -1:
                listFiles.append(os.path.join(root, file))

contents = []
for element in listFiles:
    file = open(element, "r")
    tempContents = []

    print(element)
    for instance in file.readlines():
        tempContents.append(instance.replace("\n", ""))

    contents.append(tempContents)
    file.close()

flag = False

newContents = []
tempDataFromFile = []

for element in contents:
    i = 2
    for instance in element:
        if flag:
            temp = "3." + str(i) + "."
            instance = temp + instance[4:len(instance)]
            i += 1
            if (i == 4):
                flag = False
        elif instance[0:4] == "3.1.":
            # print(instance)
            flag = True

        tempDataFromFile.append(instance)

    newContents.append(tempDataFromFile.copy())
    tempDataFromFile.clear()

j = 0
for element in listFiles:
    file = open(element, "w", encoding = "UTF8")

    for i in range(0, len(newContents[j])):
        file.write(newContents[j][i] + "\n")

    j += 1
    file.close()
