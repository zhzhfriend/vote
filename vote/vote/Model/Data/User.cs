using System;

namespace vote.Model.Data
{
	public class User
	{
		public String SessionId{ get; set; }
		public String RandomCode{ get; set; }
		public int HaveVoteCount{get;set;}
	}
}

