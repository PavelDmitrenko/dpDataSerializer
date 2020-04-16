using System;
using System.Data;
using System.Globalization;
using DPDataSerializer;
using dpDataSerializerTests;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using NUnitTestProject1.DataSource;

namespace NUnitTestProject1
{
	[TestFixture]
	public class Tests
	{
		[Test, TestCaseSource(typeof(DataSetTestData), nameof(DataSetTestData.TestCases))]
		public void DatasetTest(DataSet originalDataset)
		{
			// Serialize System.Data.DataSet to json string
			string serialized = originalDataset.Serialize();
			
			// --> Transfer json string using (e.g.) HTTP transport -->

			// Deserialize back to System.Data.DataSet
			DataSetStructure dsc = new DataSetStructure(); 
			DataSet restoredDataSet = dsc.Deserialize(serialized);

			// Deep compare objects using GregFinzer/Compare-Net-Objects 
			// TODO
			Assert.AreEqual(restoredDataSet.Tables.Count, originalDataset.Tables.Count);
			
		}

	}
}