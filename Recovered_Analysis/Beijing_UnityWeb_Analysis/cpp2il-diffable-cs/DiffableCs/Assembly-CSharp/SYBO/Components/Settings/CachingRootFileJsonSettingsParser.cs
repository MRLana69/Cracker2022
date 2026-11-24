namespace SYBO.Components.Settings;

public class CachingRootFileJsonSettingsParser : ISettingsParser
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WriteFileTextDelegate <>9__5_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <LoadRootSettings>b__5_0(string f, string t) { }

	}

	public delegate FileTextByPathGetter
	{

		public FileTextByPathGetter(object object, nint method) { }

		public virtual IAsyncResult BeginInvoke(string path, AsyncCallback callback, object object) { }

		public virtual string EndInvoke(IAsyncResult result) { }

		public virtual string Invoke(string path) { }

	}

	private FileTextByPathGetter _getFileText; //Field offset: 0x8
	private Dictionary<Type, object> _cachedSettings; //Field offset: 0xC

	public CachingRootFileJsonSettingsParser(FileTextByPathGetter getFileText, Type rootSettingsType, string rootSettingsPath) { }

	private string GetFileText(string path) { }

	private void LoadRootSettings(Type rootSettingsType, string rootSettingsPath) { }

	private object SYBO.Components.Settings.ISettingsParser.ReflectionReadSettings(Type settingsType) { }

}

