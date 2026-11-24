namespace System.Reflection;

public class MethodBody
{
	private ExceptionHandlingClause[] clauses; //Field offset: 0x8
	private LocalVariableInfo[] locals; //Field offset: 0xC
	private byte[] il; //Field offset: 0x10
	private bool init_locals; //Field offset: 0x14
	private int sig_token; //Field offset: 0x18
	private int max_stack; //Field offset: 0x1C

	protected MethodBody() { }

}

