using static System.Console;
string appName = "Leap Year App";
string appVersion = "1.0.0";
string appAuthor = "Chuka Victor Ogbodo";

//Change the text color
ForegroundColor = ConsoleColor.DarkCyan;

//write out app Intro
WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

//Reset Text color
ResetColor();

//initialize the year and count
int year = 0;
int count = 0;


ForegroundColor = ConsoleColor.Green;
WriteLine("Kindly enter a year");
ResetColor();
year = Convert.ToInt32(ReadLine());

//check to see if the year entered is a leap year i.e 2000, 1700, 1800, 2020 etc
if (year % 400 != 0 && year % 4 != 0)
{
    ForegroundColor = ConsoleColor.Red;
    WriteLine("This is not a leap year, please try again!");
    ResetColor();
}
else
{

    while (count < 20)
    {
        if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
        {
            //print the next leap year message
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine($"The next leap year is: " + year);
            ResetColor();
            count++;
        }

        year++;
    }
}