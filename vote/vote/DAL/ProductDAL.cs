using System;
using System.Collections.Generic;
using System.Data.OleDb;

using vote.Model.Data;

namespace vote.DAL
{
	public class ProductDAL
	{
		public IList<Product> GetAllProducts()
		{
			DBHelper helper = new DBHelper ();
			helper.OpenConnection ();
			OleDbDataReader reader =  helper.ExecuteQuery ("select * from products");

			IList<Product> products = new List<Product> ();
			while (reader.NextResult ()) {
				products.Add (new Product (){ Id = reader.GetInt32((int)ProductColumns.Id), Title = reader.GetString ((int)ProductColumns.Title) });
			}

			helper.CloseConnection ();
			return products;
		}


		private enum ProductColumns
		{
			Id,
			Title
		}
	}
}

