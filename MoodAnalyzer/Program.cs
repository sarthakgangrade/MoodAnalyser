﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood analyzer problem");
            MoodAnalyser moodAnalyse = new MoodAnalyser();
            string message = "I am in any Mood";

            string result = moodAnalyse.AnalyseMood(message);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
