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

        [HttpGet("{whatIs}/{ofWhat}")]
        public float CalcWhatIsXpercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / 100 * ofWhat;

            return result;
        }

        // Add a get method to calculate what is X percent of Y
        public float CalcWhatIsXpercentOfY2(
                       float whatIs,
                                  float ofWhat)
        {
            float result = whatIs / 100 * ofWhat;

            return result;
        }

        [HttpGet("{whatIs}/{ofWhat}")]
        public float CalcXisWhatPercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / ofWhat * 100;

            return result;
        }

        [HttpGet("{whatIs}/{ofWhat}")]
        public float CalcWhatIsPercentChangeFromXtoY(
            float whatIs,
            float ofWhat)
        {
            float result = (ofWhat - whatIs) / whatIs * 100;

            return result;
        }
    }
}
