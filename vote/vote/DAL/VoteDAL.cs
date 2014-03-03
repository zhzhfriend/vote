using System;
using System.Data.OleDb;

using vote.Model.Data;

namespace vote.DAL
{
	public class VoteDAL
	{
		DBHelper helper = new DBHelper ();

		public int CountsByIP(string ip)
		{
			helper.OpenConnection ();
			OleDbDataReader reader =  helper.ExecuteQuery ("select count(*) from votes where ip='"+ip+"'");
			int count = 0;
			if (reader.Read ()) {
				count= reader.GetInt32 (0);
			}
			helper.CloseConnection ();
			return count;
		}

		public int Add(Vote vote)
		{
			helper.OpenConnection ();
			var sql = String.Format ("insert into votes (productId,Ip,voteDate) values ({0},'{1}','{2}')", vote.ProductId, vote.IP, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
			int result =  helper.ExecuteNonQuery (sql);
			helper.CloseConnection ();
			return result;
		}

        public int Count(int ProductId)
        {
            helper.OpenConnection();
            //var sql = String.Format("select count(*) from votes where productId={0}", ProductId);
            //int result = helper.ExecuteNonQuery(sql);
            //string varString = Convert.ToString(ProductId);
            OleDbDataReader reader = helper.ExecuteQuery("select count(*) from votes where ProductId='" + ProductId + "'");
            int count = 0;
            if (reader.Read())
            {
                count = reader.GetInt32(0);
            }
            helper.CloseConnection();
            return count;
        }
	}
}

