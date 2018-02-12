def rus_alphabet():
    return ["а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
            "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я"]


def spec_symbols():
    return ["!", ".", ",", "\\", "|", "/", " ", "\t", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "\n"]


def is_rus_text(text):
    rus_symbols = rus_alphabet()
    other_symbols = spec_symbols()
    for element in text:
        if element not in rus_symbols and element not in other_symbols:
            return False

    return True


def encoder_cezare(text = "", key = 0):
    if type(key) != int:
        return "Key not validation"
    if key == 0:
        return text

    alphabet = rus_alphabet()
    result_encoding = []
    if is_rus_text(text):
        for element in text:
            try:
                result_encoding.append(alphabet[alphabet.index(element) + key])
            except ValueError:
                result_encoding.append(element)
            except IndexError:
                result_encoding.append(alphabet[alphabet.index(element) + (key % len(alphabet))])

        return result_encoding

    return "Text not correct"


file_input = open("input.txt", "r", encoding = "UTF8")
text_input = ''.join(file_input.readlines())

result = encoder_cezare(text = text_input, key = -543)
print(''.join(result))

file_input.close()