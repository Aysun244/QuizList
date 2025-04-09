using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
    class Quiz : BaseEntity 
    {
        public string Name { get; set; }
        public List<Question> Questions { get; private set; }

        public Quiz(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Bos ola bilmez");
            Name = name;
            Questions = new List<Question>();
        }
        public void AddQuestion(Question question )
        {
            Questions.Add(question);
        }
    }
}
