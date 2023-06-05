// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
PrintReverse(456);

static void PrintReverse(int num)
{
    int reverse = 0;
    int reminder = 0;
    while(num > 0)
    {
        reminder = num % 10;
        num = num / 10;
        reverse = (reverse * 10) + reminder;
    }
    Console.WriteLine(reverse); 
}

