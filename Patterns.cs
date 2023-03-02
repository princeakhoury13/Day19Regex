using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19Regex
{
    public class Patterns
    {
        public static string REGEX_PIN = "^[A-Z]{1}[a-z]{2,}$";

        public bool validate(string name)
        {
            return Regex.IsMatch(name, REGEX_PIN);
        }
    }
}
