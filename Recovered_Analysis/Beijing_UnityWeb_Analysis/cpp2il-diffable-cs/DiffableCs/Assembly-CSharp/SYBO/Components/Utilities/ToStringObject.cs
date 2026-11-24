namespace SYBO.Components.Utilities;

public class ToStringObject
{
	private readonly string _objectTypeName; //Field offset: 0x8
	private Dictionary<string, string> _members; //Field offset: 0xC
	private bool _isOneLine; //Field offset: 0x10

	public ToStringObject(object obj, bool isOneLine = true) { }

	public void AddMember(string name, object value) { }

	public string GetValueAsString(object value) { }

	public override string ToString() { }

}

