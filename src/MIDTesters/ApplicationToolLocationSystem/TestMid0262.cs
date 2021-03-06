﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.ApplicationToolLocationSystem;

namespace MIDTesters.ApplicationToolLocationSystem
{
    [TestClass]
    public class TestMid0262 : MidTester
    {
        [TestMethod]
        public void Mid0262Revision1()
        {
            string package = "003002620011        013200078D";
            var mid = _midInterpreter.Parse<Mid0262>(package);

            Assert.AreEqual(typeof(Mid0262), mid.GetType());
            Assert.IsNotNull(mid.HeaderData.NoAckFlag);
            Assert.IsNotNull(mid.ToolTagId);
            Assert.AreEqual(package, mid.Pack());
        }
    }
}
