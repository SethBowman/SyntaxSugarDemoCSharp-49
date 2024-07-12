namespace SyntaxSugarDemoCSharp_49;

class Program
{
    static void Main(string[] args)
    {
        //Explicit typing
        int number = 10;
        string word;
        
        //Inferred typing
        var myVariable = "";
        
        //Inline if (ternary operator)
        var age = 10;

        Console.WriteLine(age >= 18 ? "You're an adult" : age < 5 ? "You're a young child" : "You're a minor");
        
        //String interpolation vs concatenation
        var middleInitial = 'S';

        Console.WriteLine($"Brandon {middleInitial} Bowman");
        Console.WriteLine("Brandon" + " " + middleInitial + " " + "Bowman");

    }
}
