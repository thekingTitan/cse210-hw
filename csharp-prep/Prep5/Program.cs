using System;
using System.Xml.XPath;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber= squareNumber(userNumber);
        DisplayResult (userName, squaredNumber);

    }
    static void WelcomeMessage()
    {
        Console.WriteLine("welcome to the programe !");
    }
    static string PromptUserName()
    {
        Console.Write("please enter your name:");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("please enter your favorite number:");
        int number =int.Parse(Console.ReadLine());
        return number;
    }
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}" );
    }
}