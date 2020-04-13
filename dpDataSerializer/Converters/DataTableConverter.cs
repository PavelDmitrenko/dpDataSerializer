using System;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DPDataSerializer
{
	public class DataTableConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(DataTable);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			serializer.Converters.Add(new DataColumnConverter());

			DataTable result = new DataTable
			{
				CaseSensitive = jObject[nameof(Table.CaseSensitive)].ToObject<bool>(),
				DisplayExpression = jObject[nameof(Table.DisplayExpression)].ToObject<string>(),
				Namespace = jObject[nameof(Table.Namespace)].ToObject<string>(),
				Prefix = jObject[nameof(Table.Prefix)].ToObject<string>(),
				TableName = jObject[nameof(Table.TableName)].ToObject<string>()
			};
			
			DataColumn[] columns = jObject[nameof(Table.Columns)].ToObject<DataColumn[]>(serializer);
			result.Columns.AddRange(columns);

			object[][] rows = jObject[nameof(Table.Rows)].ToObject<object[][]>();

			foreach (object[] row in rows)
				result.Rows.Add(row);

			return result;
		}

		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}

}
