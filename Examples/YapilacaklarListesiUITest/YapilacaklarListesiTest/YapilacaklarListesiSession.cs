using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapilacaklarListesiTest
{
    public class YapilacaklarListesiSession
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private static string YapilacaklarListesiId = (Environment.CurrentDirectory + @"\YapilacaklarListesi.exe").Remove(Environment.CurrentDirectory.IndexOf(@"t\Y") + 2, "YapilacaklarListesiTest".Length).Insert(Environment.CurrentDirectory.IndexOf(@"t\Y") + 2, "YapilacaklarListesi");
        protected static WindowsDriver<WindowsElement> session;
        public static void Setup(TestContext context)
        {
            if (session == null)
            {
                DesiredCapabilities appCapabilities = new DesiredCapabilities();
                appCapabilities.SetCapability("app", YapilacaklarListesiId);
                appCapabilities.SetCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appCapabilities);
                Assert.IsNotNull(session);
            }
        }
        public static void ClearSession()
        {
            if (session != null)
            {
                session.Quit();
                session = null;
            }
        }
    }
}
