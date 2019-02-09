function initializelogin() {
    $("#error").hide();

    $("#submit-btn").click(function(event) {
        if (validatelogin()) {
            alert("Submitting regisgtration");
        }
    });
}

function validatelogin() {
    if ($("#first-name").val().length == 0) {
        displayError("First name must be entered.");
        return false;
    }
    if ($("#last-name").val().length == 0) {
        displayError("Last name must be entered.");
        return false;
    }
    return true;
}

function displayError(error) {
    $("#error").text(error);
    $("#error").show();
}
