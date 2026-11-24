namespace System.Text.RegularExpressions;

public class Match : Group
{
	internal static Match _empty; //Field offset: 0x0
	internal GroupCollection _groupcoll; //Field offset: 0x20
	internal Regex _regex; //Field offset: 0x24
	internal int _textbeg; //Field offset: 0x28
	internal int _textpos; //Field offset: 0x2C
	internal int _textend; //Field offset: 0x30
	internal int _textstart; //Field offset: 0x34
	internal int[][] _matches; //Field offset: 0x38
	internal int[] _matchcount; //Field offset: 0x3C
	internal bool _balancing; //Field offset: 0x40

	public static Match Empty
	{
		 get { } //Length: 89
	}

	public virtual GroupCollection Groups
	{
		 get { } //Length: 878
	}

	private static Match() { }

	internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	internal Match() { }

	internal virtual void AddMatch(int cap, int start, int len) { }

	internal virtual void BalanceMatch(int cap) { }

	public static Match get_Empty() { }

	public virtual GroupCollection get_Groups() { }

	internal virtual string GroupToStringImpl(int groupnum) { }

	internal virtual bool IsMatched(int cap) { }

	internal string LastGroupToStringImpl() { }

	internal virtual int MatchIndex(int cap) { }

	internal virtual int MatchLength(int cap) { }

	public Match NextMatch() { }

	internal virtual void RemoveMatch(int cap) { }

	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	internal virtual void Tidy(int textpos) { }

}

