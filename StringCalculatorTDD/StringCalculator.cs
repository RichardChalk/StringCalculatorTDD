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

                // Försök att omvandla texten (part) till ett heltal och
                // spara resultatet i variabeln 'number'
                // 'out' används för att skicka tillbaka ett extra
                // värde från en metod.
                // Utan 'out' kan du inte få ut själva siffran –
                // bara om det lyckades eller inte.
                // Det är alltså ett sätt att returnera två saker på en gång:
                bool isNumber = int.TryParse(part, out number);
                if (isNumber && number >= 0 && number <=1000)
                    sum += number;
            }
            return sum;
        }
    }
}
