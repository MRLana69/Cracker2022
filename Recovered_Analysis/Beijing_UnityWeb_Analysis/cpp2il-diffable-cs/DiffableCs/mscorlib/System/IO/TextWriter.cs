namespace System.IO;

public abstract class TextWriter : MarshalByRefObject, IDisposable
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__73_0(object state) { }

		internal void <.cctor>b__73_1(object state) { }

		internal void <.cctor>b__73_2(object state) { }

		internal void <.cctor>b__73_3(object state) { }

		internal void <.cctor>b__73_4(object state) { }

		internal void <.cctor>b__73_5(object state) { }

		internal void <.cctor>b__73_6(object state) { }

	}

	private sealed class NullTextWriter : TextWriter
	{

		public override Encoding Encoding
		{
			 get { } //Length: 151
		}

		internal NullTextWriter() { }

		public override Encoding get_Encoding() { }

		public override void Write(char[] buffer, int index, int count) { }

		public override void Write(string value) { }

		public override void WriteLine() { }

		public override void WriteLine(string value) { }

	}

	internal sealed class SyncTextWriter : TextWriter, IDisposable
	{
		private TextWriter _out; //Field offset: 0x14

		public override Encoding Encoding
		{
			 get { } //Length: 7
		}

		public override IFormatProvider FormatProvider
		{
			 get { } //Length: 12
		}

		internal SyncTextWriter(TextWriter t) { }

		public override void Close() { }

		protected override void Dispose(bool disposing) { }

		public override void Flush() { }

		public override Encoding get_Encoding() { }

		public override IFormatProvider get_FormatProvider() { }

		public override void Write(string value) { }

		public override void Write(int value) { }

		public override void Write(char[] buffer, int index, int count) { }

		public override void Write(char[] buffer) { }

		public override void Write(char value) { }

		public override void WriteLine() { }

		public override void WriteLine(char value) { }

		public override void WriteLine(char[] buffer, int index, int count) { }

		public override void WriteLine(string value) { }

		public override void WriteLine(string format, object arg0) { }

		public override void WriteLine(string format, object arg0, object arg1) { }

	}

	public static readonly TextWriter Null; //Field offset: 0x0
	private static Action<object> _WriteCharDelegate; //Field offset: 0x4
	private static Action<object> _WriteStringDelegate; //Field offset: 0x8
	private static Action<object> _WriteCharArrayRangeDelegate; //Field offset: 0xC
	private static Action<object> _WriteLineCharDelegate; //Field offset: 0x10
	private static Action<object> _WriteLineStringDelegate; //Field offset: 0x14
	private static Action<object> _WriteLineCharArrayRangeDelegate; //Field offset: 0x18
	private static Action<object> _FlushDelegate; //Field offset: 0x1C
	protected char[] CoreNewLine; //Field offset: 0xC
	private IFormatProvider InternalFormatProvider; //Field offset: 0x10

	public abstract Encoding Encoding
	{
		 get { } //Length: 0
	}

	public virtual IFormatProvider FormatProvider
	{
		 get { } //Length: 12
	}

	private static string InitialNewLine
	{
		 get { } //Length: 226
	}

	private static TextWriter() { }

	protected TextWriter() { }

	protected TextWriter(IFormatProvider formatProvider) { }

	public virtual void Close() { }

	protected virtual void Dispose(bool disposing) { }

	public void Dispose() { }

	public virtual void Flush() { }

	public abstract Encoding get_Encoding() { }

	public virtual IFormatProvider get_FormatProvider() { }

	private static string get_InitialNewLine() { }

	public static TextWriter Synchronized(TextWriter writer) { }

	public virtual void Write(char[] buffer) { }

	public virtual void Write(char[] buffer, int index, int count) { }

	public virtual void Write(int value) { }

	public virtual void Write(string value) { }

	public virtual void Write(char value) { }

	public virtual void WriteLine(string format, object arg0, object arg1) { }

	public virtual void WriteLine() { }

	public virtual void WriteLine(char value) { }

	public virtual void WriteLine(char[] buffer, int index, int count) { }

	public virtual void WriteLine(string value) { }

	public virtual void WriteLine(string format, object arg0) { }

}

