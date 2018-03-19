(function() {

    var inputMessage = document.Randomly.InputTextRandomly;


    async function onkeypress(e) {
        await Sleep(10);

        var message = document.getElementById('InputTextRandomly').value;

        var baseAlpabet = CreateAlphabet(message);
        var shuffleAlphabet = ShuffleArray(Object.assign([], baseAlpabet));

        var output = document.getElementById('OutputTextRandomly');

        RandomlyText(shuffleAlphabet, baseAlpabet, message, output);
    }

    function RandomlyText(shuffleAlphabet, baseAlpabet, message, output) {

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

        output.textContent = result;
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

    function Sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    inputMessage.addEventListener("keypress", onkeypress);
    inputMessage.addEventListener("keydown", onkeypress);

})();