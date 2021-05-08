using NUnit.Framework;
using Usecase;
using System.Collections.Generic;
using Domain.Entities;

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
			var monAnUseCase = new MonAnUseCase();
			List<MONAN> foodlist = monAnUseCase.LoadFoodList();
			var actualCount = foodlist.Count;
			Assert.IsTrue(actualCount > 0, "Danh sach mon an dang rong");
		}
		[TestCase("monan1")]
		[TestCase("monan2")]
		[TestCase("monan3")]
		[TestCase("mon6")]
		[TestCase("mon1")]
		[TestCase("mon2")]
		[TestCase("mon3")]
		public void TimMonAn(string value)
		{
			//Arr
			var monAnUseCase = new MonAnUseCase();
			var expectedCount = 1;

			//Act
			List<MONAN> timMonAn = monAnUseCase.TimMonAn(value);
			var actualCount = timMonAn.Count;

			//Assert
			Assert.IsTrue(actualCount > 0, "Khong tim thay mon an");
		}
        [TestCase(" ", "Khoai tay chien", "30000")]

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

        [TestCase("mon10", "Bo bit tet", "120000")]
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
        [TestCase("mon20")]
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