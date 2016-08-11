



function answers (answer1, answer2, answer3)
{
    this.answer1 = answer1;
    this.answer2 = answer2;
    this.answer3 = answer3;
    
}

var q1 = new answers ("Brazil" , "France" , "Argentina");
document.getElementById("demo").innerHTML = q1.answer1 + "<br/>" + q1.answer2 + "<br/>" + q1.answer3;

var arrayOfans = []
arrayOfans[0] = q1.answer1; 
arrayOfans[1] = q1.answer2;
arrayOfans[2] = q1.answer3;

