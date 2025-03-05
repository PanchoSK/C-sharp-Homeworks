// Task 2 Average-Number app

Console.WriteLine("Enter your first number:");
double numberOne = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your second number:");
double numberTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your third number:");
double numberThree = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your fourth number:");
double numberFour = Convert.ToDouble(Console.ReadLine());

double averageNumber = (numberOne + numberTwo + numberThree + numberFour) / 4;

Console.WriteLine($"The average number of all four number is:" + averageNumber);

//se nadevam deka nema problem sto e vo double