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
        public void switchSettingInTextTest()
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
            var body = "{\\rtf1\\ansi\\ansicpg1252\\fromhtml1 \\fbidis \\deff0{\\fonttbl\r\n{\\f0\\fswiss\\fcharset0 Arial;}\r\n{\\f1\\fmodern Courier New;}\r\n{\\f2\\fnil\\fcharset2 Symbol;}\r\n{\\f3\\fmodern\\fcharset0 Courier New;}}\r\n{\\colortbl\\red0\\green0\\blue0;\\red0\\green0\\blue255;}\r\n\\uc1\\pard\\plain\\deftab360 \\f0\\fs24 \r\n{\\*\\htmltag19 <html xmlns:v=\"urn:schemas-microsoft-com:vml\" xmlns:o=\"urn:schemas-microsoft-com:office:office\" xmlns:w=\"urn:schemas-microsoft-com:office:word\" xmlns:m=\"http://schemas.microsoft.com/office/2004/12/omml\" xmlns=\"http://www.w3.org/TR/REC-html40\">}\r\n{\\*\\htmltag34 <head>}\r\n{\\*\\htmltag161 <meta name=Generator content=\"Microsoft Word 15 (filtered medium)\">}\r\n{\\*\\htmltag241 <style>}\r\n{\\*\\htmltag241 <!--\\par /* Font Definitions */\\par @font-face\\par \\tab \\{font-family:\"Cambria Math\";\\par \\tab panose-1:2 4 5 3 5 4 6 3 2 4;\\}\\par @font-face\\par \\tab \\{font-family:Calibri;\\par \\tab panose-1:2 15 5 2 2 2 4 3 2 4;\\}\\par /* Style Definitions */\\par a:link, span.MsoHyperlink\\par \\tab \\{mso-style-priority:99;\\par \\tab color:blue;\\par \\tab text-decoration:underline;\\}\\par span.EmailStyle18\\par \\tab \\{mso-style-type:personal-compose;\\}\\par .MsoChpDefault\\par \\tab \\{mso-style-type:export-only;\\par \\tab font-size:10.0pt;\\}\\par @page WordSection1\\par \\tab \\{size:612.0pt 792.0pt;\\par \\tab margin:70.85pt 70.85pt 2.0cm 70.85pt;\\}\\par div.WordSection1\\par \\tab \\{page:WordSection1;\\}\\par -->}\r\n{\\*\\htmltag249 </style>}\r\n{\\*\\htmltag241 <!--[if gte mso 9]><xml>\\par <o:shapedefaults v:ext=\"edit\" spidmax=\"1026\" />\\par </xml><![endif]-->}\r\n{\\*\\htmltag241 <!--[if gte mso 9]><xml>\\par <o:shapelayout v:ext=\"edit\">\\par <o:idmap v:ext=\"edit\" data=\"1\" />\\par </o:shapelayout></xml><![endif]-->}\r\n{\\*\\htmltag41 </head>}\r\n{\\*\\htmltag50 <body lang=DE link=blue vlink=purple style='word-wrap:break-word'>}\r\n{\\*\\htmltag96 <div class=WordSection1>}\\htmlrtf {\\htmlrtf0 \r\n{\\*\\htmltag64 <p>}\\htmlrtf {\\htmlrtf0 \r\n{\\*\\htmltag148 <span lang=EN-US>}\\htmlrtf {\\htmlrtf0 Test \r\n{\\*\\htmltag244 <o:p>}\r\n{\\*\\htmltag252 </o:p>}\r\n{\\*\\htmltag156 </span>}\\htmlrtf }\\htmlrtf0 \\htmlrtf\\par}\\htmlrtf0\r\n\\htmlrtf \\par\r\n\\htmlrtf0 \r\n{\\*\\htmltag72 </p>}\r\n{\\*\\htmltag64 <p>}\\htmlrtf {\\htmlrtf0 \r\n{\\*\\htmltag148 <span lang=EN-US>}\\htmlrtf {\\htmlrtf0 dfsdfsdf\r\n{\\*\\htmltag244 <o:p>}\r\n{\\*\\htmltag252 </o:p>}\r\n{\\*\\htmltag156 </span>}\\htmlrtf }\\htmlrtf0 \\htmlrtf\\par}\\htmlrtf0\r\n\\htmlrtf \\par\r\n\\htmlrtf0 \r\n{\\*\\htmltag72 </p>}\r\n{\\*\\htmltag64 <p>}\\htmlrtf {\\htmlrtf0 \r\n{\\*\\htmltag148 <span lang=EN-US>}\\htmlrtf {\\htmlrtf0 sfsdfsdf\r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 Jitsi-Meeting \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 Join the meeting: \r\n{\\*\\htmltag156 </span>}\\htmlrtf }\\htmlrtf0 \r\n{\\*\\htmltag84 <a href=\"https://meet.jit.si/UnderlyingDescentsPledgeOverseas\">}\\htmlrtf {\\field{\\*\\fldinst{HYPERLINK \"https://meet.jit.si/UnderlyingDescentsPledgeOverseas\"}}{\\fldrslt\\cf1\\ul \\htmlrtf0 \r\n{\\*\\htmltag148 <span lang=EN-US>}\\htmlrtf {\\htmlrtf0 https://meet.jit.si/UnderlyingDescentsPledgeOverseas\r\n{\\*\\htmltag156 </span>}\\htmlrtf }\\htmlrtf0 \\htmlrtf }\\htmlrtf0 \\htmlrtf }\\htmlrtf0 \r\n{\\*\\htmltag92 </a>}\r\n{\\*\\htmltag148 <span lang=EN-US>}\\htmlrtf {\\htmlrtf0 \r\n{\\*\\htmltag244 <o:p>}\r\n{\\*\\htmltag252 </o:p>}\r\n{\\*\\htmltag156 </span>}\\htmlrtf }\\htmlrtf0 \\htmlrtf\\par}\\htmlrtf0\r\n\\htmlrtf \\par\r\n\\htmlrtf0 \r\n{\\*\\htmltag72 </p>}\r\n{\\*\\htmltag64 <p>}\\htmlrtf {\\htmlrtf0 \r\n{\\*\\htmltag148 <span lang=EN-US>}\\htmlrtf {\\htmlrtf0 Dial in number:\r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  US: +1.512.647.1431 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  UK: +44.203.885.2179 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  France: +33.1.87.21.0005 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Netherlands: +31.85.208.1541 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Spain: +34.932.205.409 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Canada: +1.437.538.3987 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Australia: +61.8.7150.1136 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Brazil: +55.21.3500.0112 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Japan: +81.3.4510.2372 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  Switzerland: +41.61.588.0496 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 Conference number: 1024100710 \r\n{\\*\\htmltag116 <br>}\\htmlrtf \\line\r\n\\htmlrtf0 \r\n{\\*\\htmltag84 &nbsp;}\\htmlrtf \\'a0\\htmlrtf0  \r\n{\\*\\htmltag244 <o:p>}\r\n{\\*\\htmltag252 </o:p>}\r\n{\\*\\htmltag156 </span>}\\htmlrtf }\\htmlrtf0 \\htmlrtf\\par}\\htmlrtf0\r\n\\htmlrtf \\par\r\n\\htmlrtf0 \r\n{\\*\\htmltag72 </p>}\r\n{\\*\\htmltag104 </div>}\\htmlrtf }\\htmlrtf0 \r\n{\\*\\htmltag58 </body>}\r\n{\\*\\htmltag27 </html>}}";
            var url = Utils.GetUrl(body, "meet.jit.si");
            Assert.AreEqual("https://meet.jit.si/UnderlyingDescentsPledgeOverseas", url);
        }

        [TestMethod()]
        public void GetUrlTest2()
        {
            var body = "https://meet.jit.si/UnderlyingDescentsPledgeOverseas";
            var url = Utils.GetUrl(body, "meet.jit.si");
            Assert.AreEqual("https://meet.jit.si/UnderlyingDescentsPledgeOverseas", url);

            body = "http://meet.jit.si/UnderlyingDescentsPledgeOverseas";
            url = Utils.GetUrl(body, "meet.jit.si");
            Assert.AreEqual("http://meet.jit.si/UnderlyingDescentsPledgeOverseas", url);
        }

        [TestMethod()]
        public void SettingIsActiveTest()
        {
            Assert.Fail();
        }
    }
}