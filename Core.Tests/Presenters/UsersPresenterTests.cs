using Core.Presenters;
using Core.Views;
using Moq;
using NUnit.Framework;
using System;

namespace Core.Tests.Presenters
{
	[TestFixture]
	public class UsersPresenterTests
	{
		private Mock<IUsersView> _view;
		private UsersPresenter _presenter;
		
		[SetUp]
		public void SetUp()
		{
			_view = new Mock<IUsersView>();
			_presenter = new UsersPresenter(_view.Object);
		}
		
		[Test]
		public void TestInit()
		{
			_presenter.Init();
			//_view.VerifySet(x => x.Users);
		}
	}
}

