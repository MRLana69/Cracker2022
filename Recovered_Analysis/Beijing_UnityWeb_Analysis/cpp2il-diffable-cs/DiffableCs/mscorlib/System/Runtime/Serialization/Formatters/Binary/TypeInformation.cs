namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class TypeInformation
{
	private string fullTypeName; //Field offset: 0x8
	private string assemblyString; //Field offset: 0xC
	private bool hasTypeForwardedFrom; //Field offset: 0x10

	internal string AssemblyString
	{
		 get { } //Length: 6
	}

	internal string FullTypeName
	{
		 get { } //Length: 82
	}

	internal bool HasTypeForwardedFrom
	{
		 get { } //Length: 6
	}

	internal TypeInformation(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }

	internal string get_AssemblyString() { }

	internal string get_FullTypeName() { }

	internal bool get_HasTypeForwardedFrom() { }

}

