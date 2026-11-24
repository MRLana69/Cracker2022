namespace SYBO.Subway.Promotion;

public abstract class PromotionDefinition : ScriptableObject
{
	private bool _isEnabled; //Field offset: 0xC
	private string _promotionId; //Field offset: 0x10
	private Texture2D _stickerTexture; //Field offset: 0x14
	private GameObject _buttonPrefab; //Field offset: 0x18

	public GameObject ButtonPrefab
	{
		 get { } //Length: 6
	}

	public abstract DateTime ExpireTime
	{
		 get { } //Length: 0
	}

	public long ExpireTimeUnix
	{
		 get { } //Length: 126
	}

	public bool IsActive
	{
		 get { } //Length: 88
	}

	protected virtual bool IsActiveCheck
	{
		 get { } //Length: 181
	}

	public bool IsEnabled
	{
		 get { } //Length: 3
	}

	public abstract string PopupId
	{
		 get { } //Length: 0
	}

	public string PromotionId
	{
		 get { } //Length: 9
	}

	public abstract DateTime StartTime
	{
		 get { } //Length: 0
	}

	public long StartTimeUnix
	{
		 get { } //Length: 112
	}

	public Texture2D StickerTexture
	{
		 get { } //Length: 6
	}

	public abstract string SubtitleId
	{
		 get { } //Length: 0
	}

	public TimeSpan TimeLeft
	{
		 get { } //Length: 126
	}

	public abstract string TitleId
	{
		 get { } //Length: 0
	}

	protected PromotionDefinition() { }

	public GameObject get_ButtonPrefab() { }

	public abstract DateTime get_ExpireTime() { }

	public long get_ExpireTimeUnix() { }

	public bool get_IsActive() { }

	protected virtual bool get_IsActiveCheck() { }

	public bool get_IsEnabled() { }

	public abstract string get_PopupId() { }

	public string get_PromotionId() { }

	public abstract DateTime get_StartTime() { }

	public long get_StartTimeUnix() { }

	public Texture2D get_StickerTexture() { }

	public abstract string get_SubtitleId() { }

	public TimeSpan get_TimeLeft() { }

	public abstract string get_TitleId() { }

	public abstract string GetPurchaseFailureFlurryEventValue() { }

	public abstract string GetPurchaseSuccessFlurryEventValue() { }

	public abstract bool ShouldTrackPopupCloseFlurryEvent() { }

}

