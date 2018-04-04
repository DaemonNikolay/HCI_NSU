file = open("delete.md", "r", encoding = "UTF8")
temp = file.readlines()
file.close()

result = ""
for element in temp:
    repl = element.replace("\n", "")
    if repl.find("{X}") != -1:
        result += repl.replace("{X}", "\n\n")
    else:
        result += repl

file = open("output.md", "w", encoding = "UTF8")
file.write(result)
file.close()
print(temp)
