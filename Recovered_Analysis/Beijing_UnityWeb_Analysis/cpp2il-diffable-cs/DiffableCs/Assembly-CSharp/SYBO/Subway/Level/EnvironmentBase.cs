namespace SYBO.Subway.Level;

public class EnvironmentBase : EnvironmentObject
{
	public enum EnvironmentBaseType
	{
		Tracks = 0,
		Empty = 1,
	}

	private EnvironmentBaseType _type; //Field offset: 0xC
	private int _numTracks; //Field offset: 0x10
	private int _blockCount; //Field offset: 0x14

	public int BlockCount
	{
		 get { } //Length: 6
	}

	public int NumTracks
	{
		 get { } //Length: 6
	}

	public EnvironmentBaseType Type
	{
		 get { } //Length: 6
	}

	public EnvironmentBase() { }

	public int get_BlockCount() { }

	public int get_NumTracks() { }

	public EnvironmentBaseType get_Type() { }

	private void OnValidate() { }

}

