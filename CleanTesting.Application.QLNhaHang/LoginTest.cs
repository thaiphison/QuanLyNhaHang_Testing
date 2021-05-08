using NUnit.Framework;
using Usecase;
using System.Collections.Generic;
using Domain.Entities;

namespace tests.Clean_Testing.Application.QLNhaHang
{
	public class LoginTest
	{
		private DataProvider provider = new DataProvider();
		[SetUp]
		public void Setup()
		{
		}
		[TestCase("nv", "123")]
		[TestCase("nv01", "321")]
		[TestCase("nv01", "123")]
		public void Login(string username, string password)
		{
			//Arr
			var CheckLoginUseCase = new CheckLoginUseCase();
			var expectedCount = 1;

			//Act
			int actualcount = CheckLoginUseCase.Login(username, password);

			//Assert
			Assert.IsTrue(actualcount == expectedCount, "Sai tai khoan hoac mat khau");
		}

	}
}