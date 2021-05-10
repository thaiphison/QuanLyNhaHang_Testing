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
    [TestFixture]
    class TestLoginForm : CreateSession_WithoutLogin
    {
        private string xPath_Text_TenDangNhap = "//Text[starts-with(@ClassName,'WindowsForms10')][@Name='Tên đăng nhập:']";
        private string xPath_Text_MatKhau = "//Text[starts-with(@ClassName,'WindowsForms10')][@Name='Mật khẩu:']";
        private  string xPath_Edit_MatKhau = "//Edit[starts-with(@ClassName,'WindowsForms10')][@Name='Mật khẩu:']";
        private string xPath_Edit_TenDangNhap = "//Edit[starts-with(@ClassName,'WindowsForms10')][@Name='Tên đăng nhập:']";
        private string xPath_Btn_DangNhap = "//Button[starts-with(@ClassName,'WindowsForms10')][@Name='Đăng nhập']";
        private string xPath_Title = "/Pane[@ClassName='#32769'][@Name='Desktop 1']/Window[starts-with(@ClassName,'WindowsForms10')][@Name='Đăng nhập']/TitleBar[@AutomationId='TitleBar']";
        private string xPath_panel_login = "//Pane[starts-with(@ClassName,'WindowsForms10')]";
        private string xPath_Btn_Thoat = "//Button[starts-with(@ClassName,'WindowsForms10')][@Name='Thoát']";
      
        [Test]
        public void IsConnect_Session()
        {
            Assert.IsNotNull(session);
            System.Threading.Thread.Sleep(2000);
        }

        //[TestCase("Đăng Nhập")]
        //public void Title_Name_AssertEqual(string expected_name_Title)
        //{
        //    //arr
        //    //WindowsElement name_Title = session.FindElementByXPath(xPath_Title);
        //    WindowsElement name_Title = session.FindElementById("TitleBar");

        //    //act
        //    string actual_name_Title = name_Title.Text;

        //    //assert
        //    Assert.AreEqual(expected_name_Title, actual_name_Title);
        //}

        [TestCase("Đăng nhập")]
        public void ButtonDangNhap_NameInButton_AssertEqual(string expected_name)
        {
            //arr
            WindowsElement NameInButton = session.FindElementByXPath(xPath_Btn_DangNhap);

            //act
            string actual_name = NameInButton.Text;

            //assert
            Assert.AreEqual(expected_name, actual_name);
        }


        [TestCase("Thoát")]
        public void ButtonThoat_NameInButton_AssertEqual(string expected_name)
        {
            //arr
            WindowsElement NameInButton = session.FindElementByXPath(xPath_Btn_Thoat);

            //act
            string actual_name = NameInButton.Text;

            //assert
            Assert.AreEqual(expected_name, actual_name);
        }


        [TestCase("400", "137")]
        public void PanelLogin_Size_AssertEqual(int expected_width, int expected_height)
        {
            //arr
            WindowsElement width_xPathPanelLogin = session.FindElementByXPath(xPath_panel_login);
            WindowsElement height_xPathPanelLogin = session.FindElementByXPath(xPath_panel_login);

            //act
            int actual_width = width_xPathPanelLogin.Size.Width;
            int actual_height = height_xPathPanelLogin.Size.Height;

            //assert
            Assert.AreEqual(expected_width, actual_width);
            Assert.AreEqual(expected_height, actual_height);
        }

        [TestCase("95", "22")]
        public void TextMatKhau_Size_AssertEqual(int expected_width, int expected_height)
        {
            //arr
            WindowsElement width_xPathMatKhau = session.FindElementByXPath(xPath_Text_MatKhau);
            WindowsElement height_xPathMatKhau = session.FindElementByXPath(xPath_Text_MatKhau);

            //act
            int actual_width = width_xPathMatKhau.Size.Width;
            int actual_height = height_xPathMatKhau.Size.Height;

            //assert
            Assert.AreEqual(expected_width, actual_width);
            Assert.AreEqual(expected_height, actual_height);
        }
        [TestCase("137", "22")]
        public void TextTenDangNhap_Size_AssertEqual(int expected_width, int expected_height)
        {
            //arr
            WindowsElement width_xPathTenDangNhap = session.FindElementByXPath(xPath_Text_TenDangNhap);
            WindowsElement height_xPathTenDangNhap = session.FindElementByXPath(xPath_Text_TenDangNhap);

            //act
            int actual_width = width_xPathTenDangNhap.Size.Width;
            int actual_height = height_xPathTenDangNhap.Size.Height;

            //assert
            Assert.AreEqual(expected_width, actual_width);
            Assert.AreEqual(expected_height, actual_height);
        }


        //[TestCase("nv01", "123")]
        //public void ButtonLogin_Click_NavigateToNewPage(string username, string passwd)
        //{
        //    var edit_TenDangNhap = session.FindElementByXPath(xPath_Edit_TenDangNhap);
        //    if (edit_TenDangNhap != null)
        //    {
        //        edit_TenDangNhap.Click();
        //        edit_TenDangNhap.SendKeys(username);

        //    }
        //    else
        //    {
        //        return;
        //    }

        //    var edit_MatKhau = session.FindElementByXPath(xPath_Edit_MatKhau);

        //    if (edit_TenDangNhap != null)
        //    {
        //        edit_TenDangNhap.Click();
        //        edit_MatKhau.SendKeys(passwd);

        //    }
        //    else
        //    {
        //        return;
        //    }
        //    var btn_DangNhap = session.FindElementByXPath(xPath_Btn_DangNhap);
        //    btn_DangNhap.Click();
        //}
        //[Test]
        //public void by()
        //{
        //    //string xpath_LeftClickMenuItemQuảntrị_20_11 = "/Pane[@ClassName='#32769'][@Name='Desktop 1']/Window[@Name='Phần mềm quản lý nhà hàng'][@AutomationId='fTableManager']/Pane[@AutomationId='pnTableManager']/MenuBar[@Name='menuStrip1'][@AutomationId='mnsTableManager']/MenuItem[@Name='Quản trị']";
        //    //var winElem_LeftClickMenuItemQuảntrị_20_11 = session.FindElementByXPath(xpath_LeftClickMenuItemQuảntrị_20_11);


        //    //var test = session.FindElementByXPath(xPath_test);
        //    //Assert.IsNotNull(test.Text, "Da Null");

        //    //string xpath_LeftClickTextTênđăngnhậ_40_14 = "//Text[@Name='Tên đăng nhập:'][@AutomationId='lbUserName']";
        //    //var winElem_LeftClickTextTênđăngnhậ_40_14 = session.FindElementByXPath(xpath_LeftClickTextTênđăngnhậ_40_14);

        //    //Assert.IsTrue(winElem_LeftClickTextTênđăngnhậ_40_14.Text == "Tên đăng nhập", "khong bang");

        //    string xpath_LeftClickTextThànhtiền_42_16 = "//Text[@Name='Thành tiền:'][@AutomationId='lbTotalPrice']";
        //    var winElem_LeftClickTextThànhtiền_42_16 = session.FindElementByAccessibilityId("lbTotalPrice");

        //    Assert.IsNotNull(winElem_LeftClickTextThànhtiền_42_16.Text, "Trong khong co du lieu");

        //}
    }
}

