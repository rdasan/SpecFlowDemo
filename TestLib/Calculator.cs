using System;
using System.Runtime.Versioning;

namespace TestLib
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public string StringCat(string a, string b)
        {
            return $"{a} {b}";
        }
    }
}