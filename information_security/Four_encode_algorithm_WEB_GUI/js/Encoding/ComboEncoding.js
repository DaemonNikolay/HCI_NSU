(function() {

    var SelectEncoding0 = document.ComboEncoding.SelectValueSequenceEncoding0;
    // var SelectEncoding1 = document.ComboEncoding.SelectValueSequenceEncoding;
    // var SelectEncoding2 = document.ComboEncoding.SelectValueSequenceEncoding;


    async function onkeypress(e) {
        await sleep(20);

        var value = document.getElementById("SelectValueSequenceEncoding0").value;

        alert(value);
    }



    function sleep(ms) {
        return new Promise(resolve => setTimeout(resolve, ms));
    }




    SelectEncoding0.addEventListener("change", onkeypress);
    // SelectEncoding1.addEventListener("change", onkeypress);
    // SelectEncoding2.addEventListener("change", onkeypress);

})();