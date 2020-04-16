using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DPDataSerializer
{
	public static class DataSetExtensions
	{
		public static string Serialize(this DataSet ds)
		{
			DataSetStructure dss = new DataSetStructure();
			string serialized = dss.Serialize(ds);
			return serialized;
		}

		public static DataSet Deserialize(this DataSet ds, string serialized)
		{
			DataSetStructure dss = new DataSetStructure();
			ds = dss.Deserialize(serialized);
			return ds;
		}
	}
}
