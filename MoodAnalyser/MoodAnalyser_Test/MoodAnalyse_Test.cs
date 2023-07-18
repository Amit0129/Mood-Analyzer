using MoodAnalyser;

namespace MoodAnalyser_Test
{
    [TestClass]
    public class MoodAnalyse_Test
    {
        [TestMethod]
        public void GivenSadMood_ShouldReturnSAD()
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder();
            string result = moodAnalyser.AnalyseMood("I am in Sad Mood");
            string expexted = "SAD";
            Assert.AreEqual(result, expexted);
        }
        [TestMethod]
        public void GivenaNYMood_ShouldReturnHAPPY()
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder();
            string result = moodAnalyser.AnalyseMood("I am in Any Mood");
            string expexted = "HAPPY";
            Assert.AreEqual(result, expexted);
        }
    }
}