(function() {

    var messageBox = document.code.message;
    var keyCodeCezare = document.code.valueOffset;

    var messageBoxDecode = document.decode.messageDecode;
    var keyCodeCezareDecode = document.decode.valueOffsetDecode;

    async function onkeypress(e) {

        await sleep(10);
        var content = document.getElementsByName("message")[0].value;
        var offset = Number(document.getElementById('valueOffset').value);
        var outBlock = document.getElementById('out');

        convertText(outBlock, offset, content);
    }

    async function onkeypressDecode(e) {

        await sleep(10);
        var content = document.getElementsByName("messageDecode")[0].value;
        var offset = Number(document.getElementById('valueOffsetDecode').value);
        var outBlock = document.getElementById('outDecode');

        convertText(outBlock, offset, content);
    }

    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    function convertText(outBlock, offset, content) {

        var symbols = String(content).split("");

        outBlock.textContent = "";
        var result = "";

        symbols.forEach(function(element) {
            result += String.fromCharCode(element.charCodeAt() ^ offset);
        });
        outBlock.textContent = result;
    }

    messageBox.addEventListener("keypress", onkeypress);
    messageBox.addEventListener("keydown", onkeypress);
    keyCodeCezare.addEventListener("keydown", onkeypress);
    keyCodeCezare.addEventListener("click", onkeypress);

    messageBoxDecode.addEventListener("keypress", onkeypressDecode);
    messageBoxDecode.addEventListener("keydown", onkeypressDecode);
    keyCodeCezareDecode.addEventListener("keydown", onkeypressDecode);
    keyCodeCezareDecode.addEventListener("click", onkeypressDecode);


})();