using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class NewCustomException : Exception
    {
        public ExceptionType type;
        //enum (or enumeration type) is used to assign constant names to a
        //group of numeric integer values.
        public enum ExceptionType
        {
            //declaring types of exception
            NULL_TYPE_EXCEPTION,
            EMPTY_TYPE_EXCEPTION,
            //CLASS_NOT_FOUND,
            //CONSTRUCTOR_NOT_FOUND
        }

        //creating a constructor which takes exception types and message
        public NewCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
