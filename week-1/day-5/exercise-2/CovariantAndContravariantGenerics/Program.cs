using System.Security.AccessControl;
using System.IO;

namespace CovariantAndContravariantGenerics
{
    interface IProcessor<in TInput, out TResult>
    {
        TResult Process(TInput input);
    }

    class StringToIntProcessor : IProcessor<string, int>
    {
        // Implement Process method
        public int Process(string input)
        {
            return input.Length;
        }
    }

    class DoubleToStringProcessor : IProcessor<double, string>
    {
        // Implement Process method
        public string Process(double input)
        {
            return input.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate covariance and contravariance with IProcessor interface
            StringToIntProcessor stringToIntProcessor = new StringToIntProcessor();
            int result1 = stringToIntProcessor.Process("This is intresting");
            Console.WriteLine(result1);

            DoubleToStringProcessor doubleToIntProcessor = new DoubleToStringProcessor();
            Object result2 = doubleToIntProcessor.Process(36.1453);
            Console.WriteLine(result2);
        }
    }
}