using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class PhieuDatBanTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetOrderfList_ReturnNotNull()
        {
            //Arr
            var PhieuDatBanUseCase = new PhieuDatBanUseCase();

            //Act
            List<PHIEUDATBAN> orderlist = PhieuDatBanUseCase.LoadOrderListUC();
            var actualCount = orderlist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach phieu dat ban dang rong");
        }

        [TestCase("pdb1")]         //passed
        [TestCase("pdb2")]         //failed
        [TestCase(" ")]            //failed

        public void TimPhieuDatBan(string noidung)
        {
            //Arr
            var PhieuDatBanUseCase = new PhieuDatBanUseCase();
            var expectedCount = 1;

            //Act
            List<PHIEUDATBAN> orderlist = PhieuDatBanUseCase.TimPhieuDatBan(noidung);
            var actualCount = orderlist.Count;


            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay phieu dat ban");

        }

        [TestCase("pdb01", "10", "KH08", "0123456789", "11-05-2020", "01:00", "1")]    //passed
        [TestCase("pdb02", "10", "KH08", "0123456789", "11-05-2020", "01:00", "1")]    //failed
        public void SuaPhieuDatBan(string mapdb, string mab, string makh, string sdt, string ngaydat, string giodat, string tinhtrang)
        {
            //Arr
            var PhieuDatBanUseCase = new PhieuDatBanUseCase();
            var expectedCount = 1;

            //Act
            int suaPhieuDatBan = PhieuDatBanUseCase.SuaPhieuDatBan(mapdb, mab, makh, sdt, ngaydat, giodat, tinhtrang);
            var actualCount = suaPhieuDatBan;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }

        //[TestCase("pdb01")]        //passed
        [TestCase("pdb02")]          //failed
        [TestCase(" ")]              //failed
        public void XoaPhieuDatBan(string mapdb)
        {
            //Arr
            var PhieuDatBanUseCase = new PhieuDatBanUseCase();
            var expectedCount = 1;

            //Act
            int xoaPhieuDatBan = PhieuDatBanUseCase.XoaPhieuDatBan(mapdb);
            var actualCount = xoaPhieuDatBan;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Xoa that bai");
        }


    }
}