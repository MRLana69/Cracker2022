namespace Kiloo.Common.LocalizationManager;

public class LegalTextData : ScriptableObject
{
	private sealed class <>c__DisplayClass13_0
	{
		public Locale locale; //Field offset: 0x8

		public <>c__DisplayClass13_0() { }

		internal bool <SetLanguage>b__0(LegalLanguage l) { }

	}

	private sealed class <>c__DisplayClass15_0
	{
		public Term term; //Field offset: 0x8

		public <>c__DisplayClass15_0() { }

		internal bool <SyncLanguage>b__0(Term t) { }

	}

	private const string RESOURCE_PATH = "Kiloo/LocalizationManager/LegalTextData"; //Field offset: 0x0
	private static LegalTextData _instance; //Field offset: 0x0
	private LegalLanguage _currentLanguage; //Field offset: 0xC
	public TermKeys termKeys; //Field offset: 0x10
	private LegalLanguage _fallbackLanguage; //Field offset: 0x14
	public List<LegalLanguage> legalLanguages; //Field offset: 0x18

	public static LegalTextData instance
	{
		 get { } //Length: 123
	}

	public LegalTextData() { }

	private void <Load>b__4_0(RefreshType type) { }

	private void DetectLocale() { }

	private void FillEmptyTermsWithFallback() { }

	private void FillMissingLanguageWithFallback(LegalLanguage lang) { }

	public static LegalTextData get_instance() { }

	public CultureInfo GetLegalCulture() { }

	public string GetLegalText(string key) { }

	private void Load() { }

	private void SetLanguage(Locale locale) { }

	public void SetLocale(string localeString) { }

	private void SyncLanguage(LegalLanguage lang) { }

	private void SyncLanguageKeys() { }

}

