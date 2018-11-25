file = open("output.md", "r", encoding = "UTF8")

text = file.readlines()

file2 = open("output2.md", "w", encoding = "UTF8")

for element in text:
    file2.write(element)
    file2.write("\n")

file2.close()

file.close()
