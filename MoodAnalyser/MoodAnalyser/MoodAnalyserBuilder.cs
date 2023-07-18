using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserBuilder
    {
        public string message;
        public MoodAnalyserBuilder()
        {

        }
        public MoodAnalyserBuilder(string message)
        {
            this.message = message;
        }
        public string AnalyseMood(string message)
        {
            if (message.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
