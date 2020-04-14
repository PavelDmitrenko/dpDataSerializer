# dpDataSerializer
Serialize ```System.Data.DataTable``` and ```System.Data.DataSet``` objects, providing the ability to transfer objects and deserialize (restore) them without loss between systems (via, for ex., RESTfull service).

### Supports
* ```ExtendedProperties``` data

### Usage
* Install via [nuget](https://www.nuget.org/packages/dpDataSerializer/)
```csharp
DataSet sampleDataset = SampleData(); // System.Data.DataSet
string serialized = sampleDataset.Serialize(); // Serialize DataSet using extension method

// Transfer string using, for ex., HTTP-transport

DataSet deserialized = dss.Deserialize(serialized); // Deserialize («Restore») back to System.Data.DataSet
```
      
### Example
![Example](/dpDataSerializerTests/Datatable.png)

```javascript
{
  "CaseSensitive": false,
  "DataSetName": "NewDataSet",
  "Namespace": "",
  "Prefix": "",
  "Tables": [
    {
      "CaseSensitive": false,
      "DisplayExpression": "",
      "Namespace": "",
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
          "Namespace": "",
          "Ordinal": 0,
          "ReadOnly": false,
          "Unique": false,
          "ColumnMapping": 1,
          "Site": null,
          "Container": null,
          "DesignMode": false,
          "ExtendedProperties": [
            {
              "KeyType": "System.DateTime",
              "Key": "14.04.2021 16:53:47",
              "Value": "2020-04-14T16:53:47.5120994+03:00",
              "ValueType": "System.DateTime"
            },
            {
              "KeyType": "System.DateTime",
              "Key": "14.04.2022 16:53:47",
              "Value": "51cb0524-a4df-4814-b585-e9f138064ce2",
              "ValueType": "System.Guid"
            },
            {
              "KeyType": "System.Int32",
              "Key": "2",
              "Value": 1,
              "ValueType": "System.Int32"
            },
            {
              "KeyType": "System.String",
              "Key": "Prop2",
              "Value": "string value",
              "ValueType": "System.String"
            }
          ]
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
          "Namespace": "",
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
          "Namespace": "",
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
          "Namespace": "",
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
          "Namespace": "",
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
          "Namespace": "",
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
          "2020-04-14T16:53:47.5268929",
          "322c01f7-8f89-459c-88dd-8dd7554535a4",
          null,
          10,
          0.5
        ],
        [
          "Cell1: 2",
          "2020-04-14T16:53:47.5287357",
          "d27f369d-e08d-4d39-8f3b-1d862c1b0f2c",
          null,
          20,
          1.0
        ],
        [
          "Cell1: 3",
          "2020-04-14T16:53:47.5288012",
          "868fecad-1004-4a54-b9f5-e839b2a80b6d",
          null,
          30,
          1.5
        ],
        [
          "Cell1: 4",
          "2020-04-14T16:53:47.5288311",
          "fe19101b-0023-4bef-8cb7-62e1860fcf42",
          null,
          40,
          2.0
        ],
        [
          "Cell1: 5",
          "2020-04-14T16:53:47.528839",
          "8e27af0c-6b47-46a2-af05-a96bfa2102ce",
          null,
          50,
          2.5
        ]
      ]
    }
  ]
}
```
