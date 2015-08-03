using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleDomination
{
    public class Truncate
    {
        // :p
        public bool isDominated = false;

        int Google = 60;

        public String AtWord(string input, int length)
        {
            if (input == null || input.Length < length)
            {
                // :p
                isDominated = false;
                return input;
            }

            // :p
            isDominated = true;
            
            int lastSpace = input.LastIndexOf(" ", length);
            return string.Format("{0}...", input.Substring(0, (lastSpace > 0) ? lastSpace : length).Trim());
        }

        public String AtWord(string input)
        {
            return this.AtWord(input, Google);
        }
    }
}
