using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        //method to create object of mood analyser class
        public static object CreateMoodAnalyser(string className, string constructorName)
        {
            //creating pattern for checking constructor name
            string pattern = "." + constructorName + "$";
            //checking pattern is correct or not using regex 
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    //The assembly that contains the code that is currently executing.
                    // Get the currently executing assembly.
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Console.WriteLine("Currently executing assembly:");
                    Console.WriteLine("   {0}\n", executing.FullName);

                    Type moodAnalyserType = executing.GetType(className);
                    //createInstance will return object
                    var res = Activator.CreateInstance(moodAnalyserType);
                    return res;
                }
                catch (ArgumentNullException ex)
                {
                    //exception is thrown when a null reference is passed to a method that does not accept it as a valid argument.
                    throw new NewCustomException(NewCustomException.ExceptionType.CLASS_NOT_FOUND, "Class not found");
                }

            }
            else
            {
                throw new NewCustomException(NewCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
            }
        }

        public static object CreateMoodAnalyserObject(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }
}