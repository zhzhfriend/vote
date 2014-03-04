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
			presenter.Vote (new VoteRequest()
				{ ProductId = Convert.ToInt32(Request.Form["productId"]),
					IP=Request.ServerVariables["REMOTE_ADDR"], 
					RandomCode=Request.Form["randomCode"]
				}, this);
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

