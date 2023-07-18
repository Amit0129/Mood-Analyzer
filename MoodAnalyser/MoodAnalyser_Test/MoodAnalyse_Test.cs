using MoodAnalyser;

namespace MoodAnalyser_Test
{
    [TestClass]
    public class MoodAnalyse_Test
    {
        [TestMethod]
        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder();
            string result = moodAnalyser.AnalyseMood("I am in Sad Mood");
            string expexted = "SAD";
            Assert.AreEqual(result, expexted);
        }
    }
}