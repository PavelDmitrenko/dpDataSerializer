using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DPDataSerializer
{
	public static class DataSetExtensions
	{
		public static string ToJSON(this DataSet ds)
		{
			DataSetStructure dss = new DataSetStructure();
			string serialized = dss.Serialize(ds);
			return serialized;
		}

		public static DataSet ToDataSet(this string json)
		{
			DataSetStructure dss = new DataSetStructure();
			DataSet ds = dss.Deserialize(json);
			return ds;
		}
		
		public static DataSet DeepClone(this DataSet ds)
		{
			DataSetStructure dss = new DataSetStructure();
			string json = dss.Serialize(ds);
			return dss.Deserialize(json);
		}

	}
}
