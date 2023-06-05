// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// THE Equals Method;;
// string asd = "Shakira";
// string afa = "Kalid";
// bool ffa = asd.Equals(afa);

// Console.WriteLine(ffa);

// string num1 = "Aca";
// string num2 = "Ada";
// Console.WriteLine(num1.Equals(num2));

// string var = "ADA";
// string ref = "adA";
// bool result = var.Equals(ref,StringComparison.CurrentCultureIgnoreCase);
// Console.WriteLine(result);

// string var = "ada";
// string ref = "ADA";
// Console.WriteLine(var.ToUpper(),ref);
// bool result = Equals(var.ToUpper(),ref);
// Console.WriteLine(result);

// string vee = "Ada";
// string vas = "ada";
// Console.WriteLine(vee.CompareTo(vas));

// string name = "alpha";
// string name1 = "sCore";
// Console.WriteLine(string.Compare(name1,name));

// string book = "Introduction to C# book";
// int index = book.IndexOf("C#");
// Console.WriteLine(index);

// string quote = "The main intent of the \"Intro C#\"" + "book is to introduce the C# programing to newbies.";
// string keyword = "C#";
// int index = quote.IndexOf(keyword);
// while(index != -1)
// {
//     // Console.WriteLine($"The keyword {keyword} is found at index {index}");/
//     // index = quote.IndexOf(keyword,index + 1);
// }

// string filData = " \n\n David Alein ";
// Console.WriteLine(filData);
// string reduce = filData.Trim();
// Console.WriteLine(reduce);

// string fileData = " 111 % # David Alien @ &";
// char[] trimChars = new char[] {'1','%','#','@','&', ' ' };
// string reduced = fileData.Trim(trimChars);
// Console.WriteLine(reduced);

// string doc = "Hello some@gmail.com, " + " have been calling you since buh u did not pick my call thats not fair seriously. ";
// string replace = doc.Replace("some@gmail.com", "Darling");
// Console.WriteLine(replace);

// string doc = "Hello some@gmail.com, " + " YOU ARE BADBOY nor THUG .";
// string replace = doc.Replace("some@gmail.com", "Ope");
// Console.WriteLine(replace);

// string text = "1234";
// int convert = int.Parse(text);
// Console.WriteLine(convert);

// string text = "False";
// bool var = bool.Parse(text);
// Console.WriteLine(var);

// Math Class;
// int maximum = Math.Max(7,9);
// Console.WriteLine(maximum);

// Console.WriteLine("Enter a number of your choice");
// double num = double.Parse(Console.ReadLine());
// Console.WriteLine("Enter another number");
// double num2 = double.Parse(Console.ReadLine());
// double maximum = Math.Max(num,num2)*2;
// Console.Write($"The maximum is {maximum}");

// Console.Write("Enter a number of your choice:");
// double num = double.Parse(Console.ReadLine());
// Console.Write("Enter another number:");
// double num2 = double.Parse(Console.ReadLine());
// double maxii = Math.Max(num,num2);
// Console.WriteLine(maxii);
// Console.Write("Enter another please:");
// double num3 = double.Parse(Console.ReadLine());
// Console.Write("Enter the last num:");
// double num4 = double.Parse(Console.ReadLine());
// double maxic = Math.Max(num3,num4);
// Console.WriteLine(maxic);
// double maximum = Math.Max(maxii,maxic);
// Console.WriteLine("The maximum is " + maximum);

// Console.Write("Enter a number of your choice:");
// double num = double.Parse(Console.ReadLine());
// Console.Write("Enter another number:");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine(Math.Pow(num,num2));

// Console.Write("Enter a number of your choice:");
// double num = double.Parse(Console.ReadLine());
// Console.Write("Enter another number:");
// double num2 = double.Parse(Console.ReadLine());
// double different = (num - num2);
// double action = Math.Abs(different);
// Console.WriteLine("The different is " + action);

// Console.Write(Math.Round(4.76));
// Console.Write(Math.Ceiling(4.00));
// Console.Write(Math.Floor(4.76));


// Console.WriteLine(Math.Sqrt(36));

// Random random = new Random();
// int num = random.Next(50,60);
// Console.WriteLine(num);

// Console.Write("pls enter your guess:");
// int guess = int.Parse(Console.ReadLine());
// Random rand = new Random();
// int magicNum = rand.Next(1,3);
// if(guess == magicNum)
// {
//     Console.WriteLine("Awsome you are a nice player");

// }
// else
// {
//     Console.WriteLine("Try again later");
// }

Random rand = new Random();
int num = rand.Next(1,9);
int num2 = rand .Next(5,9);
int num3 = rand.Next(3,7);

int answer = (num + num2)*num3;
string question1 = $"({num} + {num2}) * {num3}";




