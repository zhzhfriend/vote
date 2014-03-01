using System;

using vote.Model.Data;
using vote.DAL;

namespace vote.Biz
{
	public class VoteBiz
	{
		public Boolean Vote(Vote vote)
		{
			VoteDAL voteDal = new VoteDAL ();
			if (voteDal.CountsByIP (vote.IP) < 11) {
				voteDal.Add (vote);
				return true;
			} else {
				return false;
			}
		}
	}
}

