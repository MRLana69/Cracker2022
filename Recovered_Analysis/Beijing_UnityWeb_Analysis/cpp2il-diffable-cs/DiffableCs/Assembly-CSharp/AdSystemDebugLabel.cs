//Type is in global namespace

public class AdSystemDebugLabel : MonoBehaviour
{
	private UILabel _label; //Field offset: 0xC
	private UISprite _background; //Field offset: 0x10
	private int _originalBackgroundWidth; //Field offset: 0x14
	private string _originalLabelText; //Field offset: 0x18

	public AdSystemDebugLabel() { }

	private void Awake() { }

	private void FinishedShowingAd(string adLocationID) { }

	private void OnWillShowAd(string adLocationID) { }

}

