(function() {

    var InputMmessageBox = document.BlockPermutation.InputTextBlockPermutation;
    var InputlengthBox = document.BlockPermutation.LengthBlockPermutation;
    var InputkeyBlockPermutation = document.BlockPermutation.KeyBlockPermutation;


    async function onkeypress(e) {
        await sleep(20);

        var stirringKey = Number(document.getElementById("KeyBlockPermutation").value);
        var lengthBox = Number(document.getElementById("LengthBlockPermutation").value);
        var output = document.getElementById("OutputTextBlockPermutation");

        // console.log(stirringKey.toString().length + " " + lengthBox);

        var content = document.getElementById("InputTextBlockPermutation").value;

        if (lengthBox == stirringKey.toString().length && content.length != 0) {

            var blocksText = DivideTextBlocks(content, lengthBox);
            // console.log("blocksText = " + blocksText);
            var shuffleText = ShuffleText(blocksText, stirringKey);
            // console.log("shuffleText = " + shuffleText);

            output.textContent = shuffleText;

        } else {
            output.textContent = "Ошибка ключа или размера блока!" + lengthBox + " " + stirringKey.toString().length;
        }
    }

    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }

    function DivideTextBlocks(baseText, numberOfBlocks) {
        baseText = String(baseText);

        while (baseText.length % numberOfBlocks != 0) {
            console.log(baseText.length);
            baseText += " ";
        }

        var blocksText = [];
        var startingPoint = 0;
        while (numberOfBlocks + startingPoint != baseText.length) {
            blocksText.push(baseText.substring(startingPoint, numberOfBlocks + startingPoint));
            startingPoint += numberOfBlocks;
        }

        return blocksText;
    }

    function ShuffleText(blocksText, key) {

        var result = [];
        key = String(key);

        blocksText.forEach(element => {
            var temp = element;

            for (var i = 0; i < key.length; i++) {
                temp[i] = element[key[i]];
            }

            result.push(temp);
        });
        // console.log(result);
        return result.join("");
    }


    InputMmessageBox.addEventListener("keypress", onkeypress);
    InputMmessageBox.addEventListener("keydown", onkeypress);
    InputlengthBox.addEventListener("keypress", onkeypress);
    InputlengthBox.addEventListener("keydown", onkeypress);
    InputkeyBlockPermutation.addEventListener("keydown", onkeypress);
    InputkeyBlockPermutation.addEventListener("click", onkeypress);

})();
f