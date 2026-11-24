namespace UI.Screens;

public class NotebookScreen : UIScreen
{
	private const int PIXELS_OUTSIDE_THE_BACKGROUND = 84; //Field offset: 0x0
	private const int DECAL_OFFSET = 145; //Field offset: 0x0
	private static NotebookScreen _instance; //Field offset: 0x0
	private UISprite _background; //Field offset: 0x28
	private UISprite _decal; //Field offset: 0x2C
	public UIScrollBar _scrollbar; //Field offset: 0x30

	public NotebookScreen() { }

	public override void AdjustToResolution() { }

	private void Awake() { }

	public static void SetDecalState(bool active) { }

}

