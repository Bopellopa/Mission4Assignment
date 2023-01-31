$("#grades").click(function () {
    totalscore = (parseInt($("#assn").val()) + parseInt($("#gp").val()) + parseInt($("#quiz").val()) + parseInt($("#mid").val()) + parseInt($("#final").val()) + parseInt($("#intex").val()))/6;
    if (totalscore >= 94) {
        grade = "A";
    } else if(totalscore >= 90){
        grade = "A-";
    } else if(totalscore >= 87){
        grade = "B+";
    } else if(totalscore >= 84){
        grade = "B";
    } else if(totalscore >= 80){
        grade = "B-";
    } else if(totalscore >= 77){
        grade = "C+";
    } else if(totalscore >= 74){
        grade = "C";
    } else if(totalscore >= 70){
        grade = "C-";
    } else if(totalscore >= 67){
        grade = "D+";
    } else if(totalscore >= 64){
        grade = "D";
    } else if(totalscore >= 60){
        grade = "D-";
    } else {
        grade = "E";
    }
    alert("overall grade: " + grade);
    


})