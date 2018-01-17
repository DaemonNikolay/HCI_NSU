var messageBox = document.search.message;
var keyCodeCezare = document.search.valueOffset;

async function onkeypress(e) {

    await sleep(10);

    var outBlock = document.getElementById('out');
    var offset = Number(document.getElementById('valueOffset').value);
    var content = document.getElementsByName("message")[0].value;

    outBlock.textContent = "";

    var result = "";
    for (var i = 0; i < content.length; i++) {
        if (content[i] == ".") {
            result += convertSymbol(0, content[i]);
        } else if (content[i] == " ") {
            result += convertSymbol(0, content[i]);
        } else if (content[i] == "\n") {
            result += convertSymbol(0, content[i]);
        } else {
            result += convertSymbol(offset, content[i]);
        }
    }
    outBlock.textContent = result;
}

function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

function convertSymbol(step, symbol) {
    return String.fromCodePoint((String(symbol).charCodeAt() + step));
}

messageBox.addEventListener("keypress", onkeypress);
messageBox.addEventListener("keydown", onkeypress);
keyCodeCezare.addEventListener("keydown", onkeypress);