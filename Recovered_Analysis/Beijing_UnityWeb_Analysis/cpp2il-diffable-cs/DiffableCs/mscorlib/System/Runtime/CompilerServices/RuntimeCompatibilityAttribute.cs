namespace System.Runtime.CompilerServices;

public sealed class RuntimeCompatibilityAttribute : Attribute
{
	private bool m_wrapNonExceptionThrows; //Field offset: 0x8

	public bool WrapNonExceptionThrows
	{
		 set { } //Length: 11
	}

	public RuntimeCompatibilityAttribute() { }

	public void set_WrapNonExceptionThrows(bool value) { }

}

