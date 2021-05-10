//using NUnit.Framework;
//using OpenQA.Selenium.Appium;
//using OpenQA.Selenium.Appium.Windows;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace CleanTestingUI.Application.QLNhaHang
//{
//    [TestFixture]
//    class TestFormDatBan : CreateSession
//    {

//        private string xPath_Edit_MatKhau = "//Edit[starts-with(@ClassName,'WindowsForms10')][@Name='Mật khẩu:']";
//        private string xPath_Edit_TenDangNhap = "//Edit[starts-with(@ClassName,'WindowsForms10')][@Name='Tên đăng nhập:']";
//        private string xPath_test = "//MenuBar[@Name='menuStrip1'][@AutomationId='mnsTableManager']/MenuItem[@Name='Quản trị']";
//        private string xPath_Btn_DangNhap = "//Button[starts-with(@ClassName,'WindowsForms10')][@Name='Đăng nhập']";
//        private string xPath_Btn_Thoat = "//Button[starts-with(@ClassName,'WindowsForms10')][@Name='Thoát']";
//        private string xPath_Ok = "//Button[@ClassName =\"Button\"][@Name=\"OK\"]";

//        private string id_ok = @"/Pane[@ClassName='#32769'][@Name='Desktop 1']/Window[starts-with(@ClassName,'WindowsForms10')][@Name='Đăng nhập']/Window[@ClassName='#32770'][@Name='Thông báo']/Text[@ClassName='Static'][@Name='Bạn có muốn thoát khỏi phần mềm?']";

//        [Test]
//        public void Delete()
//        {
//            var Btn_Thoat = session.FindElementByXPath(xPath_Btn_Thoat);


//            Btn_Thoat.Click();
//        }



//        //[TestCase("nv01", "123")]
//        //public void ChangeSessionToLogin(string username, string passwd)
//        //{
//        //    var edit_TenDangNhap = session.FindElementByXPath(xPath_Edit_TenDangNhap);
//        //    if (edit_TenDangNhap != null)
//        //    {
//        //        edit_TenDangNhap.Click();
//        //        edit_TenDangNhap.SendKeys(username);
//        //    }
//        //    else
//        //    {
//        //        return;
//        //    }
//        //    var edit_MatKhau = session.FindElementByXPath(xPath_Edit_MatKhau);

//        //    if (edit_TenDangNhap != null)
//        //    {
//        //        edit_TenDangNhap.Click();
//        //        edit_MatKhau.SendKeys(passwd);
//        //    }
//        //    else
//        //    {
//        //        return;
//        //    }
//        //    var btn_DangNhap = session.FindElementByXPath(xPath_Btn_DangNhap);
//        //    btn_DangNhap.Click();
//        //}
//        //[Test]
//        //public void IsConnect_Session()
//        //{
//        //    Assert.IsNotNull(session);
//        //    System.Threading.Thread.Sleep(2000);
//        //}

//        //[Test]
//        //public void Test1()
//        //{
//        //    //string xpath_LeftClickMenuItemQuảntrị_20_11 = "/Pane[@ClassName='#32769'][@Name='Desktop 1']/Window[@Name='Phần mềm quản lý nhà hàng'][@AutomationId='fTableManager']/Pane[@AutomationId='pnTableManager']/MenuBar[@Name='menuStrip1'][@AutomationId='mnsTableManager']/MenuItem[@Name='Quản trị']";
//        //    //var winElem_LeftClickMenuItemQuảntrị_20_11 = session.FindElementByXPath(xpath_LeftClickMenuItemQuảntrị_20_11);


//        //    //var test = session.FindElementByXPath(xPath_test);
//        //    //Assert.IsNotNull(test.Text, "Da Null");

//        //    //string xpath_LeftClickTextTênđăngnhậ_40_14 = "//Text[@Name='Tên đăng nhập:'][@AutomationId='lbUserName']";
//        //    //var winElem_LeftClickTextTênđăngnhậ_40_14 = session.FindElementByXPath(xpath_LeftClickTextTênđăngnhậ_40_14);

//        //    //Assert.IsTrue(winElem_LeftClickTextTênđăngnhậ_40_14.Text == "Tên đăng nhập", "khong bang");

//        //    string xpath_LeftClickTextThànhtiền_42_16 = "//Button[@Name='Tạm Tính'][@AutomationId='bnProvisional']";
//        //    var winElem_LeftClickTextThànhtiền_42_16 = session.FindElementByXPath(xpath_LeftClickTextThànhtiền_42_16);

//        //    Assert.IsNotNull(winElem_LeftClickTextThànhtiền_42_16.Text, "Trong khong co du lieu");

//        //}
//    }


//}




