using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;

namespace DPDataSerializer
{
	public class TypeConverters
	{
		public static object Convert(object value, string typeName)
		{
			if (value == null)
				return null;
			
			Type type = Type.GetType(typeName);
			
			if (value.GetType() == type)
				return value;
			
			if (type == typeof(Guid))
				return new Guid(value.ToString());
			else if (type == typeof(DateTime))
				return DateTime.ParseExact(value.ToString(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
			else if (type == typeof(int))
				return int.Parse(value.ToString());
			else if (type == typeof(long))
				return long.Parse(value.ToString());

			throw new ArgumentOutOfRangeException(typeName);
		}

		public static void PropertyCollectionConvert(ExtendedProperty[] properties, PropertyCollection collection)
		{
			foreach (ExtendedProperty extendedProperty in properties)
			{
				object key = Convert(extendedProperty.Key, extendedProperty.KeyType);
				object value = Convert(extendedProperty.Value, extendedProperty.ValueType);
				collection.Add(key, value);
			}
		}
	}
}
