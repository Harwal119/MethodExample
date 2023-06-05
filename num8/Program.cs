// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Write a method that finds the biggest element of an array. Use that 
// method to implement sorting in descending order.
static int[] GetBiggest(int[] myArray)
{
    int temp = 0;
    

    for(int i = 0; i < myArray.Length - 1; i++)
    {
        for(int j = i; j < myArray.Length; j++)
        {
           if(myArray[i] < myArray[j])
           {
                temp = myArray[i];
                myArray[i] = myArray[j];
                myArray[j] = temp;
           }

        }
        
    }

   return myArray;

}
int[] myArray={1,6,8,3,5,4};
GetBiggest(myArray);
foreach(int num in myArray)
{
    Console.WriteLine(num);
}





