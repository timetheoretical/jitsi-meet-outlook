using Microsoft.VisualStudio.TestTools.UnitTesting;
using JitsiMeetOutlook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JitsiMeetOutlook.Tests
{
    [TestClass()]
    public class TextUtilsTests
    {
        [TestMethod()]
        public void findRoomIdTest()
        {
            var body = "\r\n\r\nJitsi - Meeting \r\n\r\nJoin the meeting: https://meet.jit.si/UpstairsAllowancesSpillQuite \r\n\r\nDial in number: \r\n  US: +1.512.647.1431 \r\n  UK: +44.203.885.2179 \r\n  France: +33.1.87.21.0005 \r\n  Netherlands: +31.85.208.1541 \r\n  Spain: +34.932.205.409 \r\n  Canada: +1.437.538.3987 \r\n  Australia: +61.8.7150.1136 \r\n  Brazil: +55.21.3500.0112 \r\n  Japan: +81.3.4510.2372 \r\n  Switzerland: +41.61.588.0496 \r\nConference number: 1080637763 \r\n\r\n_________________________________________________ \r\n\r\nDISCLAIMER \r\n\r\nhttps://example.de/disclaimer.pdf \r\n";
            var roomId = Utils.findRoomId(body, "meet.jit.si");
            Assert.AreEqual("UpstairsAllowancesSpillQuite", roomId);
        }

        [TestMethod()]
        public void findRoomIdTestMissing()
        {
            var body = "";
            var roomId = Utils.findRoomId(body, "meet.jit.si");
            Assert.AreEqual(string.Empty, roomId);
        }

        [TestMethod()]
        public void GetUrlTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SettingIsActiveTest()
        {
            Assert.Fail();
        }
    }
}