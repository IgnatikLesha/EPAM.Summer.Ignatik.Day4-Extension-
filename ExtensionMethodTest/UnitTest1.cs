using System;
using System.Collections.Generic;
using ExtensionMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ExtensionMethodTest
{

    [TestFixture]
    public class DoubleExtensionTests
    {
        [TestCaseSource("Data")]
        public string Format_Tests(double x)
        {
            return ExtensionForDouble.Performance(x);
        }
        public IEnumerable<TestCaseData> Data()
        {
            yield return new TestCaseData(123.4).Returns("0100000001011110110110011001100110011001100110011001100110011010");
            yield return new TestCaseData(0.00000001).Returns("0011111001000101011110011000111011100010001100001000110000111010");
            yield return new TestCaseData(12365625.265554654).Returns("0100000101100111100101011110011100101000011111110110110001111001");
            yield return new TestCaseData(0.0).Returns("0000000000000000000000000000000000000000000000000000000000000000");
        }
    }
}
