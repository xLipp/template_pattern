using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamesChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesChecker.Tests
{
    [TestClass()]
    public class TestingSeed
    {
        [TestMethod()]
        public void Check_19Symbols_True() 
        {
            string tname = "4261048955251621689";
            bool expected = true;
            bool actual = SCheck.nametemp(tname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_22Symbols_False()
        {
            string tname = "4072582545456389756128";
            bool expected = false;
            bool actual = SCheck.nametemp(tname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_Withletters_False()
        {
            string tname = "4O725825451961498";
            bool expected = false;
            bool actual = SCheck.nametemp(tname);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_Withspecsymbols_False()
        {
            string tname = "402376538433179583:";
            bool expected = false;
            bool actual = SCheck.nametemp(tname);
            Assert.AreEqual(expected, actual);
        }
    }
}