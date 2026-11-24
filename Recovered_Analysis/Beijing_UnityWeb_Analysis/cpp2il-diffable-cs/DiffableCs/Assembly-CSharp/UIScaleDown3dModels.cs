//Type is in global namespace

public class UIScaleDown3dModels : MonoBehaviour
{
	public enum ScaleAnchorType
	{
		CharacterAnchor = 0,
		GameOverAnchor = 1,
		TutorialPupupAnchor = 2,
	}

	public ScaleAnchorType anchorType; //Field offset: 0xC

	public UIScaleDown3dModels() { }

	private void OnEnable() { }

}

