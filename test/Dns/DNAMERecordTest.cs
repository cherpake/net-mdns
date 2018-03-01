﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Makaretu.Dns
{

    [TestClass]
    public class DNAMERecordTest
    {
        [TestMethod]
        public void Roundtrip()
        {
            var a = new DNAMERecord
            {
                NAME = "emanon.org",
                Target = "somewhere.else.org"
            };
            var b = (DNAMERecord)new ResourceRecord().Read(a.ToByteArray());
            Assert.AreEqual(a.NAME, b.NAME);
            Assert.AreEqual(a.CLASS, b.CLASS);
            Assert.AreEqual(a.TYPE, b.TYPE);
            Assert.AreEqual(a.TTL, b.TTL);
            Assert.AreEqual(a.Target, b.Target);
        }
    }
}