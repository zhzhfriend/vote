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
	public class Default:Page, IRandomView
	{
		protected ProductsList UCProductsList;
		protected String RandomCode=string.Empty;

		protected override void OnLoad (EventArgs e)
		{
			base.OnLoad (e);
			DefaultPagePresenter p = new DefaultPagePresenter ();
			p.ShowAllProducts (UCProductsList as IProductListView);

			p.ShowRandomCode (this as IRandomView);
		}

		public void Show (String code)
		{
			this.RandomCode=code;
		}
	}
}

