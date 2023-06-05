// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// write a method that returns the English name of the last digit of a 
// given number. Example: for 512 prints "two"; for 1024  "four".

static void GetName(int number)
{
    switch(number % 10)
    {
        case 1:
        Console.WriteLine("One");
        break;
        case 2:
        Console.WriteLine("Two");
        break;
        case 3:
        Console.WriteLine("Three");
        break;
        case 4:
        Console.WriteLine("Four");
        break;
        case 5:
        Console.WriteLine("Five");
        break;
        case 6:
        Console.WriteLine("Six");
        break;
        case 7:
        Console.WriteLine("Seven");
        break;
        case 8:
        Console.WriteLine("Eight");
        break;
        case 9:
        Console.WriteLine("Nine");
        break;
        default:
        case 0:
        Console.WriteLine("Invalid Number");
        break;
        
       
    }
}

 GetName(1236);