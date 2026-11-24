namespace UnityEngine.Bindings;

internal class NativeConditionalAttribute : Attribute
{
	private string <Condition>k__BackingField; //Field offset: 0x8
	private bool <Enabled>k__BackingField; //Field offset: 0xC

	public string Condition
	{
		 set { } //Length: 18
	}

	public bool Enabled
	{
		 set { } //Length: 11
	}

	public NativeConditionalAttribute(string condition) { }

	public void set_Condition(string value) { }

	public void set_Enabled(bool value) { }

}

