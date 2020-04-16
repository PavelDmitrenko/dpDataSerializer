using System;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DPDataSerializer
{
	internal class DataSetJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(DataSet);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			JObject jObject = JObject.Load(reader);
			serializer.Converters.Add(new DataTableJsonConverter());

			DataSet result = new DataSet
			{
				CaseSensitive = jObject[nameof(DataSet.CaseSensitive)].ToObject<bool>(),
				DataSetName = jObject[nameof(DataSet.DataSetName)].ToObject<string>(),
				Namespace = jObject[nameof(DataSet.Namespace)].ToObject<string>(),
				Prefix = jObject[nameof(DataSet.Prefix)].ToObject<string>()
			};

			DataTable[] tables = jObject[nameof(DataSet.Tables)].ToObject<DataTable[]>(serializer);

			foreach (DataTable table in tables)
				result.Tables.Add(table);
	
			return result;
		}

		public override bool CanWrite => false;

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			throw new NotImplementedException();
		}
	}

}
