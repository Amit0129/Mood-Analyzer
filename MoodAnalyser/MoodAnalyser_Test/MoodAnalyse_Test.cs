using MoodAnalyser;
using Newtonsoft.Json.Linq;
using System.Security.Claims;

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
                //Arrange - it will set up the testing object.
                MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder(null);
                //Act - it will perform the actual work what we  want  test.
                string result = moodAnalyser.AnalyseMood();

            }
            catch (MoodAnalysisException ex)
            {
                //Assert - verify result by equal actual and expected output.
                Assert.AreEqual(ex.Message, "Messsage should not be null");
            }
        }
        [TestMethod]
        public void GivenEmptyMood_ShouldThrowCostomException()
        {
            try
            {
                //Arrange - it will set up the testing object.
                MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder("");
                //Act - it will perform the actual work what we  want  test.
            }
            catch (MoodAnalysisException ex)
            {
                //Assert - verify result by equal actual and expected output.
                Assert.AreEqual(ex.Message, "Messsage should not be empty");
            }
        }
        //TC-4.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = "I am Sad";
            MoodAnalyserBuilder moodAnalyser = new MoodAnalyserBuilder();
            object expected = moodAnalyser.AnalyseMood(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserBuilder", "MoodAnalyserBuilder");
            expected.Equals(obj);
        }
        //TC-4.2
        [TestMethod]
        public void GivenMoodAnalyseClassNameWrong_ShouldReturnMoodAnalyseObject()
        {
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserBuild", "MoodAnalyserBuild");
            }
            catch (MoodAnalysisException exp)

            {
                Assert.AreEqual("Class not found", exp.Message);
            }
        }
        //TC-4.3
        [TestMethod]
        public void GivenClassWhenConstructorNotProper_ShouldThrowMoodAnalysisException()
        {
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyserBuilder", "MoodAnalyserBuild");
            }
            catch (MoodAnalysisException exc)
            {
                Assert.AreEqual("Constructor is not found", exc.Message);
            }
        }
    }
}