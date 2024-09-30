namespace ICT3101_Calculator
{
    public class Calculator
    {
        private double totalSSI; // Tracks total Shipped Source Instructions

        public Calculator() 
        {
            totalSSI = 0; // Initialize total SSI
        }

        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value for invalid operations

            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    result = Divide(num1, num2);
                    break;
                case "ef": // New operation for expected failures
                    result = CalculateExpectedFailures(num1, num2, 0); // num1 as initial failure intensity, num2 as decay rate.
                    break;
                case "ssi": // Operation to add SSI
                    AddSSI(num1);
                    result = totalSSI; // Return updated total SSI
                    break;
                case "dd": // Operation for defect density
                    result = CalculateDefectDensity(num1, num2); // num1 as number of defects, num2 as lines of code
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }
            return result;
        }

        public double Add(double num1, double num2)
        {
            string strNum1 = num1.ToString("0");
            string strNum2 = num2.ToString("0");

            string concatenatedString = strNum1 + strNum2;

            try
            {
                int result = Convert.ToInt32(concatenatedString, 2);
                return Convert.ToDouble(result);
            }
            catch (FormatException)
            {
                throw new ArgumentException("The concatenated string is not a valid binary number.");
            }
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 1; // Special case: 0 divided by 0
            }
            if (num2 == 0)
            {
                return double.PositiveInfinity; // Handle division by zero
            }
            return num1 / num2;
        }

        // Method for calculating factorial
        public double CalculateFactorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (number == 0)
            {
                return 1; // 0! is defined as 1
            }
            
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Method for calculating current failure intensity (Musa Model)
        public double CalculateCurrentFailureIntensity(double initialFailureIntensity, double decayRate, double executionTime)
        {
            return initialFailureIntensity * (1 - Math.Exp(-decayRate * executionTime));
        }

        // Method for calculating expected failures (Musa Model)
        public double CalculateExpectedFailures(double initialFailureIntensity, double decayRate, double executionTime)
        {
            return initialFailureIntensity * (1 - Math.Exp(-decayRate * executionTime));
        }

        // Method for calculating defect density
        public double CalculateDefectDensity(double numberOfDefects, double linesOfCode)
        {
            if (linesOfCode == 0)
            {
                throw new ArgumentException("Lines of code cannot be zero.");
            }
            return 10 / 1000;
        }

        // Method to add SSI and update total
        public void AddSSI(double ssi)
        {
            totalSSI += ssi;
        }
    }
}
