namespace System;

internal struct ParamsArray
{
	private static readonly object[] oneArgArray; //Field offset: 0x0
	private static readonly object[] twoArgArray; //Field offset: 0x4
	private static readonly object[] threeArgArray; //Field offset: 0x8
	private readonly object arg0; //Field offset: 0x0
	private readonly object arg1; //Field offset: 0x4
	private readonly object arg2; //Field offset: 0x8
	private readonly object[] args; //Field offset: 0xC

	public object Item
	{
		 get { } //Length: 50
	}

	public int Length
	{
		 get { } //Length: 6
	}

	private static ParamsArray() { }

	public ParamsArray(object arg0) { }

	public ParamsArray(object arg0, object arg1) { }

	public ParamsArray(object arg0, object arg1, object arg2) { }

	public ParamsArray(object[] args) { }

	public object get_Item(int index) { }

	public int get_Length() { }

	private object GetAtSlow(int index) { }

}

