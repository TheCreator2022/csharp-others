using System;
using System.Linq;
using System.Collections.Generic;

namespace TextAnimation
{
    public static class TextAnimation
    {         
        public static void Main()
        {
        	// Press "a" the start the animation.
        	int a = 0;
        	int b = 0;
        	
        	string result = "*****";
        	
        	string[] resultSymbol = {"*", "+", "$", "#"};
        	
        	Console.WriteLine("Hello!");
        	
        	// Loop is default is 2,000.
        	Console.WriteLine("Press Number of Loop The Animation:");
        	int outerInput = Int32.Parse(Console.ReadLine());
            
            // Can repeat.
            while (a < outerInput)
            {
              Console.WriteLine(result);
              Console.WriteLine(result);
              Console.WriteLine(result);
              Console.WriteLine(result);
              Console.WriteLine(result);
              Console.WriteLine(a);
              a++;
            }
            
            a = 0;
            result = "_____";
            
            while (a < outerInput)
            {
            	Console.WriteLine(result);
            	Console.WriteLine(result);
            	Console.WriteLine(result);
            	Console.WriteLine(result);
            	Console.WriteLine(result);
            	a++;
            }
            
            Console.WriteLine("The end.");
            string checkB = Console.ReadLine();
            
            b = Int32.Parse(checkB);
            
            Console.WriteLine("Number is " + b);
        }
    }
}