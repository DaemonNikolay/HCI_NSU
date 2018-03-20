(function() {

    var inputMessage = document.xorEncrypt.InputXor;
    var key = document.xorEncrypt.KeyXor;

    async function onkeypress(e) {

        await Sleep(10);

        var outputXor = document.getElementById('OutputXor');
        var offset = Number(document.getElementById('KeyXor').value);

        var content = document.getElementsByName("InputXor")[0].value;

        if (ValidKey(offset) == false) {
            outputXor.textContent = "Ошибка ввода!";
        } else if (offset.toString().length > content.toString().length) {
            outputXor.textContent = "Длина ключа не совпадает с введённой последовательностью!";
        } else {
            ValidInput() == true ? EncodingXor(outputXor, offset) : outputXor.textContent = "Ошибка ввода!";
        }

    }

    function EncodingXor(output, key) {

        var content = document.getElementsByName("InputXor")[0].value;
        var result = "";
        var j = 0;
        key = String(key);

        for (i = 0; i < content.length; i++) {
            result += content[i] ^ Number(key[j]);

            j++;
            if (j == key.length) {
                j = 0;
            }
        }

        output.textContent = result;
    }

    function ValidKey(key) {

        key = String(key);
        for (i = 0; i < key.length; i++) {
            if (key[i] > 1 || key[i] < 0) {
                return false;
            }
        }

        return true;
    }

    function ValidInput() {

        var content = document.getElementsByName("InputXor")[0].value;
        if (isNaN(Number(content))) {
            return false;
        }

        for (i = 0; i < content.length; i++) {
            if (content[i] > 1 || content[i] < 0) {
                return false;
            }
        }

        return true;
    }

    function Sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    inputMessage.addEventListener("keypress", onkeypress);
    inputMessage.addEventListener("keydown", onkeypress);
    key.addEventListener("keydown", onkeypress);
    key.addEventListener("click", onkeypress);

})();