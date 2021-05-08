using NUnit.Framework;
using Usecase;
using System.Collections.Generic;
using Domain.Entities;

namespace tests.Clean_Testing.Application.QLNhaHang
{
	public class ThongKeTest
	{
		private DataProvider provider = new DataProvider();
		[SetUp]
		public void Setup()
		{
		}
		[TestCase("nv", "123","123")]
		[TestCase("nv01", "321")]
		[TestCase("nv01", "123")]
		public void LoadThongKeNgay(string ngay, string thang, string nam)
		{
			//Arr
			var ThongKeUseCase = new ThongKeUseCase();
			var expectedCount = 1;

			//Act
			List<THONGKE> thongkengay = ThongKeUseCase.LoadThongKeNgay(ngay, thang, nam);
			var actualcount = thongkengay.Count;

			//Assert
			Assert.IsTrue(actualcount >= expectedCount, "Sai tai khoan hoac mat khau");
		}

	}
}