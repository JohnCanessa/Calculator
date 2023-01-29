namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // **** initialization ****
            var done = false;
            double a = 0.0;
            double b = 0.0;
            string? str = null;

            // **** instantiate a calculator ****
            Calculator calc = new Calculator();

            // **** loop until done ****
            while (!done)
            {

                // **** ****
                Console.WriteLine("\n**** Simple Calculator ****\n");

                // **** menu ****
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine();
                Console.WriteLine("-1. Quit");

                // **** select option ****
                Console.Write("\n>>> selection: ");
                int selection = -1;
                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Main <<< unexpected selection: {0}", selection);
                    continue;
                }

                // **** check if done ****
                if (selection == -1)
                {
                    done = true;
                    continue;
                }

                // **** prompt for arguments (if needed) ****
                if (selection >= 1 && selection <= 4)
                {

                    // **** prompt for and get first argument ****
                    Console.Write(">>> a: ");
                    str = Console.ReadLine();
                    if (!IsValidDouble(str))
                    {
                        Console.WriteLine("Main <<< unexpected a: {0}", str);
                        continue;
                    }
                    double.TryParse(str, out a);

                    // **** prompt for and get second argument ****
                    Console.Write(">>> b: ");
                    str = Console.ReadLine();
                    if (!IsValidDouble(str))
                    {
                        Console.WriteLine("Main <<< unexpected b: {0}", str);
                        continue;
                    }
                    double.TryParse(str, out b);
                }
                else
                {
                    Console.WriteLine("Main <<< unexpected selection: {0}", selection);
                    continue;
                }

                // **** perform operation ****
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("<<< r: {0}", calc.add(a, b));
                        break;

                    case 2:
                        Console.WriteLine("<<< r: {0}", calc.subtract(a, b));
                        break;

                    case 3:
                        Console.WriteLine("<<< r: {0}", calc.multiply(a, b));
                        break;

                    case 4:
                        Console.WriteLine("<<< r: {0}", calc.divide(a, b));
                        break;
                }
            }
        }


        /// <summary>
        /// Determine if the string holds a valid double.
        /// If so returns true.
        /// </summary>
        /// <param name="ValueToTest"></param>
        /// <returns></returns>
        private static bool IsValidDouble(string? ValueToTest)
        {
            if (ValueToTest == null)
            {
                return false;
            }
            return double.TryParse(ValueToTest, out double d) && !(double.IsNaN(d) || double.IsInfinity(d));
        }
    }
}