using Microsoft.AspNetCore.Mvc;

namespace Rest_WithASPNETUdemy.Controller {

    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger) {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber) {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) {
                var value = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(value.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtraction(string firstNumber, string secondNumber) {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) {
                var value = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(value.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("mul/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiplication(string firstNumber, string secondNumber) {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) {
                var value = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(value.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivision(string firstNumber, string secondNumber) {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber) && ConvertToDecimal(secondNumber) != 0) {
                var value = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(value.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("avg/{firstNumber}/{secondNumber}")]
        public IActionResult GetAverage(string firstNumber, string secondNumber) {

            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) {
                var value = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(value.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("raiz/{firstNumber}")]
        public IActionResult GetRaiz(string firstNumber) {

            if (IsNumeric(firstNumber)) {
                var value = Math.Sqrt(ConvertToDecimal(firstNumber));
                return Ok(value.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber) {

            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out double number);
            return isNumber;
        }

        private double ConvertToDecimal(string strNumber) {

            if (double.TryParse(strNumber, out double decimalValue)) {
                return decimalValue;
            }

            return 0;
        }


    }
}
