//Type is in global namespace

public class TutorialMultilineLabelsHelper : MonoBehaviour
{
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<UILabel, int> <>9__13_0; //Field offset: 0x4
		public static Func<UILabel, int> <>9__13_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <AdjustFontSizes>b__13_0(UILabel title) { }

		internal int <AdjustFontSizes>b__13_1(UILabel subtitle) { }

	}

	private static readonly Vector3 _defaultPosition; //Field offset: 0x0
	private const int DEFAULT_FONT_SIZE_TITLE = 20; //Field offset: 0x0
	private const int DEFAULT_FONT_SIZE_SUBTITLE = 16; //Field offset: 0x0
	private UILabel _label1Title; //Field offset: 0xC
	private UILabel _label1Subtitle; //Field offset: 0x10
	private UILabel _label2Title; //Field offset: 0x14
	private UILabel _label2Subtitle; //Field offset: 0x18
	private UILabel _label3Title; //Field offset: 0x1C
	private UILabel _label3Subtitle; //Field offset: 0x20
	private VerticalLayout _verticalLayout; //Field offset: 0x24

	private static TutorialMultilineLabelsHelper() { }

	public TutorialMultilineLabelsHelper() { }

	public static TutorialMultilineLabelsHelper AddToGameObject(GameObject go, GameObject prefab, Nullable<Vector3> position = null) { }

	private void AdjustFontSizes() { }

	private void SetFontSizes(IEnumerable<UILabel> labels, int fontSize) { }

	public void SetText(string line1, string line2, string line3, string line4, string line5, string line6) { }

	public void SetupPosition(Vector3 position) { }

}

