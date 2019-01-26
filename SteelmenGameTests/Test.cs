using NUnit.Framework;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelmenGameTests
{
    [TestFixture]
    public class Test
    {
        protected const string AppDriverUrl = "http://127.0.0.1:4723";
        protected static RemoteWebDriver AppSession;

        [SetUp]
        public void Setup()
        {
            Process.Start("C:\\Program Files (x86)\\Windows Application Driver\\WinAppDriver.exe");
            DesiredCapabilities cap = new DesiredCapabilities();
            cap.SetCapability("app", "8da5193e-87c7-4851-983f-6cca351ee226_3k6rj4k30b3e6!App");
            AppSession = new RemoteWebDriver(new Uri(AppDriverUrl), cap);
            Assert.IsNotNull(AppSession);
        }

        [TearDown]
        public void TestsCleanup()
        {
            AppSession.Dispose();
            AppSession = null;
        }

        [Test]
        [Category("New")]
        public void FirstTest()
        {
            Assert.AreEqual(1, 1);
        }
        [Test]
        [Category("Old")]
        public void SecondTest()
        {
            Assert.That(true, ()=>"strign");
        }

    }
}
