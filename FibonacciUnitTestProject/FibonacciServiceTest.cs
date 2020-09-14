using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciService;

namespace FibonacciUnitTestProject
{
    [TestClass]
    public class FibonacciServiceTest
    {
        [TestMethod]
        public void TestFibonacciWebService()
        {
            int expected = 55;
            int actualValue = 10;
            var test = new FibonacciService.FiboWebService();
            Assert.AreEqual(expected, test.fibonacci2switch(actualValue));
        }

        [TestMethod]
        public void Test1XmlToJsonWebService()
        {
            string expected = Newtonsoft.Json.Linq.JValue.Parse(@"{ ""foo"": ""bar"" }").ToString(Newtonsoft.Json.Formatting.Indented);;
            string actualValue = @"<foo>bar</foo>";
            var test = new FibonacciService.FiboWebService();
            Assert.AreEqual(expected, test.XmlToJson(actualValue));
        }

        [TestMethod]
        public void Test2XmlToJsonWebService()
        {
            string expected = "Bad Xml format";
            string actualValue = @"<foo>hello</bar>";
            var test = new FibonacciService.FiboWebService();
            Assert.AreEqual(expected, test.XmlToJson(actualValue));

        }

        [TestMethod]
        public void Test3XmlToJsonWebService()
        {
            string expected = Newtonsoft.Json.Linq.JValue.Parse(@"
                                                                    {
                                                                        ""TRANS"": {
                                                                            ""HPAY"": {
                                                                                ""ID"": ""103"",
                                                                                ""STATUS"": ""3"",
                                                                                ""EXTRA"": {
                                                                                    ""IS3DS"": ""0"",
                                                                                    ""AUTH"": ""031183""
                                                                                    },
                                                                                ""MLABEL"": ""501767XXXXXX6700"",
                                                                                ""MTOKEN"": ""project01""
                                                                            }
                                                                         }
                                                                     }
                                                                        ").ToString(Newtonsoft.Json.Formatting.Indented); ;
            string actualValue = @"<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            var test = new FibonacciService.FiboWebService();
            Assert.AreEqual(expected, test.XmlToJson(actualValue));
        }
    }
}
