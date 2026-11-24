namespace Mono;

internal struct MonoAssemblyName
{
	public struct <public_key_token>e__FixedBuffer
	{
		public byte FixedElementField; //Field offset: 0x0

	}

	internal nint name; //Field offset: 0x0
	internal nint culture; //Field offset: 0x4
	internal nint hash_value; //Field offset: 0x8
	internal nint public_key; //Field offset: 0xC
	internal <public_key_token>e__FixedBuffer public_key_token; //Field offset: 0x10
	internal uint hash_alg; //Field offset: 0x24
	internal uint hash_len; //Field offset: 0x28
	internal uint flags; //Field offset: 0x2C
	internal ushort major; //Field offset: 0x30
	internal ushort minor; //Field offset: 0x32
	internal ushort build; //Field offset: 0x34
	internal ushort revision; //Field offset: 0x36
	internal ushort arch; //Field offset: 0x38

}

