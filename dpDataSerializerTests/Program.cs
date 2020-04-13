using System;
using System.Data;
using System.Globalization;
using DPDataSerializer;
using Newtonsoft.Json;

namespace DPDataSerializerTests
{
	class Program
	{
		static void Main(string[] args)
		{
			DataSet ds = SampleData();
			DataSetStructure dss = new DataSetStructure(ds);
			var tableStr = JsonConvert.SerializeObject(dss, Formatting.Indented);
			Dt(tableStr);

		}

		private static DataSet Dt(string table)
		{
			DataSet ds = JsonConvert.DeserializeObject<DataSet>(table, new DataSetConverter());
			return ds;
		}
		
		private static DataSet SampleData()
		{
			DataSet sampleDataSet = new DataSet
			{
				Locale = CultureInfo.InvariantCulture
			};

			DataTable sampleDataTable = sampleDataSet.Tables.Add("SampleData");

			var column1 = sampleDataTable.Columns.Add("FirstColumn", typeof(string));
			sampleDataTable.Columns.Add("SecondColumn", typeof(DateTime));

			column1.ExtendedProperties.Add(2, 1);
			column1.ExtendedProperties.Add("Prop2", "string value");
			column1.ExtendedProperties.Add(DateTime.Now.AddYears(1), DateTime.Now);

			for (int i = 1; i <= 49; i++)
			{
				DataRow sampleDataRow = sampleDataTable.NewRow();
				sampleDataRow["FirstColumn"] = "Cell1: " + i.ToString(CultureInfo.CurrentCulture);
				sampleDataRow["SecondColumn"] = DateTime.Now;
				sampleDataTable.Rows.Add(sampleDataRow);
			}

			return sampleDataSet;
		}

	}
}
