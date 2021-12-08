using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAOOPProject
{
    public class Question
    {
        public string content { get; set; }
        public string topic { get; set; }
        public List<Option> Options { get; set; }
        static Random random = new Random();
            
        public Question()
        {
            Options = new List<Option>();
        }
        public void Random()
        {
            List<int> lstIndex = new List<int>();
            for (int i = 0; i < this.Options.Count; i++)
            {
                int index;
                do
                {
                    index = random.Next(0, this.Options.Count);
                } while (lstIndex.IndexOf(index) != -1);
                lstIndex.Add(index);
            }

            List<Option> tempOptions = new List<Option>();
            foreach (Option option in this.Options)
            {
                tempOptions.Add(option);
            }

            for (int i = 0; i < this.Options.Count; i++)
            {
                this.Options[i] = tempOptions[lstIndex[i]];
            }
        }
    }
}
