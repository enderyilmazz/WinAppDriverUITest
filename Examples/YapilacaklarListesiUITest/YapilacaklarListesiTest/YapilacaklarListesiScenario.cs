using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace YapilacaklarListesiTest
{
    [TestClass]
    public class YapilacaklarListesiScenario: YapilacaklarListesiSession
    {
        [TestMethod]
        public void ButonKontrol()
        {
            session.FindElementByName("Ekle").Click();
            session.FindElementByName("Sil").Click();
            session.FindElementByName("Güncelle").Click();
            session.FindElementByName("Tümünü Sil").Click();
        }
        [TestMethod]
        public void Ekle()
        {
            string text = "";
            session.FindElementByAccessibilityId("textBox1").Click();
            session.Keyboard.SendKeys("Test Yazısı 1");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("Test Yazısı 1", text);
            session.FindElementByName("Ekle").Click();

            session.FindElementByAccessibilityId("textBox1").Click();
            session.Keyboard.SendKeys("Test Yazısı 2");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("Test Yazısı 2", text);
            session.FindElementByName("Ekle").Click();

            session.FindElementByAccessibilityId("textBox1").Click();
            session.Keyboard.SendKeys("Test Yazısı 3");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("Test Yazısı 3", text);
            session.FindElementByName("Ekle").Click();
        }
        [TestMethod]
        public void Guncelle()
        {
            var text = "";
            session.FindElementByName("Test Yazısı 1").Click();
            session.FindElementByAccessibilityId("textBox1").Click();
            session.FindElementByAccessibilityId("textBox1").SendKeys(Keys.Control + "a" + Keys.Delete);
            session.Keyboard.SendKeys("Test Yazısı Guncelleme 1");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("Test Yazısı Guncelleme 1", text);
            session.FindElementByName("Güncelle").Click();

            session.FindElementByName("Test Yazısı 2").Click();
            session.FindElementByAccessibilityId("textBox1").Click();
            session.FindElementByAccessibilityId("textBox1").SendKeys(Keys.Control + "a" + Keys.Delete);
            session.Keyboard.SendKeys("Test Yazısı Guncelleme 2");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("Test Yazısı Guncelleme 2", text);
            session.FindElementByName("Güncelle").Click();

            session.FindElementByName("Test Yazısı 3").Click();
            session.FindElementByAccessibilityId("textBox1").Click();
            session.FindElementByAccessibilityId("textBox1").SendKeys(Keys.Control + "a" + Keys.Delete);
            session.Keyboard.SendKeys("Test Yazısı Guncelleme 3");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("Test Yazısı Guncelleme 3", text);
            session.FindElementByName("Güncelle").Click();
        }
        [TestMethod]
        public void Sil()
        {
            string text;
            session.FindElementByName("Test Yazısı Guncelleme 1").Click();
            session.FindElementByName("Sil").Click();
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("", text);

            session.FindElementByName("Test Yazısı Guncelleme 2").Click();
            session.FindElementByName("Sil").Click();
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("", text);

            session.FindElementByName("Test Yazısı Guncelleme 3").Click();
            session.FindElementByName("Sil").Click();
            text = session.FindElementByAccessibilityId("textBox1").Text;
            Assert.AreEqual("", text);
        }
        [TestMethod]
        public void TumuSil()
        {
            string text;
            session.FindElementByAccessibilityId("textBox1").Click();
            session.Keyboard.SendKeys("Test Yazısı 1");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            session.FindElementByName("Ekle").Click();
            Assert.AreEqual("Test Yazısı 1", text);

            session.FindElementByAccessibilityId("textBox1").Click();
            session.Keyboard.SendKeys("Test Yazısı 2");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            session.FindElementByName("Ekle").Click();
            Assert.AreEqual("Test Yazısı 2", text);

            session.FindElementByAccessibilityId("textBox1").Click();
            session.Keyboard.SendKeys("Test Yazısı 3");
            text = session.FindElementByAccessibilityId("textBox1").Text;
            session.FindElementByName("Ekle").Click();
            Assert.AreEqual("Test Yazısı 3", text);

            var list = session.FindElementByAccessibilityId("listBox1");
            session.FindElementByName("Tümünü Sil").Click();
            Assert.IsNotNull(list);

            session.FindElementByName("Kapat").Click();
        }
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Setup(context);
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            ClearSession();
        }
    }
}
