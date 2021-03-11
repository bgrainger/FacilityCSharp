# JsonHttpContentSerializerSettings.MemoryStreamCreator property

Called to create a memory stream. Defaults to creating a new MemoryStream.

```csharp
public Func<Stream> MemoryStreamCreator { get; set; }
```

## Remarks

Consider using `Microsoft.IO.RecyclableMemoryStream`.

## See Also

* class [JsonHttpContentSerializerSettings](../JsonHttpContentSerializerSettings.md)
* namespace [Facility.Core.Http](../../Facility.Core.md)

<!-- DO NOT EDIT: generated by xmldocmd for Facility.Core.dll -->