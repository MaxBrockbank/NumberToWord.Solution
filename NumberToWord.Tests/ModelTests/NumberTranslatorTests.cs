using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumberTranslator.Models;

namespace NumberTranslator.Tests
{
    [TestClass]
    public class TranslatorTests
    {
        [TestMethod]
        public void NumberTranslator_newObject_numberInstance()
        {
            string userInput = "101";
            Translator userNumber = new Translator(userInput);
            Assert.AreEqual(3, userNumber.NumberToArray.Length);
        }
    }
}