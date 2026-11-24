namespace Mono;

internal struct RuntimeClassHandle
{
	private MonoClass* value; //Field offset: 0x0

	internal MonoClass* Value
	{
		 get { } //Length: 3
	}

	internal RuntimeClassHandle(MonoClass* value) { }

	internal RuntimeClassHandle(nint ptr) { }

	public override bool Equals(object obj) { }

	internal MonoClass* get_Value() { }

	public override int GetHashCode() { }

	internal static nint GetTypeFromClass(MonoClass* klass) { }

	internal RuntimeTypeHandle GetTypeHandle() { }

}

