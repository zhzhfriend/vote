using System;
using System.Collections.Generic;
using vote.Model;
using vote.Model.Data;
using vote.DAL;

namespace vote
{
	public class ProductsBiz
	{
		ProductDAL dal = new ProductDAL ();

		public IList<Product> ListAll()
		{
			return dal.GetAllProducts ();
		}

		public Product Detail(int id)
		{
			return dal.GetById (id);
		}
	}
}

