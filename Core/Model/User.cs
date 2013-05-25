using System;

namespace Core.Model
{
	public class User
	{
		public virtual long Id { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Email { get; set; }
	}
}

