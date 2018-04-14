import os

postfixName = "unit_8"
listFiles = []

for root, dirs, files in os.walk(r"Answers"):
    for file in files:
        if file.endswith(".txt"):
            if file.find(postfixName) != -1:
                listFiles.append(os.path.join(root, file))

i = 0
for element in listFiles:
    print(str(i) + "\t" + element)
    i += 1


