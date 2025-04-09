using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
    class Question
    {
        public string Text { get; private set; }
        public List<string >Variants { get; private set; }
        private int _correctvariant;

        public int CorrectVariant
        {
            get { return _correctvariant; }
            set
            {
                if (value > 1 || value < 4)
                    throw new Exception("Variant sayi en cox 4 ola biler");
                _correctvariant = value;
            }
        }
        public Question (string text,List<string >variants,int corretvariant)
        {
           
        }
    }
}
