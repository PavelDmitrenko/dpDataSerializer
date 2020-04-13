using System.Data;
using System.Linq;

namespace DPDataSerializer
{
	public class Table
	{
		public bool CaseSensitive { get; set; }
		public string DisplayExpression { get; set; }
		public string Namespace { get; set; }
		public string Prefix { get; set; }
		public string TableName { get; set; }
		public Column[] Columns { get; set; }
		public object[][] Rows { get; set; }


		public Table(DataTable dt)
		{
			CaseSensitive = dt.CaseSensitive;
			DisplayExpression = dt.DisplayExpression;
			Namespace = dt.Namespace;
			Prefix = dt.Prefix;
			TableName = dt.TableName;

			Columns = dt.Columns.Cast<DataColumn>().Select(x => new Column(x)).ToArray();
			Rows = dt.Rows.Cast<DataRow>().Select(x => x.ItemArray).ToArray();
		}

		public Table()
		{
			// Empty constructor for deserialization
		}
	}

}
