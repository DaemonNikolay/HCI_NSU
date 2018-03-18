(function() {

    var messageBox = document.cezareEncrypt.InputTextCezare;
    var keyCodeCezare = document.cezareEncrypt.ValueOffsetCezare;

    async function onkeypress(e) {

        await sleep(10);
        var offset = Number(document.getElementById('ValueOffsetCezare').value);
        if (offset > 32) {
            offset = offset % 32;
        } else if (offset < -32) {
            offset = -(offset % 32);
        }
        var OutputCezare = document.getElementById('OutputCezare');

        convertText(OutputCezare, offset);
    }

    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    function convertText(OutputCezare, offset) {

        var content = document.getElementsByName("InputTextCezare")[0].value;

        OutputCezare.textContent = "";
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
        OutputCezare.textContent = result;
    }

    function convertSymbol(step, symbol) {
        var value = String.fromCodePoint((String(symbol).charCodeAt() + step));
        if (value > "я") {
            return String.fromCodePoint((String(symbol).charCodeAt() + step - 32));
        } else if (value > "z" && value < "а" && step <= 26) {
            return String.fromCodePoint((String(symbol).charCodeAt() + step - 26));
        } else if (value > "z" && value < "а" && step > 26) {
            return String.fromCodePoint((String(symbol).charCodeAt() + (step - 25) - 26));
        }
        return value;
    }

    messageBox.addEventListener("keypress", onkeypress);
    messageBox.addEventListener("keydown", onkeypress);
    keyCodeCezare.addEventListener("keydown", onkeypress);
    keyCodeCezare.addEventListener("click", onkeypress);

})();