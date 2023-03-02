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
        public static string REGEX_PIN = "^[a-zA-Z0-9]+[-.]?[a-zA-Z0-9]*@[a-zA-Z0-9]+(\\.[a-zA-Z]{2,}){1,2}\\.?[a-zA-Z]{0,2}$";

        public bool validate(string name)
        {
            return Regex.IsMatch(name, REGEX_PIN);
        }
    }
}



