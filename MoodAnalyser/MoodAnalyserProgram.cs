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
        public MoodAnalyserProgram()
        {

        }
        public MoodAnalyserProgram(string message)
        {
            this.message = message;
        }
        public string MoodMessage()
        {
            try
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
            catch (NullReferenceException ex)
            {
                return "Happy";
            }
        }
    }
}
