using System;
using vote.Views;
using vote.Model.ViewLayer;
using vote.Presenters;

namespace vote.UserControls.CodeBehind
{
	public class Vote:System.Web.UI.Page, IVoteView
	{
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);

			VotePagePresenter presenter = new VotePagePresenter ();
			presenter.Vote (null, this);
		}


		public void ShowVoteResult(string voteResult)
		{
			Response.Clear ();
			Response.Write (voteResult);
			Response.Flush ();
			Response.End ();
		}
	}
}

