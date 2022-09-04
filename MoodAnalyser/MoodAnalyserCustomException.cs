using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserCustomException:Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,NO_SUCH_METHOD,NO__CONSTRUCTOR_FOUND,NO_SUCH_CLASS,NO_METHOD_FOUND,INVALID_MESSAGE,NO_FIELD_FOUND
        }
        ExceptionType exceptionType;
        public MoodAnalyserCustomException(ExceptionType exception,string message) : base(message)
        {
            this.exceptionType = exception;
        }
    }
}
