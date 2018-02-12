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


def correct_step(step):
    length_alphabet = len(rus_alphabet())
    if step >= length_alphabet:
        return step - length_alphabet
    else:
        return step

def encoder_cezare(text = "", key = 0):
    if type(key) != int:
        return "Key not validation"
    elif key == 0:
        return text
    elif key > 32 or key < -32:
        key = key % len(rus_alphabet())

    alphabet = rus_alphabet()
    result_encoding = []
    if is_rus_text(text):
        for element in text:
            if element in alphabet:
                step = correct_step(alphabet.index(element) + key)
                result_encoding.append(alphabet[step])
            else:
                result_encoding.append(element)

        return result_encoding

    return "Text not correct"


file_input = open("input.txt", "r", encoding = "UTF8")
text_input = ''.join(file_input.readlines())

key = 1
result = ''.join(encoder_cezare(text = text_input, key = key))

file_input.close()

print(result)