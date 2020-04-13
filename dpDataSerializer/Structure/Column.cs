using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DPDataSerializer
{
	public class Column
	{
		public bool AllowDBNull { get; set; }
		public bool AutoIncrement { get; set; }
		public long AutoIncrementSeed { get; set; }
		public long AutoIncrementStep { get; set; }
		public string Caption { get; set; }
		public string ColumnName { get; set; }
		public string Prefix { get; set; }
		public string DataType { get; set; }
		public int DateTimeMode { get; set; }
		public object DefaultValue { get; set; }
		public string Expression { get; set; }
		public int MaxLength { get; set; }
		public string Namespace { get; set; }
		public int Ordinal { get; set; }
		public bool ReadOnly { get; set; }
		public bool Unique { get; set; }
		public int ColumnMapping { get; set; }
		public object Site { get; set; }
		public object Container { get; set; }
		public bool DesignMode { get; set; }
		public Dictionary<object, object> ExtendedProperties { get; set; }

		public Column()
		{
			// Empty constructor for deserialization
		}

		public Column(DataColumn dataColumn)
		{
			AllowDBNull = dataColumn.AllowDBNull;
			AutoIncrement = dataColumn.AutoIncrement;
			AutoIncrementSeed = dataColumn.AutoIncrementSeed;
			AutoIncrementStep = dataColumn.AutoIncrementStep;
			Caption = dataColumn.Caption;
			ColumnName = dataColumn.ColumnName;
			Prefix = dataColumn.Prefix;
			DataType = dataColumn.DataType.FullName;
			DateTimeMode = (int)dataColumn.DateTimeMode;
			DefaultValue = dataColumn.DefaultValue;
			Expression = dataColumn.Expression;
			MaxLength = dataColumn.MaxLength;
			Namespace = dataColumn.Namespace;
			Ordinal = dataColumn.Ordinal;
			ReadOnly = dataColumn.ReadOnly;
			Unique = dataColumn.Unique;
			ColumnMapping = (int)dataColumn.ColumnMapping;
			Site = dataColumn.Site;
			Container = dataColumn.Container;
			DesignMode = dataColumn.DesignMode;

			ExtendedProperties = dataColumn.ExtendedProperties.Cast<DictionaryEntry>().ToDictionary(k => k.Key, v=> v.Value);

		}
	}

}
