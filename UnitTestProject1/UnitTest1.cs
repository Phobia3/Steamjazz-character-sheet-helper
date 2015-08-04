using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System.Windows.Forms;
using Steamjazz;

namespace UnitTestProject
{
    [TestClass]
    
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestInitialAttributes()
        {
            //arrange
            Form1 formi = new Form1();
            string expected = "10";
            //act
            string[] list = new string[]{formi.Label6.Text, formi.Label8.Text, formi.Label10.Text, formi.Label12.Text, formi.Label30.Text, formi.Label33.Text, formi.Label35.Text, formi.Label37.Text, };
            //assert
            for(int i=0;i<7;i++)
            {
                Assert.AreEqual(expected, list[i]);
            }
        }
        [TestMethod]
        public void TestPointBuy()
        {
            Form1 formi = new Form1();
            string expectation = "72";
            string value = formi.Label39.Text;

            Assert.AreEqual(expectation, value);
        }
    }
}
