using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PercentageCalculationsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet(Name = "AccessPercentageCalculator")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("CalcWhatIsXpercentOfY")]
        public ResultModel CalcWhatIsXpercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / 100 * ofWhat;

            return new ResultModel() { Result = result };
        }

        [HttpGet("CalcXisWhatPercentOfY")]
        public ResultModel CalcXisWhatPercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / ofWhat * 100;

            return new ResultModel() { Result = result };
        }

        [HttpGet("CalcWhatIsPercentChangeFromXtoY")]
        public ResultModel CalcWhatIsPercentChangeFromXtoY(
            float whatIs,
            float ofWhat)
        {
            float result = (ofWhat - whatIs) / whatIs * 100;

            return new ResultModel() { Result = result };
        }

        [HttpGet("CalcPercentageChange")]
        public ResultModel CalcPercentageChange(
            float oldValue,
            float newValue)
        {
            float result = ((newValue - oldValue) / oldValue) * 100;

            return new ResultModel() { Result = result };
        }

        [HttpGet("CalcFinalPriceAfterDiscount")]
        public PriceResultModel CalcFinalPriceAfterDiscount(
            float originalPrice,
            float discountRate)
        {
            float discountAmount = discountRate / 100 * originalPrice;
            float result = originalPrice - discountAmount;

            return new PriceResultModel() { Result = result };
        }

        [HttpGet("CalcTaxAmount")]
        public TaxResultModel CalcTaxAmount(
            float purchasePrice,
            float taxRate)
        {
            float result = purchasePrice * (taxRate / 100);

            return new TaxResultModel() { Result = result };
        }

        [HttpGet("CalcTipAmount")]
        public TipResultModel CalcTipAmount(
            float billAmount,
            float tipRate)
        {
            float result = billAmount * (tipRate / 100);

            return new TipResultModel() { Result = result };
        }

        [HttpGet("CalcFractionToPercentage")]
        public ResultModel CalcFractionToPercentage(
            float numerator,
            float denominator)
        {
            float result = (numerator / denominator) * 100;

            return new ResultModel() { Result = result };
        }

        [HttpGet("CalcOriginalPriceBeforeTax")]
        public PriceResultModel CalcOriginalPriceBeforeTax(
            float totalPrice,
            float taxRate)
        {
            float result = totalPrice / (1 + (taxRate / 100));

            return new PriceResultModel() { Result = result };
        }

        [HttpGet("CalcPercentageAchieved")]
        public ResultModel CalcPercentageAchieved(
            float amountAchieved,
            float goal)
        {
            float result = (amountAchieved / goal) * 100;

            return new ResultModel() { Result = result };
        }

        [HttpGet("CalcRelativePercentage")]
        public ResultModel CalcRelativePercentage(
            float part,
            float whole)
        {
            float result = (part / whole) * 100;

            return new ResultModel() { Result = result };
        }

    }
}
