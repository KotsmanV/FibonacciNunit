using NUnit.Framework;
using FibonacciNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNunit.Test
{
    [TestFixture]
    class Fibonacci
    {
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(5,3)]
        [TestCase(8,4)]
        public void TestFibonacci(double expected, double input)
        {
            Assert.AreEqual(expected, FiboNumbers.FiboNext(input));
        }


    }
}
