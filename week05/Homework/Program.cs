class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("Sam I am", "Dr. Seuss");
        WritingAssignment a1 = new WritingAssignment("Joe Shmo", "American History", "Paul Reveres Journey");
        WritingAssignment a2 = new WritingAssignment("Jimmy", "Creative Assignment", "The Deepest Thoughts of my Mind");

        MathAssignment m1 = new MathAssignment("Joseph", "Addition", "4.04", "8-27");
        MathAssignment m2 = new MathAssignment("Benjamin", "Trigonometry ", "3.14", "5-36");

        Console.WriteLine(assign.GetSummary());

        Console.WriteLine(a1.GetSummary());
        Console.WriteLine(a1.GetWritingInfo());
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetWritingInfo());

        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());
        Console.WriteLine(m2.GetSummary());
        Console.WriteLine(m2.GetHomeworkList());
    }
}