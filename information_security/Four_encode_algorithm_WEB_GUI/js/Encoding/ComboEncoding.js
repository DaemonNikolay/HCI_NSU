(function() {

    var SelectEncodingZero = document.ComboEncoding.SelectValueSequenceEncodingZero;
    var SelectEncodingOne = document.ComboEncoding.SelectValueSequenceEncodingOne;
    var SelectEncodingTwo = document.ComboEncoding.SelectValueSequenceEncodingTwo;


    async function onkeypress(e) {
        await sleep(20);

        var valueSelectZero = document.getElementById("SelectValueSequenceEncodingZero").value;
        var valueSelectOne = document.getElementById("SelectValueSequenceEncodingOne").value;
        var valueSelectTwo = document.getElementById("SelectValueSequenceEncodingTwo").value;

        console.log(valueSelectZero + "\n" + valueSelectOne + '\n' + valueSelectTwo + "\n\n");




    }



    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }




    SelectEncodingZero.addEventListener("change", onkeypress);
    SelectEncodingOne.addEventListener("change", onkeypress);
    SelectEncodingTwo.addEventListener("change", onkeypress);
})();