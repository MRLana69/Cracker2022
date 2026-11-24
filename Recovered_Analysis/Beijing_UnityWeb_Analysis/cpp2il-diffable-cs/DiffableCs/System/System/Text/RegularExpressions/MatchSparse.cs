namespace System.Text.RegularExpressions;

internal class MatchSparse : Match
{
	internal Hashtable _caps; //Field offset: 0x44

	public override GroupCollection Groups
	{
		 get { } //Length: 20
	}

	internal MatchSparse(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	public override GroupCollection get_Groups() { }

}

