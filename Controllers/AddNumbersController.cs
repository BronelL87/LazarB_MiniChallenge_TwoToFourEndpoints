using LazarB_MiniChallenge_TwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_TwoToFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddNumbersController : ControllerBase
    {
        private readonly AddNumbersServices _addNumbersServices;

        public AddNumbersController(AddNumbersServices addNumbersServices)
        {
            _addNumbersServices = addNumbersServices;
        }


        [HttpPost]
        [Route("AddNumbers/{num1}/{num2}")]
        public string AddNumbers(int num1, int num2 ){
            return _addNumbersServices.AddNumbers(num1, num2);
        }
    }
}