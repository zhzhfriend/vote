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
<<<<<<< HEAD
			while (reader.NextResult ()) {
				products.Add (new Product (){ Id = reader.GetInt32((int)ProductColumns.Id), Title = reader.GetString ((int)ProductColumns.Title),PicSource=reader.GetString((int)ProductColumns.Pic) });
=======
			while (reader.Read ()) {
				products.Add (new Product (){ Id = reader.GetInt32((int)ProductColumns.Id), Title = reader.GetString ((int)ProductColumns.Title) });
>>>>>>> 9603db858a3a3fd48656d41357d2b854077af382
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

