using Microsoft.VisualStudio.TestTools.UnitTesting;
using PairedProgramLibrary;
using System;

namespace PairedProgramMSTest {
    [TestClass]
    public class UnitTest1 {

        Class1 functions = null;

        [TestInitialize]
        public void Setup() {
            functions = new Class1();
        }
        [TestMethod]
        public void Testclear() {
            
        }
        [TestMethod]
        public void TestAdd() {
            var answer = functions.Add(0,5);
            Assert.AreEqual(5, answer);

            answer = functions.Add(7, 6);
            Assert.AreEqual(13, answer);

            answer = functions.Add(-1, -5);
            Assert.AreEqual(-6, answer);
        }
        [TestMethod]
        public void TestSubtract() {
            var answer = functions.Subtract(5,3);
            Assert.AreEqual(2, answer);

            answer = functions.Subtract(0, -1);
            Assert.AreEqual(1, answer);

            answer = functions.Subtract(-3, -2);
            Assert.AreEqual(-1, answer);
        }
        [TestMethod]
        public void TestMultiply() {
            var answer = functions.Multiply(2,7);
            Assert.AreEqual(14, answer);

            answer = functions.Multiply(0, 51654);
            Assert.AreEqual(0, answer);

            answer = functions.Multiply(-3, 7);
            Assert.AreEqual(-21, answer);
            
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivide() {
            var answer = functions.Divide(14,2);
            Assert.AreEqual(7, answer);

            answer = functions.Divide(5,2);
            Assert.AreEqual(2, answer);

            answer = functions.Divide(874, 0);
            Assert.AreNotEqual(0, answer);
        }

    }
}
