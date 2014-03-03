using System;
using System.Collections.Generic;

using vote.Model.ViewLayer;
using vote.Views;
using vote.DAL;

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
	}
}

