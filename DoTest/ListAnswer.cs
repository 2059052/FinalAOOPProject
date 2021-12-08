using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoTest
{
    static class ListAnswer
    {
        public static List<String> Answers = new List<String>();
        public static void Empty()
        {
            ListAnswer.Answers.Clear();
        }
    }
}
