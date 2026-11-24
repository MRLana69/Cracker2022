namespace System.Text.RegularExpressions;

public abstract class RegexRunner
{
	protected internal int runtextbeg; //Field offset: 0x8
	protected internal int runtextend; //Field offset: 0xC
	protected internal int runtextstart; //Field offset: 0x10
	protected internal string runtext; //Field offset: 0x14
	protected internal int runtextpos; //Field offset: 0x18
	protected internal int[] runtrack; //Field offset: 0x1C
	protected internal int runtrackpos; //Field offset: 0x20
	protected internal int[] runstack; //Field offset: 0x24
	protected internal int runstackpos; //Field offset: 0x28
	protected internal int[] runcrawl; //Field offset: 0x2C
	protected internal int runcrawlpos; //Field offset: 0x30
	protected internal int runtrackcount; //Field offset: 0x34
	protected internal Match runmatch; //Field offset: 0x38
	protected internal Regex runregex; //Field offset: 0x3C
	private int timeout; //Field offset: 0x40
	private bool ignoreTimeout; //Field offset: 0x44
	private int timeoutOccursAt; //Field offset: 0x48
	private int timeoutChecksToSkip; //Field offset: 0x4C

	protected internal RegexRunner() { }

	protected void Capture(int capnum, int start, int end) { }

	protected void CheckTimeout() { }

	protected void Crawl(int i) { }

	protected int Crawlpos() { }

	private void DoCheckTimeout() { }

	protected void DoubleCrawl() { }

	protected void DoubleStack() { }

	protected void DoubleTrack() { }

	protected void EnsureStorage() { }

	protected abstract bool FindFirstChar() { }

	protected abstract void Go() { }

	private void InitMatch() { }

	protected abstract void InitTrackCount() { }

	protected bool IsBoundary(int index, int startpos, int endpos) { }

	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	protected bool IsMatched(int cap) { }

	protected int MatchIndex(int cap) { }

	protected int MatchLength(int cap) { }

	protected int Popcrawl() { }

	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	private void StartTimeoutWatch() { }

	private Match TidyMatch(bool quick) { }

	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	protected void Uncapture() { }

}

