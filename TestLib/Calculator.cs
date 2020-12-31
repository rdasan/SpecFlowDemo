using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

namespace TestLib
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        // private readonly HashSet<string> SeededFirmNames = new HashSet<string>()
        // {
        //     "American Bank Corp.",
        //     "American Bank Corporation",
        //     "American Trust Bank Corp"
        // };

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public string StringCat(string a, string b)
        {
            return $"{a} {b}";
        }

        public bool FullVerbatimRule(string firmName, string seededFirmName)
        {
            var seededFirmWithoutPunctuation = new string(seededFirmName.Where(c => !char.IsPunctuation(c)).ToArray());
            var firmWithoutPunctuation = new string(firmName.Where(c => !char.IsPunctuation(c)).ToArray());
            return seededFirmWithoutPunctuation.Equals(firmWithoutPunctuation, StringComparison.OrdinalIgnoreCase);
        }
        
    }
}