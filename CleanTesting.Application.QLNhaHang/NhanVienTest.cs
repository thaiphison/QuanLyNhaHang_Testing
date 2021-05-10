using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class NhanVienTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void GetStaffList_ReturnNotNull()
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();

            //Act
            List<NHANVIEN> stafflist = NhanVienUseCase.LoadStaffList();
            var actualCount = stafflist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Danh sach nhan vien dang rong");
        }

        [TestCase("nv01")]      //passed
        [TestCase("nv02")]      //passed
        [TestCase("nv5")]       //passed
        [TestCase("nv2")]       //failed
        [TestCase(" ")]         //failed
        public void TimNhanVien(string noidung)
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();
            var expectedCount = 1;

            //Act
            List<NHANVIEN> timNhanVien = NhanVienUseCase.TimNhanVien(noidung);
            var actualCount = timNhanVien.Count;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Khong tim thay nhan vien");

        }

        [TestCase(" ", "Trinh The Vinh", "0123456788", "0987654321", "vinh", "08/26/2000", "TPHCM",
            "Nguyen Huu Trung", "0123456798", "1", "123456")]     //passed
        [TestCase("nv7", "Trinh The Vinh", "0123456788", "0987654321", "vinh", "08/26/2000", "TPHCM",
            "Nguyen Huu Trung", "0123456798", "1", "123456")]     //passed
        [TestCase("nv1", "Trinh The Vinh", "0123456788", "0987654321", "vinh", "26/08/2000", "TPHCM",
            "Nguyen Huu Trung", "0123456798", "1", "123456")]     //failed
        [TestCase("nv1", "Trinh The Vinh", "0123456788", "0987654321", "vinh", "26/08/2000", "TPHCM",
            "Nguyen Huu Trung", "0123456798", "1", "123456")]        //failed
        public void ThemNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi,
            string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau)
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();
            var expectedCount = 1;

            //Act
            int themNhanVien = NhanVienUseCase.ThemNhanVien(manv, hotennv, cmnd, sdtnv, mail, ngaysinh, diachi,
                hoten_nguoilienhe, sdt_nguoilienhe, machucvu, matkhau);
            var actualCount = themNhanVien;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Them that bai");
        }

        [TestCase("nv7", "Trinh The Vinh", "0123456788", "0987654321", "vinh123", "26/08/2000", "TPHCM", "Nguyen Huu Trung", "0123456798", "1", "123456")]
        public void SuaNhanVien(string manv, string hotennv, string cmnd, string sdtnv, string mail, string ngaysinh, string diachi, string hoten_nguoilienhe, string sdt_nguoilienhe, int machucvu, string matkhau)
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();
            var expectedCount = 1;

            //Act
            int suaNhanVien = NhanVienUseCase.SuaNhanVien(manv, hotennv, cmnd, sdtnv, mail, ngaysinh, diachi, hoten_nguoilienhe, sdt_nguoilienhe, machucvu, matkhau);
            var actualCount = suaNhanVien;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sua that bai");
        }
        [TestCase("nv7")]
        public void XoaNhanVien(string manv)
        {
            //Arr
            var NhanVienUseCase = new NhanVienUseCase();
            var expectedCount = 1;

            //Act
            int xoaNhanVien = NhanVienUseCase.XoaNhanVien(manv);
            var actualCount = xoaNhanVien;

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Xoa that bai");
        }


    }
}