namespace System.Globalization;

public class TextInfo : ICloneable, IDeserializationCallback
{
	internal static TextInfo s_Invariant; //Field offset: 0x0
	private const int wordSeparatorMask = 536672256; //Field offset: 0x0
	private string m_listSeparator; //Field offset: 0x8
	private bool m_isReadOnly; //Field offset: 0xC
	private string m_cultureName; //Field offset: 0x10
	private CultureData m_cultureData; //Field offset: 0x14
	private string m_textInfoName; //Field offset: 0x18
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; //Field offset: 0x1C
	private string customCultureName; //Field offset: 0x20
	internal int m_nDataItem; //Field offset: 0x24
	internal bool m_useUserOverride; //Field offset: 0x28
	internal int m_win32LangID; //Field offset: 0x2C

	public string CultureName
	{
		 get { } //Length: 13
	}

	internal static TextInfo Invariant
	{
		 get { } //Length: 222
	}

	private bool IsAsciiCasingSameAsInvariant
	{
		 get { } //Length: 12
	}

	internal TextInfo() { }

	internal TextInfo(CultureData cultureData) { }

	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	public virtual object Clone() { }

	internal static int CompareOrdinalIgnoreCase(string str1, string str2) { }

	internal static int CompareOrdinalIgnoreCaseEx(string strA, int indexA, string strB, int indexB, int lengthA, int lengthB) { }

	public override bool Equals(object obj) { }

	public string get_CultureName() { }

	internal static TextInfo get_Invariant() { }

	private bool get_IsAsciiCasingSameAsInvariant() { }

	internal int GetCaseInsensitiveHashCode(string str, bool forceRandomizedHashing, long additionalEntropy) { }

	internal int GetCaseInsensitiveHashCode(string str) { }

	public override int GetHashCode() { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s) { }

	internal static int GetHashCodeOrdinalIgnoreCase(string s, bool forceRandomizedHashing, long additionalEntropy) { }

	private int GetInvariantCaseInsensitiveHashCode(string str) { }

	internal static int IndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	private static int InternalCompareStringOrdinalIgnoreCase(string strA, int indexA, string strB, int indexB, int lenA, int lenB) { }

	private static bool IsAscii(char c) { }

	private static bool IsLetterCategory(UnicodeCategory uc) { }

	private static bool IsWordSeparator(UnicodeCategory category) { }

	internal static int LastIndexOfStringOrdinalIgnoreCase(string source, string value, int startIndex, int count) { }

	private void OnDeserialized(StreamingContext ctx) { }

	private void OnDeserialized() { }

	private void OnDeserializing(StreamingContext ctx) { }

	private void OnSerializing(StreamingContext ctx) { }

	internal void SetReadOnlyState(bool readOnly) { }

	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	public virtual string ToLower(string str) { }

	public virtual char ToLower(char c) { }

	private static char ToLowerAsciiInvariant(char c) { }

	private char ToLowerInternal(char c) { }

	private string ToLowerInternal(string str) { }

	public override string ToString() { }

	public string ToTitleCase(string str) { }

	public virtual string ToUpper(string str) { }

	public virtual char ToUpper(char c) { }

	private static char ToUpperAsciiInvariant(char c) { }

	private string ToUpperInternal(string str) { }

	private char ToUpperInternal(char c) { }

}

