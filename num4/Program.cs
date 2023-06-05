// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 4. Write a method that finds how many times certain number can be 
// found in a given array. Write a program to test that the method works 
// correctly.

static int FindsNumberOfTimesNumberIsFound(int[] numbers, int num)
{
    int count = 0;
    for(int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] > num)
        {
            count++;
        } 
    }
    return count;
}

int[] asd = {6,8,4,4,3,9};
Console.WriteLine(FindsNumberOfTimesNumberIsFound(asd, 4));
