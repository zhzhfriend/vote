using System;
using System.Web.UI;
using vote.Views;
using vote.Presenters;
using vote.Model.ViewLayer;

namespace vote.UserControls.CodeBehind
{
	public class ProductDetail :Page,IProductDetailView
	{
		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
			ViewProductPresenter presenter = new ViewProductPresenter ();
			presenter.ShowPdf (this);
		}

		public void Show(ProductView product)
		{

		}
		public void ShowNotFound()
		{
			Response.Clear ();
			Response.StatusCode = 404;
			Response.Flush();
		}
	}
}

