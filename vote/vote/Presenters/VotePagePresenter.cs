using System;
using vote.Views;
using vote.Model.ViewLayer;
using vote.Model.Data;
using vote.Biz;

namespace vote.Presenters
{
	public class VotePagePresenter
	{
		public void Vote (VoteRequest request, IVoteView view)
		{
			VoteBiz biz = new VoteBiz ();
			if (biz.Vote (new Vote (){ ProductId = 1 }))
				view.ShowVoteResult ("Success");
			else
				view.ShowVoteResult ("Failure");
		}
	}
}

