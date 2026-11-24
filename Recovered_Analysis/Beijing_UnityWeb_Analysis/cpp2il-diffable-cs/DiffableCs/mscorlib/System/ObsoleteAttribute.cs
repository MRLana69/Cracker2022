namespace System;

public sealed class ObsoleteAttribute : Attribute
{
	private string _message; //Field offset: 0x8
	private bool _error; //Field offset: 0xC

	public string Message
	{
		 get { } //Length: 85
	}

	public ObsoleteAttribute() { }

	public ObsoleteAttribute(string message) { }

	public ObsoleteAttribute(string message, bool error) { }

	public string get_Message() { }

}

