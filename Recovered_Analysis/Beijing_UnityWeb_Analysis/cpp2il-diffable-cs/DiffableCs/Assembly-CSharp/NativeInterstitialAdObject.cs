//Type is in global namespace

public class NativeInterstitialAdObject
{
	public const int TITLE_MIN_LENGTH = 20; //Field offset: 0x0
	public const int BODY_MIN_LENGTH = 72; //Field offset: 0x0
	public const int CAT_MIN_LENGTH = 25; //Field offset: 0x0
	private string _title; //Field offset: 0x8
	private string _subtitle; //Field offset: 0xC
	private string _body; //Field offset: 0x10
	private string _socialContext; //Field offset: 0x14
	private string _callToActionText; //Field offset: 0x18
	private string _iconImageURL; //Field offset: 0x1C
	private string _coverImageURL; //Field offset: 0x20
	private Texture2D _iconImage; //Field offset: 0x24
	private Texture2D _coverImage; //Field offset: 0x28
	private bool _valid; //Field offset: 0x2C

	public string Body
	{
		 get { } //Length: 6
	}

	public string CallToActionText
	{
		 get { } //Length: 6
	}

	public Texture2D CoverImage
	{
		 get { } //Length: 6
	}

	public string CoverImageURL
	{
		 get { } //Length: 6
	}

	public Texture2D IconImage
	{
		 get { } //Length: 6
	}

	public string IconImageURL
	{
		 get { } //Length: 6
	}

	public string SocialContext
	{
		 get { } //Length: 6
	}

	public string Subtitle
	{
		 get { } //Length: 6
	}

	public string Title
	{
		 get { } //Length: 9
	}

	public bool Valid
	{
		 get { } //Length: 66
	}

	public NativeInterstitialAdObject(string title, string subtitle, string body, string socialContext, string callToActionText, string iconImageURL, string coverImageURL, Texture2D iconImage, Texture2D coverImage, bool ignoreValidate = false) { }

	public void Dispose() { }

	public string get_Body() { }

	public string get_CallToActionText() { }

	public Texture2D get_CoverImage() { }

	public string get_CoverImageURL() { }

	public Texture2D get_IconImage() { }

	public string get_IconImageURL() { }

	public string get_SocialContext() { }

	public string get_Subtitle() { }

	public string get_Title() { }

	public bool get_Valid() { }

	private static void Log(string msg, Object context = null) { }

	private static void LogError(string msg, Object context = null) { }

	private static void LogWarning(string msg, Object context = null) { }

	public override string ToString() { }

	public bool Validate() { }

}

