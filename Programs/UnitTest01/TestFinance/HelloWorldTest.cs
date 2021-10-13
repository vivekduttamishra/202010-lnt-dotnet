using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFinance
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("I am Test 1");
        }

        public void Test2()
        {
            Console.WriteLine("I am Test 2");
        }

        [TestMethod]
        public void NotATest()
        {
            Console.WriteLine("I am Not a Test");
        }


    }
}
