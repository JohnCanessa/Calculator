namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **** ****
            Console.WriteLine("**** Simple Calculator ****\n");

            // **** ****
            Calculator calc = new Calculator();

            // **** menu ****
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            // **** select option ****
            Console.Write("\n>>> selection: ");
            var selection = Console.ReadLine();

            // ???? ????
            Console.WriteLine("Main <<< selection: {0}", selection);
        }
    }
}