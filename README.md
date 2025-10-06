## Percentage calculator project

https://perc-calc.appbuilder.dev/swagger/index.html

A simple Web API project, that provides endpoints for simple math calculations.

| **Endpoint**                                              | **HTTP Method** | **Parameters**                                  | **Description**                                                                                        |
| --------------------------------------------------------- | --------------- | ----------------------------------------------- | ------------------------------------------------------------------------------------------------------ |
| `/PercentageCalculations/CalcWhatIsXpercentOfY`           | `GET`           | `whatIs` (float), `ofWhat` (float)              | Calculates *X percent of Y*. Example: What is 20% of 150 → `30`.                                       |
| `/PercentageCalculations/CalcXisWhatPercentOfY`           | `GET`           | `whatIs` (float), `ofWhat` (float)              | Calculates *what percentage X is of Y*. Example: 30 is what % of 150 → `20%`.                          |
| `/PercentageCalculations/CalcWhatIsPercentChangeFromXtoY` | `GET`           | `whatIs` (float), `ofWhat` (float)              | Computes *percent change* from X to Y (increase or decrease). Example: from 100 to 120 → `20%`.        |
| `/PercentageCalculations/CalcPercentageChange`            | `GET`           | `oldValue` (float), `newValue` (float)          | Calculates *percentage difference* between an old and new value. Equivalent to `(new-old)/old × 100`.  |
| `/PercentageCalculations/CalcFinalPriceAfterDiscount`     | `GET`           | `originalPrice` (float), `discountRate` (float) | Returns the *final price* after applying a percentage discount. Example: 100 with 15% discount → `85`. |
| `/PercentageCalculations/CalcTaxAmount`                   | `GET`           | `purchasePrice` (float), `taxRate` (float)      | Calculates the *tax amount* based on a given rate. Example: 100 with 20% tax → `20`.                   |
| `/PercentageCalculations/CalcTipAmount`                   | `GET`           | `billAmount` (float), `tipRate` (float)         | Calculates the *tip amount* based on a given rate. Example: 100 with 10% tip → `10`.                   |
| `/PercentageCalculations/CalcFractionToPercentage`        | `GET`           | `numerator` (float), `denominator` (float)      | Converts a fraction into a percentage. Example: 1 / 4 → `25%`.                                         |
| `/PercentageCalculations/CalcOriginalPriceBeforeTax`      | `GET`           | `totalPrice` (float), `taxRate` (float)         | Determines the *price before tax* was applied. Example: total 120 with 20% tax → `100`.                |
| `/PercentageCalculations/CalcPercentageAchieved`          | `GET`           | `amountAchieved` (float), `goal` (float)        | Calculates *achievement percentage* relative to a goal. Example: 80 out of 100 → `80%`.                |
| `/PercentageCalculations/CalcRelativePercentage`          | `GET`           | `part` (float), `whole` (float)                 | Calculates *relative proportion* of a part to a whole in percentage. Example: 40 of 200 → `20%`.       |


Available here:

https://perc-calc.appbuilder.dev/swagger/index.html

![image](https://github.com/user-attachments/assets/33f46f1c-744f-4b55-bfde-33c4748867d0)
