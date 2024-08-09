namespace Generics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intRange = new Range<int>(6, 10);
            Console.WriteLine(intRange.IsInRange(11));   
            Console.WriteLine(intRange.Length());       

            var doubleRange = new Range<double>(3.5, 7.2);
            Console.WriteLine(doubleRange.IsInRange(4.1)); 
            Console.WriteLine(doubleRange.Length());       
        }
    }
}
