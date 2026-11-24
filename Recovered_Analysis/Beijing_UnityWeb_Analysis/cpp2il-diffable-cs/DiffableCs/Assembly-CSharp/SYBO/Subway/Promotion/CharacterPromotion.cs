namespace SYBO.Subway.Promotion;

public class CharacterPromotion : PromotionDefinition
{
	private string _characterIdStr; //Field offset: 0x1C
	private AnimationClip[] _characterAnimations; //Field offset: 0x20
	private bool _useSpecialAssets; //Field offset: 0x24
	private int _themeIndex; //Field offset: 0x28
	private Color _backgroundColor; //Field offset: 0x2C
	private Color _flashColor; //Field offset: 0x3C
	private Color _beamColor; //Field offset: 0x4C
	private Vector2 _stickerPosition; //Field offset: 0x5C
	private Vector2 _stickerScale; //Field offset: 0x64

	public Color BackgroundColor
	{
		 get { } //Length: 26
	}

	public Color BeamColor
	{
		 get { } //Length: 26
	}

	public AnimationClip[] CharacterAnimations
	{
		 get { } //Length: 188
	}

	public CharacterId CharacterId
	{
		 get { } //Length: 85
	}

	public override DateTime ExpireTime
	{
		 get { } //Length: 112
	}

	public Color FlashColor
	{
		 get { } //Length: 27
	}

	protected override bool IsActiveCheck
	{
		 get { } //Length: 43
	}

	public override string PopupId
	{
		 get { } //Length: 112
	}

	public override DateTime StartTime
	{
		 get { } //Length: 109
	}

	public Vector2 StickerPosition
	{
		 get { } //Length: 26
	}

	public Vector2 StickerScale
	{
		 get { } //Length: 11
	}

	public override string SubtitleId
	{
		 get { } //Length: 112
	}

	public int ThemeIndex
	{
		 get { } //Length: 9
	}

	public override string TitleId
	{
		 get { } //Length: 6
	}

	public bool UseSpecialAssets
	{
		 get { } //Length: 6
	}

	public CharacterPromotion() { }

	public Color get_BackgroundColor() { }

	public Color get_BeamColor() { }

	public AnimationClip[] get_CharacterAnimations() { }

	public CharacterId get_CharacterId() { }

	public override DateTime get_ExpireTime() { }

	public Color get_FlashColor() { }

	protected override bool get_IsActiveCheck() { }

	public override string get_PopupId() { }

	public override DateTime get_StartTime() { }

	public Vector2 get_StickerPosition() { }

	public Vector2 get_StickerScale() { }

	public override string get_SubtitleId() { }

	public int get_ThemeIndex() { }

	public override string get_TitleId() { }

	public bool get_UseSpecialAssets() { }

	public override string GetPurchaseFailureFlurryEventValue() { }

	public override string GetPurchaseSuccessFlurryEventValue() { }

	public override bool ShouldTrackPopupCloseFlurryEvent() { }

}

