using System.Data;
using System.Diagnostics;
using Newtonsoft.Json;

namespace DPDataSerializer
{
	public class DataSetStructure
	{
		public bool CaseSensitive{ get; set; }
		public string DataSetName	{ get; set; }
		public string Namespace{ get; set; }
		public string  Prefix	{ get; set; }
		public string  Locale	{ get; set; }
		public bool EnforceConstraints { get; set; }
		public Table[] Tables { get; set; }

		public DataSet Deserialize(string str)
		{
			DataSet ds = JsonConvert.DeserializeObject<DataSet>(str, new DataSetJsonConverter());
			return ds;
		}

		internal string Serialize(DataSet ds)
		{
			CaseSensitive = ds.CaseSensitive;
			DataSetName = ds.DataSetName;
			Namespace = ds.Namespace;
			Prefix = ds.Prefix;
			Locale = ds.Locale.ToString();
			EnforceConstraints = ds.EnforceConstraints;
			Tables = new Table[ds.Tables.Count];

			for (var index = 0; index < ds.Tables.Count; index++)
			{
				Table table = new Table(ds.Tables[0]);
				Tables[index] = table;
			}

			Formatting formatting = Formatting.None;
			if (Debugger.IsAttached)
				formatting = Formatting.Indented;

			return JsonConvert.SerializeObject(this, new JsonSerializerSettings { Formatting = formatting });
		}
	}
}
