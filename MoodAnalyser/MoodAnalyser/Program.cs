namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder();

            string happyResult = moodAnalyser.AnalyseMood("I am Happy");
            Console.WriteLine(happyResult);

            string sadResult = moodAnalyser.AnalyseMood("I am Sad");
            Console.WriteLine(sadResult);
        }
    }
}