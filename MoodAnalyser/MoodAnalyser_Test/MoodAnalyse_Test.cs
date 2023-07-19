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
        [TestMethod]
        public void GivenHappyMoodInConstrutor_ShouldReturnHappy()
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder("I am in Happy Mood");
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMood_ShouldReturnHappy()
        {
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder(null);
            string result = moodAnalyser.AnalyseMood();
            Assert.AreEqual(result, "HAPPY");
        }
        [TestMethod]
        public void GivenNullMood_ShouldThrowCostomException()
        {
            try
            {
                //Arrange - it will set up the testing object
                MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder(null);
                //Act - it will perform the actual work what we  want  test
                string result = moodAnalyser.AnalyseMood();
                
            }
            catch (MoodAnalysisException ex)
            {
                //Assert - verify result 
                Assert.AreEqual(ex.Message, "Messsage should not be null");
            }
        }
    }
}