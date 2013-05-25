using Core.Model;
using System;
using System.Collections.Generic;

namespace Core.Views
{
	public interface IUsersView
	{
		IList<User> Users { set; }
	}
}

