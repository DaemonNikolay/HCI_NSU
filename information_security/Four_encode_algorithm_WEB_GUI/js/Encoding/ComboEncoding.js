(function() {

    var SelectEncodingZero = document.ComboEncoding.SelectValueSequenceEncodingZero;
    var SelectEncodingOne = document.ComboEncoding.SelectValueSequenceEncodingOne;
    var SelectEncodingTwo = document.ComboEncoding.SelectValueSequenceEncodingTwo;

    var InputTextCombo = document.ComboResult.InputTextCombo;

    var ValueOffsetCezareCombo = document.ComboCezareEncrypt.ComboValueOffsetCezare;

    var LengthBlockPermutationCombo = document.ComboBlockPermutation.LengthBlockPermutation;
    var KeyBlockPermutationCombo = document.ComboBlockPermutation;


    async function onkeypress(e) {
        await sleep(10);

        var valueSelectZero = document.getElementById("SelectValueSequenceEncodingZero").value;
        var valueSelectOne = document.getElementById("SelectValueSequenceEncodingOne").value;
        var valueSelectTwo = document.getElementById("SelectValueSequenceEncodingTwo").value;

        // console.log(valueSelectZero + "\n" + valueSelectOne + '\n' + valueSelectTwo + "\n\n");

        var inputCombo = document.getElementById("InputTextCombo").value;
        var outputCombo = document.getElementById("OutputTextCombo").value;

        // console.log(inputCombo + "\t" + outputCombo);


    }



    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }



    //Cezare Encoding

    function validData(valueOffset, Output) {
        var offset = Number(document.getElementById(valueOffset).value);
        if (offset > 32) {
            offset = offset % 32;
        } else if (offset < -32) {
            offset = -(offset % 32);
        }

        var OutputCezare = document.getElementById(Output);

        convertText(OutputCezare, offset);
    }

    function convertText(OutputCezare, offset, inputText) {

        var content = document.getElementsByName(inputText)[0].value;

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