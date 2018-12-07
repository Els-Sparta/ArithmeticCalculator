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
          //initialise the firstNumber and secondNumber variable has a 'double' so for calculation
          string firstEntry;
          string secondEntry;
          double firstNumber;
          double secondNumber;
          string operation;
          double answer;
          Console.WriteLine(name + " type 'b/a' if you would like to perform a (b)asic or (a)dvanced calculation");
          var which = Console.ReadLine();
          // Basic Calculator
          if (which.ToLower() == "b")
          {
            //Prompt the user to type in their first number
            Console.Write(name + ", can you please type your first number ");
            //save it to this variable
            firstEntry = Console.ReadLine();
            // Prompt the user to type in their second number
            Console.Write(name + ", can you please type your second number ");
            //save it to this variable
            secondEntry = Console.ReadLine();
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
            operation = Console.ReadLine();
            // Addition
            if (operation == "+")
            {
              // save the answer to a variable and print it out on the console
              answer = firstNumber + secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Subtraction
            else if (operation == "-")
            {
              // save the answer to a variable and print it out on the console
              answer = firstNumber - secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Multiplication
            else if (operation == "*")
            {
              // save the answer to a variable and print it out on the console
              answer = firstNumber * secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Division
            else if (operation == "/")
            {
              // save the answer to a variable and print it out on the console5
              answer = firstNumber / secondNumber;
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
            // Ask the user what operation, index or squareroot
            Console.WriteLine(name + " type in 'i/s' to perform an (i)ndex or (s)quareroot operation");
            operation = Console.ReadLine();
            // Index opertaion
            if(operation.ToLower() == "i")
            {
              //Prompt the user to type in their first number
              Console.Write(name + ", can you please type your base number ");
              //save it to this variable
              firstEntry = Console.ReadLine();
              // Prompt the user to type in their second number
              Console.Write(name + ", can you please type your power number ");
              //save it to this variable
              secondEntry = Console.ReadLine();
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
              // save the answer to a variable and print it out on the console
              answer = Math.Pow(firstNumber, secondNumber);
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            // Squareroot Operation
            else if(operation.ToLower() == "s")
            {
              //Prompt the user to type in their first number
              Console.Write(name + ", can you please type the number you would like to squareroot ");
              //save it to this variable
              firstEntry = Console.ReadLine();
              // Prompt the user to type in their second number
              try
              {
                // convert firstNumber and secondNumber into double
                firstNumber = double.Parse(firstEntry);
              }
              // if the console is unable to convert it into a double, incorrect input has been provided
              catch(FormatException)
              {
                // Tell the user they have provided incorrect input, restart program
                Console.WriteLine(name + ", please follow the instructions...");
                Console.WriteLine("Restarting...");
                continue;
              }
              // save the answer to a variable and print it out on the console
              answer = Math.Pow(firstNumber, 0.5);
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            else
            {
              Console.WriteLine(name + ", please follow the instructions...");
              Console.WriteLine("Restarting...");
              continue;
            }
          }
          else
          {
            Console.WriteLine(name + " please select a valid calculator");
          }
      }
    }
  }
}
