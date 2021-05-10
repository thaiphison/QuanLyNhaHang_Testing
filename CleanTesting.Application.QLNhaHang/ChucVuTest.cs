using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class ChucVuTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetChuVuList_ReturnNotNull()
        {
            //Arr
            var chucvuUseCase = new ChucVuUseCase();

            //Act
            List<CHUCVU> chucvulist = chucvuUseCase.LoadDSChucVu();
            var actualCount = chucvulist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach chuc vu dang rong");
        }

    }
}