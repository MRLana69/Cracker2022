namespace System.Diagnostics;

public class StackTrace
{
	internal enum TraceFormat
	{
		Normal = 0,
		TrailingNewLine = 1,
		NoResourceLookup = 2,
	}

	public const int METHODS_TO_SKIP = 0; //Field offset: 0x0
	private static bool isAotidSet; //Field offset: 0x0
	private static string aotid; //Field offset: 0x4
	private StackFrame[] frames; //Field offset: 0x8
	private readonly StackTrace[] captured_traces; //Field offset: 0xC
	private bool debug_info; //Field offset: 0x10

	public virtual int FrameCount
	{
		 get { } //Length: 320
	}

	public StackTrace() { }

	public StackTrace(bool fNeedFileInfo) { }

	public StackTrace(int skipFrames, bool fNeedFileInfo) { }

	public StackTrace(Exception e, bool fNeedFileInfo) { }

	public StackTrace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	private bool AddFrames(StringBuilder sb) { }

	public virtual int get_FrameCount() { }

	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	private static string GetAotId() { }

	public virtual StackFrame GetFrame(int index) { }

	internal void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi) { }

	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	public override string ToString() { }

	internal string ToString(TraceFormat traceFormat) { }

}

