using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewCustomException;

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
            
            {
                //convert the message to lower case and then checks it contains happy or not
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else if (message.Contains(null))
                {
                    throw new NewCustomException(NewCustomException.ExceptionType.NULL_TYPE_EXCEPTION, "Mood can't be Null");

                }
                else
                {
                    return "HAPPY";
                }

            }




            /*catch (NullReferenceException)//this block will catch exception if there
            {
                throw new NewCustomException(NewCustomException.ExceptionType.NULL_TYPE_EXCEPTION, "Mood can't be Null");
                //return ;
            }*/
        }
    }
}




