using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Subway.Info;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
	private GameObject _rigPrefab;

	private GameObject ShadowPrefab;

	private GameObject rigController;

	private GameObject focusPoint;

	private GameObject charaterAssetFactoryPrefab;

	private TopRunIdleAnimation topRunIdleAnimation;

	private GameObject _shadowPrefab;

	private GameObject currentHoverboard;

	private GameObject _rigController;

	private GameObject _focusPoint;

	private GameObject _sprayCanPrefab;

	private GameObject _coinMagnetPrefab;

	private GameObject _jetpackPrefab;

	private GameObject _pogostickPrefab;

	private Renderer currentHoverboadBasemodel;

	private List<Renderer> currentCustomBoardModelsRenderes;

	private TopRunIdleAnimation _topRunIdleAnimation;

	private GameObject _sprayCanModel;

	private MeshRenderer _meshCoinMagnet;

	private MeshRenderer _meshJetpack;

	private MeshRenderer _meshPogostick;

	private Transform _jetpackCloudPositionL;

	private Transform _jetpackCloudPositionR;

	private Transform[] _jetpackThrusters;

	private Transform _attachPoint1;

	private Transform _attachPoint2;

	private Transform _attachPoint3;

	private Transform _attachPoint4;

	private Transform _attachPoint5;

	private Transform _attachPoint6;

	private Transform _attachPoint7;

	private Transform _attachPoint8;

	private Transform _attachPoint9;

	private SkinnedMeshRenderer _model;

	private SkinnedMeshRenderer _outfitModel;

	private SkinnedMeshRenderer _headModel;

	private SkinnedMeshRenderer _meshSuperSneaker;

	private SkinnedMeshRenderer _doubleJumpers;

	private SkinnedMeshRenderer _rocketSkates;

	private Animation _characterAnimation;

	private Transform _spineTransform;

	private Transform _shoulderTransform;

	private Transform _hip;

	private Transform _leftFoot;

	private Transform _rightFoot;

	private Transform _headJoint;

	private Transform _rightHand;

	private CharacterAssetsBundle _currentModelBundle;

	private MeshRenderer _meshBlobShadow;

	private GameObject _currentHoverboard;

	private List<GameObject> _currentCustomBoardModels;

	private List<Renderer> _currentCustomBoardModelsRenderes;

	private Dictionary<string, SkinnedMeshRenderer> _modelLookupTable;

	private string[] _modelNames;

	private CharacterAssetFactory _charaterAssetFactory;

	private AvatarEyeAnimation _animEye;

	private AvatarAnimations _anim;

	private CharacterRig _characterRig;

	private bool _isVisibleShadow;

	public Renderer CurrentHoverboadBasemodel
	{
		get
		{
			return currentHoverboadBasemodel;
		}
		set
		{
			currentHoverboadBasemodel = value;
		}
	}

	public List<Renderer> CurrentHoverboardModelsRenderes
	{
		get
		{
			return currentCustomBoardModelsRenderes;
		}
		set
		{
			currentCustomBoardModelsRenderes = value;
		}
	}

	public bool IsVisibleShadow
	{
		get
		{
			return _meshBlobShadow.enabled;
		}
		set
		{
			_meshBlobShadow.enabled = value;
		}
	}

	public CharacterRig CharacterRig => _characterRig;

	public MeshRenderer MeshBlobShadow => _meshBlobShadow;

	public GameObject CurrentHoverboard => _currentHoverboard;

	public List<GameObject> CurrentCustomBoardModels => _currentCustomBoardModels;

	public List<Renderer> CurrentCustomBoardModelsRenderes => _currentCustomBoardModelsRenderes;

	public GameObject SprayCanModel => GetSprayCanModel();

	public MeshRenderer MeshCoinMagnet => GetCoinMagnet();

	public MeshRenderer MeshJetpack => GetJetpack();

	public MeshRenderer MeshPogostick => GetPogostick();

	public Transform JetpackCloudPositionL => _jetpackCloudPositionL;

	public Transform JetpackCloudPositionR => _jetpackCloudPositionR;

	public Transform[] JetpackThrusters => _jetpackThrusters;

	public Transform AttachPoint1 => _attachPoint1;

	public Transform AttachPoint2 => _attachPoint2;

	public Transform AttachPoint3 => _attachPoint3;

	public Transform AttachPoint4 => _attachPoint4;

	public Transform AttachPoint5 => _attachPoint5;

	public Transform AttachPoint6 => _attachPoint6;

	public Transform AttachPoint7 => _attachPoint7;

	public Transform AttachPoint8 => _attachPoint8;

	public Transform AttachPoint9 => _attachPoint9;

	public SkinnedMeshRenderer Model => _model;

	public SkinnedMeshRenderer OutfitModel => _outfitModel;

	public SkinnedMeshRenderer HeadModel => _headModel;

	public SkinnedMeshRenderer MeshSuperSneaker => _meshSuperSneaker;

	public SkinnedMeshRenderer DoubleJumpers => _doubleJumpers;

	public SkinnedMeshRenderer RocketSkates => _rocketSkates;

	public Animation CharacterAnimation => _characterAnimation;

	public Transform SpineTransform => _spineTransform;

	public Transform ShoulderTransform => _shoulderTransform;

	public Transform Hip => _hip;

	public Transform LeftFoot => _leftFoot;

	public Transform RightFoot => _rightFoot;

	public Transform HeadJoint => _headJoint;

	public Transform RightHand => _rightHand;

	public TopRunIdleAnimation TopRunIdleAnimation => _topRunIdleAnimation;

	private void Awake()
	{
		BuildRig();
		GameObject gameObject = UnityEngine.Object.Instantiate(_shadowPrefab);
		Transform transform = gameObject.transform;
		Transform parent = base.transform;
		transform.parent = parent;
		MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
		_meshBlobShadow = component;
		IsVisibleShadow = true;
		PointConstraint component2 = gameObject.GetComponent<PointConstraint>();
		component2.transformCached = _hip;
		GameObject sprayCanModel = GetSprayCanModel();
		GameObject gameObject2 = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ S3_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v75 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		_sprayCanModel.SetActive(value: false);
	}

	private unsafe void BuildRig()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01ec: Expected I, but got Obj
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected VT, but got Unknown
		//IL_0264: Expected I, but got Obj
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected VT, but got Unknown
		//IL_02dc: Expected I, but got Obj
		//IL_0301: Expected F4, but got I
		//IL_02fc: Expected native int or pointer, but got VT
		//IL_030f: Expected F4, but got VT
		//IL_030a: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		GameObject gameObject = UnityEngine.Object.Instantiate(_rigPrefab);
		Transform transform = gameObject.transform;
		Transform parent = _rigController.transform;
		transform.parent = parent;
		Transform transform2 = gameObject.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = gameObject.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v37 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation;
		Transform transform4 = gameObject.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S1_v34 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v35 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
		CharacterRig component = gameObject.GetComponent<CharacterRig>();
		_characterRig = component;
		CharacterRig characterRig = _characterRig;
		_characterAnimation = characterRig.characterAnimation;
		CharacterRig characterRig2 = _characterRig;
		_attachPoint1 = characterRig2.attachPoint1;
		CharacterRig characterRig3 = _characterRig;
		_attachPoint2 = characterRig3.attachPoint2;
		CharacterRig characterRig4 = _characterRig;
		_attachPoint3 = characterRig4.attachPoint3;
		CharacterRig characterRig5 = _characterRig;
		_attachPoint4 = characterRig5.attachPoint4;
		CharacterRig characterRig6 = _characterRig;
		_attachPoint5 = characterRig6.attachPoint5;
		CharacterRig characterRig7 = _characterRig;
		_attachPoint6 = characterRig7.attachPoint6;
		CharacterRig characterRig8 = _characterRig;
		_attachPoint7 = characterRig8.attachPoint7;
		CharacterRig characterRig9 = _characterRig;
		_attachPoint8 = characterRig9.attachPoint8;
		CharacterRig characterRig10 = _characterRig;
		_attachPoint9 = characterRig10.attachPoint9;
		CharacterRig characterRig11 = _characterRig;
		_model = characterRig11.model;
		CharacterRig characterRig12 = _characterRig;
		_outfitModel = characterRig12.outfitModel;
		_outfitModel.enabled = false;
		CharacterRig characterRig13 = _characterRig;
		_headModel = characterRig13.headModel;
		_headModel.enabled = false;
		CharacterRig characterRig14 = _characterRig;
		_meshSuperSneaker = characterRig14.meshSuperSneaker;
		_meshSuperSneaker.enabled = false;
		CharacterRig characterRig15 = _characterRig;
		_doubleJumpers = characterRig15.doubleJumpers;
		_doubleJumpers.enabled = false;
		CharacterRig characterRig16 = _characterRig;
		_rocketSkates = characterRig16.rocketSkates;
		_rocketSkates.enabled = false;
		CharacterRig characterRig17 = _characterRig;
		_characterAnimation = characterRig17.characterAnimation;
		CharacterRig characterRig18 = _characterRig;
		_spineTransform = characterRig18.spineTransform;
		CharacterRig characterRig19 = _characterRig;
		_shoulderTransform = characterRig19.rightShoulderTransform;
		CharacterRig characterRig20 = _characterRig;
		_hip = characterRig20.hip;
		CharacterRig characterRig21 = _characterRig;
		_leftFoot = characterRig21.leftFoot;
		CharacterRig characterRig22 = _characterRig;
		_rightFoot = characterRig22.rightFoot;
		CharacterRig characterRig23 = _characterRig;
		_headJoint = characterRig23.headJoint;
		CharacterRig characterRig24 = _characterRig;
		_rightHand = characterRig24.rightHand;
	}

	public void InitializeCharacter()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected Obj, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		PlayerInfo instance = PlayerInfo.Instance;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<SYBO.Subway.Info.Characters+CharacterType, SYBO.Subway.Info.Characters+Model>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v40 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 == null)
		{
			_ = instance._currentCharacter;
			object obj7 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg = default;
			string text = $"This character index ({arg}) does not exist on this branch. Stop the scene. In the menu bar press \"Tools -> Data files -> Delete PlayerInfo\" and try play the scene again.";
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterType)instance._currentCharacter);
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentThemeIndex = instance2.currentThemeIndex;
		SetCharacterModel(model.modelName, currentThemeIndex, useSpecialAsset: false, deleteSpecialAsset: true);
		CharacterRig characterRig = _characterRig;
		_outfitModel = characterRig.outfitModel;
		Hoverboard instance3 = Hoverboard.Instance;
		instance3.intialize();
		GameObject gameObject = base.gameObject;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S3_v10 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		RunnerAnimPlayer runnerAnimPlayer = default;
		runnerAnimPlayer.Initialize();
		GameObject gameObject2 = base.gameObject;
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr2 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S3_v14 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		KeyframeBehaviour keyframeBehaviour = default;
		keyframeBehaviour.Initialize();
	}

	public void RecreateCharacter()
	{
		PlayerInfo instance = PlayerInfo.Instance;
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterType)instance._currentCharacter);
		PlayerInfo instance2 = PlayerInfo.Instance;
		int currentThemeIndex = instance2.currentThemeIndex;
		ChangeCharacterModel(model.modelName, currentThemeIndex, useSpecialAsset: false, deleteSpecialAsset: true);
		CharacterRig characterRig = _characterRig;
		_outfitModel = characterRig.outfitModel;
		GameObject gameObject = base.gameObject;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v55 @ S3_v7 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		RunnerAnimPlayer runnerAnimPlayer = default;
		runnerAnimPlayer.Initialize();
		GameObject gameObject2 = base.gameObject;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S3_v11 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		KeyframeBehaviour keyframeBehaviour = default;
		keyframeBehaviour.Initialize();
	}

	public void ChangeCharacterModel(string name, int customizedVersion, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		StopIdleAnimations();
		if (_currentModelBundle != null)
		{
			GameObject obj = _currentModelBundle.gameObject;
			UnityEngine.Object.Destroy(obj);
		}
		SetCharacterModel(name, customizedVersion, useSpecialAsset, deleteSpecialAsset);
	}

	public void SetCharacterModel(string name, int customizedVersion, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		throw new ArgumentException();
	}

	private void SetupModel(CharacterAssetsBundle characterAssetBundle, string name, int customizedVersion, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		if (!(characterAssetBundle == null))
		{
			_currentModelBundle = characterAssetBundle;
			GameObject gameObject = _currentModelBundle.gameObject;
			gameObject.name = name;
			Transform transform = _currentModelBundle.transform;
			Transform parent = base.transform;
			transform.parent = parent;
			_model.sharedMesh = characterAssetBundle.MainMesh;
			CharacterRig characterRig = _characterRig;
			_anim = characterRig.avatarAnimations;
			_headModel.enabled = false;
			_headModel.sharedMesh = null;
			_headModel.sharedMesh = characterAssetBundle.HeadMesh;
			Renderer component = _headModel.GetComponent<Renderer>();
			component.enabled = true;
			_anim.Initialize(characterAssetBundle);
			_animEye = characterAssetBundle._avatarEyeAnimation;
			if (_animEye != null)
			{
				CharacterRig characterRig2 = _characterRig;
				_animEye.Initialize(_focusPoint, _headJoint, characterRig2.eyeSwitch, characterRig2.eyeFocusOrigin, characterRig2.eyeFocusTarget, characterRig2.blendShapeController, _headModel, characterAssetBundle.EyeMaterialID);
			}
			CharacterRig characterRig3 = _characterRig;
			characterRig3.characterCustomization.Customize(name, customizedVersion, _model, _outfitModel, _headModel, _characterRig, useSpecialAsset, deleteSpecialAsset, forceLOD0: false);
		}
	}

	private unsafe GameObject GetSprayCanModel()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected VT, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01c4: Expected F4, but got I
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got VT
		//IL_01cd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		object obj2 = this + 80;
		if (_sprayCanModel == null)
		{
			GameObject sprayCanModel = UnityEngine.Object.Instantiate(_sprayCanPrefab);
			_sprayCanModel = sprayCanModel;
			Transform transform = _sprayCanModel.transform;
			transform.parent = _rightHand;
			Transform transform2 = _sprayCanModel.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = ((GameObject)obj2).transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v53 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v54 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = ((GameObject)obj2).transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
		}
		return (GameObject)obj2;
	}

	private unsafe MeshRenderer GetCoinMagnet()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected VT, but got Unknown
		//IL_0127: Expected I, but got Obj
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected VT, but got Unknown
		//IL_019f: Expected I, but got Obj
		//IL_01c4: Expected F4, but got I
		//IL_01bf: Expected native int or pointer, but got VT
		//IL_01d2: Expected F4, but got VT
		//IL_01cd: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		if (_meshCoinMagnet == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(_coinMagnetPrefab);
			CoinMagnet instance = CoinMagnet.Instance;
			instance.Initialize();
			Transform transform = gameObject.transform;
			transform.parent = _rightHand;
			Transform transform2 = gameObject.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v36 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v37 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = gameObject.transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v51 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v52 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = gameObject.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
			nint num7 = 0;
			nint num8 = 0;
			IntPtr intPtr = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v179 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			MeshRenderer meshCoinMagnet = default;
			_meshCoinMagnet = meshCoinMagnet;
			_meshCoinMagnet.enabled = false;
		}
		return _meshCoinMagnet;
	}

	private unsafe MeshRenderer GetJetpack()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0098: Expected I, but got Obj
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected VT, but got Unknown
		//IL_0110: Expected I, but got Obj
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected VT, but got Unknown
		//IL_0188: Expected I, but got Obj
		//IL_01ad: Expected F4, but got I
		//IL_01a8: Expected native int or pointer, but got VT
		//IL_01bb: Expected F4, but got VT
		//IL_01b6: Expected native int or pointer, but got VT
		//IL_01f8: Expected Obj, but got I
		//IL_021a: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_023e: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		if (_meshJetpack == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(_jetpackPrefab);
			Transform transform = gameObject.transform;
			transform.parent = _spineTransform;
			Transform transform2 = gameObject.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v33 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v34 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = gameObject.transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v48 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v49 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = gameObject.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v36 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v37 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
			nint num7 = 0;
			nint num8 = 0;
			IntPtr intPtr = num8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v43+C]");
			_meshJetpack = (MeshRenderer)0;
			_meshJetpack.enabled = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v43+10]");
			_jetpackCloudPositionL = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v43+14]");
			_jetpackCloudPositionR = (Transform)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v43+18]");
			_jetpackThrusters = (Transform[])0;
		}
		return _meshJetpack;
	}

	private unsafe MeshRenderer GetPogostick()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected VT, but got Unknown
		//IL_0119: Expected I, but got Obj
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected VT, but got Unknown
		//IL_0191: Expected I, but got Obj
		//IL_01b6: Expected F4, but got I
		//IL_01b1: Expected native int or pointer, but got VT
		//IL_01c4: Expected F4, but got VT
		//IL_01bf: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		object obj2 = this + 92;
		if (_meshPogostick == null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(_pogostickPrefab);
			Transform transform = gameObject.transform;
			transform.parent = _attachPoint1;
			Transform transform2 = gameObject.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = gameObject.transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v50 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v51 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = gameObject.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S1_v37 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v38 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
			MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
			obj2 = component;
			((Renderer)obj2).enabled = false;
		}
		return (MeshRenderer)obj2;
	}

	public GameObject GetHoverboardGameObject()
	{
		if (_attachPoint1 != null)
		{
			return _attachPoint1.gameObject;
		}
		return null;
	}

	public HoverboardBundle AddEquippedHoverboard()
	{
		//IL_0013: Expected VT, but got Obj
		//IL_001c: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)val).RequestEquippedHoverboardInstance();
		SetupBoard(hoverboardBundle, isMenu: false);
		return hoverboardBundle;
	}

	public GameObject SetNewHoverboard(GameObject root, GameObject newBoard, string boardName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected Obj, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_047c: Expected I, but got Obj
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected VT, but got Unknown
		//IL_04f4: Expected I, but got Obj
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected Obj, but got Unknown
		//IL_0522: Expected Obj, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected VT, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected Obj, but got Unknown
		//IL_0575: Expected I, but got Obj
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected VT, but got Unknown
		//IL_05e7: Expected Obj, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected Obj, but got Unknown
		//IL_030f: Expected Obj, but got I
		//IL_0376: Expected Obj, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		if (_currentHoverboard != null)
		{
			UnityEngine.Object.Destroy(_currentHoverboard);
		}
		List<GameObject> currentCustomBoardModels = _currentCustomBoardModels;
		object obj9;
		CharacterModel characterModel = default;
		if (currentCustomBoardModels._size >= 1)
		{
			object obj3 = obj + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			_ = 0;
			object obj4 = obj + 112;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
			_ = 0;
			object obj6 = default;
			object obj7 = default;
			object obj8 = default;
			object obj10 = default;
			object obj11 = default;
			GameObject result = default;
			while (true)
			{
				_ = 0;
				object obj5 = obj + 112;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj6 == null)
					{
						break;
					}
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj7 != obj8;
				obj9 = obj10;
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj9 = obj11;
				}
				_ = 0;
				object obj12 = obj + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				characterModel = (CharacterModel)0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_033a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return result;
			}
			object obj13 = obj + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
			((List<T>)(object)_currentCustomBoardModels).Clear();
			((List<T>)(object)_currentCustomBoardModelsRenderes).Clear();
		}
		GameObject original = default;
		GameObject gameObject = UnityEngine.Object.Instantiate(original);
		Transform transform = gameObject.transform;
		GameObject gameObject2 = default;
		Transform parent = gameObject2.transform;
		transform.parent = parent;
		Transform transform2 = gameObject.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v49 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v50 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
		_ = 0;
		Vector3 localPosition = (Vector3)(obj + 40);
		transform2.localPosition = localPosition;
		Transform transform3 = gameObject.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v64 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		object obj14 = obj - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v65 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		obj14 = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+38]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(obj + 24);
		transform3.localRotation = localRotation;
		Transform transform4 = gameObject.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v51 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v52 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		_ = 0;
		_ = Vector3.oneVector;
		Vector3 localScale = (Vector3)(obj + 8);
		transform4.localScale = localScale;
		gameObject.name = boardName;
		nint num7 = 0;
		nint num8 = 0;
		IntPtr intPtr = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
		obj9 = 0;
		goto IL_05ec;
		IL_05ec:
		GameObject gameObject3 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v84 (UnityEngine.GameObject)+C]");
			if (0 <= (nint)obj9)
			{
				break;
			}
			object obj15 = obj9 << 2;
			object obj16 = (object)gameObject3 + obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ S0_v31+10]");
			GameObject gameObject4 = ((Component)0).gameObject;
			Layers instance = Layers.Instance;
			gameObject4.layer = instance._3DGUI;
			object obj17 = obj9 + 1;
			obj9 = obj17;
		}
		characterModel._currentHoverboard = gameObject;
		return gameObject;
		IL_033a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_05ec;
	}

	public HoverboardBundle AddRandomHoverboard()
	{
		//IL_0013: Expected VT, but got Obj
		//IL_001c: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)val).RequestRandomHoverboardInstance();
		SetupBoard(hoverboardBundle, isMenu: false);
		return hoverboardBundle;
	}

	public HoverboardBundle AddHoverboard(string name, bool isMenu)
	{
		//IL_0013: Expected VT, but got Obj
		//IL_0020: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonobehavior<>.Instance;
		HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)val).RequestHoverboardInstance(name);
		SetupBoard(hoverboardBundle, isMenu);
		return hoverboardBundle;
	}

	public unsafe Renderer AddCustomHoverboardModel(GameObject modelPrefab, bool isMenu, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0186: Expected I, but got Obj
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected VT, but got Unknown
		//IL_01fe: Expected I, but got Obj
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected VT, but got Unknown
		//IL_0276: Expected I, but got Obj
		//IL_029b: Expected F4, but got I
		//IL_0296: Expected native int or pointer, but got VT
		//IL_02a9: Expected F4, but got VT
		//IL_02a4: Expected native int or pointer, but got VT
		//IL_00dc: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		Renderer result = default;
		if (modelPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(modelPrefab);
			nint num = 0;
			nint num2 = 0;
			IntPtr intPtr = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v84 @ S3_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Transform transform = gameObject.transform;
			transform.parent = parent;
			Transform transform2 = gameObject.transform;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v31 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = gameObject.transform;
			nint num5 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v45 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v46 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = gameObject.transform;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ S1_v36 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v37 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
			_currentCustomBoardModels.Add(gameObject);
			nint num9 = 0;
			nint num10 = 0;
			IntPtr intPtr2 = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ S4_v4 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
			Renderer item = default;
			_currentCustomBoardModelsRenderes.Add(item);
			bool flag = !isMenu;
			Renderer renderer = default;
			result = renderer;
			if (!flag)
			{
				Layers instance = Layers.Instance;
				gameObject.layer = instance._3DGUI;
				nint num11 = 0;
				nint num12 = 0;
				IntPtr intPtr3 = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ S3_v12 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentsInChildren>>)+4] (should have been resolved before IL gen)");
				object obj2 = 0;
				object obj6 = default;
				while (true)
				{
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v70+C]");
					bool flag2 = (nint)obj3 >= 0;
					result = renderer;
					if (flag2)
					{
						break;
					}
					object obj4 = obj2 << 2;
					object obj5 = obj6 + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S0_v76+10]");
					GameObject gameObject2 = ((Component)0).gameObject;
					Layers instance2 = Layers.Instance;
					gameObject2.layer = instance2._3DGUI;
					object obj7 = obj2 + 1;
					obj2 = obj7;
				}
			}
		}
		return result;
	}

	public void RemoveCurrentHoverboard()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0040: Expected Obj, but got I4
		((List<T>)(object)currentCustomBoardModelsRenderes).Clear();
		if (currentHoverboard != null)
		{
			object obj = this + 40;
			UnityEngine.Object.Destroy((UnityEngine.Object)obj);
			obj = 0;
		}
	}

	private unsafe void SetupBoard(HoverboardBundle board, bool isMenu)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected VT, but got Unknown
		//IL_0105: Expected I, but got Obj
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected VT, but got Unknown
		//IL_017d: Expected I, but got Obj
		//IL_01a2: Expected F4, but got I
		//IL_019d: Expected native int or pointer, but got VT
		//IL_01b0: Expected F4, but got VT
		//IL_01ab: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		RemoveCurrentHoverboard();
		board._charactermodel = this;
		board.AddModel(isMenu);
		GameObject gameObject = board.gameObject;
		currentHoverboard = gameObject;
		Transform transform = board.transform;
		transform.parent = _attachPoint1;
		Transform transform2 = board.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v16 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v17 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 localPosition = vector + 32;
		transform2.localPosition = localPosition;
		Transform transform3 = board.transform;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v31 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
		_ = 0;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
		_ = 0;
		Quaternion localRotation = (Quaternion)(vector + 16);
		transform3.localRotation = localRotation;
		Transform transform4 = board.transform;
		nint num5 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S1_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		((Vector3*)(nint)vector)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
		transform4.localScale = vector;
	}

	public unsafe void AddCustomHoverboardVanityMenuFX(GameObject modelPrefab, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_008c: Expected I, but got Obj
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected VT, but got Unknown
		//IL_0104: Expected I, but got Obj
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected VT, but got Unknown
		//IL_017c: Expected I, but got Obj
		//IL_01a1: Expected F4, but got I
		//IL_019c: Expected native int or pointer, but got VT
		//IL_01af: Expected F4, but got VT
		//IL_01aa: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		if (modelPrefab != null)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(modelPrefab);
			Transform transform = gameObject.transform;
			transform.parent = parent;
			Transform transform2 = gameObject.transform;
			nint num = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v26 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v27 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			_ = Vector3.zeroVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 localPosition = vector + 32;
			transform2.localPosition = localPosition;
			Transform transform3 = gameObject.transform;
			nint num3 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v41 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v42 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			_ = 0;
			_ = Quaternion.identityQuaternion;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			_ = 0;
			Quaternion localRotation = (Quaternion)(vector + 16);
			transform3.localRotation = localRotation;
			Transform transform4 = gameObject.transform;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v35 (Il2CppClass<UnityEngine.Vector3>)+5C]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v36 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)Vector3.oneVector;
			transform4.localScale = vector;
			_currentCustomBoardModels.Add(gameObject);
		}
	}

	public void DeleteBoardModels()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		List<GameObject> currentCustomBoardModels = _currentCustomBoardModels;
		if (currentCustomBoardModels._size < 1)
		{
			return;
		}
		object obj3 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj6 = default;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_01e9;
				}
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj7 != obj8;
			object obj9 = obj10;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_01e9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj9 = obj11;
			break;
			IL_01e9:
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EBE");
			((List<T>)(object)_currentCustomBoardModels).Clear();
			((List<T>)(object)_currentCustomBoardModelsRenderes).Clear();
			return;
		}
		_ = 0;
		object obj13 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	public unsafe void HideAllPowerups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0151: Expected Obj, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected VT, but got Unknown
		//IL_01bc: Expected Ref, but got VT
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		if (_currentHoverboard != null)
		{
			_currentHoverboard.SetActive(value: false);
		}
		if (_meshJetpack != null)
		{
			_meshJetpack.enabled = false;
		}
		if (_meshSuperSneaker != null)
		{
			_meshSuperSneaker.enabled = false;
		}
		if (_meshCoinMagnet != null)
		{
			_meshCoinMagnet.enabled = false;
		}
		if (_sprayCanModel != null)
		{
			_sprayCanModel.SetActive(value: false);
		}
		ParticleSystem[] componentsInChildren = _sprayCanModel.GetComponentsInChildren<ParticleSystem>(includeInactive: true);
		object obj3 = 0;
		while (componentsInChildren.Length > (nint)obj3)
		{
			object obj4 = obj3 << 2;
			object obj5 = (object)componentsInChildren + obj4;
			object obj6 = obj - 16;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v54+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v57+8]");
			_ = 0;
			ParticleSystem.EmissionModule emissionModule = (ParticleSystem.EmissionModule)(obj + 8);
			((ParticleSystem.EmissionModule*)emissionModule)->enabled = false;
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
	}

	public void HideBlobShadow()
	{
		_meshBlobShadow.enabled = false;
	}

	public void ShowCurrentHoverboard()
	{
		if (currentHoverboard != null)
		{
			currentHoverboard.SetActive(value: true);
		}
	}

	public void HideCurrentHoverboard()
	{
		if (currentHoverboard != null)
		{
			currentHoverboard.SetActive(value: false);
		}
	}

	public void StartEyeAnimations(UIModelController.ModelScreen modelScreen)
	{
		if (_model != null && _animEye != null)
		{
			_animEye.AnimateEyes(modelScreen);
		}
	}

	public void StopEyeAnimations()
	{
		if (_model != null && _animEye != null)
		{
			_animEye.StopAnimatingEyes();
		}
	}

	public void StartIdleAnimations(UIModelController.ModelScreen modelScreen)
	{
		if (_model != null)
		{
			if (_anim != null)
			{
				_anim.StartIdleAnimations();
			}
			if (_animEye != null)
			{
				_animEye.AnimateEyes(modelScreen);
			}
		}
	}

	public void StartIdlePopupAnimations()
	{
		if (_model != null)
		{
			if (_anim != null)
			{
				_anim.StartIdlePopupAnimations();
			}
			if (_animEye != null)
			{
				_animEye.AnimateEyes(UIModelController.ModelScreen.Popup);
			}
		}
	}

	public void StopIdleAnimations()
	{
		if (_model != null)
		{
			if (_anim != null)
			{
				_anim.StopIdleAnimations();
			}
			if (_animEye != null)
			{
				_animEye.StopAnimatingEyes();
			}
		}
	}

	public void PauseIdleAnimations()
	{
		if (_model != null && _anim != null)
		{
			_anim.PauseIdleAnimations();
		}
	}

	public void ResumeIdleAnimations()
	{
		if (_model != null && _anim != null)
		{
			_anim.ResumeIdleAnimations();
		}
	}

	private void CheckForCharactersToBeInSyncWithStaticData()
	{
	}

	private void OnDestroy()
	{
		UnityEngine.Object.DestroyImmediate(focusPoint);
		UnityEngine.Object.Destroy(_focusPoint);
		UnityEngine.Object.DestroyImmediate(focusPoint);
	}

	public CharacterModel()
	{
		List<Renderer> list = default;
		list._002Ector();
		currentCustomBoardModelsRenderes = list;
		List<GameObject> list2 = default;
		list2._002Ector();
		_currentCustomBoardModels = list2;
		List<Renderer> list3 = default;
		list3._002Ector();
		_currentCustomBoardModelsRenderes = list3;
		base._002Ector();
	}
}
