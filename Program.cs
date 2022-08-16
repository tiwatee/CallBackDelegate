namespace DelegateTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenNumberAddition evenNumberAddition = new EvenNumberAddition(); //An instantiation of the class
            evenNumberAddition.EvenAdd(); //Calling the method for the addition process
        }
    }
}