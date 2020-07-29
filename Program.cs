// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

public class Solution
{

	public class Calculator
	{
		public int Add(int a, int b) { return a + b; }
	}

	public class Logger
	{
		public void Log(string message) { Console.WriteLine(message); }
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			Logger log = new Logger();
			if (args.Length == 2) {
				int firstNumber;
				int secondNumber;
				bool successFirstNumber = int.TryParse(args[0], out firstNumber);
				bool successSecondNumber = int.TryParse(args[1], out secondNumber);
				if (successFirstNumber && successSecondNumber)
				{
					// Do the calculation
					Calculator calculator = new Calculator();
					int result = calculator.Add(firstNumber, secondNumber);

					// Result log
					
					log.Log(result.ToString());
				}
                else
                {
					log.Log("Error: value can not be parse to int");
                }

            }
            else
            {
				log.Log("Error: incorrect number of inputs");
			}
			


		}
	}
}