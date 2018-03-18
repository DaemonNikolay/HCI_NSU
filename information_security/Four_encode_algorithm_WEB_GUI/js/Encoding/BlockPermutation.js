(function() {

    var InputMmessageBox = document.BlockPermutation.InputTextBlockPermutation;
    var InputlengthBox = document.BlockPermutation.LengthBlockPermutation;
    var InputkeyBlockPermutation = document.BlockPermutation.KeyBlockPermutation;


    async function onkeypress(e) {
        await sleep(20);

        var stirringKey = Number(document.getElementById("KeyBlockPermutation").value);
        stirringKey = ConvertNumberProgrammistToUser(stirringKey);
        var lengthBox = Number(document.getElementById("LengthBlockPermutation").value);
        var content = document.getElementById("InputTextBlockPermutation").value;
        var output = document.getElementById("OutputTextBlockPermutation");

        var lengthKey = stirringKey.toString().length;

        if (content.length == 0) {
            output.textContent = "Отсутствует текст!";
        } else if (!IsCorrectStirringKey(lengthBox, stirringKey)) {
            output.textContent = "Ключ перемешивания не корректен!";
        } else if (lengthBox != lengthKey) {
            output.textContent = "Ошибка размера блока!";
        } else {
            var blocksText = DivideTextBlocks(content, lengthBox);
            var shuffleText = ShuffleText(blocksText, stirringKey);

            output.textContent = shuffleText;
        }
    }

    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    function ConvertNumberProgrammistToUser(number) {

        number = number.toString();
        var result = "";
        for (var i = 0; i < number.length; i++) {
            result += Number(number[i]) - 1;
        }

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


    InputMmessageBox.addEventListener("keypress", onkeypress);
    InputMmessageBox.addEventListener("keydown", onkeypress);
    InputlengthBox.addEventListener("keypress", onkeypress);
    InputlengthBox.addEventListener("keydown", onkeypress);
    InputkeyBlockPermutation.addEventListener("keydown", onkeypress);
    InputkeyBlockPermutation.addEventListener("click", onkeypress);

})();