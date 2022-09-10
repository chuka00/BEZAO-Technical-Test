using static System.Console;



string appName = "Pig Latin App";
string appVersion = "1.0.0";
string appAuthor = "Chuka Victor Ogbodo";

//Change the text color
ForegroundColor = ConsoleColor.Yellow;

//write out app Intro
WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

//Reset Text color
ResetColor();


//Initialize the variables
string firstLetter;
string afterWord;
string pigLatinWord = "";
int j;


//Collect input from user
WriteLine("Enter a word or sentence to convert into PigLatin");
string newSentence = ReadLine();



string[] text = newSentence.Split();

foreach (string word in text)
{
    afterWord = word.Substring(1);
    firstLetter = word.Substring(0, 1);
    j = newSentence.IndexOf(firstLetter);

    pigLatinWord = afterWord + firstLetter + "ay ";

    Write(pigLatinWord);


}


//To reverse the input back to its original form
WriteLine("Press any key to convert back to sentence.");
ReadKey(true);
string reversedString = null;
reversedString = (string)newSentence.Clone();
ForegroundColor = ConsoleColor.Green;
WriteLine(reversedString);
ResetColor();
