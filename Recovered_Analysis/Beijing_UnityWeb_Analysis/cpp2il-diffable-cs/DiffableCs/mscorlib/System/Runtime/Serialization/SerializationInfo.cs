namespace System.Runtime.Serialization;

public sealed class SerializationInfo
{
	private const int defaultSize = 4; //Field offset: 0x0
	private const string s_mscorlibAssemblySimpleName = "mscorlib"; //Field offset: 0x0
	private const string s_mscorlibFileName = "mscorlib.dll"; //Field offset: 0x0
	internal string[] m_members; //Field offset: 0x8
	internal object[] m_data; //Field offset: 0xC
	internal Type[] m_types; //Field offset: 0x10
	private Dictionary<string, int> m_nameToIndex; //Field offset: 0x14
	internal int m_currMember; //Field offset: 0x18
	internal IFormatterConverter m_converter; //Field offset: 0x1C
	private string m_fullTypeName; //Field offset: 0x20
	private string m_assemName; //Field offset: 0x24
	private Type objectType; //Field offset: 0x28
	private bool isFullTypeNameSetExplicit; //Field offset: 0x2C
	private bool isAssemblyNameSetExplicit; //Field offset: 0x2D
	private bool requireSameTokenInPartialTrust; //Field offset: 0x2E

	public string AssemblyName
	{
		 get { } //Length: 6
	}

	public string FullTypeName
	{
		 get { } //Length: 12
	}

	public bool IsAssemblyNameSetExplicit
	{
		 get { } //Length: 9
	}

	public bool IsFullTypeNameSetExplicit
	{
		 get { } //Length: 6
	}

	public int MemberCount
	{
		 get { } //Length: 6
	}

	public Type ObjectType
	{
		 get { } //Length: 6
	}

	public SerializationInfo(Type type, IFormatterConverter converter) { }

	public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	public void AddValue(string name, DateTime value) { }

	public void AddValue(string name, float value) { }

	public void AddValue(string name, ulong value) { }

	public void AddValue(string name, long value) { }

	public void AddValue(string name, int value) { }

	public void AddValue(string name, short value) { }

	public void AddValue(string name, char value) { }

	public void AddValue(string name, bool value) { }

	public void AddValue(string name, object value) { }

	public void AddValue(string name, object value, Type type) { }

	public void AddValue(string name, byte value) { }

	internal void AddValueInternal(string name, object value, Type type) { }

	private static bool Compare(byte[] a, byte[] b) { }

	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	private void ExpandArrays() { }

	private int FindElement(string name) { }

	public string get_AssemblyName() { }

	public string get_FullTypeName() { }

	public bool get_IsAssemblyNameSetExplicit() { }

	public bool get_IsFullTypeNameSetExplicit() { }

	public int get_MemberCount() { }

	public Type get_ObjectType() { }

	public bool GetBoolean(string name) { }

	private object GetElement(string name, out Type foundType) { }

	private object GetElementNoThrow(string name, out Type foundType) { }

	public SerializationInfoEnumerator GetEnumerator() { }

	public int GetInt32(string name) { }

	public long GetInt64(string name) { }

	public float GetSingle(string name) { }

	public string GetString(string name) { }

	public object GetValue(string name, Type type) { }

	internal object GetValueNoThrow(string name, Type type) { }

	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	public void SetType(Type type) { }

	internal void UpdateValue(string name, object value, Type type) { }

}

