using System;
using System.Web.UI;
using vote.Views;
using vote.Presenters;
using vote.Model.ViewLayer;

namespace vote.UserControls.CodeBehind
{
	public class ProductDetail :Page,IProductDetailView
	{
		protected String pdfSource = string.Empty;
		protected String productTitle = string.Empty;

		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
			ViewProductPresenter presenter = new ViewProductPresenter ();
			presenter.ShowPdf (Convert.ToInt32(Request.QueryString["id"]),this);
		}

		public void Show(ProductView product)
		{
			pdfSource = product.PdfSource;
			productTitle = product.Title;
		}
		public void ShowNotFound()
		{
			Response.Clear ();
			Response.StatusCode = 404;
			Response.Flush();
		}
	}
}

