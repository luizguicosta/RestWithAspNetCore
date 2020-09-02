using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //GET api/calculator/sum/firstNumber/secondNumber
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }

        //GET api/calculator/sum/firstNumber/secondNumber
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any
                                                                                , System.Globalization.NumberFormatInfo.InvariantInfo
                                                                                , out number);
            return isNumber;
        }
    }
}
