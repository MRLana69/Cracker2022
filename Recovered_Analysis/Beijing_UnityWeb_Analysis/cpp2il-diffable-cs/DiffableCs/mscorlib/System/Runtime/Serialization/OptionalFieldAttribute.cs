namespace System.Runtime.Serialization;

public sealed class OptionalFieldAttribute : Attribute
{
	private int versionAdded; //Field offset: 0x8

	public int VersionAdded
	{
		 set { } //Length: 159
	}

	public OptionalFieldAttribute() { }

	public void set_VersionAdded(int value) { }

}

