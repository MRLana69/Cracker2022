namespace UI.Screens.CharacterScreenInternal;

public class CharacterOverlayHelper : MonoBehaviour
{
	private CharacterId _cachedType; //Field offset: 0xC
	private int _placementIndex; //Field offset: 0x10
	private Camera _3DClipCam; //Field offset: 0x14
	private Camera _2DOverlayCam; //Field offset: 0x18
	private bool _hasInited; //Field offset: 0x1C
	private Transform _cachedTransform; //Field offset: 0x20
	private Transform _headTransform; //Field offset: 0x24
	private Transform _chestTransform; //Field offset: 0x28
	private Transform _headTrack; //Field offset: 0x2C
	private float _xOffset; //Field offset: 0x30
	private float _yOffset; //Field offset: 0x34
	private UISprite _newBubble; //Field offset: 0x38
	private UISprite _limitedBubble; //Field offset: 0x3C
	private UISprite _limitedIcon; //Field offset: 0x40
	private UISprite _giftBubble; //Field offset: 0x44
	private UISprite _eventBubble; //Field offset: 0x48
	private UISprite _collectBubble; //Field offset: 0x4C
	private Transform _feetTrack; //Field offset: 0x50
	private UISprite _ownedSprite; //Field offset: 0x54
	private UISprite _selectedSprite; //Field offset: 0x58
	private Nullable<CharacterId> _eventCharType; //Field offset: 0x5C

	public CharacterOverlayHelper() { }

	private void EnableEventRelatedElements() { }

	private Nullable<CharacterId> EventCharacter() { }

	public CharacterId GetCharacterType() { }

	public int GetIndex() { }

	public void Init(int index, CharacterId type, Transform transformToTrack, bool selected, int themeVersion = 0) { }

	private void LateUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void RefreshOverlay() { }

	private void RefreshSelection(bool selected) { }

	public void SelectedInMenu() { }

	private void Update() { }

	private void UpdateSelection() { }

}

