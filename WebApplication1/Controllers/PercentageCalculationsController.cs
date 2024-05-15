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

        [HttpGet("per1")]
        public PercentageResultModel CalcWhatIsXpercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / 100 * ofWhat;

            return new PercentageResultModel() { Result = result };
        }

        [HttpGet("per2")]
        public PercentageResultModel CalcXisWhatPercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / ofWhat * 100;

            return new PercentageResultModel() { Result = result };
        }

        [HttpGet("per3")]
        public PercentageResultModel CalcWhatIsPercentChangeFromXtoY(
            float whatIs,
            float ofWhat)
        {
            float result = (ofWhat - whatIs) / whatIs * 100;

            return new PercentageResultModel() { Result = result };
        }
    }
}
