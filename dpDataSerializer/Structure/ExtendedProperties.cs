using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DPDataSerializer
{
	public class ExtendedProperty
	{
		public string KeyType { get; set; }
		public object Key { get; set; }
		public object Value { get; set; }
		public string ValueType { get; set; }

		public ExtendedProperty(DictionaryEntry entry)
		{
			Key = entry.Key.ToString();
			Value = entry.Value;
			
			KeyType = entry.Key.GetType().FullName;
			ValueType = entry.Value.GetType().FullName;
		}
		
		public ExtendedProperty()
		{
			// Empty constructor for deserialization
		}
		
	}
}
