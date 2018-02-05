original_alphabet = ['а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
                     'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я']
modified_alphabet = ['и', 'ы', 'р', 'щ', 'у', 'ё', 'ч', 'ь', 'й', 'ш', 'ю', 'о', 'ф', 'з', 'к', 'в', 'а', 'л', 'э', 'я',
                     'б', 'н', 'г', 'ъ', 'х', 'ц', 'ж', 'п', 'м', 'е', 'д', 'с', 'т']

file_input = open("input.txt", "r", encoding = "utf8")
line = file_input.readline()

input_symbols = []
file_output = open("output.txt", "w", encoding = "utf8")
while line:
    for symbol in line:
        if symbol.lower() in original_alphabet:
            input_symbols.append(modified_alphabet[original_alphabet.index(symbol.lower())])
        else:
            input_symbols.append(symbol)
    line = file_input.readline()

file_output.write(''.join(input_symbols))
file_input.close()
file_output.close()