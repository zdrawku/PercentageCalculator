using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PercentageCalculationsController : ControllerBase
    {
        /// <summary>
        /// Calculates the value that represents X percent of a given number Y.
        /// </summary>
        /// <param name="whatIs">The percentage value (X).</param>
        /// <param name="ofWhat">The base value (Y).</param>
        /// <returns>The result of X percent of Y.</returns>
        [HttpGet("CalcWhatIsXpercentOfY")]
        public ResultModel CalcWhatIsXpercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / 100 * ofWhat;
            return new ResultModel() { Result = result };
        }

        /// <summary>
        /// Determines what percentage X is of another number Y.
        /// </summary>
        /// <param name="whatIs">The value to compare (X).</param>
        /// <param name="ofWhat">The base value (Y).</param>
        /// <returns>The percentage that X is of Y.</returns>
        [HttpGet("CalcXisWhatPercentOfY")]
        public ResultModel CalcXisWhatPercentOfY(
            float whatIs,
            float ofWhat)
        {
            float result = whatIs / ofWhat * 100;
            return new ResultModel() { Result = result };
        }

        /// <summary>
        /// Calculates the percentage change from an initial value X to a new value Y.
        /// </summary>
        /// <param name="whatIs">The initial value (X).</param>
        /// <param name="ofWhat">The new value (Y).</param>
        /// <returns>The percentage change from X to Y.</returns>
        [HttpGet("CalcWhatIsPercentChangeFromXtoY")]
        public ResultModel CalcWhatIsPercentChangeFromXtoY(
            float whatIs,
            float ofWhat)
        {
            float result = (ofWhat - whatIs) / whatIs * 100;
            return new ResultModel() { Result = result };
        }

        /// <summary>
        /// Computes the percentage change between an old value and a new value.
        /// </summary>
        /// <param name="oldValue">The old value.</param>
        /// <param name="newValue">The new value.</param>
        /// <returns>The percentage change from old to new value.</returns>
        [HttpGet("CalcPercentageChange")]
        public ResultModel CalcPercentageChange(
            float oldValue,
            float newValue)
        {
            float result = ((newValue - oldValue) / oldValue) * 100;
            return new ResultModel() { Result = result };
        }

        /// <summary>
        /// Calculates the final price after applying a percentage discount to the original price.
        /// </summary>
        /// <param name="originalPrice">The original price before discount.</param>
        /// <param name="discountRate">The discount rate as a percentage.</param>
        /// <returns>The final price after discount.</returns>
        [HttpGet("CalcFinalPriceAfterDiscount")]
        public PriceResultModel CalcFinalPriceAfterDiscount(
            float originalPrice,
            float discountRate)
        {
            float discountAmount = discountRate / 100 * originalPrice;
            float result = originalPrice - discountAmount;
            return new PriceResultModel() { Result = result };
        }

        /// <summary>
        /// Determines the tax amount based on a purchase price and a tax rate.
        /// </summary>
        /// <param name="purchasePrice">The purchase price.</param>
        /// <param name="taxRate">The tax rate as a percentage.</param>
        /// <returns>The calculated tax amount.</returns>
        [HttpGet("CalcTaxAmount")]
        public TaxResultModel CalcTaxAmount(
            float purchasePrice,
            float taxRate)
        {
            float result = purchasePrice * (taxRate / 100);
            return new TaxResultModel() { Result = result };
        }

        /// <summary>
        /// Calculates the tip amount for a bill based on a specified tip rate.
        /// </summary>
        /// <param name="billAmount">The total bill amount.</param>
        /// <param name="tipRate">The tip rate as a percentage.</param>
        /// <returns>The calculated tip amount.</returns>
        [HttpGet("CalcTipAmount")]
        public TipResultModel CalcTipAmount(
            float billAmount,
            float tipRate)
        {
            float result = billAmount * (tipRate / 100);
            return new TipResultModel() { Result = result };
        }

        /// <summary>
        /// Converts a fraction (numerator/denominator) to its percentage equivalent.
        /// </summary>
        /// <param name="numerator">The numerator of the fraction.</param>
        /// <param name="denominator">The denominator of the fraction.</param>
        /// <returns>The percentage representation of the fraction.</returns>
        [HttpGet("CalcFractionToPercentage")]
        public ResultModel CalcFractionToPercentage(
            float numerator,
            float denominator)
        {
            float result = (numerator / denominator) * 100;
            return new ResultModel() { Result = result };
        }

        /// <summary>
        /// Calculates the original price before tax was added, given the total price and tax rate.
        /// </summary>
        /// <param name="totalPrice">The total price including tax.</param>
        /// <param name="taxRate">The tax rate as a percentage.</param>
        /// <returns>The original price before tax.</returns>
        [HttpGet("CalcOriginalPriceBeforeTax")]
        public PriceResultModel CalcOriginalPriceBeforeTax(
            float totalPrice,
            float taxRate)
        {
            float result = totalPrice / (1 + (taxRate / 100));
            return new PriceResultModel() { Result = result };
        }

        /// <summary>
        /// Determines the percentage of a goal that has been achieved.
        /// </summary>
        /// <param name="amountAchieved">The amount achieved.</param>
        /// <param name="goal">The target goal amount.</param>
        /// <returns>The percentage of the goal achieved.</returns>
        [HttpGet("CalcPercentageAchieved")]
        public ResultModel CalcPercentageAchieved(
            float amountAchieved,
            float goal)
        {
            float result = (amountAchieved / goal) * 100;
            return new ResultModel() { Result = result };
        }

        /// <summary>
        /// Calculates what percentage a part is of a whole.
        /// </summary>
        /// <param name="part">The part value.</param>
        /// <param name="whole">The whole value.</param>
        /// <returns>The percentage that the part is of the whole.</returns>
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
