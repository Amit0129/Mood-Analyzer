using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{

        public class MoodAnalysisException : Exception
        {
            public enum ExceptionType
            {
                NULL_MOOD,
                EMPTY_MOOD,
                NO_SUCH_CLASS,
                NO_SUCH_METHOD
        }
            public ExceptionType type;
            //Base - Keyword is used to access member of a base class with a derived class
            public MoodAnalysisException(string message, ExceptionType type) : base(message)
            {
                this.type = type;
            }
        }
    
}
