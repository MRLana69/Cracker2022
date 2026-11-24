namespace System.Runtime.InteropServices;

public sealed class MarshalAsAttribute : Attribute
{
	public string MarshalCookie; //Field offset: 0x8
	public string MarshalType; //Field offset: 0xC
	public Type MarshalTypeRef; //Field offset: 0x10
	public Type SafeArrayUserDefinedSubType; //Field offset: 0x14
	private UnmanagedType utype; //Field offset: 0x18
	public UnmanagedType ArraySubType; //Field offset: 0x1C
	public VarEnum SafeArraySubType; //Field offset: 0x20
	public int SizeConst; //Field offset: 0x24
	public int IidParameterIndex; //Field offset: 0x28
	public short SizeParamIndex; //Field offset: 0x2C

	internal MarshalAsAttribute Copy() { }

}

