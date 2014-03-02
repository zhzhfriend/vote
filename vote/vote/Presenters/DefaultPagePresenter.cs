using System;
using System.Collections.Generic;

using vote.Model.ViewLayer;
using vote.Views;

namespace vote.Presenters
{
	public class DefaultPagePresenter
	{
		public void ShowAllProducts(IProductListView view)
		{
			ProductsBiz biz = new ProductsBiz ();
			IList<Product> products = new List<Product> ();
			foreach(var t in biz.ListAll ())
			{
				products.Add (new Product (){ Id = t.Id, Title = t.Title,Pic=t.PicSource,VoteCount=0});
			}
			view.Show (products);
		}
	}
}

