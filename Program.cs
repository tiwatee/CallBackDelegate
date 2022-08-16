namespace DelegateTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenNumberAddition evenNumberAddition = new EvenNumberAddition();

            EvenNumberAddition.EvenAdd(CompletedRange);
        }


        static void CompletedRange (int Num)
        {
            Console.WriteLine($"1 to {Num} completed");
        }
    }
}