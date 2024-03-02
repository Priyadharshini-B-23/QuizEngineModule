using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuizEngineModule.Models;

namespace QuizEngineModule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class QuizController : ControllerBase
    {
        private static List<QuizModel> quizes = new List<QuizModel> { };

       
        [HttpGet]
        public IEnumerable<QuizModel> GetQuizes()
        {
            return quizes;
        }

        [HttpPost]
        public IActionResult PostQuizes(QuizModel quiz)
        {
            quizes.Add(quiz);
            return Ok(quiz);
        }
    }
}







