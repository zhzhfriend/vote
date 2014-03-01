using System;
using System.Collections.Generic;

using vote.Model.ViewLayer;
using vote.Views;

namespace vote
{
	public class DefaultPagePresenter
	{
		public void ShowAllProducts(IProductListView view)
		{
			IList<Product> products = new List<Product> {
				new Product(){ Id = 1, Title="Product1", VoteCount = 1},
				new Product(){ Id = 2, Title="Product1", VoteCount = 1},
				new Product(){ Id = 3, Title="Product1", VoteCount = 1},
				new Product(){ Id = 4, Title="Product1", VoteCount = 1},
				new Product(){ Id = 5, Title="Product1", VoteCount = 1},
				new Product(){ Id = 6, Title="Product1", VoteCount = 1},
				new Product(){ Id = 7, Title="Product1", VoteCount = 1},
				new Product(){ Id = 8, Title="Product1", VoteCount = 1}
			};
			view.Show (products);
		}
	}
}

