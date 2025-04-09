using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
    class Exception
    {
        public class QuizNameException : Exception
        {
            public QuizNameException(string message) : base(message)
            {

            }
        }
    }
}
        public class QuestionNameException : Exception
        {
            public QuestionNameException(string message) : base(message)
            {

            }
        }

    
        public class InvalidVariantNumberException : Exception
        {
            public InvalidVariantNumberException(string message) : base(message) 
            {
    
            }
        }


