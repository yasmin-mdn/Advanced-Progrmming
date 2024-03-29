﻿using System;
using A5;
using ExceptionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//all passed
namespace A5Tests
{

    [TestClass]
    public class OutOfMemoryExceptionTests
    {
        #region OutOfMemoryException
        [TestMethod]
        public void TestNoOutOfMemoryException()///fail
        {
            ExceptionHandler eh = new ExceptionHandler(
                "10", false);
            eh.OutOfMemoryExceptionMethod();
            Assert.AreEqual(eh.ErrorMsg, null);
        }

        [TestMethod]
        [ExpectedException(typeof(OutOfMemoryException))]
        public void TestThrowOutOfMemoryException()
        {
            ExceptionHandler eh = new ExceptionHandler(int.MaxValue.ToString(), false);
            eh.OutOfMemoryExceptionMethod();
        }

        [TestMethod]
        public void TestCatchOutOfMemoryException()
        {
            ExceptionHandler eh = new ExceptionHandler(
                int.MaxValue.ToString(), false, true);
            eh.OutOfMemoryExceptionMethod();

            Assert.AreEqual(
                $"Caught exception {typeof(OutOfMemoryException)}",
                eh.ErrorMsg);
        }
        #endregion
    }
}