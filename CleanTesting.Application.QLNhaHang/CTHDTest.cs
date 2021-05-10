using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class CTHDTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetListCTHD(string id)
        {
            //Arr
            var CTHDUseCase = new CTHDUseCase();

            //Act
            List<CTHD> CTHDllist = CTHDUseCase.GetListCTHD(id);
            var actualCount = CTHDllist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach CTHD dang rong");
        }

        //[TestCase("HD01", "mon3", "1", "90000")]     //passed
        //[TestCase("HD01", "mon20", "2", "60000")]    //passed
        //[TestCase("HD02", "mon1", "1", "80000")]     //passed
        [TestCase(" ", "mon3", "2", "90000")]        //failed
        [TestCase("HD01", " ", "2", "3000")]         //failed
        [TestCase("HD01", "mon2", " ", "50000")]     //failed
        [TestCase("HD02", "mon10", "1", " ")]        //failed
        [TestCase(" ", " ", " ", " ")]               //failed
        public void InsertCTHD(string mahd, string mam, int slmon, decimal tongtien)
        {
            //Arr
            var CTHDUseCase = new CTHDUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = CTHDUseCase.InsertCTHD(mahd, mam, slmon, tongtien);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Them that bai");
        }

        //[TestCase("HD01", "mon10", "3", " 600000")]    //passed
        //[TestCase("HD02", "mon13", "2", "300000")]     //passed
        [TestCase(" ", "mon10", "3", " 360000")]       //failed
        [TestCase("HD01", " ", "2", "60000")]          //failed
        [TestCase("HD01", "mon1", " ", "80000")]       //failed
        [TestCase("HD01", "mon1", "1", " ")]           //failed
        [TestCase(" ", " ", " ", " ")]                 //failed
        public void UpdateSLMonCTHD(string mahd, string mam, int slmon, decimal tongtien)
        {
            //Arr
            var CTHDUseCase = new CTHDUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = CTHDUseCase.UpdateSLMonCTHD(mahd, mam, slmon, tongtien);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Cap nhat that bai");
        }

        [TestCase("HD01", "mon10")]      //passed
        [TestCase("HD02", "mon6")]       //passed
        [TestCase("HD08", "mon6")]       //failed
        [TestCase(" ", "mon6")]          //failed
        [TestCase("HD04", " ")]          //failed
        [TestCase(" ", " ")]             //failed
        public void DeleteCTHD(string mahd, string mam)
        {
            //Arr
            var CTHDUseCase = new CTHDUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = CTHDUseCase.DeleteCTHD(mahd, mam);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Xoa that bai");
        }


    }
}