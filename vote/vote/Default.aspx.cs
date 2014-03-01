using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using vote.UserControls;
using vote.UserControls.CodeBehind;
using vote.Presenters;
using vote.Views;

using System.Diagnostics;

namespace vote
{
	public class Default:Page
	{
		protected ProductsList UCProductsList;

		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
			base.OnPreRender (e);
			DefaultPagePresenter p = new DefaultPagePresenter ();
			p.ShowAllProducts (UCProductsList as IProductListView);
		}
	}
}

