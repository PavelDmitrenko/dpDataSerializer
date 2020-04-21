using System;
using System.Data;
using System.Globalization;
using DPDataSerializer;
using dpDataSerializerTests;
using NUnit.Framework;
using NUnitTestProject1.DataSource;

namespace NUnitTestProject1
{
	[TestFixture]
	public class Tests
	{
		[Test, TestCaseSource(typeof(DataSetTestData), nameof(DataSetTestData.TestCases))]
		public void SerializationDeserialization(DataSet originalDataset)
		{

			// Serialize System.Data.DataSet to json string
			string jsonString = originalDataset.ToJSON();
			
			// --> Transfer json string using (e.g.) HTTP transport -->

			// Deserialize back to System.Data.DataSet
			DataSet restoredDataSet = jsonString.ToDataSet();

			// Compare
			bool equals = DataComparer.DataSetsEqual(originalDataset, restoredDataSet);
			Assert.That(equals, Is.True);
			
		}

		[Test, TestCaseSource(typeof(DataSetTestData), nameof(DataSetTestData.TestCases))]
		public void DeepClone(DataSet originalDataset)
		{
			DataSet cloned = originalDataset.DeepClone();
			
			// Compare
			bool deepEquals = DataComparer.DataSetsEqual(originalDataset, cloned);
			bool referenceEquals = originalDataset == cloned;

			Assert.That(deepEquals, Is.True);
			Assert.That(referenceEquals, Is.False);
			
		}
	}
}