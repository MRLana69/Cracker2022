namespace SYBO.Subway.Level;

public class Environment : EnvironmentObject
{
	private EnvironmentKind _environmentKind; //Field offset: 0xC
	private int _blockCount; //Field offset: 0x10

	public int BlockCount
	{
		 get { } //Length: 6
	}

	public EnvironmentKind EnvironmentKind
	{
		 get { } //Length: 6
	}

	public Environment() { }

	public int get_BlockCount() { }

	public EnvironmentKind get_EnvironmentKind() { }

	private void OnDrawGizmos() { }

	private void OnValidate() { }

}

