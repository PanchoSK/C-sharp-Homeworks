// Task 3 - Swap Numbers app

Console.WriteLine("Enter your first number:");
int firstNumber = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter your second number:");
int secondNumber = Convert.ToInt16(Console.ReadLine());

int intVar = firstNumber;
firstNumber = secondNumber;
secondNumber = intVar;
Console.Read();
Console.WriteLine("Swapped values");
Console.WriteLine($"New value of first number is" +  " " + firstNumber + " " + "and new value of second number is" + " "+secondNumber);