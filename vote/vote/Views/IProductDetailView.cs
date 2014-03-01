using System;
using vote.Model.ViewLayer;

namespace vote
{
	public interface IProductDetailView
	{
		void Show(ProductView product);
		void ShowNotFound();
	}
}

