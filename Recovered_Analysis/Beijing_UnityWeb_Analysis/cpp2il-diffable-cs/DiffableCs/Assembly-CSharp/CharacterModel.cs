//Type is in global namespace

public class CharacterModel : MonoBehaviour
{
	private sealed class <>c__DisplayClass145_0
	{
		public CharacterModel <>4__this; //Field offset: 0x8
		public string name; //Field offset: 0xC
		public int outfitIndex; //Field offset: 0x10
		public bool useSpecialAsset; //Field offset: 0x14
		public bool deleteSpecialAsset; //Field offset: 0x15

		public <>c__DisplayClass145_0() { }

		internal void <SetCharacterModel>b__0(CharacterAssetsBundle bundle) { }

	}

	private GameObject _rigPrefab; //Field offset: 0xC
	private GameObject ShadowPrefab; //Field offset: 0x10
	private GameObject rigController; //Field offset: 0x14
	private GameObject focusPoint; //Field offset: 0x18
	private GameObject charaterAssetFactoryPrefab; //Field offset: 0x1C
	private TopRunIdleAnimation topRunIdleAnimation; //Field offset: 0x20
	private GameObject _shadowPrefab; //Field offset: 0x24
	private GameObject currentHoverboard; //Field offset: 0x28
	private GameObject _rigController; //Field offset: 0x2C
	private GameObject _focusPoint; //Field offset: 0x30
	private GameObject _sprayCanPrefab; //Field offset: 0x34
	private GameObject _coinMagnetPrefab; //Field offset: 0x38
	private GameObject _jetpackPrefab; //Field offset: 0x3C
	private GameObject _pogostickPrefab; //Field offset: 0x40
	private Renderer currentHoverboadBasemodel; //Field offset: 0x44
	private List<Renderer> currentCustomBoardModelsRenderes; //Field offset: 0x48
	private TopRunIdleAnimation _topRunIdleAnimation; //Field offset: 0x4C
	private GameObject _sprayCanModel; //Field offset: 0x50
	private MeshRenderer _meshCoinMagnet; //Field offset: 0x54
	private MeshRenderer _meshJetpack; //Field offset: 0x58
	private MeshRenderer _meshPogostick; //Field offset: 0x5C
	private Transform _jetpackCloudPositionL; //Field offset: 0x60
	private Transform _jetpackCloudPositionR; //Field offset: 0x64
	private Transform[] _jetpackThrusters; //Field offset: 0x68
	private Transform _attachPoint1; //Field offset: 0x6C
	private Transform _attachPoint2; //Field offset: 0x70
	private Transform _attachPoint3; //Field offset: 0x74
	private Transform _attachPoint4; //Field offset: 0x78
	private Transform _attachPoint5; //Field offset: 0x7C
	private Transform _attachPoint6; //Field offset: 0x80
	private Transform _attachPoint7; //Field offset: 0x84
	private Transform _attachPoint8; //Field offset: 0x88
	private Transform _attachPoint9; //Field offset: 0x8C
	private SkinnedMeshRenderer _model; //Field offset: 0x90
	private SkinnedMeshRenderer _outfitModel; //Field offset: 0x94
	private SkinnedMeshRenderer _headModel; //Field offset: 0x98
	private SkinnedMeshRenderer _meshSuperSneaker; //Field offset: 0x9C
	private SkinnedMeshRenderer _doubleJumpers; //Field offset: 0xA0
	private SkinnedMeshRenderer _rocketSkates; //Field offset: 0xA4
	private Animation _characterAnimation; //Field offset: 0xA8
	private Transform _spineTransform; //Field offset: 0xAC
	private Transform _shoulderTransform; //Field offset: 0xB0
	private Transform _hip; //Field offset: 0xB4
	private Transform _leftFoot; //Field offset: 0xB8
	private Transform _rightFoot; //Field offset: 0xBC
	private Transform _headJoint; //Field offset: 0xC0
	private Transform _rightHand; //Field offset: 0xC4
	private CharacterAssetsBundle _currentModelBundle; //Field offset: 0xC8
	private MeshRenderer _meshBlobShadow; //Field offset: 0xCC
	private GameObject _currentHoverboard; //Field offset: 0xD0
	private List<GameObject> _currentCustomBoardModels; //Field offset: 0xD4
	private List<Renderer> _currentCustomBoardModelsRenderes; //Field offset: 0xD8
	private Dictionary<string, SkinnedMeshRenderer> _modelLookupTable; //Field offset: 0xDC
	private string[] _modelNames; //Field offset: 0xE0
	private CharacterAssetFactory _charaterAssetFactory; //Field offset: 0xE4
	private AvatarEyeAnimation _animEye; //Field offset: 0xE8
	private AvatarAnimations _anim; //Field offset: 0xEC
	private CharacterRig _characterRig; //Field offset: 0xF0
	private bool _isVisibleShadow; //Field offset: 0xF4

	public Transform AttachPoint1
	{
		 get { } //Length: 6
	}

	public Transform AttachPoint2
	{
		 get { } //Length: 6
	}

	public Transform AttachPoint3
	{
		 get { } //Length: 6
	}

	public Transform AttachPoint4
	{
		 get { } //Length: 6
	}

	public Transform AttachPoint5
	{
		 get { } //Length: 6
	}

	public Transform AttachPoint6
	{
		 get { } //Length: 6
	}

	public Transform AttachPoint7
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint8
	{
		 get { } //Length: 7
	}

	public Transform AttachPoint9
	{
		 get { } //Length: 7
	}

	public Animation CharacterAnimation
	{
		 get { } //Length: 7
	}

	public CharacterRig CharacterRig
	{
		 get { } //Length: 13
	}

	public List<GameObject> CurrentCustomBoardModels
	{
		 get { } //Length: 7
	}

	public List<Renderer> CurrentCustomBoardModelsRenderes
	{
		 get { } //Length: 7
	}

	public Renderer CurrentHoverboadBasemodel
	{
		 get { } //Length: 66
		 set { } //Length: 11
	}

	public GameObject CurrentHoverboard
	{
		 get { } //Length: 7
	}

	public List<Renderer> CurrentHoverboardModelsRenderes
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public SkinnedMeshRenderer DoubleJumpers
	{
		 get { } //Length: 7
	}

	public Transform HeadJoint
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer HeadModel
	{
		 get { } //Length: 7
	}

	public Transform Hip
	{
		 get { } //Length: 7
	}

	public bool IsVisibleShadow
	{
		 get { } //Length: 6
		 set { } //Length: 12
	}

	public Transform JetpackCloudPositionL
	{
		 get { } //Length: 9
	}

	public Transform JetpackCloudPositionR
	{
		 get { } //Length: 6
	}

	public Transform[] JetpackThrusters
	{
		 get { } //Length: 6
	}

	public Transform LeftFoot
	{
		 get { } //Length: 7
	}

	public MeshRenderer MeshBlobShadow
	{
		 get { } //Length: 7
	}

	public MeshRenderer MeshCoinMagnet
	{
		 get { } //Length: 9
	}

	public MeshRenderer MeshJetpack
	{
		 get { } //Length: 9
	}

	public MeshRenderer MeshPogostick
	{
		 get { } //Length: 9
	}

	public SkinnedMeshRenderer MeshSuperSneaker
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer Model
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer OutfitModel
	{
		 get { } //Length: 7
	}

	public Transform RightFoot
	{
		 get { } //Length: 7
	}

	public Transform RightHand
	{
		 get { } //Length: 7
	}

	public SkinnedMeshRenderer RocketSkates
	{
		 get { } //Length: 7
	}

	public Transform ShoulderTransform
	{
		 get { } //Length: 7
	}

	public Transform SpineTransform
	{
		 get { } //Length: 7
	}

	public GameObject SprayCanModel
	{
		 get { } //Length: 7
	}

	public TopRunIdleAnimation TopRunIdleAnimation
	{
		 get { } //Length: 7
	}

	public CharacterModel() { }

	public Renderer AddCustomHoverboardModel(GameObject modelPrefab, bool isMenu, Transform parent) { }

	public void AddCustomHoverboardVanityMenuFX(GameObject modelPrefab, Transform parent) { }

	public HoverboardBundle AddEquippedHoverboard() { }

	public HoverboardBundle AddHoverboard(string name, bool isMenu) { }

	public HoverboardBundle AddRandomHoverboard() { }

	private void Awake() { }

	private void BuildRig() { }

	public void ChangeCharacterModel(string name, int outfitIndex, bool useSpecialAsset, bool deleteSpecialAsset) { }

	private void CheckForCharactersToBeInSyncWithStaticData() { }

	public void DeleteBoardModels() { }

	public Transform get_AttachPoint1() { }

	public Transform get_AttachPoint2() { }

	public Transform get_AttachPoint3() { }

	public Transform get_AttachPoint4() { }

	public Transform get_AttachPoint5() { }

	public Transform get_AttachPoint6() { }

	public Transform get_AttachPoint7() { }

	public Transform get_AttachPoint8() { }

	public Transform get_AttachPoint9() { }

	public Animation get_CharacterAnimation() { }

	public CharacterRig get_CharacterRig() { }

	public List<GameObject> get_CurrentCustomBoardModels() { }

	public List<Renderer> get_CurrentCustomBoardModelsRenderes() { }

	public Renderer get_CurrentHoverboadBasemodel() { }

	public GameObject get_CurrentHoverboard() { }

	public List<Renderer> get_CurrentHoverboardModelsRenderes() { }

	public SkinnedMeshRenderer get_DoubleJumpers() { }

	public Transform get_HeadJoint() { }

	public SkinnedMeshRenderer get_HeadModel() { }

	public Transform get_Hip() { }

	public bool get_IsVisibleShadow() { }

	public Transform get_JetpackCloudPositionL() { }

	public Transform get_JetpackCloudPositionR() { }

	public Transform[] get_JetpackThrusters() { }

	public Transform get_LeftFoot() { }

	public MeshRenderer get_MeshBlobShadow() { }

	public MeshRenderer get_MeshCoinMagnet() { }

	public MeshRenderer get_MeshJetpack() { }

	public MeshRenderer get_MeshPogostick() { }

	public SkinnedMeshRenderer get_MeshSuperSneaker() { }

	public SkinnedMeshRenderer get_Model() { }

	public SkinnedMeshRenderer get_OutfitModel() { }

	public Transform get_RightFoot() { }

	public Transform get_RightHand() { }

	public SkinnedMeshRenderer get_RocketSkates() { }

	public Transform get_ShoulderTransform() { }

	public Transform get_SpineTransform() { }

	public GameObject get_SprayCanModel() { }

	public TopRunIdleAnimation get_TopRunIdleAnimation() { }

	private MeshRenderer GetCoinMagnet() { }

	public GameObject GetHoverboardGameObject() { }

	private MeshRenderer GetJetpack() { }

	private MeshRenderer GetPogostick() { }

	private GameObject GetSprayCanModel() { }

	public void HideAllPowerups() { }

	public void HideBlobShadow() { }

	public void HideCurrentHoverboard() { }

	public void InitializeCharacter() { }

	private void OnDestroy() { }

	public void PauseIdleAnimations() { }

	public void RecreateCharacter() { }

	public void RemoveCurrentHoverboard() { }

	public void ResumeIdleAnimations() { }

	public void set_CurrentHoverboadBasemodel(Renderer value) { }

	public void set_CurrentHoverboardModelsRenderes(List<Renderer> value) { }

	public void set_IsVisibleShadow(bool value) { }

	public void SetCharacterModel(string name, int outfitIndex, bool useSpecialAsset, bool deleteSpecialAsset) { }

	public GameObject SetNewHoverboard(GameObject root, GameObject newBoard, string boardName) { }

	private void SetupBoard(HoverboardBundle board, bool isMenu) { }

	private void SetupModel(CharacterAssetsBundle characterAssetBundle, string name, int outfitIndex, bool useSpecialAsset, bool deleteSpecialAsset) { }

	public void ShowCurrentHoverboard() { }

	public void StartCustomAnimation(ModelScreen modelScreen, bool useUnscaledTime, AnimationClip[] clips) { }

	public void StartEyeAnimations(ModelScreen modelScreen) { }

	public void StartIdleAnimations(ModelScreen modelScreen) { }

	public void StartIdlePopupAnimations() { }

	public void StopEyeAnimations() { }

	public void StopIdleAnimations() { }

}

