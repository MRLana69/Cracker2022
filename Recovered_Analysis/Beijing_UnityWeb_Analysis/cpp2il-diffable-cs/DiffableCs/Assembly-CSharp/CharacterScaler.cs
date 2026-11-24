//Type is in global namespace

public class CharacterScaler : MonoBehaviour
{
	public enum ScaleAnchorType
	{
		CharacterAnchor = 0,
		GameOverAnchor = 1,
		TutorialPupupAnchor = 2,
		CelebrationPopupAnchor = 3,
		LimitedCharacterPopupAnchor = 4,
		BirthdayAnchor = 5,
		BoardPromotionPopupAnchor = 6,
	}

	private const float STANDARD_ASPECT_RATIO = 1.5; //Field offset: 0x0
	public bool lookAtCamera; //Field offset: 0xC
	private Camera _camera; //Field offset: 0x10
	private ScaleAnchorType _anchorType; //Field offset: 0x14
	private float _posX; //Field offset: 0x18
	private float _posY; //Field offset: 0x1C
	private float _scaleMultiplierForRotation; //Field offset: 0x20
	private float _scaleFactor; //Field offset: 0x24
	private float _scaleDelta; //Field offset: 0x28
	private UIRoot _root; //Field offset: 0x2C

	public CharacterScaler() { }

	private void PositionCharacter() { }

	private void RotateCharacter() { }

	private void ScaleCharacter() { }

	private void SetScreenRelatedSettings() { }

	private void Start() { }

	private void Update() { }

}

