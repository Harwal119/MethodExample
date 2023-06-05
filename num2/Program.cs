// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Create a method GetMax() with two integer (int) parameters, that 
// returns maximal of the two numbers. Write a program that reads three 
// numbers from the console and prints the biggest of them. Use the 
// GetMax() method you just created. Write a test program that validates 
// that the methods works correctly.
GetMax(4, GetMax(7,8));

static int GetMax(int firstNum, int secondNum)
{
    int biggest;
    if(first > second)
    {
        biggest = first;
    }
    else
    {
        biggest = second;
    }
    return biggest;
}


