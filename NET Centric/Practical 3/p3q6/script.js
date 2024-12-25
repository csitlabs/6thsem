$(document).ready(function () {
    $("#myForm").submit(function (event) {
        var valid = true;

        // Clear previous error messages
        $("#nameError").hide();
        $("#emailError").hide();

        // Validate Name
        if ($("#name").val().trim() === "") {
            valid = false;
            $("#nameError").show();
        }

        // Validate Email
        if ($("#email").val().trim() === "") {
            valid = false;
            $("#emailError").show();
        }

        // If the form is invalid, prevent submission
        if (!valid) {
            event.preventDefault();
        }
    });
});
