using System;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        //method to analyse the mood
        public string message;

        public MoodAnalyser()
        {
        }

        //creadted parameterized constructor
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood(string message)
        {

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









                catch (NullReferenceException)//this block will catch exception if there
                {
                    throw new NewCustomException(NewCustomException.ExceptionType.NULL_TYPE_EXCEPTION, "Mood can't be Null");
                    //return ;
                }
            }
            
        }
    }
}





