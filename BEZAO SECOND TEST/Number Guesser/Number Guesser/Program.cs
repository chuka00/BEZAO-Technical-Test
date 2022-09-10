using static System.Console;



string appName = "Number Guesser";
string appVersion = "1.0.0";
string appAuthor = "Chuka Victor Ogbodo";

//Change the text color
ForegroundColor = ConsoleColor.Yellow;

//write out app function
WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

//Reset Text color
ResetColor();

//Ask Users for their name
WriteLine("What's Your Name?");

//Get users input
string inputName = ReadLine();

WriteLine("Hello {0}, let's play a game. Shall we?..", inputName);

//Init number of tries
int numberOfTries = 5;


Random generatedSecretNum = new Random();
int secretNumber = generatedSecretNum.Next(1, 100);



while (true)
{
    //Print the message to the user
    WriteLine($"Please guess the number between 1 and 100 \nYou have {numberOfTries} tries: \n");

    //Collect input from user
    int input = Convert.ToInt32(ReadLine());

    //Check if user input is equal to secret number
    if (input == secretNumber)
    {
        ForegroundColor = ConsoleColor.Green;
        WriteLine($"Congratulations, you are correct!, the secret number is {secretNumber}\n");
        ResetColor();
        break;
    }

    //Check if user input is greater than the secret number
    else if (input >= secretNumber)
    {
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Your guess is larger than secret number\n");
        ResetColor();
        numberOfTries--;
    }

    //Check if user input is lesser than the secret number
    else if (input <= secretNumber)
    {
        //Change the text color
        ForegroundColor = ConsoleColor.Red;
        WriteLine("Your guess is smaller than the secret number\n");
        //Reset Text color
        ResetColor();
        numberOfTries--;
        
    }
   

    //Check if user has run out of chances
    if (numberOfTries == 0)
    {
        ForegroundColor = ConsoleColor.DarkCyan;
        WriteLine("Sorry, you've run out of tries!");
        WriteLine("Thanks for playing!");
        ResetColor();
        break;
    }
}

