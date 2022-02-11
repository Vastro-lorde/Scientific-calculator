using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scientific_calculator
{
    public class Calculate
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
                // Collect user input
                var InputNum = Console.ReadLine();

                
                if (Validate.singleValidation(InputNum))
                {
                    Console.Clear();
                    int inputNum = Convert.ToInt32(InputNum);
                    if (inputNum == 21)
                    {
                      end += 3;
                     }
                    
                    switch (inputNum)
                    {
                        case 1:
                            // addition
                            Console.Clear();
                            var (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Addition(firstInput, secondInput));
                            break;
                        case 2:
                            // subtraction
                            Console.Clear();
                            (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Subtraction(firstInput, secondInput));
                            break;
                        case 3:
                            // multiplication
                            Console.Clear();
                            (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Multiplication(firstInput,secondInput));
                            break;
                        case 4:
                            // division
                            Console.Clear();
                            (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Quotient(firstInput, secondInput));
                            break;
                        case 5:
                            // modulo
                            Console.Clear();
                            (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Modulo(firstInput, secondInput));
                            break;
                        case 6:
                            // square
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Square(firstInput));
                            break;
                        case 7:
                            // square root
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.SquareRoot(firstInput));
                            break;
                        case 8:
                            // cube
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Cube(firstInput));
                            break;
                        case 9:
                            // cube root
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.CubeRoot(firstInput));
                            break;
                        case 10:
                            // exponential
                            Console.Clear();
                            (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Exponential(firstInput,secondInput));
                            break;
                        case 11:
                            // sine
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Sine(firstInput));
                            break;
                        case 12:
                            // cosine
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Cosine(firstInput));
                            break;
                        case 13:
                            // tangent
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Tangent(firstInput));
                            break;
                        case 14:
                            // cosec
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Cosecant(firstInput));
                            break;
                        case 15:
                            // sec
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Secant(firstInput));
                            break;
                        case 16:
                            // cot
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Cotangent(firstInput));
                            break;
                        case 17:
                            // factorial
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Factorial(firstInput));
                            break;
                        case 18:
                            // 10^x
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.PowerOf10(firstInput));
                            break;
                        case 19:
                            // log
                            Console.Clear();
                            (firstInput, secondInput) = Cal.TwoInputs();
                            Console.WriteLine(Cal.Log(firstInput,secondInput));
                            break;
                        case 20:
                            // ln
                            Console.Clear();
                            firstInput = Cal.OneInput();
                            Console.WriteLine(Cal.Ln(firstInput));
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
                else
                {
                    Console.Clear();
                    Console.WriteLine("What are you doing?");
                }
            }
        }
    }
}
