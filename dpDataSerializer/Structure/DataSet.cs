using System.Data;

namespace DPDataSerializer
{
	public class DataSetStructure
	{
		public bool CaseSensitive{ get; set; }
		public string DataSetName	{ get; set; }
		public string Namespace{ get; set; }
		public string  Prefix	{ get; set; }
		public Table[] Tables { get; set; }

		public DataSetStructure(DataSet ds)
		{
			CaseSensitive = ds.CaseSensitive;
			DataSetName = ds.DataSetName;
			Namespace = ds.Namespace;
			Prefix = ds.Prefix;

			Tables = new Table[ds.Tables.Count];

			for (var index = 0; index < ds.Tables.Count; index++)
			{
				Table table = new Table(ds.Tables[0]);
				Tables[index] = table;
			}
		}
	}
}
