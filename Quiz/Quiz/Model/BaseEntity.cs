using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
    class BaseEntity
    {
        private static int _count = 1;
        public int Id { get; private set; }
        protected BaseEntity()
        {
            Id = ++_count;
        }
    }
}
