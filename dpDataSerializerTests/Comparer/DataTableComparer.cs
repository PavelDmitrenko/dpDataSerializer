using System.Data;

namespace dpDataSerializerTests
{
	public static class DataComparer
	{
		public static bool DataSetsEqual(DataSet ds1, DataSet ds2)
		{
			if (ds1.Tables.Count != ds2.Tables.Count)
				return false;

			if (ds1.Locale.ToString() != ds2.Locale.ToString()
				|| ds1.CaseSensitive != ds2.CaseSensitive
				|| ds1.DataSetName != ds2.DataSetName
				|| ds1.EnforceConstraints != ds2.EnforceConstraints
				|| ds1.Namespace != ds2.Namespace
				|| ds1.Prefix != ds2.Prefix
				) return false;

			for (int i = 0; i < ds1.Tables.Count; i++)
			{
				if (!TablesEqual(ds1.Tables[i], ds2.Tables[i]))
					return false;
			}
			return true;
		}

		public static bool TablesEqual(DataTable tbl1, DataTable tbl2)
		{
			if (tbl1.Rows.Count != tbl2.Rows.Count || tbl1.Columns.Count != tbl2.Columns.Count)
				return false;


			for (int i = 0; i < tbl1.Rows.Count; i++)
			{
				for (int c = 0; c < tbl1.Columns.Count; c++)
				{
					if (!Equals(tbl1.Rows[i][c], tbl2.Rows[i][c]))
						return false;
				}
			}
			return true;
		}

	}
}
