using System;
using System.Collections.Generic;
using vote.Model;
using vote.Model.Data;
using vote.DAL;

namespace vote
{
	public class ProductsBiz
	{
		public IList<Product> ListAll()
		{
			ProductDAL dal = new ProductDAL ();
			return dal.GetAllProducts ();
		}
	}
}

