using System;
using System.Web;
using vote.Model.Data;

namespace vote.Biz
{
	public class UserBiz
	{
		public User GetCurrentUser()
		{
			if (HttpContext.Current.Session ["User"] == null) {
				HttpContext.Current.Session ["User"] = new User () {
					SessionId = Guid.NewGuid().ToString(),
					HaveVoteCount = 0,
					RandomCode = string.Empty
				};
			}
			return HttpContext.Current.Session ["User"] as User;
		}
	}
}

