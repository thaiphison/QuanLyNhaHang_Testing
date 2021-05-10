using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class KhuyenMaiTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetPromotionList_ReturnNotNull()
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();

            //Act
            List<KHUYENMAI> khuyenmailist = KhuyenMaiUseCase.LoadPromotionList();
            int actualCount = khuyenmailist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach khuyen mai dang rong");
        }

        [TestCase("KM3")]       //passed
        [TestCase("8/3")]       //passed
        [TestCase("KM8")]       //passed
        [TestCase("KM10")]      //failed
        [TestCase("-1")]        //failed
        [TestCase(" ")]         //failed
        public void TimKhuyenMai(string noidung)
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();
            var expectedCount = 1;

            //Act
            List<KHUYENMAI> timkhuyenmai = KhuyenMaiUseCase.TimKhuyenMai(noidung);
            var actualCount = timkhuyenmai.Count;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay khuyen mai");
        }

        [TestCase(" ", "30/4", "30/04/2021", "01/05/2021", "15")]
        [TestCase("KM08", "Ca thang tu", "01/04/2021", "02/04/2021", "10")]
        public void ThemKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();
            var expectedCount = 1;

            //Act
            int themkhuyenmai = KhuyenMaiUseCase.ThemKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm);
            var actualCount = themkhuyenmai;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Them that bai");
        }

        [TestCase("KM7", "8/3", "08/03/2021", "09/03/2021", "20")]              //passed
        [TestCase("KM8", "Ca thang tu", "01/04/2021", "02/04/2021", "15")]      //passed
        [TestCase("KM07", "Quoc Khanh", "02/09/2021", "03/09/2021", "10")]      //failed
        [TestCase(" ", "8/3", "08/03/2021", "09/03/2021", "15")]                //failed


        public void SuaKhuyenMai(string makm, string tenkm, string ngaybd, string ngaykt, string phantramkm)
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();
            var expectedCount = 1;

            //Act
            int suakhuyenmai = KhuyenMaiUseCase.SuaKhuyenMai(makm, tenkm, ngaybd, ngaykt, phantramkm);
            var actualCount = suakhuyenmai;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }

        [TestCase("KM10")]
        [TestCase(" ")]
        public void XoakhuyenMai(string makm)
        {
            //Arr
            var KhuyenMaiUseCase = new KhuyenMaiUseCase();
            var expectedCount = 1;

            //Act
            int xoakhuyenmai = KhuyenMaiUseCase.XoaKhuyenMai(makm);
            var actualCount = xoakhuyenmai;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Xoa that bai");
        }
    }
}