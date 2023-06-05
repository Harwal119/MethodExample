// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Write a method that returns the position of the first occurrence of an 
// element from an array, such that it is greater than its two neighbors 
// simultaneously. Otherwise the result must be -1.

// int[] asd = {1,5,3,4,7,6,9};
// Console.WriteLine(NumberOfOccrrence(asd));

static int NumberOfOccrrence(int[] num)
{
    int g = -1;
  for(int i = 1; i < num.Length-1;i++)
  {
    if(num[i] > num[i-1] && num[i] > num[i+1])
    {
        g = i;
        break;
    }
  }
     return g;
}

// Console.WriteLine(NumberOfOccrrence);


