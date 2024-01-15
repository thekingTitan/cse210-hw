using System;
using System.Net;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("what is your magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator= new Random();
        int magicNumber =randomGenerator.Next(1, 101);

        int guess =-1;

        //Console.Write("what is your guess? ");
        //int  guess = int.Parse(Console.ReadLine());
        
        
        
    
        while (magicNumber != guess)

         
        
            
        

        
        {
            Console.Write("what is your guess? ");
            guess = int.Parse(Console.ReadLine());
    
        
            if (magicNumber > guess)
            {
               Console.WriteLine("higher");
            }

            else if (magicNumber < guess)

            {
                Console.WriteLine("lesser");
            }
        
            else 
            {
                Console.WriteLine("you guessed right!");
                
            }
        
            
               
        }
          
        
    }
    
        
}