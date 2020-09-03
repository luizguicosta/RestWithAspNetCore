using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWithAspNetCore.Utils;

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
            if(UtilsForNumbers.IsNumeric(firstNumber) && UtilsForNumbers.IsNumeric(secondNumber))
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
            if (UtilsForNumbers.IsNumeric(firstNumber) && UtilsForNumbers.IsNumeric(secondNumber))
            {
                var result = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }

        //GET api/calculator/sum/firstNumber/secondNumber
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult Division(string firstNumber, string secondNumber)
        {
            if (UtilsForNumbers.IsNumeric(firstNumber) && UtilsForNumbers.IsNumeric(secondNumber))
            {
                var result = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }

        //GET api/calculator/sum/firstNumber/secondNumber
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (UtilsForNumbers.IsNumeric(firstNumber) && UtilsForNumbers.IsNumeric(secondNumber))
            {
                var result = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }

        //GET api/calculator/sum/firstNumber/secondNumber
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber)
        {
            if (UtilsForNumbers.IsNumeric(firstNumber) && UtilsForNumbers.IsNumeric(secondNumber))
            {
                var result = (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)) / 2;
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }

        //GET api/calculator/sum/firstNumber/secondNumber
        [HttpGet("square-root/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (UtilsForNumbers.IsNumeric(firstNumber))
            {
                var result = Math.Sqrt((double)Convert.ToDecimal(firstNumber));
                return Ok(result);
            }
            return BadRequest("Invalid input");
        }
    }
}
