using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class ThongKeTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("09", "09", "2020")]         //passed
        [TestCase("16", "12", "2020")]         //passed
        [TestCase("09", "04", "2020")]         //failed
        [TestCase("09", "08", "2020")]         //failed
        [TestCase("09", " ", "2020")]          //failed
        [TestCase(" ", " ", " ")]              //failed

        public void GetThongKeNgayList_ReturnNotNull(string ngay, string thang, string nam)
        {
            //Arr
            var thongkeUseCase = new ThongKeUseCase();

            //Arr
            List<THONGKE> danhsackthongke = thongkeUseCase.LoadThongKeNgay(ngay, thang, nam);
            var actualCount = danhsackthongke.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Khong co thong ke trong ngay nay");

        }

        [TestCase("09", "2020")]      //passed
        [TestCase("12", "2020")]      //passed
        [TestCase("01", "2020")]      //passed
        [TestCase("0", "2020")]       //failed
        [TestCase("0", " ")]          //failed
        [TestCase(" ", " ")]          //failed

        public void GetThongKeThangList_ReturnNotNull(string thang, string nam)
        {
            //Arr
            var thongkeUseCase = new ThongKeUseCase();

            //Arr
            List<THONGKE> danhsackthongke = thongkeUseCase.LoadThongKeThang(thang, nam);
            var actualCount = danhsackthongke.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Khong co thong ke trong thang nay");
        }

        [TestCase("2020")]         //passed
        [TestCase("2018")]         //failed
        [TestCase("-1")]           //failed
        [TestCase(" ")]            //failed
        public void GetThongKeNamList_ReturnNotNull(string nam)
        {
            //Arr
            var thongkeUseCase = new ThongKeUseCase();

            //Arr
            List<THONGKE> danhsackthongke = thongkeUseCase.LoadThongKeNam(nam);
            var actualCount = danhsackthongke.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Khong co thong ke trong nam nay");
        }
    }
}