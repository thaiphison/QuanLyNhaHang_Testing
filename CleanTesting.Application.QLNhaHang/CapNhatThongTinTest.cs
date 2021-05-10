using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class CapNhatThongTinTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("nv02", "Tran Chanh Truc", "026053691", "0987654321", "TPHCM", "1", "123456")]    //passed
                                                                                                    //[TestCase("nv02", "Tran Chanh Truc", " ", "0987654321", "TPHCM", "1", "123456")]    //passed
        public void UpdateAccountProfile(string manv, string hotennv, string cmnd, string sdtnv, string diachi, string chucvu, string matkhau)
        {
            //Arr
            var UpdateAccountProfileUseCase = new UpdateAccountProfileUseCase();
            var expectedCount = 1;

            //Act
            int capnhatthongtin = UpdateAccountProfileUseCase.UpdateAccountProfile(manv, hotennv, cmnd, sdtnv, diachi, chucvu, matkhau);
            var actualCount = capnhatthongtin;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Cap nhat that bai");
        }

    }
}

