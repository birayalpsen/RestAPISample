using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RestAPI
{

    public class Solution
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the City:");
            string city = Console.ReadLine();

            Console.Write("Enter Max Cost: ");
            int maxCost = Convert.ToInt32(Console.ReadLine().Trim());            

            List<string> result = Result.getRelevantFoodOutlets(city, maxCost);

            Console.WriteLine();
            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();
        }
    }
}