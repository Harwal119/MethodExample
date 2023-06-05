// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int[] nums = {2,7,3,-9,5,421,8};

Console.WriteLine(String.Join(' ', nums));

for(int i = 0; i <= 6; i ++)
{
    for(int j = i+1; j <= 6; j++)
    {
        if(nums[i] < nums[j])
        {
            int a = nums[i];
            nums[i] = nums[j];
            nums[j] = a;
        }
    }
}

Console.WriteLine(string.Join(' ', nums));

