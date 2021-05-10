using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class BanAnTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetTableListUC_ReturnNotNull()
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();

            //Act
            List<BANAN> tablelist = BanAnUseCase.LoadTableListUC();
            var actualCount = tablelist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach ban an dang rong");
        }

        [TestCase("1", "4", "3")]   //passed
        [TestCase("2", "5", "2")]   //passed
        [TestCase("3", "3", "1")]   //passed
        [TestCase("-1", "3", "1")]  //failed
        [TestCase("100", "3", "1")] //failed
        [TestCase(" ", "3", "1")]   //failed
        [TestCase("1", " ", "1")]   //failed
        [TestCase("1", "2", " ")]   //failed
        [TestCase(" ", " ", " ")]   //failed
        public void SuaBanAn(int mab, int sokhach_toida, int tinhtrang)
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();
            var expectedCount = 1;

            //Act
            int suaBanAn = BanAnUseCase.SuaBanAn(mab, sokhach_toida, tinhtrang);
            var actualCount = suaBanAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }

        [TestCase("1", "2")]    //passed
        [TestCase("2", "2")]    //passed
        [TestCase("3", "2")]    //passed
        [TestCase("-1", "2")]   //failed
        [TestCase("100", "2")]  //failed
        [TestCase("1", " ")]    //failed
        [TestCase(" ", "2")]    //failed
        [TestCase(" ", " ")]    //failed
        public void SwitchTable(int mab, int tinhtrang)
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();
            var expectedCount = 1;

            //Act
            int chuyenBanAn = BanAnUseCase.SwitchTable(mab, tinhtrang);
            var actualCount = chuyenBanAn;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Chuyen that bai");
        }

        [Test]
        public void GetTableList_ReturnNotNull()
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();

            //Act
            List<BANAN> tablelist = BanAnUseCase.LoadTableList();
            var actualCount = tablelist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Khong co ban nao dang trong");
        }

        [TestCase("1")]    //passed
        [TestCase("2")]    //passed
        [TestCase("3")]    //passed
        [TestCase("4")]    //passed
        [TestCase("-1")]   //failed
        [TestCase("100")]  //failed
        [TestCase(" ")]    //failed
        public void TimBanAn(string noidung)
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();
            var expectedCount = 1;

            //Act
            List<BANAN> timBanAn = BanAnUseCase.TimBanAn(noidung);
            var actualCount = timBanAn.Count;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay ban");
        }

        [TestCase("1")]    //passed
        [TestCase("2")]    //passed
        [TestCase("3")]    //passed
        [TestCase("4")]    //passed
        [TestCase("-1")]   //failed
        [TestCase("20")]   //failed
        [TestCase("100")]  //failed
        [TestCase(" ")]    //failed
        public void LaySoKhachToiDa(int so)
        {
            //Arr
            var BanAnUseCase = new BanAnUseCase();

            //Act
            int actualCount = BanAnUseCase.LaySoKhachToiDa(so);

            //Assert
            Assert.IsTrue(actualCount != -1, "So khach toi da khong hop le");
        }

    }
}