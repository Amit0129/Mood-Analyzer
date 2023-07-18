using MoodAnalyser;

namespace MoodAnalyser_Test
{
    [TestClass]
    public class MoodAnalyse_Test
    {
        [TestMethod]
        public void GivenSadMoodInConstrutor_ShouldReturnSAD()
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder("I am in Sad Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "SAD");
        }
    }
}