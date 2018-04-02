(function() {

    var SelectEncodingZero = document.ComboEncoding.SelectValueSequenceEncodingZero;
    var SelectEncodingOne = document.ComboEncoding.SelectValueSequenceEncodingOne;
    var SelectEncodingTwo = document.ComboEncoding.SelectValueSequenceEncodingTwo;

    var InputTextCombo = document.ComboResult.InputTextCombo;

    var ValueOffsetCezareCombo = document.ComboCezareEncrypt.ComboValueOffsetCezare;

    var LengthBlockPermutationCombo = document.ComboBlockPermutation.ComboLengthBlockPermutation;
    var KeyBlockPermutationCombo = document.ComboBlockPermutation.ComboKeyBlockPermutation;


    async function onkeypress(e) {
        await sleep(20);

        var valueSelectZero = document.getElementById("SelectValueSequenceEncodingZero").value;
        var valueSelectOne = document.getElementById("SelectValueSequenceEncodingOne").value;
        var valueSelectTwo = document.getElementById("SelectValueSequenceEncodingTwo").value;

        var inputCombo = document.getElementById("InputTextCombo").value;
        var outputCombo = document.getElementById("OutputTextCombo");

        var lengthBlockPermutation = Number(document.getElementById("ComboLengthBlockPermutation").value);
        var keyBlockPermutation = Number(document.getElementById("ComboKeyBlockPermutation").value);

        var offsetCezare = document.getElementById("ComboValueOffsetCezare").value;

        var firstEncoding;
        if (valueSelectZero == 0) {
            firstEncoding = BlockPermutationEncoding(inputCombo, lengthBlockPermutation, keyBlockPermutation);
        } else if (valueSelectZero == 1) {
            firstEncoding = Randomly(inputCombo);
        } else if (valueSelectZero == 2) {
            firstEncoding = Cezare(offsetCezare, inputCombo);
        }


        if (firstEncoding == "~~~Отсутствует исходный текст!~~~") {
            outputCombo.textContent = firstEncoding.substr(3, firstEncoding.length - 6);
            return;
        } else if (firstEncoding == "~~~Ключ перемешивания не корректен!~~~") {
            outputCombo.textContent = firstEncoding.substr(3, firstEncoding.length - 6);
            return;
        } else if (firstEncoding == "~~~Ошибка размера блока!~~~") {
            outputCombo.textContent = firstEncoding.substr(3, firstEncoding.length - 6);
            return;
        }


        var secondEncoding;
        if (valueSelectOne == 0) {
            secondEncoding = BlockPermutationEncoding(firstEncoding, lengthBlockPermutation, keyBlockPermutation);
        } else if (valueSelectOne == 1) {
            secondEncoding = Randomly(firstEncoding);
        } else if (valueSelectOne == 2) {
            secondEncoding = Cezare(offsetCezare, firstEncoding);
        }

        var thirdEncoding;
        if (valueSelectTwo == 0) {
            thirdEncoding = BlockPermutationEncoding(secondEncoding, lengthBlockPermutation, keyBlockPermutation);
        } else if (valueSelectTwo == 1) {
            thirdEncoding = Randomly(secondEncoding);
        } else if (valueSelectTwo == 2) {
            thirdEncoding = Cezare(offsetCezare, secondEncoding);
        }

        outputCombo.textContent = thirdEncoding;
    }



    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }


    //Block permutation

    function BlockPermutationEncoding(content, lengthBox, stirringKey) {

        // console.log(stirringKey);

        stirringKey = ConvertNumberProgrammistToUser(stirringKey);
        var lengthKey = stirringKey.toString().length;

        // console.log("stirringKey: " + stirringKey + "\tlengthKey: " + lengthKey);

        if (content.length == 0) {
            return "~~~Отсутствует исходный текст!~~~";
        } else if (!IsCorrectStirringKey(lengthBox, stirringKey)) {
            return "~~~Ключ перемешивания не корректен!~~~"
        } else if (lengthBox != lengthKey) {

            // console.log(lengthBox + "\t" + stirringKey);

            return "~~~Ошибка размера блока!~~~";
        } else {
            var blocksText = DivideTextBlocks(content, lengthBox);
            var shuffleText = ShuffleText(blocksText, stirringKey);

            return shuffleText;
        }
    }

    function ConvertNumberProgrammistToUser(number) {

        if (number == 0) {
            return 0;
        }

        number = number.toString();
        var result = "";
        for (var i = 0; i < number.length; i++) {
            result += Number(number[i]) - 1;
        }
        console.log("result: " + result);
        return Number(result);
    }

    function IsCorrectStirringKey(lengthBox, key) {

        key = key.toString();
        for (var i = 0; i < key.length; i++) {
            if (key[i] >= lengthBox) {
                return false;
            }
        }

        if (!KeyUnique(key)) {
            return false;
        }

        return true;
    }

    function KeyUnique(key) {

        key = key.toString();
        var n = key.length;
        for (var i = 0; i < n - 1; i++) {
            for (var j = i + 1; j < n; j++) {
                if (key[i] === key[j]) {
                    return false;
                }
            }
        }

        return true;
    }

    function DivideTextBlocks(baseText, numberOfBlocks) {
        baseText = String(baseText);

        while (baseText.length % numberOfBlocks != 0) {
            baseText += " ";
        }

        var blocksText = [];
        var startingPoint = 0;
        while (startingPoint != baseText.length) {
            blocksText.push(baseText.substring(startingPoint, numberOfBlocks + startingPoint));
            startingPoint += numberOfBlocks;
        }

        return blocksText;
    }

    function ShuffleText(blocksText, key) {

        var result = [];
        key = String(key);

        blocksText.forEach(element => {
            var temp = [];
            for (var i = 0; i < key.length; i++) {
                temp.push(element[key[i]]);
            }

            result.push(temp.join(""));
        });

        return result.join("");
    }


    //Randomly

    function Randomly(inputText) {

        var message = inputText;

        var baseAlpabet = CreateAlphabet(message);
        var shuffleAlphabet = ShuffleArray(Object.assign([], baseAlpabet));

        return RandomlyText(shuffleAlphabet, baseAlpabet, message);
    }

    function RandomlyText(shuffleAlphabet, baseAlpabet, message) {

        var result = "";
        var specialSymbols = [",", ".", "!", "?", "\\", "!", "/", "|", " ", "   "];

        for (i = 0; i < message.length; i++) {
            if (specialSymbols.indexOf(message[i]) != -1) {
                result += message[i];
                continue;
            }
            var numAlph = baseAlpabet.indexOf(message[i]);
            result += shuffleAlphabet[numAlph];
        }

        return result;
    }

    function CreateAlphabet(text) {
        text = String(text).replace(/[ ]|[.]|[,]|[!]|[*]|[?]|[//]|[-]|[0-9]/g, "").split("");

        return Unique(text);
    }

    function ShuffleArray(array) {

        for (var i = array.length - 1; i > 0; i--) {
            var j = Math.floor(Math.random() * (i + 1));
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        return array;
    }

    function Unique(arr) {

        var obj = {};
        for (var i = 0; i < arr.length; i++) {
            var str = arr[i];
            obj[str] = true;
        }

        return Object.keys(obj);
    }



    //Cezare Encoding

    function Cezare(offset, content) {

        return cezareValidData(offset, content);
    }

    function cezareValidData(offset, content) {

        var offset = Number(offset);
        if (offset > 32) {
            offset = offset % 32;
        } else if (offset < -32) {
            offset = -(offset % 32);
        }

        return convertText(offset, content);
    }

    function convertText(offset, content) {

        var result = "";

        for (var i = 0; i < content.length; i++) {
            if (content[i] == ".") {
                result += convertSymbol(0, content[i]);
            } else if (content[i] == ",") {
                result += convertSymbol(0, content[i]);
            } else if (content[i] == "ё") {
                result += convertSymbol(offset, "е");
            } else if (content[i] == " ") {
                result += convertSymbol(0, content[i]);
            } else if (content[i] == "!") {
                result += convertSymbol(0, content[i]);
            } else if (content[i] == "?") {
                result += convertSymbol(0, content[i]);
            } else if (content[i] == "\n") {
                result += convertSymbol(0, content[i]);
            } else {
                result += convertSymbol(offset, content[i]);
            }
        }

        return result;
    }

    function convertSymbol(step, symbol) {

        var flag = false;

        if (symbol.toUpperCase() == symbol) {

            flag = true;
            symbol = symbol.toLowerCase();
        }

        var value = String.fromCodePoint((String(symbol).charCodeAt() + step));

        if (value > "я") {

            var result = String.fromCodePoint((String(symbol).charCodeAt() + step - 32));

            return flag == false ? result : result.toUpperCase();

        } else if (value > "z" && value < "а" && step <= 26) {

            var result = String.fromCodePoint((String(symbol).charCodeAt() + step - 26));

            return flag == false ? result : result.toUpperCase();

        } else if (value > "z" && value < "а" && step > 26) {

            var result = String.fromCodePoint((String(symbol).charCodeAt() + (step - 25) - 26));

            return flag == false ? result : result.toUpperCase();
        }

        return flag == false ? value : value.toUpperCase();
    }





    SelectEncodingZero.addEventListener("change", onkeypress);
    SelectEncodingOne.addEventListener("change", onkeypress);
    SelectEncodingTwo.addEventListener("change", onkeypress);

    InputTextCombo.addEventListener("keypress", onkeypress);
    InputTextCombo.addEventListener("keydown", onkeypress);

    ValueOffsetCezareCombo.addEventListener("keydown", onkeypress);
    ValueOffsetCezareCombo.addEventListener("click", onkeypress);

    LengthBlockPermutationCombo.addEventListener("keypress", onkeypress);
    LengthBlockPermutationCombo.addEventListener("keydown", onkeypress);
    KeyBlockPermutationCombo.addEventListener("keydown", onkeypress);
    KeyBlockPermutationCombo.addEventListener("click", onkeypress);
})();