//Task 1 - Real calculator

Console.WriteLine("Enter first number:");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter second number");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter operator (+, -, *, /)");
char userOperator = Convert.ToChar(Console.ReadLine());
double result = 0;
bool correct = true;
switch (userOperator)
{
    case '+':
        result = firstNumber + secondNumber;
        break;
    case '-':
        result = firstNumber - secondNumber;
        break;
    case '*':
        result = firstNumber * secondNumber;
        break;
    case '/':
        if (secondNumber != 0)
            result = firstNumber / secondNumber;
        else
        {
            Console.WriteLine("Error, choose other number than 0");
            correct = false;
        }
        break;
    default:
        Console.WriteLine("Error, choose valid operator");
        correct = false;
        break;
}

if (correct)
    Console.WriteLine($"Your resulit is:"+result);
