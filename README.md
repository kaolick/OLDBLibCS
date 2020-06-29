# OLDBLibCS: An easy-to-use C# API for OpenligaDB.de

## How to use

The usage is pretty self-explanatory:

```csharp
var oldbApi = new OLDBApi();
var cts = new CancellationTokenSource();

var groups = await _api.GetAvailableGroups("bl1", 2020, cts.Token);
```

For a more detailed description of [OpenligaDB.de](https://openligadb.de) API see [here](https://github.com/OpenLigaDB/OpenLigaDB-Samples).
