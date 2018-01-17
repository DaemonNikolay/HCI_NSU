var messageBox = document.search.message;

function onkeypress(e) {
    var outBlock = document.getElementById('out');
    var val = (String.fromCharCode(e.keyCode)).toLowerCase();

    var offset = Number(document.getElementById('valueOffset').value);

    if (val.charCodeAt() == 32) {
        outBlock.textContent += " ";
    } else if (val.charCodeAt() + offset > 1103) {
        outBlock.textContent += String.fromCodePoint((val.charCodeAt() + offset) - 32);
    } else {
        outBlock.textContent += String.fromCodePoint((val.charCodeAt() + offset));
    }
}

function onkeydown(e) {
    if (e.keyCode === 8) { // если нажат Backspace
        var outBlock = document.getElementById('out'),
            length = outBlock.textContent.length;
        outBlock.textContent = outBlock.textContent.substring(0, length - 1);
    }
}

messageBox.addEventListener("keypress", onkeypress);
messageBox.addEventListener("keydown", onkeydown);