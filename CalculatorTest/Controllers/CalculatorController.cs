using CalculatorTest.Repository;
using System.Web.Http;

namespace CalculatorTest.Controllers
{
    public class CalculatorController : ApiController
    {
        private readonly ICalculatorRepository _calculatorRepository;
        public CalculatorController(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }

        [Route("api/calculator/sum")]
        [HttpGet]
        public IHttpActionResult Sum(int a, int b)
        {
            var outcome = _calculatorRepository.Sum(a , b);
            return Ok(outcome);
        }

        [Route("api/calculator/sub")]
        [HttpGet]
        public IHttpActionResult Sub(int a, int b)
        {
            var outcome = _calculatorRepository.Sub(a, b);
            return Ok(outcome);
        }

        [Route("api/calculator/multiply")]
        [HttpGet]
        public IHttpActionResult Multiply(int a, int b)
        {
            var outcome = _calculatorRepository.Multiply(a, b);
            return Ok(outcome);
        }

        [Route("api/calculator/divide")]
        [HttpGet]
        public IHttpActionResult Divide(double a, double b)
        {
            var outcome = _calculatorRepository.Divide(a, b);
            return Ok(outcome);
        }
    }
}
