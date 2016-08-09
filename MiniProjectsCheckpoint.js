/*Mini Project -  Guess the number guessing game
Build a small game where the user has to guess a secret number which is generated automatically in Javascript. After each guess the webpage displays to the user whether their guess is too large or too small. When the user guesses the secret number correctly - three pieces of information are displayed on the webpage: (1) the correct number  (2)the number of guesses (3)the message “Well done – correct guess!”*/

var event1 = document.getElementById("button1");
event1.addEventListener("click", checkGuess, false);

var randomNum = Math.floor((Math.random() * 100) + 1);//to generate the secret number
var count = 0;//will start the attempt from count 0
var msg1 = "Too low";
var msg2 = "Too high";
var msg3 = "Correct!";

function checkGuess(){//clicking the button will execute the function
    
    
    var guess = document.getElementById("input").value;//user to guess a number
    var playerGuess = parseInt(guess);//changes the guess from string to Int
    
    count++;//will increase the count (attempts) 
    
    
    
    
    document.getElementById("demo").innerHTML = "Your attempts: " +  count;//counts the times you guessed.
    
   
    //document.getElementById("demo2").innerHTML = randomNum;
    
    
       
    
    if (playerGuess === randomNum){
        document.getElementById("demo2").innerHTML = msg3;
    }
    
     else if(playerGuess < randomNum){
        document.getElementById("demo2").innerHTML = msg1;
    }
    
    else if(playerGuess > randomNum){
       document.getElementById("demo2").innerHTML = msg2;
    }
    
   
    
    
}




