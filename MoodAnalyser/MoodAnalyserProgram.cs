using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserProgram
    {
        string message;
        public MoodAnalyserProgram(string message)
        {
            this.message = message;
        }
        public string MoodMessage()
        {
            if (this.message.ToLower().Equals("sad"))
            {
                return "sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
