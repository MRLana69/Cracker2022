namespace System.Globalization;

public class SortKey
{
	private readonly string source; //Field offset: 0x8
	private readonly byte[] key; //Field offset: 0xC
	private readonly CompareOptions options; //Field offset: 0x10
	private readonly int lcid; //Field offset: 0x14

	public virtual byte[] KeyData
	{
		 get { } //Length: 6
	}

	public virtual string OriginalString
	{
		 get { } //Length: 15
	}

	internal SortKey(int lcid, string source, CompareOptions opt) { }

	internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	internal SortKey() { }

	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	public override bool Equals(object value) { }

	public virtual byte[] get_KeyData() { }

	public virtual string get_OriginalString() { }

	public override int GetHashCode() { }

	public override string ToString() { }

}

