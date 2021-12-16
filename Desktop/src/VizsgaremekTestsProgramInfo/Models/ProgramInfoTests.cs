﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vizsgaremek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vizsgaremek.Models.Tests
{
    [TestClass()]
    public class ProgramInfoTests
    {
        [TestMethod()]
        public void ProgramInfoTest()
        {
            //arrange
            ProgramInfo programInfo = new ProgramInfo();
            string expected = "0.0.2";

            //act
            string actual = programInfo.Version;

            //assert
            Assert.AreEqual(expected, actual, "Version is not 0.0.2");
        }
    }
}