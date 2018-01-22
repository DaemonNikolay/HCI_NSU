(function() {

    var messageBox = document.search.message;
    var keyCodeCezare = document.search.valueOffset;

    async function onkeypress(e) {

        await sleep(10);

        var offset = Number(document.getElementById('valueOffset').value);
        var outBlock = document.getElementById('out');

        if (Number(offset) <= 32 && Number(offset) >= 0) {
            convertText(outBlock, offset);
        } else {
            outBlock.textContent = "error! max offset 32!";
        }
    }

    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    function convertText(outBlock, offset) {

        var content = document.getElementsByName("message")[0].value;

        outBlock.textContent = "";
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
        outBlock.textContent = result;
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