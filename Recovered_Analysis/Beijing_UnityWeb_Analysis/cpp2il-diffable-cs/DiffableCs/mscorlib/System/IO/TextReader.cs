namespace System.IO;

public abstract class TextReader : MarshalByRefObject, IDisposable
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <.cctor>b__22_0(object state) { }

		internal int <.cctor>b__22_1(object state) { }

	}

	private sealed class NullTextReader : TextReader
	{

		public NullTextReader() { }

		public override int Read(char[] buffer, int index, int count) { }

		public override string ReadLine() { }

	}

	internal sealed class SyncTextReader : TextReader
	{
		internal TextReader _in; //Field offset: 0xC

		internal SyncTextReader(TextReader t) { }

		public override void Close() { }

		protected override void Dispose(bool disposing) { }

		public override int Peek() { }

		public override int Read() { }

		public override int Read(out char[] buffer, int index, int count) { }

		public override string ReadLine() { }

		public override string ReadToEnd() { }

	}

	private static Func<object, string> _ReadLineDelegate; //Field offset: 0x0
	private static Func<object, int> _ReadDelegate; //Field offset: 0x4
	public static readonly TextReader Null; //Field offset: 0x8

	private static TextReader() { }

	protected TextReader() { }

	public virtual void Close() { }

	public void Dispose() { }

	protected virtual void Dispose(bool disposing) { }

	public virtual int Peek() { }

	public virtual int Read() { }

	public virtual int Read(out char[] buffer, int index, int count) { }

	public virtual string ReadLine() { }

	public virtual string ReadToEnd() { }

	public static TextReader Synchronized(TextReader reader) { }

}

