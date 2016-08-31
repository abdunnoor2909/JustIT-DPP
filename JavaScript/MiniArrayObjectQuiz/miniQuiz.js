/*
Your challenge is to create a small quiz using an array of objects in Javascript.

The quiz can be on any topic of your choice and no more than 5 questions.

An additional challenge will be to track the users score.
*/

function answers (answer1, answer2, answer3)//Object constructer. This will be the template for the objects.
{
    this.answer1 = answer1;
    this.answer2 = answer2;
    this.answer3 = answer3;
    
}

var q1 = new answers ("Brazil" , "France" , "Argentina");//These are the multiple choices for question 1.
document.getElementById("demo").innerHTML = q1.answer1 + "<br/>" + q1.answer2 + "<br/>" + q1.answer3;

var q2 = new answers ("7" , "8" , "6");
document.getElementById("question2").innerHTML = q2.answer1 + "<br/>" + q2.answer2 + "<br/>" + q2.answer3;

var arrayOfanswersQ1 = []
arrayOfanswersQ1[0] = q1.answer1; //Creating an array of objects(answers). For question 1
arrayOfanswersQ1[1] = q1.answer2;
arrayOfanswersQ1[2] = q1.answer3;

var arrayOfanswersQ2 = []
arrayOfanswersQ2[0] = q2.answer1; //Creating an array of objects(answers). For question 2
arrayOfanswersQ2[1] = q2.answer2;
arrayOfanswersQ2[2] = q2.answer3;


var event1 = document.getElementById("button1");//Function for button1. The function is for question 1.
event1.addEventListener('click', getAnswer, false);

function getAnswer()
{

	var userInputQ1 = document.getElementById("input1").value;

	if (userInputQ1 === arrayOfanswersQ1[1]){

		document.getElementById("demo2").innerHTML = q1.answer2 + " is the correct answer!";
}

	else
	{
		document.getElementById("demo2").innerHTML = "Wrong answer";
	}
} 

var event2 = document.getElementById("button2");//Function for button2. The function is for question 2.
event2.addEventListener('click', getAnswer2, false);

function getAnswer2()
{

	var userInputQ2 = document.getElementById("input2").value;

	if (userInputQ2 === arrayOfanswersQ2[2]){

	document.getElementById("demo3").innerHTML = q2.answer3 + " is the correct answer!";
}

	else
	{
		document.getElementById("demo3").innerHTML = "Wrong answer";
	}
} 