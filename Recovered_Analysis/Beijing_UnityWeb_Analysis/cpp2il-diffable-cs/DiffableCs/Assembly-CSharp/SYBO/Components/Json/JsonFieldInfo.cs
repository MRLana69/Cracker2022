namespace SYBO.Components.Json;

public class JsonFieldInfo
{
	public FieldInfo Field; //Field offset: 0x8
	public Type ValueType; //Field offset: 0xC
	public bool SerializeByKey; //Field offset: 0x10
	public bool EnumAsString; //Field offset: 0x11
	public string SerializedName; //Field offset: 0x14
	public int SizeLimit; //Field offset: 0x18
	public bool FailOnSizeLimit; //Field offset: 0x1C
	public string SerializedFileName; //Field offset: 0x20

	public JsonFieldInfo() { }

	public object GetKey(object obj) { }

	public object GetValue(object obj) { }

	public object ReadValue(JsonDict json) { }

	public void SetValue(object obj, object value) { }

	public string ToLimitedString(object value) { }

	public void WriteValue(object value, JsonDict json) { }

}

