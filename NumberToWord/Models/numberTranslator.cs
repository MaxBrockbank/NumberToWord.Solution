using System;
using System.Collections.Generic;


namespace NumberTranslator.Models
{
    public class Translator
    {
        public string UserNumber {get; set;}
        public char[] NumberToArray {get; set;}
        private static Dictionary<int, string> oneToNineteen = new Dictionary<int, string>(){};
        private static Dictionary<int, string> tenToNinety = new Dictionary<int, string>(){};
        private static Dictionary<int, string> hundredToNineHundred = new Dictionary<int, string>(){};
        private static Dictionary<int, string> thousandToNineThousand = new Dictionary<int, string>(){};

        public Translator (string number)
        {           
            // UserNumber = number;
            // NumberToArray = number.ToCharArray();
        }

    }
}

//BL goes here