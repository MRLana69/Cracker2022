namespace System.Runtime.ConstrainedExecution;

public sealed class ReliabilityContractAttribute : Attribute
{
	private Consistency _consistency; //Field offset: 0x8
	private Cer _cer; //Field offset: 0xC

	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer) { }

}

