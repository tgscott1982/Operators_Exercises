#region Exercise 1
using OperatorExercises;
int a = 17;
int b = 4;
int quotient = a / b;
int remainder = a % b;
int sum = a + b;
int dif = a - b;
int prod = a * b;

if (a == 17 && b == 4);
{
    Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
}
Console.WriteLine($"The sum is {sum}.");
Console.WriteLine($"The difference is {dif}.");
Console.WriteLine($"The product is {prod}.");



#endregion



#region Exercise 2


Console.WriteLine("\nWhat is the radius of your circle?");

var radius = double.Parse(Console.ReadLine());

double calculatedArea = OperatorExercises.Operator.AreaOfCircle(radius);

Console.WriteLine($"\nThe area of a circle with the radis of {radius} is {calculatedArea}.");




#endregion


