namespace System.Text;

public sealed class StringBuilder : ISerializable
{
	internal const int DefaultCapacity = 16; //Field offset: 0x0
	private const string CapacityField = "Capacity"; //Field offset: 0x0
	private const string MaxCapacityField = "m_MaxCapacity"; //Field offset: 0x0
	private const string StringValueField = "m_StringValue"; //Field offset: 0x0
	private const string ThreadIDField = "m_currentThread"; //Field offset: 0x0
	internal const int MaxChunkSize = 8000; //Field offset: 0x0
	internal char[] m_ChunkChars; //Field offset: 0x8
	internal StringBuilder m_ChunkPrevious; //Field offset: 0xC
	internal int m_ChunkLength; //Field offset: 0x10
	internal int m_ChunkOffset; //Field offset: 0x14
	internal int m_MaxCapacity; //Field offset: 0x18

	public int Capacity
	{
		 get { } //Length: 89
	}

	public char Chars
	{
		 get { } //Length: 217
		 set { } //Length: 182
	}

	public int Length
	{
		 get { } //Length: 13
		 set { } //Length: 13
	}

	public int MaxCapacity
	{
		 get { } //Length: 15
	}

	public StringBuilder() { }

	public StringBuilder(int capacity) { }

	public StringBuilder(string value) { }

	public StringBuilder(string value, int capacity) { }

	public StringBuilder(string value, int startIndex, int length, int capacity) { }

	private StringBuilder(SerializationInfo info, StreamingContext context) { }

	private StringBuilder(StringBuilder from) { }

	private StringBuilder(int size, int maxCapacity, StringBuilder previousBlock) { }

	public StringBuilder Append(char* value, int valueCount) { }

	public StringBuilder Append(object value) { }

	public StringBuilder Append(float value) { }

	public StringBuilder Append(int value) { }

	public StringBuilder Append(char value) { }

	public StringBuilder Append(string value, int startIndex, int count) { }

	public StringBuilder Append(string value) { }

	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	public StringBuilder Append(long value) { }

	public StringBuilder Append(char value, int repeatCount) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	public StringBuilder AppendFormat(string format, object[] args) { }

	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	public StringBuilder AppendFormat(string format, object arg0) { }

	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	private void AppendHelper(string value) { }

	public StringBuilder AppendLine() { }

	public StringBuilder AppendLine(string value) { }

	public StringBuilder Clear() { }

	private void ExpandByABlock(int minBlockCharCount) { }

	private StringBuilder FindChunkForIndex(int index) { }

	private static void FormatError() { }

	public int get_Capacity() { }

	public char get_Chars(int index) { }

	public int get_Length() { }

	public int get_MaxCapacity() { }

	public StringBuilder Insert(int index, string value) { }

	private void Insert(int index, char* value, int valueCount) { }

	public StringBuilder Insert(int index, string value, int count) { }

	public StringBuilder Insert(int index, char value) { }

	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	private StringBuilder Next(StringBuilder chunk) { }

	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

	public StringBuilder Remove(int startIndex, int length) { }

	public StringBuilder Replace(string oldValue, string newValue) { }

	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	public void set_Chars(int index, char value) { }

	public void set_Length(int value) { }

	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	public override string ToString() { }

	public string ToString(int startIndex, int length) { }

}

