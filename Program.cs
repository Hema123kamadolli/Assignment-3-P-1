using System;
 

namespace ConversionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string intStr = "42";  //Using TryParse TO Convert a string to an integer
            if (int.TryParse(intStr, out int intValue))
            {
                Console.WriteLine($"TryParse Result: {intValue}");
            }
            else
            {
                Console.WriteLine("TryParse Error: Invalid integer format.");
            }

           
            string doubleStr = "3.14";  // Using Convert to convert a string to a double with error handling
            try
            {
                double doubleValue = Convert.ToDouble(doubleStr);
                Console.WriteLine($"Convert Result: {doubleValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Convert Error: Invalid double format.");
            }

            
            string decimalStr = "123.456"; // Using Parse to convert a string to a decimal with error handling
            try
            {
                decimal decimalValue = decimal.Parse(decimalStr);
                Console.WriteLine($"Parse Result: {decimalValue}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Parse Error: Invalid decimal format.");
            }
            Console.ReadKey();
        }
    }
}
        
    

