using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class HoaDonTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("1")]      //passed
        [TestCase("2")]      //passed
        [TestCase("3")]      //passed
        [TestCase("4")]      //passed
        [TestCase("8")]      //failed
        [TestCase("-1")]     //failed
        [TestCase("100")]    //failed
        [TestCase(" ")]      //failed
        public void GetUncheckBillIdByTableId(int mab)
        {
            //Arr
            var HoaDonUseCase = new HoaDonUseCase();

            //Act
            var actualCount = HoaDonUseCase.GetUncheckBillIdByTableId(mab);

            //Assert
            Assert.IsTrue(actualCount != "-1", "Ban nay chua thanh toan");
        }

        //[TestCase("nv01", "2", "KM1", "4")]         //passed
        //[TestCase("nv03", "1", "KM10", "3")]        //passed
        [TestCase("nv", "1", "KM10", "3")]          //failed
        [TestCase("nv02", "100", "KM10", "3")]      //failed
        [TestCase("nv02", "3", "KM01", "3")]        //failed
        [TestCase("nv02", "3", "KM01", "9")]        //failed
        [TestCase(" ", "1", "KM10", "3")]           //failed
        [TestCase("nv02", " ", "KM10", "3")]        //failed
        [TestCase("nv02", "3", " ", "3")]           //failed
        [TestCase("nv02", "3", "KM01", " ")]        //failed 
        [TestCase(" ", " ", " ", " ")]              //failed 
        public void InsertHoaDon(string manv, int mab, string makm, int slkhach)
        {
            //Arr
            var HoaDonUseCase = new HoaDonUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = HoaDonUseCase.InsertHoaDon(manv, mab, makm, slkhach);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Them that bai");
        }

        [Test]
        public void getMaxIdHD()
        {
            //Arr
            var HoaDonUseCase = new HoaDonUseCase();

            //Act
            string actualCount = HoaDonUseCase.getMaxIdHD();

            //Assert
            Assert.IsTrue(actualCount != "1", "Danh sach hoa don dang rong");
        }

        [TestCase("HD01", "4")]          //passed
        [TestCase("HD02", "1")]          //passed
        [TestCase("HD03", "3")]          //passed
        [TestCase("HD1", "1")]           //failed
        [TestCase(" ", "1")]             //failed
        [TestCase("HD02", " ")]          //failed
        [TestCase(" ", " ")]             //failed
        public void SuaSLKhachHoaDon(string mahd, int slkhach)
        {
            //Arr
            var HoaDonUseCase = new HoaDonUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = HoaDonUseCase.SuaSLKhachHoaDon(mahd, slkhach);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong hop le");
        }

        [TestCase("HD01", "4")]       //passed
        [TestCase("HD02", "1")]       //passed
        [TestCase("HD1", "2")]        //failed
        [TestCase("HD03", "100")]     //failed
        [TestCase(" ", "3")]          //failed
        [TestCase("HD04", " ")]       //failed
        [TestCase(" ", " ")]          //failed
        public void SwitchTable(string mahd, int mab)
        {
            //Arr
            var HoaDonUseCase = new HoaDonUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = HoaDonUseCase.SwitchTable(mahd, mab);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong hop le");
        }

        [TestCase("1")]     //passed
        [TestCase("5")]     //passed     
        [TestCase(" ")]     //failed
        public void LaySoKhachHD(int mab)
        {
            //Arr
            var HoaDonUseCase = new HoaDonUseCase();

            //Act
            int actualCount = HoaDonUseCase.LaySoKhachHD(mab);

            //Assert
            Assert.IsTrue(actualCount != 1, "Khong hop le");
        }

    }
}