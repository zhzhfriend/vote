using System;
using System.Collections.Generic;

using vote.Model.ViewLayer;
using vote.Views;
using vote.DAL;
using vote.Biz;

namespace vote.Presenters
{
	public class DefaultPagePresenter
	{
		public void ShowAllProducts(IProductListView view)
		{
			ProductsBiz biz = new ProductsBiz ();
			IList<Product> products = new List<Product> ();
            VoteDAL votedal=new VoteDAL();

			foreach(var t in biz.ListAll ())
			{
				products.Add (new Product (){ Id = t.Id, Title = t.Title,Pic=t.PicSource.Replace("~","."),VoteCount=votedal.Count(t.Id)});
			}
			view.Show (products);
		}

		public void ShowRandomCode(IRandomView view)
		{
			UserBiz userBiz = new UserBiz ();
			userBiz.GetCurrentUser ().RandomCode = (new Random (DateTime.Now.Millisecond)).Next (0, 10000).ToString();
			view.Show (userBiz.GetCurrentUser ().RandomCode);
		}
	}

}

