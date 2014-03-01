using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using vote.Views;
using vote.Model.ViewLayer;

namespace vote.UserControls.CodeBehind
{
	public class ProductsList
	{
		protected Repeater rptProducts{ get; set; }

		public  void Show(IList<Product> products)
		{
			rptProducts.DataSource = products;
		}
	}
}

