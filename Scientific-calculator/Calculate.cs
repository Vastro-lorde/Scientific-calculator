using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scientific_calculator
{
    internal class Calculate
    {
        public static void Start()
        {
            int end = 0;
            while (end < 1)
            {
                Console.WriteLine(
                    "\n" +
                    "\n" +
                    "\n" +
                    "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<SPIRIT SCIENTIC CALCULATOR>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n" +
                    "\n" +
                    "CHOOSE A NUMBER TO PERFORM THAT OPERATION\n" +
                    "\n" +
                    "SIMPLE ARITHEMETIC                             TRIGNOMETRY\n" +
                    "1. addition                                    11. sine\n" +
                    "2. subtraction                                 12. cosine\n" +
                    "3. multiplication                              13. tan\n" +
                    "4. division                                    14. cosec\n" +
                    "5. modulo(remainder)                           15. sec\n" +
                    "6. square                                      16. cot\n" +
                    "7. square root\n" +
                    "8. cube\n" +
                    "9. cube root\n" +
                    "10. exponentials\n" +
                    "\n" +
                    "FACTORIAL                                      LOGARITHM\n" +
                    "17. factorial                                  19. log\n" +
                    "18. 10^x                                       20. ln\n" +
                    "21. EXIT"
                    );
                var InputNum = Console.ReadLine();
                if (String.IsNullOrEmpty(InputNum))
                {
                    Console.Clear();
                    Console.WriteLine("You have not input a number");
                    continue;
                }
                Regex rx = new Regex(@"^(\D)+$",
                      RegexOptions.Compiled | RegexOptions.IgnoreCase);

                if (rx.IsMatch(InputNum))
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input");
                    continue;
                }
                if (Convert.ToInt32(InputNum) == 21)
                {
                    end += 3;
                }
                static (double, double, string) binaryOperation(string action)
                {
                    Regex rx = new Regex(@"^(\D)+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    Console.WriteLine($"please input the number :");
                    var userInputa = Console.ReadLine();
                    Console.WriteLine("please input the number :");
                    var userInputb = Console.ReadLine();
                    if (String.IsNullOrEmpty(userInputa) || String.IsNullOrEmpty(userInputb))
                    {
                        Console.Clear();
                        Console.WriteLine("You have not input a number");
                        Start();
                    }
                    if (rx.IsMatch(userInputa) || rx.IsMatch(userInputb))
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect input");
                        Start();
                    }
                    double a = Convert.ToDouble(userInputa);
                    double b = Convert.ToDouble(userInputb);
                    return (a, b, action);
                }
                static double singleOperation()
                {
                    Regex rx = new Regex(@"^(\D)+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    Console.WriteLine($"please input the number :");
                    var userInputa = Console.ReadLine();
                    if (String.IsNullOrEmpty(userInputa))
                    {
                        Console.Clear();
                        Console.WriteLine("You have not input a number");
                        Start();
                    }
                    if (rx.IsMatch(userInputa))
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect input");
                        Start();
                    }
                    double a = Convert.ToDouble(userInputa);
                    return a;
                }
                switch (Convert.ToInt32(InputNum))
                {
                    case 1:
                        // addition
                        Console.Clear();
                        var (a, b, action) = binaryOperation("addition");
                        Console.Clear();
                        Console.WriteLine($"The {action} of {a} and {b} is {a + b}");
                        break;
                    case 2:
                        // subtraction
                        Console.Clear();
                        (a, b, action) = binaryOperation("subtraction");
                        Console.Clear();
                        Console.WriteLine($"The {action} of {a} and {b} is {a - b}");
                        break;
                    case 3:
                        // multiplication
                        Console.Clear();
                        (a, b, action) = binaryOperation("multiplication");
                        Console.Clear();
                        Console.WriteLine($"The multiplication of {a} and {b} is {a * b}");
                        break;
                    case 4:
                        // division
                        Console.Clear();
                        (a, b, action) = binaryOperation("division");
                        Console.Clear();
                        Console.WriteLine($"The {action} of {a} and {b} is {a / b}");
                        break;
                    case 5:
                        // modulo
                        Console.Clear();
                        (a, b, action) = binaryOperation("division");
                        Console.Clear();
                        Console.WriteLine($"The {action} of {a} and {b} is {a % b}");
                        break;
                    case 6:
                        // square
                        Console.Clear();
                        Console.WriteLine("please input the number to be Squared :");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"The square of {a} is {Math.Pow(a, 2)}");
                        break;
                    case 7:
                        // square root
                        Console.Clear();
                        Console.WriteLine("please input the number to check root :");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"The square root of {a} is {Math.Pow(a, 0.5)}");
                        break;
                    case 8:
                        // cube
                        Console.Clear();
                        Console.WriteLine("please input the number :");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"The cube of {a} is {Math.Pow(a, 3)}");
                        break;
                    case 9:
                        // cube root
                        Console.Clear();
                        Console.WriteLine("please input the number to check the cube root :");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"The cube root of {a} is {Math.Cbrt(a)}");
                        break;
                    case 10:
                        // exponential
                        Console.Clear();
                        (a, b, action) = binaryOperation("exponential");
                        Console.Clear();
                        Console.WriteLine($"The exponential of {a} to {b} is {Math.Pow(a, b)}");
                        break;
                    case 11:
                        // sine
                        Console.Clear();
                        Console.WriteLine("Convert to Sine, Input Number :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The Sine of {a} is {Math.Round(Math.Sin(a), 4)} in rads," +
                            $" { Math.Round(Math.Sin(a * Math.PI / 180), 2) } in Degrees and {Math.Round(Math.Sin(a * Math.PI / 200), 3)} in grads");
                        break;
                    case 12:
                        // cosine
                        Console.Clear();
                        Console.WriteLine("Convert to Cosine, Input Number :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The Cosine of {a} is {Math.Round(Math.Cos(a), 4)} in rads," +
                            $" { Math.Round(Math.Cos(a * Math.PI / 180), 2) } in Degrees and {Math.Round(Math.Cos(a * Math.PI / 200), 3)} in grads");
                        break;
                    case 13:
                        // tangent
                        Console.Clear();
                        Console.WriteLine("Convert to Tangent, Input Number :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The Tangent of {a} is {Math.Round(Math.Tan(a), 4)} in rads," +
                            $" { Math.Round(Math.Tan(a * Math.PI / 180), 2) } in Degrees and {Math.Round(Math.Tan(a * Math.PI / 200), 3)} in grads");
                        break;
                    case 14:
                        // cosec
                        Console.Clear();
                        Console.WriteLine("Convert to cosec, Input Number :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The Cosec of {a} is {1 / Math.Round(Math.Sin(a), 4)} in rads," +
                            $" {1 / Math.Round(Math.Sin(a * Math.PI / 180), 2)} in Degrees and {Math.Round(1 / Math.Round(Math.Sin(a * Math.PI / 200), 3), 2)} in grads");
                        break;
                    case 15:
                        // sec
                        Console.Clear();
                        Console.WriteLine("Convert to Sec, Input Number :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The Sec of {a} is {Math.Round(1 / Math.Cos(a), 4)} in rads," +
                            $" {1 / Math.Round(Math.Cos(a * Math.PI / 180), 2)} in Degrees and {Math.Round(1 / Math.Round(Math.Cos(a * Math.PI / 200), 3), 2)} in grads");
                        break;
                    case 16:
                        // cot
                        Console.Clear();
                        Console.WriteLine("Convert to Cot, Input Number :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The Cot of {a} is {Math.Round(1 / Math.Tan(a), 4)} in rads," +
                            $" {1 / Math.Round(Math.Tan(a * Math.PI / 180), 2)} in Degrees and {Math.Round(1 / Math.Round(Math.Tan(a * Math.PI / 200), 3), 2)} in grads");
                        break;
                    case 17:
                        // factorial
                        Console.Clear();
                        Console.WriteLine("Calculate factorial, Input Number :");
                        a = singleOperation();
                        for (double i = a - 1; i > 0; i--)
                        {
                            a *= i;
                        }
                        Console.Clear();
                        Console.WriteLine($"The Factorial is {a}");
                        break;
                    case 18:
                        // 10^x
                        Console.Clear();
                        Console.WriteLine("Input the number for 10 to be raised to :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The exponential of 10 to {a} is {Math.Pow(10, a)}");
                        break;
                    case 19:
                        // log
                        Console.Clear();
                        Console.WriteLine("First input the log number, then input the base");
                        (a, b, action) = binaryOperation("log");
                        Console.Clear();
                        Console.WriteLine($"The {action} of {a} to base {b} is {Math.Log(a, b)}");
                        break;
                    case 20:
                        // ln
                        Console.Clear();
                        Console.WriteLine("Input the number for E to be raised to :");
                        a = singleOperation();
                        Console.Clear();
                        Console.WriteLine($"The ln of {a} is {Math.Pow(Math.E, a)}");
                        break;
                    case 21:
                        // EXIT
                        Console.WriteLine("Thank you for donating your spirit");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Your choice is currently limited to the range of 1 to 16");
                        break;
                }
            }
        }
    }
}
