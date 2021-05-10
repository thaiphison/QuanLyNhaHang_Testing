using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTestingUI.Application.QLNhaHang
{
    class CreateSession_WithoutLogin
    {
        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";
        private const string WpfAppId = @"D:\Hoc\KTPM\Sang\QuanLyNhaHang_Testing\CleanArchQLNH\bin\Debug\net5.0-windows\CleanArchQLNH.exe";
        public static WindowsDriver<WindowsElement> session;

        [OneTimeSetUp]
        public void Setup()
        {
            if (session == null)
            {
                var appiumOptions = new AppiumOptions();
                appiumOptions.AddAdditionalCapability("app", WpfAppId);
                appiumOptions.AddAdditionalCapability("deviceName", "WindowsPC");
                session = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), appiumOptions);
            }
        }
        
    }




    //[OneTimeTearDown]

    //public void TearDown()

    //{

    //    session.Close();

    //}
}

