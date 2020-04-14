# dpDataSerializer
Serialize ```System.Data.DataTable``` and ```System.Data.DataSet``` objects, providing the ability to transfer objects and deserialize (restore) them without loss between systems using, for example, RESTfull services.

### Supports
* ```ExtendedProperties``` data

### Usage
Inastall via [nuget](https://www.nuget.org/packages/dpDataSerializer/)

### Example
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
          "Caption": "FirstColumn",
          "ColumnName": "FirstColumn",
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
              "Key": "13.04.2021 12:05:13",
              "Value": "2020-04-13T12:05:13.2652827+03:00",
              "ValueType": "System.DateTime"
            },
            {
              "KeyType": "System.DateTime",
              "Key": "13.04.2022 12:05:13",
              "Value": "6ef7363f-d45b-487d-9319-5227c0e5cab4",
              "ValueType": "System.Guid"
            },
            {
              "KeyType": "System.String",
              "Key": "Prop2",
              "Value": "string value",
              "ValueType": "System.String"
            },
            {
              "KeyType": "System.Int32",
              "Key": "2",
              "Value": 1,
              "ValueType": "System.Int32"
            }
          ]
        },
        {
          "AllowDBNull": true,
          "AutoIncrement": false,
          "AutoIncrementSeed": 0,
          "AutoIncrementStep": 1,
          "Caption": "SecondColumn",
          "ColumnName": "SecondColumn",
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
        }
      ],
      "Rows": [
        [
          "Cell1: 1",
          "2020-04-13T12:05:13.2696173"
        ],
        [
          "Cell1: 2",
          "2020-04-13T12:05:13.2705371"
        ],
        [
          "Cell1: 3",
          "2020-04-13T12:05:13.2705899"
        ],
        [
          "Cell1: 4",
          "2020-04-13T12:05:13.2706167"
        ],
        [
          "Cell1: 5",
          "2020-04-13T12:05:13.270621"
        ]
      ]
    }
  ]
}
```
