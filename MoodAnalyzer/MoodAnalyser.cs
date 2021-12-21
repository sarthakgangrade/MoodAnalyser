using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        //method to analyse the mood
        public string message;

        //creadted parameterized constructor
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood(string message)
        {
            try
            {
                //convert the message to lower case and then checks it contains happy or not
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }

            }




            //catch block will catch the exception
            catch (NullReferenceException ex)
            {
                //prints the default exception message 
                Console.WriteLine(ex.Message);
                return "HAPPY";
            }
        }
    }
}




