using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoTest
{
    public class Question
    {
        public string content { get; set; }
        public string topic { get; set; }
        public List<Option> Options { get; set; }

        public Question()
        {
            Options = new List<Option>();
        }

    }
}
