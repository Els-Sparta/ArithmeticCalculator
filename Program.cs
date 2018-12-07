//using directive
using System;
// set a namespace for the Calculator
namespace Calculator
{
  class Program
  {
    static void Main()
    {
      //Ask the User for their name and give them an option to quit the program
      Console.WriteLine("Please enter your name to begin, or type 'quit' to close the application ");
      //Save the user's name to this variable to be used throughout the rest of the program
      var name = Console.ReadLine();
        //If user types in quit, this ends the program
        while (true)
        {
          if (name.ToLower() == "quit")
          {
             break;
          }
          Console.WriteLine(name + " type 'b/a' if you would like to perform a (b)asic or (a)dvanced calculation");
          var which = Console.ReadLine();
          // Basic Calculator
          if (which.ToLower() == "b")
          {
            //Prompt the user to type in their first number
            Console.Write(name + ", can you please type your first number ");
            //save it to this variable
            var firstEntry = Console.ReadLine();
            //initialise the firstNumber variable has a 'double' so it can calculate any number
            double firstNumber;
            // Prompt the user to type in their second number
            Console.Write(name + ", can you please type your second number ");
            //save it to this variable
            var secondEntry = Console.ReadLine();
            //initialise the secondNumber var as a 'double'
            double secondNumber;
            // check if the user typed in an input which meets the requirements of the program, if not the program tells the user incorrect input was provided and restarts the program
            try
            {
              // convert firstNumber and secondNumber into double
              firstNumber = double.Parse(firstEntry);
              secondNumber = double.Parse(secondEntry);
            }
            // if the console is unable to convert it into a double, incorrect input has been provided
            catch(FormatException)
            {
              // Tell the user they have provided incorrect input, restart program
              Console.WriteLine(name + ", please follow the instructions...");
              Console.WriteLine("Restarting...");
              continue;
            }
            // Prompt the user to select an operator
            Console.Write(name + "can you please select an operator +, -, * or /: ");
            var operation = Console.ReadLine();
            // Addition
            if (operation == "+")
            {
              var answer = firstNumber + secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Subtraction
            else if (operation == "-")
            {
              var answer = firstNumber - secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Multiplication
            else if (operation == "*")
            {
              var answer = firstNumber * secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Division
            else if (operation == "/")
            {
              var answer = firstNumber / secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // If no correct operatior is provided, tell the user incorrect input restart the program
            else
            {
              Console.WriteLine(name + " PLEASE select a valid operator.");
              Console.WriteLine("Restarting...");
              continue;
            }
          }
          // Advance Calculator
          else if(which.ToLower() == "a")
          {

          }
          else
          {
            Console.WriteLine(name + " please select a valid calculator");
          }
      }
    }
  }
}
