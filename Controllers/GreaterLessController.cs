using LazarB_MiniChallenge_TwoToFourEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_TwoToFourEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreaterLessController : ControllerBase
    {
        private readonly GreaterLessServices _greaterLessServices;

        public GreaterLessController(GreaterLessServices greaterLessServices){
            _greaterLessServices = greaterLessServices;
        }

        [HttpPost]
        [Route("GreaterOrLess/{num1}/{num2}")]

        public string GreaterOrLess(int num1, int num2){
            return _greaterLessServices.GreaterOrLess(num1, num2);
        }
    }
}