using LazarB_MiniChallenge_TwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_TwoToFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskQuestionsController : ControllerBase
    {
        private readonly AskQuestionsServices _askQuestionsServices;

        public AskQuestionsController(AskQuestionsServices askQuestionsServices){
            _askQuestionsServices = askQuestionsServices;
        }

        [HttpPost]
        [Route("AskQuestions/{userName}/{userTime}")]

        public string AskQuestions(string userName, string userTime){
            return _askQuestionsServices.AskingQuestions(userName, userTime);
        }
    }
}