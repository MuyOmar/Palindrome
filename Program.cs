using System;
using System.Text;


// Making a simple palindrome application that checks a user input sentence. 
// Omar Muy

//Let's make a tuple and have it return 2 values
(bool, int) palinedromeChecker(string str)
{

    string exStr;

    //Convert the string to upper
    exStr = str.ToUpper();
    
    //Use stringbuilder to strip out punctuation so that IamSam is the same as mas m aI    OR     racecar  is the same as   race car

    var stringb = new StringBuilder();

    foreach(char c in exStr)
    {
        //Add chars to builder if not punctuation or whitespace
        if(!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
        {
            stringb.Append(c);
        }

    }
    //Convert builder to finished string
    exStr = stringb.ToString();

    //Time for comparisons....
    int i = 0, j = exStr.Length-1;
    //When index's meet at the middle means that they both are equal and thus are palindromes...

    while (i <= j)
    {
        // Not the same? Not a palindrome, return a false bool value and then 0 for the int.
        if (exStr[i] != exStr[j])
        {
            return (false, 0);
        }
        // Now to update the counters and try again
        i++;
        j--;
    }
    return (true, str.Length);
}

//Now to use the function
string inputStr = "";
//Make a tuple
(bool b, int l) res;
Console.WriteLine("Enter a string: ");
while(inputStr != "exit")
{
    // Take user input into the empty string...
    inputStr = Console.ReadLine();
    //Check for exit again to exit the program. 
    if(inputStr != "exit")
    {
        //Output 
        res = palinedromeChecker(inputStr);
        Console.WriteLine($"Palindrome: {res.b}, Length: {res.l}");
    }
}