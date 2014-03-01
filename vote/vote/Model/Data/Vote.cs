using System;

namespace vote.Model.Data
{
	public class Vote
	{
		public int Id{ get; set; }
		public int ProductId{ get; set; }
		public String IP{ get; set; }
		public DateTime VoteTime{ get; set; }
	}
}

