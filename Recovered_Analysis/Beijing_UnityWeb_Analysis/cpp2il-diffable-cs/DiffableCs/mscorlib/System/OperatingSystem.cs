namespace System;

public sealed class OperatingSystem : ICloneable, ISerializable
{
	private PlatformID _platform; //Field offset: 0x8
	private Version _version; //Field offset: 0xC
	private string _servicePack; //Field offset: 0x10

	public PlatformID Platform
	{
		 get { } //Length: 13
	}

	public string ServicePack
	{
		 get { } //Length: 6
	}

	public Version Version
	{
		 get { } //Length: 6
	}

	public OperatingSystem(PlatformID platform, Version version) { }

	private OperatingSystem(SerializationInfo information, StreamingContext context) { }

	public object Clone() { }

	public PlatformID get_Platform() { }

	public string get_ServicePack() { }

	public Version get_Version() { }

	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public override string ToString() { }

}

