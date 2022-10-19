//Mauricio Acosta
//10-19-22
//GitChallange Guess It

string playAgain = "yes";
while (playAgain == "yes")
{


string usersAnswer = "";



Console.WriteLine("We will be playing a guessing game");
Console.WriteLine("Would you like to play in easy, medium or hard?");
usersAnswer = Console.ReadLine();
if(usersAnswer == "easy")
{

bool isCorrectGuess = false;
Random random = new Random();
int randomNum = random.Next(1,11);
Console.WriteLine("Please choose a number from 1-10");
while (!isCorrectGuess){
    Console.WriteLine("Please enter your guess");
    int guess = Convert.ToInt32(Console.ReadLine());
    if(guess > randomNum){
        Console.WriteLine("Your guess is to high");
    }else if (guess < randomNum){
        Console.WriteLine("Your guess is too low");
    }else{
        Console.WriteLine("Correct you win");
        isCorrectGuess = true;
    }
}
}


    if(usersAnswer == "medium")
    {
        bool isCorrectGuess = false;
Random random = new Random();
int randomNum = random.Next(1,51);
Console.WriteLine("Choose a number from 1-50");
while (!isCorrectGuess){
    Console.WriteLine("Please enter your guess");
    int guess = Convert.ToInt32(Console.ReadLine());
    if(guess > randomNum){
        Console.WriteLine("Your guess is to high");
    }else if (guess < randomNum){
        Console.WriteLine("Your guess is too low");
    }else{
        Console.WriteLine("Correct you win");
        isCorrectGuess = true;
    }
}
}

    
        if(usersAnswer == "hard")
        {
            bool isCorrectGuess = false;
Random random = new Random();
int randomNum = random.Next(1,101);
Console.WriteLine("Choose a number from 1-100");
while (!isCorrectGuess){
    Console.WriteLine("Please enter your guess");
    int guess = Convert.ToInt32(Console.ReadLine());
    if(guess > randomNum){
        Console.WriteLine("Your guess is to high");
    }else if (guess < randomNum){
        Console.WriteLine("Your guess is too low");
    }else{
        Console.WriteLine("Correct you win");
        isCorrectGuess = true;
    }
}
}

Console.WriteLine("Type yes to play again");
playAgain = Console.ReadLine();
}