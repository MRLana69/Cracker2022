//Type is in global namespace

public class ByteReader
{
	private static BetterList<string> mTemp; //Field offset: 0x0
	private byte[] mBuffer; //Field offset: 0x8
	private int mOffset; //Field offset: 0xC

	public bool canRead
	{
		 get { } //Length: 185
	}

	private static ByteReader() { }

	public ByteReader(byte[] bytes) { }

	public ByteReader(TextAsset asset) { }

	public bool get_canRead() { }

	public static ByteReader Open(string path) { }

	public BetterList<string> ReadCSV() { }

	public Dictionary<string, string> ReadDictionary() { }

	private static string ReadLine(byte[] buffer, int start, int count) { }

	public string ReadLine() { }

	public string ReadLine(bool skipEmptyLines) { }

}

