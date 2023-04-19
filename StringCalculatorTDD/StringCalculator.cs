using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorTDD
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            string[] parts = numbers.Split(',');
            int sum = 0;

            foreach (string part in parts)
            {
                int number;
                bool isNumber = int.TryParse(part, out number);
                if (isNumber && number >= 0 && number <=1000)
                    sum += number;
            }
            return sum;
        }
    }
}
