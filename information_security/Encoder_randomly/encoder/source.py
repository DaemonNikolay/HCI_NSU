import random
import os

#исходный "правильный" алфавит
original_alphabet = ['а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я']
modified_alphabet = original_alphabet.copy()  #копируем исходный алфавит в новую переменную
random.shuffle(modified_alphabet)  #перемешиванием случайным образом скопированный алфавит


file_input = open("input.txt", "r", encoding = "utf8")  #открываем файл на чтение указав кодировку
line = file_input.readline()  #считываем первую строку из файла
input_symbols = []  #сюда будем записывать шифрованные буквы текста

while line:  #пока есть строки продолжаем считывать
    for symbol in line:  #разбиваем полученную строку на буквы
        if symbol.lower() in original_alphabet:  #преобразуем к нижнему регистру и проверяем есть ли данная буква в "правильном" алфавите
            input_symbols.append(modified_alphabet[original_alphabet.index(symbol.lower())])  #если есть, то заменяем на букву, находящуюся на той же позиции в перемешанном алфавите и кладём в список
        else:
            input_symbols.append(symbol)  #если нет, то кладём в список без модификации
    line = file_input.readline()  #считываем следующую строку из файла
file_input.close()  #закрываем файл с исходным текстом
file_output = open("output.txt", "w", encoding = "utf8")  #открываем файл, в который будем записывать зашифрованный текст
file_output.write(''.join(input_symbols))  #преобразуем список в строку
file_output.close()  #закрываем файл с зашифрованным текстом