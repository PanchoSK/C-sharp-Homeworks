//Task 1 - Real calculator

Console.WriteLine("Enter first number:");
bool firstSuccess = double.TryParse(Console.ReadLine(), out double firstNumber);
if (!firstSuccess)
{
    Console.WriteLine("Please enter valid operator!");
    return;
}
Console.WriteLine("Enter second number");
bool secondSuccess = double.TryParse(Console.ReadLine(), out double secondNumber);
if (!secondSuccess)
{
    Console.WriteLine("Please enter valid operator!");
    return;
}
Console.WriteLine("Enter operator (+, -, *, /)");
bool thirdSuccess = char.TryParse(Console.ReadLine(), out char userOperator);
if(!thirdSuccess)
{
    Console.WriteLine("Please enter valid operator");
    return;
}
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
    Console.WriteLine($"Your resulit is:" + result);
