namespace SYBO.Subway.Level;

public class EnvironmentBase : EnvironmentObject
{
	public enum EnvironmentBaseType
	{
		Tracks,
		Empty
	}

	private EnvironmentBaseType _type;

	private int _numTracks = 3;

	private int _blockCount;

	public EnvironmentBaseType Type => _type;

	public int NumTracks => _numTracks;

	public int BlockCount => _blockCount;

	private void OnValidate()
	{
		int num = _blockCount;
		if (_blockCount <= 2)
		{
			num = 2;
		}
		_blockCount = num;
		int num2 = num >> 1;
		int blockCount = num2 << 1;
		_blockCount = blockCount;
	}
}
