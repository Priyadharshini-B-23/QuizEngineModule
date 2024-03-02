


using Microsoft.AspNetCore.Http.HttpResults;
using QuizEngineModule.Models;
using QuizEngineModule.Controllers;


namespace TestProject1
{
    public class Tests
    {
        private QuizController controller;
        [SetUp]
        public void Setup()
        {
            controller = new QuizController();
        }

        [Test]
        public void TestMethodForGetQuiz()
        {
            IEnumerable<QuizModel> result = controller.GetQuizes();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostQuiz()
        {
            var newItem = new QuizModel
            {
                QuestionNo = 1,
                QuestionText = "test",
                Category = "test",
                AnswerOne = "test",
                AnswerTwo = "test",
                AnswerThree = "test",
                RightAnswer = "test"
            };
            var actionResult = controller.PostQuizes(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostQuizNull()
        {
            var newItem = new QuizModel
            {
                QuestionNo = 1,
                QuestionText = null,
                Category = null,
                AnswerOne = null,
                AnswerTwo = null,
                AnswerThree = null,
                RightAnswer = null
            };
            var actionResult = controller.PostQuizes(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}



      