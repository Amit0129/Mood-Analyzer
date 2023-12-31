﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyser.MoodAnalysisException;

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
        public string AnalyseMood()
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException("Messsage should not be empty", ExceptionType.EMPTY_MOOD);
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                //return "HAPPY";
                throw new MoodAnalysisException("Messsage should not be null", ExceptionType.NULL_MOOD);
            }
        }
        public string AnalyseMood(string message)
        {
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException("Messsage should not be empty", ExceptionType.EMPTY_MOOD);
                }
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                //return "HAPPY";
                throw new MoodAnalysisException("Messsage should not be null", ExceptionType.NULL_MOOD);
            }

        }
    }
}
