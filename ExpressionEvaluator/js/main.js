$(document).ready(function ()
{
    var variables = 'ABCDEFGHIJ';

    initialHide();

    $('#evaluationBox').on('keypress', showVars);

    // Show variable labels/textboxes for the given user input
    function showVars() {

        var evalText = $('#evaluationBox').val();
        evalText = evalText.toUpperCase();

        // Get most recent key press and add it to the string. Most recent key presses are not added
        // to the textbox string.
        var pressedKey = String.fromCharCode(event.keyCode).toUpperCase();
        evalText += pressedKey;

        for (var i = 0; i < variables.length; i++) {
            // Show variable textbox + label if it is part of user input, otherwise hide it.
            if (evalText.indexOf(variables.charAt(i)) != -1) {
                $('#var' + variables.charAt(i)).show();
            } else {
                $('#var' + variables.charAt(i)).hide();
            }// end if
        }// end for

    }// end

    function initialHide() {

        // Used so variables aren't hidden when submit is clicked.
        showVars();
    }// end initialHide

});