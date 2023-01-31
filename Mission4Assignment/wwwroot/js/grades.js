$("#grades").click(function () {
    alert("assignments: " + $("#txtFrom").val() +
        ", Subject: " + $("#txtSubject").val() +
        ", Message: " + $("#txtMessage").val());
    $("#picGanderson").fadeOut("slow");
})