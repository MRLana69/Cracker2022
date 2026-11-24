//Type is in global namespace

public class LinearLayout : MonoBehaviour
{
	public enum LayoutAlignment
	{
		Center = 0,
	}

	public enum LayoutDirection
	{
		Horizontal = 0,
	}

	private bool _updateManually; //Field offset: 0xC
	private int _horizontalSpacing; //Field offset: 0x10
	private bool _useHorizontalWeights; //Field offset: 0x14
	private WeightList _layoutWeights; //Field offset: 0x18

	public WeightList LayoutWeights
	{
		 get { } //Length: 66
	}

	public LinearLayout() { }

	private void Awake() { }

	public WeightList get_LayoutWeights() { }

	private void Update() { }

	public void UpdateChildren() { }

	private void UpdateWidgetAnchors(UIWidget widget) { }

}

