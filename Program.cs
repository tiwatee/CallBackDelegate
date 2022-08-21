namespace DelegateTwo
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenNumberAddition evenNumberAddition = new EvenNumberAddition(); //An instantiation of the class

            CallbackDelegate callbackDelegate = new CallbackDelegate(evenNumberAddition.EvenNumAddCallback);

            //Calling the long process with the delegate as a parameter
            evenNumberAddition.EvenAdd(callbackDelegate);
        }
        
    }
}