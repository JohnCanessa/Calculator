using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorEvaluator
    {

        // **** ****
        private readonly IValidateArguments _validator;


        /// <summary>
        /// Constructor.
        /// Note we pass an interface as an argument.
        /// </summary>
        /// <param name="validator"></param>
        /// <returns></returns>
        public CalculatorEvaluator(IValidateArguments validator)
        {
            //_validator = validator;
            _validator = validator ?? throw new System.ArgumentNullException(nameof(validator));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="calcApp"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public double Evaluate(CalculatorApplication application)
        {

            // **** ****
            var isValid = _validator.IsValid(application);

            // **** ****
            if (!isValid)
            {
                throw new ArgumentException("arguments are not valid");
            }

            // **** for ease of use ****
            double firstOp = application.firstOp;
            double secondOp = application.secondOp;

            // **** compute and return result ****
            switch (application.op)
            {
                case "+":
                    return firstOp + secondOp;

                case "-":
                    return firstOp - secondOp;

                case "*":
                    return firstOp * secondOp;

                case "/":
                    try
                    {
                        return firstOp / secondOp;
                    }
                    catch (DivideByZeroException)
                    {
                        throw new DivideByZeroException("divide by 0");
                    }

                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
