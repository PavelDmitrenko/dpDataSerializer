# dpDataSerializer
* Serialize ```System.Data.DataTable``` and ```System.Data.DataSet``` objects, providing the ability to transfer objects and deserialize (restore) them without loss between systems (via, for ex., RESTfull service).
* DeepClone ```System.Data.DataTable``` and ```System.Data.DataSet``` objects

### Usage
* Install via [nuget](https://www.nuget.org/packages/dpDataSerializer/)

#### Serialize / Deserialize
```csharp
// Serialize System.Data.DataSet to json string
string jsonString = originalDataset.ToJSON();
			
// --> Transfer json string using (e.g.) HTTP transport -->

// Deserialize back to System.Data.DataSet
DataSet restoredDataSet = jsonString.ToDataSet();

// Compare
bool equals = DataComparer.DataSetsEqual(originalDataset, restoredDataSet);
Assert.That(equals, Is.True);
```
#### DeepClone
```csharp
DataSet cloned = originalDataset.DeepClone();
			
// Compare
bool deepEquals = DataComparer.DataSetsEqual(originalDataset, cloned);
bool referenceEquals = originalDataset == cloned;

Assert.That(deepEquals, Is.True);
Assert.That(referenceEquals, Is.False);
```
   
### Serialization example
#### Original DataSet
![Example](/dpDataSerializerTests/Datatable.png)

#### Serialized DataSet
```javascript
{
  "CaseSensitive": true,
  "DataSetName": "TestDataset",
  "Namespace": "TestNamespace",
  "Prefix": "TestPrefix",
  "Locale": "en-GB",
  "EnforceConstraints": false,
  "Tables": [
    {
      "CaseSensitive": false,
      "DisplayExpression": "",
      "Namespace": "TestNamespace",
      "Prefix": "",
      "TableName": "SampleData",
      "Columns": [
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "StringColumn",
          "ColumnName": "StringColumn",
          "Prefix": "",
          "DataType": "System.String",
          "DateTimeMode": 3,
          "DefaultValue": null,
          "Expression": "",
          "MaxLength": -1,
          "Namespace": "TestNamespace",
          "Ordinal": 0,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": []
        },
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "DateTimeColumn",
          "ColumnName": "DateTimeColumn",
          "Prefix": "",
          "DataType": "System.DateTime",
          "DateTimeMode": 3,
          "DefaultValue": null,
          "Expression": "",
          "MaxLength": -1,
          "Namespace": "TestNamespace",
          "Ordinal": 1,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": []
        },
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "GuidColumn",
          "ColumnName": "GuidColumn",
          "Prefix": "",
          "DataType": "System.Guid",
          "DateTimeMode": 3,
          "DefaultValue": null,
          "Expression": "",
          "MaxLength": -1,
          "Namespace": "TestNamespace",
          "Ordinal": 2,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": []
        },
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "EmptyColumn",
          "ColumnName": "EmptyColumn",
          "Prefix": "",
          "DataType": "System.String",
          "DateTimeMode": 3,
          "DefaultValue": null,
          "Expression": "",
          "MaxLength": -1,
          "Namespace": "TestNamespace",
          "Ordinal": 3,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": []
        },
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "LongColumn",
          "ColumnName": "LongColumn",
          "Prefix": "",
          "DataType": "System.Int64",
          "DateTimeMode": 3,
          "DefaultValue": null,
          "Expression": "",
          "MaxLength": -1,
          "Namespace": "TestNamespace",
          "Ordinal": 4,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": []
        },
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "DecimalColumn",
          "ColumnName": "DecimalColumn",
          "Prefix": "",
          "DataType": "System.Decimal",
          "DateTimeMode": 3,
          "DefaultValue": null,
          "Expression": "",
          "MaxLength": -1,
          "Namespace": "TestNamespace",
          "Ordinal": 5,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": []
        }
      ],
      "Rows": [
        [
          "Cell1: 1",
          "2020-04-21T12:03:57.0328923",
          "2d470c4e-8a23-498a-8c94-bf776954854e",
          null,
          10,
          0.5
        ],
        [
          "Cell1: 2",
          "2020-04-21T12:03:57.0338918",
          "d802481c-33f5-428c-948f-857b345916fe",
          null,
          20,
          1.0
        ],
        [
          "Cell1: 3",
          "2020-04-21T12:03:57.0339998",
          "5602df8f-cd1e-4469-bb26-0b6feb330dd7",
          null,
          30,
          1.5
        ],
        [
          "Cell1: 4",
          "2020-04-21T12:03:57.0340342",
          "4371d661-ecad-4001-8ed1-7865e8f5cf2a",
          null,
          40,
          2.0
        ],
        [
          "Cell1: 5",
          "2020-04-21T12:03:57.0340396",
          "f9548a64-3615-4c38-863a-70db9cc4c2d8",
          null,
          50,
          2.5
        ]
      ]
    }
  ]
}
```
