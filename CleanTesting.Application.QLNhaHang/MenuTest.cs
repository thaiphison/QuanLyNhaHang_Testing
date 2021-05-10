using System.Collections.Generic;
using Domain.Entities;
using NUnit.Framework;
using Usecase;

namespace tests.Clean_Testing.Application.QLNhaHang
{
    public class MenuTest
    {
        private DataProvider provider = new DataProvider();
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("2")]       //passed
        [TestCase("4")]       //passed
        [TestCase("1")]       //failed
        [TestCase("-1")]      //failed
        [TestCase("100")]     //failed
        [TestCase(" ")]       //failed
        public void GetMenuList_ReturnNotNull(int id)
        {
            //Arr
            var MenuUseCase = new MenuUseCase();

            //Act
            List<MENU> menulist = MenuUseCase.GetListMenuByTable(id);
            var actualCount = menulist.Count;

            //Assert
            Assert.IsTrue(actualCount > 0, "Menu ban nay dang rong");
        }

    }
}