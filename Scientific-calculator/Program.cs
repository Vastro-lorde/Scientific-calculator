// See https://aka.ms/new-console-template for more information

Console.WriteLine(
    "<<<<<<<<<<SPIRIT SCIENTIC CALCULATOR>>>>>>>>>>\n" + 
    "\n" +
    "CHOOSE A NUMBER TO PERFORM THAT OPERATION\n" + 
    "1. addition\n" +
    "2. subtraction\n" +
    "3. multiplication\n" +
    "4. division\n" +
    "5. modulo(remainder)\n" +
    "6. square\n" +
    "7. square root\n" +
    "8. cube\n" +
    "9. cube root\n" +
    "10. exponentials\n" +
    "\n" +
    "TRIGNOMETRY\n" +
    "11. sine\n" +
    "12. cosine\n" +
    "13. tan"
    );
var InputNum = Convert.ToDouble(Console.ReadLine());
var theType = InputNum.GetType().ToString();


static (double, double, string) binaryOperation(string action)
{
    Console.WriteLine($"please input the first number to be {action} :");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("please input the second number :");
    double b = Convert.ToDouble(Console.ReadLine());

    return (a, b, action);
}

//if (theType == "System.Double")
//{
  //  Console.WriteLine(theType);
//}
//else { Console.WriteLine("Wrong Input");

switch (InputNum)
{
    case 1:
        // addition
        var (a, b, action) = binaryOperation("addition");
        Console.WriteLine($"The {action} of {a} and {b} is {a + b}");
        break;
    case 2:
        // subtraction
        (a, b, action) = binaryOperation("subtraction");
        Console.WriteLine($"The {action} of {a} and {b} is {a - b}");
        break;
    case 3:
        // multiplication
        (a, b, action) = binaryOperation("multiplication");
        Console.WriteLine($"The multiplication of {a} and {b} is {a * b}");
        break;
    case 4:
        // division
        (a, b, action) = binaryOperation("division");
        Console.WriteLine($"The {action} of {a} and {b} is {a / b}");
        break;
    case 5:
        // modulo
        (a, b, action) = binaryOperation("division");
        Console.WriteLine($"The {action} of {a} and {b} is {a % b}");
        break;
    case 6:
        // square
        Console.WriteLine("please input the number to be Squared :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The square of {a} is {Math.Pow(a,2)}");
        break;
    case 7:
        // square root
        Console.WriteLine("please input the number to check root :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The square root of {a} is {Math.Pow(a, 0.5)}");
        break;
    case 8:
        // cube
        Console.WriteLine("please input the number :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The cube of {a} is {Math.Pow(a, 3)}");
        break;
    case 9:
        // cube root
        Console.WriteLine("please input the number to check the cube root :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The cube root of {a} is {Math.Cbrt(a)}");
        break;
    case 10:
        // exponential
        Console.WriteLine("please input the number :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("please input the power :");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The square of {a} is {Math.Pow(a, b)}");
        break;
    case 11:
        // sine
        Console.WriteLine("Convert to Sine, Input Number :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The Sine of {a} is {Math.Asin(a)}");
        break;
    case 12:
        // cosine
        Console.WriteLine("Convert to Cosine, Input Number :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The Cosine of {a} is {Math.Acos(a)}");
        break;
    case 13:
        // tangent
        Console.WriteLine("Convert to Tangent, Input Number :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The Tangent of {a} is {Math.Round(Math.Atan(a))} in radian and {Math.Round(Math.Atan(a)) * (180/Math.PI) }");
        break;
    default:
        Console.WriteLine("You chose none");
        break;
}
