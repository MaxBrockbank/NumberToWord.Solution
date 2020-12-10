using System;
using System.Collections.Generic;


namespace NumberTranslator.Models
{
    public class Translator
    {
        public string UserNumber {get; set;}
        public char[] NumberToArray {get; set;}
        List<Dictionary> numberDictionaries = new List<Dictionary> {};
        private static Dictionary<string, string> oneToTen = new Dictionary<string, string>(){ {"1", "one"}, {"2", "two"}, {"3", "three"}, {"4", "four"}, {"5", "five"}, {"6", "six"}, {"7", "seven"}, {"8", "eight"}, {"9", "nine"}, {"10", "ten"}}; //9
        private static Dictionary<string, string> teens = new Dictionary<string, string> <string, string>() {
            
        }; 
        private static Dictionary<string, string> tenToNinety = new Dictionary<string, string>(){};
        private static Dictionary<string, string> hundredToNineHundred = new Dictionary<string, string>(){};
        private static Dictionary<string, string> thousandToNineThousand = new Dictionary<string, string>(){};

        public Translator (string number)
        {           
            UserNumber = number;
            NumberToArray = number.ToCharArray();
        }

        public DigitToWords ()
        {
            int numLength = NumberToArray.Length; // 323 = 3
            string[] numberInWords = new string[numLength];
            for(int element = 0; element < numLength; element ++)
            {
                if(element == (numLength-2) && (numLength-2 = 1))
                {
                    //dict = list[teen]
                    // word = dict[Num[Element]]
                    //return arry;
                }
                else
                {
                    Dictionary<string, string> current = numberDictionaries[numLength-1];
                    string word = current[NumberToArray[element]];
                    numberInWords[element] = word;
                    numLength -=1;
                }
            }
            return String.Join(" ", numberInWords);
        }

    }
}

//BL goes here