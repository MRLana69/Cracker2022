namespace SYBO.Subway.Promotion;

public class BoardPromotion : PromotionDefinition
{
	private BoardId _boardId; //Field offset: 0x1C
	private Color _backgroundColor; //Field offset: 0x20
	private Color _flashColor; //Field offset: 0x30
	private Color _beamColor; //Field offset: 0x40

	public Color BackgroundColor
	{
		 get { } //Length: 805
	}

	public Color BeamColor
	{
		 get { } //Length: 26
	}

	public BoardId BoardId
	{
		 get { } //Length: 17
	}

	public override DateTime ExpireTime
	{
		 get { } //Length: 109
	}

	public Color FlashColor
	{
		 get { } //Length: 26
	}

	protected override bool IsActiveCheck
	{
		 get { } //Length: 43
	}

	public override string PopupId
	{
		 get { } //Length: 109
	}

	public override DateTime StartTime
	{
		 get { } //Length: 83
	}

	public override string SubtitleId
	{
		 get { } //Length: 109
	}

	public override string TitleId
	{
		 get { } //Length: 6
	}

	public BoardPromotion() { }

	public Color get_BackgroundColor() { }

	public Color get_BeamColor() { }

	public BoardId get_BoardId() { }

	public override DateTime get_ExpireTime() { }

	public Color get_FlashColor() { }

	protected override bool get_IsActiveCheck() { }

	public override string get_PopupId() { }

	public override DateTime get_StartTime() { }

	public override string get_SubtitleId() { }

	public override string get_TitleId() { }

	public override string GetPurchaseFailureFlurryEventValue() { }

	public override string GetPurchaseSuccessFlurryEventValue() { }

	public override bool ShouldTrackPopupCloseFlurryEvent() { }

}

