using Core.Model;
using Core.Presenters;
using Core.Views;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;

namespace WebFormsDemo
{
	public partial class UsersPage : System.Web.UI.Page, IUsersView
	{
		private UsersPresenter _presenter;
		
		protected override void OnPreInit(EventArgs e)
		{
			base.OnPreInit(e);
			_presenter = new UsersPresenter(this);
			_presenter.Init();
		}
		
		public IList<User> Users
		{
			set
			{
				_usersGrid.DataSource = value;
				_usersGrid.DataBind();
			}
		}
	}
}

