using System;
using vote.Biz;
using vote.Model.ViewLayer;

namespace vote.Presenters
{
	public class ViewProductPresenter
	{
		public void ShowPdf(int productId, IProductDetailView view)
		{
			ProductsBiz biz = new ProductsBiz();
			var product = biz.Detail(productId);
			if(product!=null)
				view.Show(new ProductView()
					{
						PdfSource=product.PDFSource.Replace("~","."),
						Title = product.Title
					});
			else
				view.ShowNotFound();
		}
	}
}

