// See https://aka.ms/new-console-template for more information
using Matrix = RotateMatrix.RotateMatrix;
Console.WriteLine("Hello, World!");


Matrix RotateMatrix = new Matrix();
RotateMatrix.printMessage += PrintMessage;

Console.WriteLine(RotateMatrix.LogMatrix(RotateMatrix.matrix));

Console.WriteLine("Start Rotating --------------------------");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

RotateMatrix.Rotate(RotateMatrix.matrix);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("End Rotating --------------------------");


Console.ReadKey();

void PrintMessage(string message)
{
    Console.WriteLine(message);
}

