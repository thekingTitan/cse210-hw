using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letter="";
        

        if (percent >= 90)
        
        {
            letter="A";
        }
        else if (percent >= 80)
        {
            letter= "B";

        }
        else if (percent >=70)
        {
            letter ="C";
        }
        else if (percent>=60)
        {
            letter ="D";
        
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"your grade is :{letter}");

        if (percent>=70)
        {
            Console.WriteLine("you definitely passed!");
        }
        else
        {
            Console.WriteLine ("do better next time!");
        }
    }
}