using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSiSP_Lab1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IContravariation<ChildClass> obj = new Contravariation<BaseClass<string>>();
        }

        [TestMethod]
        public void TestMethod2()
        {
            ICovariation<BaseClass<string>> obj = new Covariation<ChildClass>();
        }

        [TestMethod]
        //[ExpectedException(typeof())]
        public void TestMethod3()
        {
            IContravariation<ChildClass> obj = new Contravariation<BaseClass<string>>();
            obj = (Contravariation<ChildClass>)obj;
        }

        [TestMethod]
       // [ExpectedException(typeof())]
        public void TestMethod4()
        {
            ICovariation<BaseClass<string>> obj = new Covariation<ChildClass>();
            obj = (Covariation<ChildClass>)obj;
        }
    }
}
