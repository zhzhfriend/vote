using System;
using System.Collections.Generic;
using vote.Model.ViewLayer;

namespace vote.Views
{
	public interface IProductListView
	{
		void Show(IList<Product> products);
	}
}

