#region Exercise 1
using OperatorExercises;
int a = 17;
int b = 4;
int sum = a += b;
Console.WriteLine($"The sum is {sum}.");
int c = 17;
int d = 4;
int dif = c -= d;
Console.WriteLine($"The difference is {dif}.");
int e = 17;
int f = 4;
int prod = e *= f;
Console.WriteLine($"The product is {prod}.");
int g = 17;
int h = 4;
int quotient = g / h;
int remainder = g % h;

if (g == 17 && h == 4)
{
    
    Console.WriteLine($"{g}/{h} is {quotient} remainder {remainder}");
}
else
{
    Console.WriteLine("Your lack of maths is disturbing...");
}





#endregion



#region Exercise 2


Console.WriteLine("\nWhat is the radius of your circle?");

var radius = double.Parse(Console.ReadLine());

double calculatedArea = OperatorExercises.Operator.AreaOfCircle(radius);

Console.WriteLine($"\nThe area of a circle with the radis of {radius} is {calculatedArea}.");




#endregion


