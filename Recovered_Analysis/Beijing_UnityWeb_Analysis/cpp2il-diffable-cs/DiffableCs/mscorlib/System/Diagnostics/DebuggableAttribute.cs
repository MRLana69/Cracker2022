namespace System.Diagnostics;

public sealed class DebuggableAttribute : Attribute
{
	public enum DebuggingModes
	{
		None = 0,
		Default = 1,
		DisableOptimizations = 256,
		IgnoreSymbolStoreSequencePoints = 2,
		EnableEditAndContinue = 4,
	}

	private DebuggingModes m_debuggingModes; //Field offset: 0x8

	public DebuggableAttribute(DebuggingModes modes) { }

}

