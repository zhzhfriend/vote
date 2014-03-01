using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vote.Views;
using vote.Model.ViewLayer;

namespace vote.UserControls.CodeBehind
{
	public class ProductsList:System.Web.UI.UserControl, IProductListView
	{
		protected Repeater rptProducts{ get; set; }
		protected Label lblNoProducts{ get; set; }
		protected Panel pnlProductsList{ get; set; }

		public  void Show(IList<Product> products)
		{
			if (products.Count > 0) {
				pnlProductsList.Visible = true;
				lblNoProducts.Visible = false;
				rptProducts.DataSource = products;
				rptProducts.DataBind ();
			}
			else{
				lblNoProducts.Visible = true;
				pnlProductsList.Visible = false;
				}
		}
	}
}

