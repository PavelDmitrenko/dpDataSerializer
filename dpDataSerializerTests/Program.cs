﻿using System;
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
			var tbl = dss.Tables[0];
			var tableStr = JsonConvert.SerializeObject(dss, new JsonSerializerSettings { Formatting =  Formatting.Indented });
			DataSet conv = Dt(tableStr);
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

			var column1 = sampleDataTable.Columns.Add("StringColumn", typeof(string));
			sampleDataTable.Columns.Add("DateTimeColumn", typeof(DateTime));
			sampleDataTable.Columns.Add("GuidColumn", typeof(Guid));
			sampleDataTable.Columns.Add("EmptyColumn", typeof(string));
			sampleDataTable.Columns.Add("LongColumn", typeof(long));
			sampleDataTable.Columns.Add("DecimalColumn", typeof(decimal));

			column1.ExtendedProperties.Add(2, 1);
			column1.ExtendedProperties.Add("Prop2", "string value");
			column1.ExtendedProperties.Add(DateTime.Now.AddYears(1), DateTime.Now);
			column1.ExtendedProperties.Add(DateTime.Now.AddYears(2), Guid.NewGuid());

			for (int i = 1; i <= 5; i++)
			{
				DataRow sampleDataRow = sampleDataTable.NewRow();
				sampleDataRow["StringColumn"] = "Cell1: " + i.ToString(CultureInfo.CurrentCulture);
				sampleDataRow["DateTimeColumn"] = DateTime.Now;
				sampleDataRow["GuidColumn"] = Guid.NewGuid();
				sampleDataRow["EmptyColumn"] = null;
				sampleDataRow["LongColumn"] = i * 10;
				sampleDataRow["DecimalColumn"] = i * 0.5;

				sampleDataTable.Rows.Add(sampleDataRow);
			}

			return sampleDataSet;
		}

	}
}
