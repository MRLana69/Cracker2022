namespace UnityEngine.Scripting;

internal class RequiredByNativeCodeAttribute : Attribute
{
	private string <Name>k__BackingField; //Field offset: 0x8
	private bool <Optional>k__BackingField; //Field offset: 0xC
	private bool <GenerateProxy>k__BackingField; //Field offset: 0xD

	public bool GenerateProxy
	{
		 set { } //Length: 11
	}

	public string Name
	{
		 set { } //Length: 11
	}

	public bool Optional
	{
		 set { } //Length: 11
	}

	public RequiredByNativeCodeAttribute() { }

	public RequiredByNativeCodeAttribute(string name) { }

	public void set_GenerateProxy(bool value) { }

	public void set_Name(string value) { }

	public void set_Optional(bool value) { }

}

