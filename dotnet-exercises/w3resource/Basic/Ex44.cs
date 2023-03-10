using System.Text;
using System.Text.RegularExpressions;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to create a new string of every other character (odd position) from the first position of a given string. Go to the editor
Test Data:
Input a string : w3resource
Sample Output
wrsuc 
*/
public class Ex44 : IRunner
{
    public void Run()
    {
        Console.Write("Input a string: ");
        var input = Console.ReadLine();
        Console.WriteLine($"{DoAlgorithm(input)}");
        
    }
    

    private static string DoAlgorithm(string input)
    {
        StringBuilder output = new StringBuilder(input.Length / 2);
        for (int i = 0; i < input.Length; i += 2)
        {
            output.Append(input[i]);
        }

        return output.ToString();
    }
    


}