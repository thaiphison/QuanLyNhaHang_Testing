using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class MonAnTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetFoodList_ReturnNotNull()
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();

            //Act
            List<MONAN> foodlist = monAnUseCase.LoadFoodList();
            var actualCount = foodlist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach mon an dang rong");
        }

        [TestCase("mon1")]
        [TestCase("mon2")]
        [TestCase("mon01")]
        [TestCase(" ")]
        public void TimMonAn(string mam)
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();

            //Act
            List<MONAN> timMonAn = monAnUseCase.TimMonAn(mam);
            var actualCount = timMonAn.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Khong tim thay mon an");
        }

        [TestCase(" ", "Pho bo", "50000")]              //passed
        [TestCase(" ", "Burger thit bo", "30000")]      //passed              
        [TestCase(" ", "Com", " ")]                     //failed
        [TestCase(" ", " ", " ")]                       //failed

        public void ThemMonAn(string mam, string tenm, decimal gia)
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();
            var expectedCount = 1;

            //Act
            int themMonAn = monAnUseCase.ThemMonAn(mam, tenm, gia);
            var actualCount = themMonAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Them that bai");
        }

        [TestCase("mon1", "Mi xao hai san", "100000")]       //passed
        [TestCase("mon38", "Pho", "60000")]                  //passed
        [TestCase("mon4", "Bo bit tet", "100000")]           //failed
        [TestCase("mon7", " ", "100000")]                    //failed

        public void SuaMonAn(string mam, string tenm, decimal gia)
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();
            var expectedCount = 1;

            //Act
            int themMonAn = monAnUseCase.SuaMonAn(mam, tenm, gia);
            var actualCount = themMonAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }

        [TestCase("mon4")]         //passed
        [TestCase("mon40")]        //passed
        [TestCase("mon01")]        //failed
        [TestCase(" ")]            //failed
        public void XoaMonAn(string mam)
        {
            //Arr
            var monAnUseCase = new MonAnUseCase();
            var expectedCount = 1;

            //Act
            int xoaMonAn = monAnUseCase.XoaMonAn(mam);
            var actualCount = xoaMonAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Xoa that bai");
        }


    }
}