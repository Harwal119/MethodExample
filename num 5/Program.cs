// Write a method that checks whether an element, from a certain position 
// in an array is greater than its two neighbors. Test whether the 
// method works correctly

int[] numbers = {2,2,3,4,5,7,4,6};
Console.WriteLine(GreaterThanNeighbouringNumbers(numbers, 1));

static bool GreaterThanNeighbouringNumbers(int[] numbers, int position)
{
    bool isGreater = false;
    if(position > 0 && position < numbers.Length - 1)
    {
        if((numbers[position] > numbers[position - 1]) && (numbers[position] > numbers[position + 1]))
        {
            isGreater = true;
        }
    
    }
    return isGreater; 
}