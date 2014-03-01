using System;
using vote.Biz;
using vote.Model.ViewLayer;

namespace vote.Presenters
{
	public class ViewProductPresenter
	{
		public void ShowPdf(IProductDetailView view)
		{
			ProductsBiz biz = new ProductsBiz();
			var product = biz.Detail(1);
			if(product!=null)
				view.Show(new ProductView()
					{
						PdfSource="111"
					});
			else
				view.ShowNotFound();
		}
	}
}

