namespace Mono;

internal static class RuntimeStructs
{
	internal struct GenericParamInfo
	{
		internal MonoClass* pklass; //Field offset: 0x0
		internal nint name; //Field offset: 0x4
		internal ushort flags; //Field offset: 0x8
		internal uint token; //Field offset: 0xC
		internal MonoClass** constraints; //Field offset: 0x10

	}

	internal struct GPtrArray
	{
		internal nint* data; //Field offset: 0x0
		internal int len; //Field offset: 0x4

	}

	private struct HandleStackMark
	{
		private int size; //Field offset: 0x0
		private int interior_size; //Field offset: 0x4
		private nint chunk; //Field offset: 0x8

	}

	internal struct MonoClass
	{

	}

	private struct MonoError
	{
		private ushort error_code; //Field offset: 0x0
		private ushort hidden_0; //Field offset: 0x2
		private nint hidden_1; //Field offset: 0x4
		private nint hidden_2; //Field offset: 0x8
		private nint hidden_3; //Field offset: 0xC
		private nint hidden_4; //Field offset: 0x10
		private nint hidden_5; //Field offset: 0x14
		private nint hidden_6; //Field offset: 0x18
		private nint hidden_7; //Field offset: 0x1C
		private nint hidden_8; //Field offset: 0x20
		private nint hidden_11; //Field offset: 0x24
		private nint hidden_12; //Field offset: 0x28
		private nint hidden_13; //Field offset: 0x2C
		private nint hidden_14; //Field offset: 0x30
		private nint hidden_15; //Field offset: 0x34
		private nint hidden_16; //Field offset: 0x38
		private nint hidden_17; //Field offset: 0x3C
		private nint hidden_18; //Field offset: 0x40

	}

	internal struct RemoteClass
	{
		internal nint default_vtable; //Field offset: 0x0
		internal nint xdomain_vtable; //Field offset: 0x4
		internal MonoClass* proxy_class; //Field offset: 0x8
		internal nint proxy_class_name; //Field offset: 0xC
		internal uint interface_count; //Field offset: 0x10

	}


}

