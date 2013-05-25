using Core.Model;
using Core.Views;
using System;
using System.Collections.Generic;

namespace Core.Presenters
{
	public class UsersPresenter
	{
		private IUsersView _view;
		
		public UsersPresenter(IUsersView view)
		{
			if (view == null) throw new ArgumentNullException("Parameter 'view' is null");
			this._view = view;
		}
		
		public void Init()
		{
			_view.Users = new List<User>
			{
				new User { FirstName = "John", LastName = "Martin", Email = "john.martin@mail.com"}
			};
		}
	}
}

