using Core.Views;
using System;

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
	}
}

