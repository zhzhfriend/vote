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
			UserBiz userBiz = new UserBiz ();
			if (userBiz.GetCurrentUser ().RandomCode != request.RandomCode)
				view.ShowVoteResult ("验证码错误");
			else if (userBiz.GetCurrentUser ().HaveVoteCount > 9)
				view.ShowVoteResult ("投票失败，您已经投过10张票啦~~");
			else {
				VoteBiz biz = new VoteBiz ();
				if (biz.Vote (new Vote (){ ProductId = request.ProductId, IP = request.IP })) {
					userBiz.GetCurrentUser ().HaveVoteCount++;
					view.ShowVoteResult ("投票成功");
				}
				else
					view.ShowVoteResult ("投票失败，您所在的IP地址已经投过10张票啦~");
			}
		}
	}
}

