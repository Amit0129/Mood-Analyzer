using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnalysisException;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {

                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException("Class not found", MoodAnalysisException.ExceptionType.NO_SUCH_CLASS);

                }
            }
            else
            {
                throw new MoodAnalysisException("Constructor is not found", MoodAnalysisException.ExceptionType.NO_SUCH_METHOD);
            }
        }
    }
}
