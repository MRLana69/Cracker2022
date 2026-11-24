namespace UI.Helpers;

public class MostPopularStickerHelper : MonoBehaviour
{
	private const int EXTRA_DEPTH_ON_TOP_OF_PANEL_PLACED_ON = 50; //Field offset: 0x0
	private UILabel _title; //Field offset: 0xC
	private UIWidget _widget; //Field offset: 0x10
	private HorizontalLayout _layout; //Field offset: 0x14
	private UIPanel _contentPanel; //Field offset: 0x18
	private UIPanel _maskPanel; //Field offset: 0x1C

	public int height
	{
		 get { } //Length: 321
	}

	public MostPopularStickerHelper() { }

	public int get_height() { }

	private void OnEnable() { }

	public void SetDepthFrom(int depth) { }

}

