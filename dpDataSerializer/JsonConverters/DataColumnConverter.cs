using System;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DPDataSerializer
{
	public class DataColumnConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(DataColumn);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			Column column = jObject.ToObject<Column>();

			DataColumn result = new DataColumn
			{
				AllowDBNull = column.AllowDBNull,
				AutoIncrement = column.AutoIncrement,
				AutoIncrementSeed = column.AutoIncrementSeed,
				AutoIncrementStep = column.AutoIncrementStep,
				Caption = column.Caption,
				ColumnName = column.ColumnName,
				Prefix = column.Prefix,
				DataType = Type.GetType(column.DataType),
				DateTimeMode = (DataSetDateTime) column.DateTimeMode,
				DefaultValue = column.DefaultValue,
				Expression = column.Expression,
				MaxLength = column.MaxLength,
				Namespace = column.Namespace,
				ReadOnly = column.ReadOnly,
				Unique = column.Unique,
				ColumnMapping = (MappingType) column.ColumnMapping
			};

			TypeConverters.PropertyCollectionConvert(column.ExtendedProperties, result.ExtendedProperties);

			return result;
		}

		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}

}
