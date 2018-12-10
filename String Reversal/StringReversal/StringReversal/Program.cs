using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string ReverseThis = Console.ReadLine();

        Console.WriteLine("You entered: {0}", ReverseThis);

        string Reversed = "";
        int Index = ReverseThis.Length - 1;
        Console.WriteLine("Length is {0}", ReverseThis.Length);
        
        while (Index >= 0)
        {
            Reversed = Reversed + ReverseThis[Index];
            Index--;
        }

        Console.WriteLine("Reversed string: {0}", Reversed);
    }
}