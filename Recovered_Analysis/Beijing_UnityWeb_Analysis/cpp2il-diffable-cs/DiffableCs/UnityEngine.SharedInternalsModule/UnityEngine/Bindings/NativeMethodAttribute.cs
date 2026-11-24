namespace UnityEngine.Bindings;

internal class NativeMethodAttribute : Attribute
{
	private string <Name>k__BackingField; //Field offset: 0x8
	private bool <IsThreadSafe>k__BackingField; //Field offset: 0xC
	private bool <IsFreeFunction>k__BackingField; //Field offset: 0xD
	private bool <ThrowsException>k__BackingField; //Field offset: 0xE
	private bool <HasExplicitThis>k__BackingField; //Field offset: 0xF

	public bool HasExplicitThis
	{
		 set { } //Length: 11
	}

	public bool IsFreeFunction
	{
		 set { } //Length: 11
	}

	public bool IsThreadSafe
	{
		 set { } //Length: 11
	}

	public string Name
	{
		 set { } //Length: 167
	}

	public bool ThrowsException
	{
		 set { } //Length: 11
	}

	public NativeMethodAttribute() { }

	public NativeMethodAttribute(string name) { }

	public NativeMethodAttribute(string name, bool isFreeFunction) { }

	public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe) { }

	public void set_HasExplicitThis(bool value) { }

	public void set_IsFreeFunction(bool value) { }

	public void set_IsThreadSafe(bool value) { }

	public void set_Name(string value) { }

	public void set_ThrowsException(bool value) { }

}

