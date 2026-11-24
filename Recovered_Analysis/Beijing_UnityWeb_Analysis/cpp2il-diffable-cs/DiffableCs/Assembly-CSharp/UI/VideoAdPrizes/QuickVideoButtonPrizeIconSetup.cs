namespace UI.VideoAdPrizes;

public class QuickVideoButtonPrizeIconSetup : PrizeIconSetup
{
	private Texture2D _iconMask; //Field offset: 0x28
	protected UISprite _iconSprite; //Field offset: 0x2C
	private UIPanel _maskPanel; //Field offset: 0x30
	private Transform _unrotateGlint; //Field offset: 0x34

	public Texture2D iconMask
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public override UISprite iconSprite
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public UIPanel maskPanel
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public Transform unrotateGlint
	{
		 get { } //Length: 6
		 set { } //Length: 11
	}

	public QuickVideoButtonPrizeIconSetup() { }

	private void Enable() { }

	public Texture2D get_iconMask() { }

	public override UISprite get_iconSprite() { }

	public UIPanel get_maskPanel() { }

	public Transform get_unrotateGlint() { }

	protected override void OnDeactivate() { }

	protected override void OnSetup() { }

	public void set_iconMask(Texture2D value) { }

	public override void set_iconSprite(UISprite value) { }

	public void set_maskPanel(UIPanel value) { }

	public void set_unrotateGlint(Transform value) { }

	private void SetupMask() { }

}

