//using directive
using System;

namespace Calculator
{
  class Program
  {
    static void Main()
    {
        while (true)
        {
          Console.Write("Please enter your name, or type 'quit' to close the application ");
          var name = Console.ReadLine();
          if (name.ToLower() == "quit")
          {
             break;
          }
          Console.Write(name + ", can you please type your first number ");
          var firstEntry = Console.ReadLine();
          double firstNumber;

          Console.Write(name + " can you please type your second number ");
          var secondEntry = Console.ReadLine();
          double secondNumber;
          try
          {
            firstNumber = double.Parse(firstEntry);
            secondNumber = double.Parse(secondEntry);
          }
          catch(FormatException)
          {
            Console.WriteLine(name + ", please follow the instructions...");
            Console.WriteLine("Restarting...");
            continue;
          }
          Console.WriteLine(name + " now type if you would like to perform a (b)asic or (a)dvanced calculation");
          var which = Console.ReadLine();

          if (which == "b")
          {
            Console.Write(name + "can you please select an operator +, -, * or /: ");
            var operation = Console.ReadLine();
            if (operation == "+")
            {
              var answer = firstNumber + secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            else if (operation == "-")
            {
              var answer = firstNumber - secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            else if (operation == "*")
            {
              var answer = firstNumber * secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            else if (operation == "/")
            {
              var answer = firstNumber / secondNumber;
              Console.WriteLine(name + " your answer is " + answer);
              break;
            }
            else
            {
              Console.WriteLine(name + " PLEASE select a valid operator.");
              Console.WriteLine("Restarting...");
              continue;
            }
          }
      }
    }
  }
}
