using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scientific_calculator
{
   public class Cal
    {
        public static string Addition(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The addition of {input1} and {input2} is {input1 + input2}";
            }
            else
            {
                 return "Please check your input, input numbers only";
            }
           
        }
        public static string Subtraction(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The subtraction of {input1} and {input2} is {input1 - input2}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Multiplication(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The multiplication of {input1} and {input2} is {input1 * input2}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Quotient(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The Quotient of {input1} and {input2} is {input1 / input2}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Modulo(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The Modulo of {input1} and {input2} is {input1 % input2}";
            }
            else
            {
                return "Please check your input, input reason numbers only";
            }

        }
        public static string Square(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The square of {input1} is {Math.Pow(input1, 2)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string SquareRoot(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The squareroot of {input1} is {Math.Pow(input1, 0.5)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Cube(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Cube of {input1} is {Math.Pow(input1, 3)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string CubeRoot(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Cuberoot of {input1} is {Math.Cbrt(input1)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Exponential(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The exponential of {input1} to {input2} is {Math.Pow(input1, input2)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Sine(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Sine of {input1} is {Math.Round(Math.Sin(input1), 4)} in rads," +
                       $" { Math.Round(Math.Sin(input1 * Math.PI / 180), 2) } in Degrees and {Math.Round(Math.Sin(input1 * Math.PI / 200), 3)} in grads";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Cosine(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Cosine of {input1} is {Math.Round(Math.Cos(input1), 4)} in rads," +
                       $" { Math.Round(Math.Cos(input1 * Math.PI / 180), 2) } in Degrees and {Math.Round(Math.Cos(input1 * Math.PI / 200), 3)} in grads";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Tangent(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Tangent of {input1} is {Math.Round(Math.Tan(input1), 4)} in rads," +
                       $" { Math.Round(Math.Tan(input1 * Math.PI / 180), 2) } in Degrees and {Math.Round(Math.Tan(input1 * Math.PI / 200), 3)} in grads";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Cosecant(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Cosec of {input1} is {1 / Math.Round(Math.Sin(input1), 4)} in rads," +
                       $" {1 / Math.Round(Math.Sin(input1 * Math.PI / 180), 2)} in Degrees and {Math.Round(1 / Math.Round(Math.Sin(input1 * Math.PI / 200), 3), 2)} in grads";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Secant(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Secant of {input1} is {1 / Math.Round(Math.Cos(input1), 4)} in rads," +
                       $" {1 / Math.Round(Math.Cos(input1 * Math.PI / 180), 2)} in Degrees and {Math.Round(1 / Math.Cos(input1 * Math.PI / 200), 2)} in grads";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Cotangent(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The Cotangent of {input1} is {1 / Math.Round(Math.Tan(input1), 4)} in rads," +
                       $" {1 / Math.Round(Math.Tan(input1 * Math.PI / 180), 2)} in Degrees and {Math.Round(1 / Math.Round(Math.Tan(input1 * Math.PI / 200), 3), 2)} in grads";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Factorial(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                for (long i = input1 - 1; i > 0; i--)
                {
                    input1 *= i;
                }
                return $"The Factorial is {input1}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string PowerOf10(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The exponential of 10 to {input1} is {Math.Pow(10, input1)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Log(string firstInput, string secondInput)
        {
            bool input = Validate.binaryValidation(firstInput, secondInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                long input2 = Convert.ToInt64(secondInput);
                return $"The log of {input1} to base {input2} is {Math.Log(input1, input2)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static string Ln(string firstInput)
        {
            bool input = Validate.singleValidation(firstInput);
            if (input)
            {
                long input1 = Convert.ToInt64(firstInput);
                return $"The ln of {input1} is {Math.Pow(Math.E, input1)}";
            }
            else
            {
                return "Please check your input, input numbers only";
            }

        }
        public static (string , string) TwoInputs()
        {
            Console.WriteLine($"please input the number :");
            var firstInput = Console.ReadLine();
            Console.WriteLine("please input the number :");
            var secondInput = Console.ReadLine();

            return (firstInput, secondInput);
        }
        public static string OneInput()
        {
            Console.WriteLine($"please input the number :");
            var firstInput = Console.ReadLine();
            return firstInput;
        }
    }
}
