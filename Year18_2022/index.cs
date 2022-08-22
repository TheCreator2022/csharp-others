using System;
using System.Linq;
using System.Collections.Generic;

namespace MyIndex
{
    public static class Program 
    {         
        public static void Main()
        {
            Console.WriteLine("Enter a Color Red:");
            string colorRed = Console.ReadLine();
            
            Console.WriteLine("Enter a Color Green:");
            string colorGreen = Console.ReadLine();
            
            Console.WriteLine("Enter a Color Blue:");
            string colorBlue = Console.ReadLine();
            
            Console.WriteLine("Source CSS");
            Console.WriteLine("color:rgb(" + colorRed + ", " + colorGreen + ", " + colorBlue + ")");
        }
    }
}