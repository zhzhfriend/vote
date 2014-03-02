using System;
using System.Collections.Generic;
using System.Data.OleDb;

using vote.Model.Data;

namespace vote.DAL
{
	public class ProductDAL
	{
		DBHelper helper = new DBHelper ();

		public ProductDAL()
		{
		}

		public IList<Product> GetAllProducts()
		{

			helper.OpenConnection ();
			OleDbDataReader reader =  helper.ExecuteQuery ("select * from products");

			IList<Product> products = new List<Product> ();
			while (reader.NextResult ()) {
				products.Add (new Product (){ Id = reader.GetInt32((int)ProductColumns.Id), Title = reader.GetString ((int)ProductColumns.Title),PicSource=reader.GetString((int)ProductColumns.Pic) });
			}

			helper.CloseConnection ();
			return products;
		}

		public Product GetById(int id)
		{
			DBHelper helper = new DBHelper ();
			helper.OpenConnection ();
			OleDbDataReader reader =  helper.ExecuteQuery ("select * from products where id="+id);

			Product product = null;
			while (reader.NextResult ()) {
				product = new Product (){ 
					Id = reader.GetInt32((int)ProductColumns.Id),
					Title = reader.GetString ((int)ProductColumns.Title),
					PDFSource = reader.GetString((int)ProductColumns.Pdf) };
			}

			helper.CloseConnection ();
			return product;
		}


		private enum ProductColumns
		{
			Id,
			Title,
			Pdf,
            Pic
		}
	}
}

