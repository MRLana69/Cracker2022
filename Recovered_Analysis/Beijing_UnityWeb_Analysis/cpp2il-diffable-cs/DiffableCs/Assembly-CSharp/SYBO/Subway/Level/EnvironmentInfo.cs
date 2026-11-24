namespace SYBO.Subway.Level;

public class EnvironmentInfo
{
	public static int DefaultMaxMidPieceCount; //Field offset: 0x0
	public static int DefaultMidPieceLengthInBlocks; //Field offset: 0x4
	public static int DefaultMaxMidLengthInBlocks; //Field offset: 0x8
	public static readonly EnvironmentInfo None; //Field offset: 0xC
	public static readonly EnvironmentInfo Empty; //Field offset: 0x10
	public static readonly EnvironmentInfo FillersLow; //Field offset: 0x14
	public static readonly EnvironmentInfo FillersMedium; //Field offset: 0x18
	public static readonly EnvironmentInfo FillersHigh; //Field offset: 0x1C
	public static readonly EnvironmentInfo Gates; //Field offset: 0x20
	public static readonly EnvironmentInfo Tube; //Field offset: 0x24
	public static readonly EnvironmentInfo Pillars; //Field offset: 0x28
	public static readonly EnvironmentInfo Station; //Field offset: 0x2C
	public static readonly EnvironmentInfo Epic; //Field offset: 0x30
	public static readonly EnvironmentInfo[] All; //Field offset: 0x34
	public readonly EnvironmentKind Kind; //Field offset: 0x8
	public readonly bool HasStartEnd; //Field offset: 0xC
	public readonly bool HasSides; //Field offset: 0xD
	public readonly bool UseSameVariationPerSequence; //Field offset: 0xE
	public readonly bool UseSameVariationForSides; //Field offset: 0xF
	public readonly int MaxMidPieceCount; //Field offset: 0x10
	public readonly int MidPieceLengthInBlocks; //Field offset: 0x14
	public readonly int StartEndPieceLengthInBlocks; //Field offset: 0x18

	public int LengthMin
	{
		 get { } //Length: 29
	}

	public int MaxLength
	{
		 get { } //Length: 41
	}

	public int MaxLengthInBlocks
	{
		 get { } //Length: 12
	}

	public int MidLengthMax
	{
		 get { } //Length: 35
	}

	public int MidPieceLength
	{
		 get { } //Length: 155
	}

	public int MinLengthInBlocks
	{
		 get { } //Length: 10
	}

	public int StartEndPieceLength
	{
		 get { } //Length: 10
	}

	private static EnvironmentInfo() { }

	public EnvironmentInfo(EnvironmentKind envKind, bool hasStartEnd, bool hasSides, bool useSameVariationPerSequence, bool useSameVariationForSides, int maxMidPieceCount, int lengthMidPieceInBlocks, int lengthStartEndPieceInBlocks) { }

	public int get_LengthMin() { }

	public int get_MaxLength() { }

	public int get_MaxLengthInBlocks() { }

	public int get_MidLengthMax() { }

	public int get_MidPieceLength() { }

	public int get_MinLengthInBlocks() { }

	public int get_StartEndPieceLength() { }

	public static EnvironmentInfo GetByKind(EnvironmentKind envKind) { }

	public int GetSequenceLengthInBlocks(EnvironmentSequence sequence) { }

}

