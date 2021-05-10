using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class LoginTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("nv01", "123")]        //passed
        [TestCase("nv02", "123456")]     //passed
        [TestCase("nv03", " ")]          //failed
        [TestCase(" ", "123")]           //failed
        [TestCase(" ", " ")]             //failed
        public void Login(string username, string password)
        {
            //Arr
            var CheckLoginUseCase = new CheckLoginUseCase();
            var expectedCount = 1;

            //Act
            int actualCount = CheckLoginUseCase.Login(username, password);

            //Assert
            Assert.IsTrue(actualCount == expectedCount, "Sai tai khoan hoac mat khau");
        }

    }
}