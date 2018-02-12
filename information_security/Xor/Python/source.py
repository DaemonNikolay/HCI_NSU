def correct_len_key(value, length_key):
    value.__int__() + 1
    if value >= length_key.__int__():
        return 0
    return value


def is_binary(value):
    for element in value:
        try:
            element = int(element)
        except ValueError:
            return False
        if element != 0 and element != 1:
            return False

    return True


def correct_len_data(value, key):
    return len(value) >= len(key)


def encode_xor(value, key):
    if not is_binary(value) or not is_binary(key):
        return "Not validation input data!"
    elif not correct_len_data(value, key):
        return "Length key bigger value!"

    i = 0
    result = ""
    for element in value:
        result += str(int(element) ^ int(key[i]))
        i = correct_len_key(i, len(key))

    return result


key_file = open("key.txt", "r")
key = key_file.readline()
key_file.close()

value_input_file = open("value.txt", "r")
value_input = value_input_file.readline()
value_input_file.close()

result = encode_xor(value_input, key)

print(result)
