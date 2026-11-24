namespace System.Resources;

public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable
{
	internal sealed class ResourceEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private ResourceReader _reader; //Field offset: 0x8
		private bool _currentIsValid; //Field offset: 0xC
		private int _currentName; //Field offset: 0x10
		private int _dataPosition; //Field offset: 0x14

		public object Current
		{
			 get { } //Length: 239
		}

		internal int DataPosition
		{
			 get { } //Length: 89
		}

		public DictionaryEntry Entry
		{
			 get { } //Length: 25
		}

		public object Key
		{
			 get { } //Length: 84
		}

		public object Value
		{
			 get { } //Length: 6
		}

		internal ResourceEnumerator(ResourceReader reader) { }

		public object get_Current() { }

		internal int get_DataPosition() { }

		public DictionaryEntry get_Entry() { }

		public object get_Key() { }

		public object get_Value() { }

		public bool MoveNext() { }

		public void Reset() { }

	}

	private BinaryReader _store; //Field offset: 0x8
	internal Dictionary<string, ResourceLocator> _resCache; //Field offset: 0xC
	private long _nameSectionOffset; //Field offset: 0x10
	private long _dataSectionOffset; //Field offset: 0x18
	private int[] _nameHashes; //Field offset: 0x20
	private int* _nameHashesPtr; //Field offset: 0x24
	private int[] _namePositions; //Field offset: 0x28
	private int* _namePositionsPtr; //Field offset: 0x2C
	private RuntimeType[] _typeTable; //Field offset: 0x30
	private int[] _typeNamePositions; //Field offset: 0x34
	private BinaryFormatter _objFormatter; //Field offset: 0x38
	private int _numResources; //Field offset: 0x3C
	private UnmanagedMemoryStream _ums; //Field offset: 0x40
	private int _version; //Field offset: 0x44

	private object _LoadObjectV1(int pos) { }

	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	private void _ReadResources() { }

	internal ResourceReader(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	public void Close() { }

	private bool CompareStringEqualsName(string name) { }

	private object DeserializeObject(int typeIndex) { }

	public void Dispose() { }

	private void Dispose(bool disposing) { }

	internal int FindPosForResource(string name) { }

	private RuntimeType FindType(int typeIndex) { }

	public IDictionaryEnumerator GetEnumerator() { }

	internal ResourceEnumerator GetEnumeratorInternal() { }

	private int GetNameHash(int index) { }

	private int GetNamePosition(int index) { }

	private object GetValueForNameIndex(int index) { }

	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	internal object LoadObject(int pos) { }

	internal object LoadObjectV1(int pos) { }

	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	internal string LoadString(int pos) { }

	private void ReadResources() { }

	internal static int ReadUnalignedI4(int* p) { }

	private void SkipString() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

