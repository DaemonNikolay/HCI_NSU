from yandex_translate import YandexTranslate

translate = YandexTranslate('trnsl.1.1.20171112T154849Z.fc55bd1bcb9d8d6c.0c15c5d09889cf7c9a0d6dfb330619ddf07a9389')


# print('Languages:', translate.langs)
# print('Translate directions:', translate.directions)
# print('Detect language:', translate.detect('Привет, мир!'))
# print('Translate:', translate.translate('Привет, мир!', 'ru-en'))  # or just 'en'


# temp = translate.translate("Hello", "en-ru")
# print(temp["text"][0])

def is_digit(string):
    if string.isdigit():
        return True
    else:
        try:
            float(string)
            return True
        except ValueError:
            return False


file = open("English text.md", "r", encoding = "UTF8")

textFromFile = file.readlines()

textNotLineBreak = set()

for line in textFromFile:
    temp = line.replace(".", "").replace(",", "").replace("\n", "").split(" ")
    for word in temp:
        textNotLineBreak.add(word)

file.close()

file = open("output.md", "w", encoding = "UTF8")

for word in textNotLineBreak:
    if len(word) <= 1:
        continue
    if is_digit(word):
        continue

    englishText = "**" + word + "**"
    file.write(englishText)
    file.write(" - ")

    temp = translate.translate(word, 'en-ru')
    russianText = "`" + temp["text"][0] + "`"
    file.write(russianText)
    file.write("\n")

file.close()

translate.translate('Привет, мир!', 'ru-en')
