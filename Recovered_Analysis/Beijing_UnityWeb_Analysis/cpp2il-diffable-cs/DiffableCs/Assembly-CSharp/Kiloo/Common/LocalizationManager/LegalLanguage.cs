namespace Kiloo.Common.LocalizationManager;

public class LegalLanguage : ScriptableObject
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<string, bool> <>9__6_0; //Field offset: 0x4
		public static Func<string, bool> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ImportLocalePaste>b__6_0(string l) { }

		internal bool <ImportValuePaste>b__7_0(string v) { }

	}

	private sealed class <>c__DisplayClass9_0
	{
		public string key; //Field offset: 0x8

		public <>c__DisplayClass9_0() { }

		internal bool <get_Item>b__0(Term t) { }

	}

	public class Term
	{
		public string key; //Field offset: 0x8
		public string value; //Field offset: 0xC

		public Term() { }

	}

	public string id; //Field offset: 0xC
	private string _localeId; //Field offset: 0x10
	public List<string> affectedLocales; //Field offset: 0x14
	private string _pasteLocaleList; //Field offset: 0x18
	private string _pasteTermValues; //Field offset: 0x1C
	public List<Term> terms; //Field offset: 0x20

	public string Item
	{
		 get { } //Length: 43
	}

	public LegalLanguage() { }

	public string get_Item(string key) { }

	public CultureInfo GetCulture() { }

	private void ImportLocalePaste() { }

	private void ImportValuePaste() { }

	private void OnValidate() { }

}

