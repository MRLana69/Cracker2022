using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using Info;
using SYBO.Components.Utilities;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

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
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Renderer renderer = default;
			((UnityEngine.Object)renderer).m_CachedPtr = (IntPtr)0;
			object obj = renderer + 16;
			obj = this;
			return renderer;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 36;
			obj = value;
		}
	}

	public List<Renderer> CurrentHoverboardModelsRenderes
	{
		get
		{
			return (List<Renderer>)(object)currentHoverboadBasemodel;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 68;
			obj = value;
		}
	}

	public bool IsVisibleShadow
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)currentCustomBoardModelsRenderes != 0;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 72;
			obj = value;
		}
	}

	public CharacterRig CharacterRig => (CharacterRig)(object)_meshBlobShadow.sortingLayerName;

	public MeshRenderer MeshBlobShadow => (MeshRenderer)(object)_characterRig;

	public GameObject CurrentHoverboard => (GameObject)(object)_meshBlobShadow;

	public List<GameObject> CurrentCustomBoardModels => (List<GameObject>)(object)_currentHoverboard;

	public List<Renderer> CurrentCustomBoardModelsRenderes => (List<Renderer>)(object)_currentCustomBoardModels;

	public GameObject SprayCanModel => (GameObject)(object)_currentCustomBoardModelsRenderes;

	public MeshRenderer MeshCoinMagnet => GetCoinMagnet();

	public MeshRenderer MeshJetpack => GetJetpack();

	public MeshRenderer MeshPogostick => GetPogostick();

	public Transform JetpackCloudPositionL => (Transform)(object)GetHoverboardGameObject();

	public Transform JetpackCloudPositionR => _jetpackCloudPositionL;

	public Transform[] JetpackThrusters => (Transform[])(object)_jetpackCloudPositionR;

	public Transform AttachPoint1 => (Transform)(object)_jetpackThrusters;

	public Transform AttachPoint2 => _attachPoint1;

	public Transform AttachPoint3 => _attachPoint2;

	public Transform AttachPoint4 => _attachPoint3;

	public Transform AttachPoint5 => _attachPoint4;

	public Transform AttachPoint6 => _attachPoint5;

	public Transform AttachPoint7 => _attachPoint6;

	public Transform AttachPoint8 => _attachPoint7;

	public Transform AttachPoint9 => _attachPoint8;

	public SkinnedMeshRenderer Model => (SkinnedMeshRenderer)(object)_attachPoint9;

	public SkinnedMeshRenderer OutfitModel => _model;

	public SkinnedMeshRenderer HeadModel => _outfitModel;

	public SkinnedMeshRenderer MeshSuperSneaker => _headModel;

	public SkinnedMeshRenderer DoubleJumpers => _meshSuperSneaker;

	public SkinnedMeshRenderer RocketSkates => _doubleJumpers;

	public Animation CharacterAnimation => (Animation)(object)_rocketSkates;

	public Transform SpineTransform => (Transform)(object)_characterAnimation;

	public Transform ShoulderTransform => _spineTransform;

	public Transform Hip => _shoulderTransform;

	public Transform LeftFoot => _hip;

	public Transform RightFoot => _leftFoot;

	public Transform HeadJoint => _rightFoot;

	public Transform RightHand => _headJoint;

	public TopRunIdleAnimation TopRunIdleAnimation => (TopRunIdleAnimation)(object)_rightHand;

	private void Awake()
	{
		CancelInvoke();
	}

	private void BuildRig()
	{
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		InitializeCharacter();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v30 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(_shadowPrefab);
		int layer = gameObject.layer;
		GameObject parentInternal = base.gameObject;
		((Transform)layer).parentInternal = (Transform)(object)parentInternal;
		object obj2 = this + 204;
		MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
		obj2 = component;
		StartEyeAnimations(UIModelController.ModelScreen.GameOver);
		_0021_00210 componentInChildren = (_0021_00210)gameObject.GetComponentInChildren<T>();
		object obj3 = componentInChildren + 12;
		obj3 = _hip;
		MeshRenderer coinMagnet = GetCoinMagnet();
		string text = tag;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S2_v8 (Il2CppMethodInfo)+18]");
		object obj4 = 0;
		object obj5 = obj4;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v75 @ S3_v4 (should have been resolved before IL gen)");
		object obj9 = default;
		object obj8 = obj9 + 16;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S3_v6 (Il2CppMethodInfo)+18]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v92 @ S4_v6 (should have been resolved before IL gen)");
		object obj14 = default;
		obj8 = obj14;
		_sprayCanModel.tag = null;
	}

	public void InitializeCharacter()
	{
		//IL_0583: Expected I, but got Obj
		//IL_0599: Expected Obj, but got I
		//IL_005f: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected Obj, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected Obj, but got Unknown
		//IL_010d: Expected I, but got Obj
		//IL_0123: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_01c0: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected Obj, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02de: Expected Obj, but got Unknown
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected Obj, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected Obj, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Obj, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected Obj, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected Obj, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected Obj, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected Obj, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected Obj, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v154 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate(_rigPrefab);
		int layer = gameObject.layer;
		int layer2 = _rigController.layer;
		((Transform)layer).parentInternal = (Transform)layer2;
		int layer3 = gameObject.layer;
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v16 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v150 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = default;
		object obj3 = obj4 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj4 + 48);
		transform = (Transform)obj3;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v21+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer4 = gameObject.layer;
		nint num5 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v28 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v146 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj4 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj6;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v33+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		int layer5 = gameObject.layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj4;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer5).parent = transform;
		object obj7 = this + 240;
		CharacterRig component = gameObject.GetComponent<CharacterRig>();
		obj7 = component;
		object obj8 = this + 168;
		CharacterRig characterRig = _characterRig;
		obj8 = characterRig.characterAnimation;
		object obj9 = this + 108;
		CharacterRig characterRig2 = _characterRig;
		obj9 = characterRig2.attachPoint1;
		object obj10 = this + 112;
		CharacterRig characterRig3 = _characterRig;
		obj10 = characterRig3.attachPoint2;
		object obj11 = this + 116;
		CharacterRig characterRig4 = _characterRig;
		obj11 = characterRig4.attachPoint3;
		object obj12 = this + 120;
		CharacterRig characterRig5 = _characterRig;
		obj12 = characterRig5.attachPoint4;
		object obj13 = this + 124;
		CharacterRig characterRig6 = _characterRig;
		obj13 = characterRig6.attachPoint5;
		object obj14 = this + 128;
		CharacterRig characterRig7 = _characterRig;
		obj14 = characterRig7.attachPoint6;
		object obj15 = this + 132;
		CharacterRig characterRig8 = _characterRig;
		obj15 = characterRig8.attachPoint7;
		object obj16 = this + 136;
		CharacterRig characterRig9 = _characterRig;
		obj16 = characterRig9.attachPoint8;
		object obj17 = this + 140;
		CharacterRig characterRig10 = _characterRig;
		obj17 = characterRig10.attachPoint9;
		object obj18 = this + 144;
		CharacterRig characterRig11 = _characterRig;
		obj18 = characterRig11.model;
		object obj19 = this + 148;
		CharacterRig characterRig12 = _characterRig;
		obj19 = characterRig12.outfitModel;
		_outfitModel.shadowCastingMode = ShadowCastingMode.Off;
		object obj20 = this + 152;
		CharacterRig characterRig13 = _characterRig;
		obj20 = characterRig13.headModel;
		_headModel.shadowCastingMode = ShadowCastingMode.Off;
		object obj21 = this + 156;
		CharacterRig characterRig14 = _characterRig;
		obj21 = characterRig14.meshSuperSneaker;
		_meshSuperSneaker.shadowCastingMode = ShadowCastingMode.Off;
		object obj22 = this + 160;
		CharacterRig characterRig15 = _characterRig;
		obj22 = characterRig15.doubleJumpers;
		_doubleJumpers.shadowCastingMode = ShadowCastingMode.Off;
		object obj23 = this + 164;
		CharacterRig characterRig16 = _characterRig;
		obj23 = characterRig16.rocketSkates;
		_rocketSkates.shadowCastingMode = ShadowCastingMode.Off;
		object obj24 = this + 168;
		CharacterRig characterRig17 = _characterRig;
		obj24 = characterRig17.characterAnimation;
		object obj25 = this + 172;
		CharacterRig characterRig18 = _characterRig;
		obj25 = characterRig18.spineTransform;
		object obj26 = this + 176;
		CharacterRig characterRig19 = _characterRig;
		obj26 = characterRig19.rightShoulderTransform;
		object obj27 = this + 180;
		CharacterRig characterRig20 = _characterRig;
		obj27 = characterRig20.hip;
		object obj28 = this + 184;
		CharacterRig characterRig21 = _characterRig;
		obj28 = characterRig21.leftFoot;
		object obj29 = this + 188;
		CharacterRig characterRig22 = _characterRig;
		obj29 = characterRig22.rightFoot;
		object obj30 = this + 192;
		CharacterRig characterRig23 = _characterRig;
		obj30 = characterRig23.headJoint;
		object obj31 = this + 196;
		CharacterRig characterRig24 = _characterRig;
		obj31 = characterRig24.rightHand;
	}

	public void RecreateCharacter()
	{
		//IL_0289: Expected I, but got Obj
		//IL_029f: Expected Obj, but got I
		//IL_02d2: Expected Obj, but got I
		//IL_02e2: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_0098: Expected I, but got Obj
		//IL_00ae: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected Obj, but got Unknown
		//IL_0148: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I
		//IL_00d9: Expected I, but got Obj
		//IL_01de: Expected Obj, but got I
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected Obj, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_0189: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v60 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 <= -1)
		{
			object obj8 = currentBoardId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			object[] args = default;
			string msg = $"This character ({args}) does not exist on this branch. Stop the scene. In the menu bar press \"Tools -> Data files -> Delete PlayerInfo\" and try play the scene again.";
			SDebug.LogFormat(msg, null);
		}
		nint num4 = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v22 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num5 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v47 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)currentBoardId);
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		((CharacterModelPreviewFactory)this).GetCharacterModelPreview(model.modelName, (int)currentCharacterId, (Action<GameObject>)null, true);
		object obj10 = this + 148;
		CharacterRig characterRig = _characterRig;
		obj10 = characterRig.outfitModel;
		nint num6 = (nint)typeof(Hoverboard);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v30 (Il2CppClass<Hoverboard>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num7 = (nint)typeof(Hoverboard);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v43 (Il2CppClass<Hoverboard>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterModifier characterModifier = MysteryPowerup.SelectRandomCharacterModifier();
		((Hoverboard)characterModifier).Game_OnCharacterModelRecreated();
		string text = tag;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S2_v11 (Il2CppMethodInfo)+18]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = obj13 & 0x1FFF;
		object obj15 = obj14 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v146 @ S3_v11 (should have been resolved before IL gen)");
		RunnerAnimPlayer runnerAnimPlayer = default;
		runnerAnimPlayer.InitializeHoverboardClips();
		string text2 = tag;
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S2_v15 (Il2CppMethodInfo)+18]");
		object obj16 = 0;
		object obj17 = obj16;
		object obj18 = obj17 & 0x1FFF;
		object obj19 = obj18 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v163 @ S3_v15 (should have been resolved before IL gen)");
		KeyframeBehaviour keyframeBehaviour = default;
		keyframeBehaviour._002Ector();
	}

	public void ChangeCharacterModel(string name, int outfitIndex, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0780: Expected Obj, but got Unknown
		//IL_0796: Expected I4, but got Obj
		//IL_0796: Expected Obj, but got I
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_07fe: Expected I, but got Obj
		//IL_0814: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_083b: Expected Obj, but got I4
		//IL_00e7: Expected I, but got Obj
		//IL_07c7: Expected Obj, but got I
		//IL_087b: Expected I4, but got Obj
		//IL_087b: Expected Obj, but got I
		//IL_0134: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_036b: Expected I, but got Obj
		//IL_0381: Expected Obj, but got I
		//IL_0181: Expected I, but got Obj
		//IL_0197: Expected Obj, but got I
		//IL_0913: Expected Obj, but got I
		//IL_0224: Expected I4, but got Obj
		//IL_08ae: Expected Obj, but got I4
		//IL_08ba: Expected Obj, but got I4
		//IL_03ac: Expected I, but got Obj
		//IL_0245: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I
		//IL_01c2: Expected I, but got Obj
		//IL_09f4: Expected Obj, but got I4
		//IL_03f9: Expected I, but got Obj
		//IL_040f: Expected Obj, but got I
		//IL_0490: Expected Obj, but got I4
		//IL_0490: Expected Obj, but got I4
		//IL_04a6: Expected Obj, but got I
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected Obj, but got Unknown
		//IL_04e5: Expected Obj, but got I
		//IL_0945: Expected Obj, but got I
		//IL_0286: Expected I, but got Obj
		//IL_04fc: Expected I, but got Obj
		//IL_0512: Expected Obj, but got I
		//IL_043a: Expected I, but got Obj
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_058d: Expected Obj, but got I
		//IL_059e: Expected Obj, but got I4
		//IL_053d: Expected I, but got Obj
		//IL_0314: Expected I, but got Obj
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05ba: Expected Obj, but got I4
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Obj, but got Unknown
		//IL_0748: Expected Obj, but got I4
		//IL_075e: Expected Obj, but got I4
		//IL_068e: Expected I, but got Obj
		//IL_06a4: Expected Obj, but got I
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected Obj, but got Unknown
		//IL_06cf: Expected I, but got Obj
		object obj = default;
		Transform transform = (Transform)(obj + 12);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+20]");
		char c = ((string)0).get_Chars((int)"");
		if (((uint)c & (useSpecialAsset ? 1u : 0u)) == 0)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+1C]");
			int num3 = ((ComputeShader)0).FindKernel(null);
			if (((uint)num3 & (useSpecialAsset ? 1u : 0u)) == 0)
			{
				return;
			}
		}
		nint num4 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v20 (Il2CppClass<UIScreenController>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v130 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		nint num6 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v99 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num8 = ((ComputeShader)flag).FindKernel(null);
		bool flag2 = num8 == 0;
		string text = "";
		if (!flag2)
		{
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v119 (Il2CppClass<UIScreenController>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v126 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag3 = UIScreenController.ShouldShowOnlineScreen();
			bool isShowingPopup = ((UIScreenController)flag3).isShowingPopup;
			text = (string)isShowingPopup;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+20]");
		GameObject gameObject;
		if (((string)0).get_Chars((int)"") != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+20]");
			string text2 = string.ConcatArray((string[])(object)"Prefabs/CharacterSpecialProps/", 0);
			string nameInternal = Scene.GetNameInternal((int)text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v95 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v114 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ComputeShader computeShader = default;
			if (computeShader.FindKernel(null) != 0)
			{
				nint num13 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v104 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num14 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ S0_v110 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				gameObject = UnityEngine.Object.Instantiate((GameObject)(object)computeShader);
			}
			else
			{
				gameObject = null;
			}
		}
		else
		{
			nint num15 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num16 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S1_v82 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+1C]");
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num18 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v78 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+1C]");
				gameObject = UnityEngine.Object.Instantiate((GameObject)0);
			}
			else
			{
				gameObject = null;
			}
		}
		int layer = gameObject.layer;
		string text3 = ((Component)outfitIndex).tag;
		bool activeSelf = ((GameObject)(object)text3).activeSelf;
		((AssignTextureAndMaterial)layer)._003CAwake_003Eb__3_0((Material)activeSelf);
		nint num19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S2_v12 (Il2CppMethodInfo)+18]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v287 @ S3_v5 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [outfitIndex @ L2 (System.Int32)+A4]");
		GameObject gameObject2 = ((Component)0).gameObject;
		nint num20 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v27 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num21 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S1_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject2).parent = transform;
		int layer2 = gameObject.layer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [outfitIndex @ L2 (System.Int32)+A4]");
		GameObject parentInternal = ((Component)0).gameObject;
		((Transform)layer2).parentInternal = (Transform)(object)parentInternal;
		object obj16 = default;
		object obj15 = obj16 + 12;
		object obj17 = 0;
		bool flag4 = false;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
		{
			object obj18 = obj16 + 16;
			object obj19 = obj17 << 2;
			object obj20 = obj18 + obj19;
			if (deleteSpecialAsset)
			{
				string item = ((Component)obj20).tag;
				((List<GameObject>)(object)rigController).Add((GameObject)(object)item);
			}
			bool flag5 = text != "CharacterNameEventPopup";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
			bool flag6;
			if (flag4)
			{
				flag6 = true;
			}
			else
			{
				string text4 = ((Component)obj20).tag;
				nint num22 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ S0_v68 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num23 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				flag6 = gameObject != (UnityEngine.Object)(object)text4;
			}
			bool flag7 = flag6;
			object obj22 = obj17 + 1;
			obj17 = obj22;
			flag4 = flag7;
		}
		if (!flag4)
		{
			int layer3 = gameObject.layer;
			GameObject parentInternal2 = ((Component)outfitIndex).gameObject;
			((Transform)layer3).parentInternal = (Transform)(object)parentInternal2;
			((List<GameObject>)(object)rigController).Add(gameObject);
		}
	}

	public void SetCharacterModel(string name, int outfitIndex, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		//IL_011a: Expected I, but got Obj
		//IL_0130: Expected Obj, but got I
		//IL_0105: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_00b0: Expected I, but got Obj
		PauseIdleAnimations();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_currentModelBundle).FindKernel((string)null) != 0)
		{
			string obj2 = _currentModelBundle.tag;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj2);
		}
		((CharacterModelPreviewFactory)this).GetCharacterModelPreview(name, outfitIndex, (Action<GameObject>)useSpecialAsset, deleteSpecialAsset);
	}

	private void SetupModel(CharacterAssetsBundle characterAssetBundle, string name, int outfitIndex, bool useSpecialAsset, bool deleteSpecialAsset)
	{
		//IL_00c4: Expected I, but got Obj
		//IL_00da: Expected Obj, but got I
		//IL_016c: Expected I, but got Obj
		//IL_0182: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I
		//IL_0154: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DeviceInfo>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		nint num3 = (nint)typeof(CharacterMaterial);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<CharacterMaterial>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(CharacterMaterial);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v25 (Il2CppClass<CharacterMaterial>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = (nint)characterAssetBundle == 2;
		CharacterPickupParticles characterPickupParticles = default;
		if (name != null)
		{
			object obj3 = flag & name;
			characterPickupParticles = (CharacterPickupParticles)(object)((obj3 == null) ? characterAssetBundle : null);
		}
		CharacterPickupParticles characterPickupParticles2 = characterPickupParticles;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Int32)+8]");
		IEnumerator textureName = characterPickupParticles2.EffectCoroutine((CharacterPickupParticles.EffectDetails)0);
		CharacterMaterial.SetTexture((Material)(object)this, (string)(object)textureName, useSpecialAsset, (Action<Material>)deleteSpecialAsset);
	}

	private GameObject GetSprayCanModel()
	{
		return (GameObject)(object)_topRunIdleAnimation;
	}

	private MeshRenderer GetCoinMagnet()
	{
		//IL_0258: Expected I, but got Obj
		//IL_026e: Expected Obj, but got I
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected Obj, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I4
		//IL_00fd: Expected I, but got Obj
		//IL_0113: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_018b: Expected I, but got Obj
		//IL_01a1: Expected Obj, but got I
		//IL_013e: Expected I, but got Obj
		//IL_023e: Expected Obj, but got I4
		//IL_01cc: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (_sprayCanModel != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj6 = this + 80;
			GameObject gameObject = UnityEngine.Object.Instantiate(_sprayCanPrefab);
			obj6 = gameObject;
			int layer = _sprayCanModel.layer;
			((Transform)layer).parentInternal = _rightHand;
			int layer2 = _sprayCanModel.layer;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v26 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S1_v53 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			int layer3 = _sprayCanModel.layer;
			nint num7 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v36 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num8 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v49 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer4 = _sprayCanModel.layer;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer4).parent = transform;
		}
		return (MeshRenderer)(object)_sprayCanModel;
	}

	private MeshRenderer GetJetpack()
	{
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected Obj, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0373: Expected I, but got Obj
		//IL_0389: Expected Obj, but got I
		//IL_03b8: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_013c: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_0172: Expected Obj, but got I
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_019d: Expected I, but got Obj
		//IL_029d: Expected Obj, but got I4
		//IL_022b: Expected I, but got Obj
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02c3: Expected Obj, but got I
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected Obj, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v70 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (_meshCoinMagnet != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v66 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(_coinMagnetPrefab);
			nint num5 = (nint)typeof(CoinMagnet);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v18 (Il2CppClass<CoinMagnet>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(CoinMagnet);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v36 (Il2CppClass<CoinMagnet>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool doubleScoreActive = DoubleScoreMultiplier.doubleScoreActive;
			((CoinMagnet)doubleScoreActive).SetUpHoldAnimation();
			int layer = gameObject.layer;
			((Transform)layer).parentInternal = _rightHand;
			int layer2 = gameObject.layer;
			nint num7 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S1_v31 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v62 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			int layer3 = gameObject.layer;
			nint num9 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S1_v41 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S1_v58 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer4 = gameObject.layer;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer4).parent = transform;
			object obj9 = this + 84;
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S3_v3 (Il2CppMethodInfo)+18]");
			object obj10 = 0;
			object obj11 = obj10;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S4_v5 (should have been resolved before IL gen)");
			object obj14 = default;
			obj9 = obj14;
			_meshCoinMagnet.shadowCastingMode = ShadowCastingMode.Off;
		}
		return _meshCoinMagnet;
	}

	private MeshRenderer GetPogostick()
	{
		//IL_0314: Expected I, but got Obj
		//IL_032a: Expected Obj, but got I
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0379: Expected Obj, but got I4
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_013c: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I4
		//IL_01ca: Expected I, but got Obj
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected Obj, but got Unknown
		//IL_0262: Expected Obj, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected Obj, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected Obj, but got Unknown
		//IL_02cb: Expected Obj, but got I
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected Obj, but got Unknown
		//IL_0301: Expected Obj, but got I
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v78 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (_meshJetpack != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(_jetpackPrefab);
			int layer = gameObject.layer;
			((Transform)layer).parentInternal = _spineTransform;
			int layer2 = gameObject.layer;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v29 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v70 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			int layer3 = gameObject.layer;
			nint num7 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S1_v39 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S1_v66 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer4 = gameObject.layer;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer4).parent = transform;
			object obj8 = this + 88;
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S3_v3 (Il2CppMethodInfo)+18]");
			object obj9 = 0;
			object obj10 = obj9;
			object obj11 = obj10 & 0x1FFF;
			object obj12 = obj11 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v63 @ S4_v5 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v54+C]");
			obj8 = 0;
			_meshJetpack.shadowCastingMode = ShadowCastingMode.Off;
			object obj13 = this + 96;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v54+10]");
			obj13 = 0;
			object obj14 = this + 100;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v54+14]");
			obj14 = 0;
			object obj15 = this + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S1_v54+18]");
			obj15 = 0;
		}
		return _meshJetpack;
	}

	public GameObject GetHoverboardGameObject()
	{
		//IL_0296: Expected I, but got Obj
		//IL_02ac: Expected Obj, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected Obj, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_02f2: Expected Obj, but got I4
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_00ac: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_0147: Expected I, but got Obj
		//IL_0247: Expected Obj, but got I4
		//IL_01d5: Expected I, but got Obj
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		Transform transform = (Transform)(obj2 + 48);
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		if (_meshPogostick != null)
		{
			object original = this - -64;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S1_v65 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)original);
			int layer = gameObject.layer;
			((Transform)layer).parentInternal = _attachPoint1;
			int layer2 = gameObject.layer;
			nint num5 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num6 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 one = Vector3.one;
			transform = (Transform)obj3;
			Transform transform2 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v11+8]");
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
			Vector3 eulerAngles = transform.eulerAngles;
			int layer3 = gameObject.layer;
			nint num7 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v40 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num8 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S1_v57 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector2 zero = Vector2.zero;
			transform = (Transform)obj4;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Vector3 localScale = transform.localScale;
			int layer4 = gameObject.layer;
			Vector3 forward = Vector3.forward;
			transform = (Transform)obj2;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			((Transform)layer4).parent = transform;
			object obj8 = this + 92;
			MeshRenderer component = gameObject.GetComponent<MeshRenderer>();
			obj8 = component;
			_meshPogostick.shadowCastingMode = ShadowCastingMode.Off;
		}
		return (GameObject)(object)_meshPogostick;
	}

	public HoverboardBundle AddEquippedHoverboard()
	{
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_attachPoint1).FindKernel((string)null) != 0)
		{
			return (HoverboardBundle)(object)_attachPoint1.tag;
		}
		return null;
	}

	public GameObject SetNewHoverboard(GameObject root, GameObject newBoard, string boardName)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj7 = default;
		string text = default;
		GameObject result = default;
		while (true)
		{
			GameObject shadowPrefab = ShadowPrefab;
			object obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (UnityEngine.GameObject)+C]");
			if ((nint)obj < 0)
			{
				object obj3 = ShadowPrefab + 16;
				object obj4 = obj2 << 2;
				object obj5 = obj3 + obj4;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v25+C]");
				if (0 == (nint)root)
				{
					break;
				}
				obj2 = obj7 + 1;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string msg = "Missing asset bundle mapping for " + text;
			SDebug.LogFormat(msg, null);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			return result;
		}
		object obj8 = ShadowPrefab + 16;
		object obj9 = obj2 << 2;
		object obj10 = obj8 + obj9;
		return (GameObject)(object)((CharacterRenderingEffects.OnDoubleJumpDelegate)obj10).BeginInvoke((AsyncCallback)(object)newBoard, (object)boardName);
	}

	public HoverboardBundle AddRandomHoverboard()
	{
		//IL_0013: Expected VT, but got Obj
		//IL_001c: Expected Obj, but got VT
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		HoverboardBundle hoverboardBundle = ((HoverboardModelFactory)val).RequestRandomHoverboardInstance();
		AddCustomHoverboardVanityMenuFX((GameObject)(object)hoverboardBundle, null);
		return hoverboardBundle;
	}

	public unsafe HoverboardBundle AddHoverboard(string name, bool isMenu)
	{
		//IL_010b: Expected I, but got Obj
		//IL_0121: Expected Obj, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected VT, but got Unknown
		//IL_015b: Expected Obj, but got I4
		//IL_0073: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0085: Expected F4, but got Obj
		//IL_0080: Expected native int or pointer, but got VT
		//IL_0097: Expected F4, but got I
		//IL_0092: Expected native int or pointer, but got VT
		//IL_00e7: Expected F4, but got I
		//IL_00e7: Expected F4, but got I4
		//IL_00e7: Expected F4, but got I
		//IL_00e7: Expected F4, but got I
		//IL_00e7: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = default;
		Vector3 vector = (Vector3)(transform + 12);
		if ((UnityEngine.Object)name.m_stringLength != null)
		{
			return null;
		}
		GameObject gameObject = base.gameObject;
		transform.position = (Vector3)gameObject;
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		int stringLength = name.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+1C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+14]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+18]");
		nint num5 = 0;
		char firstChar = name.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [name @ L1 (System.String)+10]");
		return (HoverboardBundle)((Sound)(object)this).playAudioClip((AudioClip)stringLength, (AudioRolloffMode)num3, (float)num4, (float)num5, (float)(int)firstChar, 0f, vector, isMenu);
	}

	public Renderer AddCustomHoverboardModel(GameObject modelPrefab, bool isMenu, Transform parent)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_06f1: Expected Obj, but got I4
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected Obj, but got Unknown
		//IL_0721: Expected I, but got Obj
		//IL_0737: Expected Obj, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_039e: Expected I, but got Obj
		//IL_03b4: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_07b5: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_03df: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_044b: Expected I, but got Obj
		//IL_0461: Expected Obj, but got I
		//IL_07e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e6: Expected Obj, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_025e: Expected Obj, but got I4
		//IL_04d9: Expected I, but got Obj
		//IL_04ef: Expected Obj, but got I
		//IL_048c: Expected I, but got Obj
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected Obj, but got Unknown
		//IL_0191: Expected I, but got Obj
		//IL_01a7: Expected Obj, but got I
		//IL_058c: Expected Obj, but got I4
		//IL_051a: Expected I, but got Obj
		//IL_02e6: Expected Obj, but got I
		//IL_059e: Expected I4, but got Obj
		//IL_05b4: Expected Obj, but got I
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected Obj, but got Unknown
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected Obj, but got Unknown
		//IL_05f9: Expected Obj, but got I4
		//IL_01d2: Expected I, but got Obj
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected Obj, but got Unknown
		//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		//IL_0642: Expected I, but got Obj
		//IL_0658: Expected Obj, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0895: Expected Obj, but got I4
		//IL_08a2: Expected I4, but got Obj
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b0: Expected Obj, but got Unknown
		//IL_0683: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 96;
		object obj3 = obj2 + 56;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 48;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S1_v145 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_currentHoverboard).FindKernel((string)null) != 0)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v136 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S1_v141 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(_currentHoverboard);
		}
		Transform transform = (Transform)(obj2 + 72);
		List<GameObject> currentCustomBoardModels = _currentCustomBoardModels;
		if (currentCustomBoardModels._size >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			object obj7 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S0_v127 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v136 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			object obj9 = obj4 + 4;
			object obj10 = obj9 + 1;
			obj9 = obj10;
			object obj11 = obj10 << 2;
			object obj12 = obj4 + obj11;
			obj12 = 90;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj13 = (nint)0 << 2;
				object obj14 = obj4 + obj13;
				if ((nint)obj14 == 90)
				{
					object obj15 = obj4 + 4;
					if ((nint)obj15 > -1)
					{
						object obj16 = obj15 + -1;
						obj15 = obj16;
					}
					goto IL_0911;
				}
			}
			object obj17 = default;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0911;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = UnityEngine.Object.Instantiate((GameObject)isMenu);
		int layer = gameObject.layer;
		int layer2 = modelPrefab.layer;
		((Transform)layer).parentInternal = (Transform)layer2;
		int layer3 = gameObject.layer;
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S1_v28 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S1_v83 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj20 = obj2 + 32;
		Vector3 one = Vector3.one;
		transform = (Transform)obj20;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S1_v33+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		int layer4 = gameObject.layer;
		nint num11 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S1_v39 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num12 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S1_v79 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj22 = obj2 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj22;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S1_v44+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		int layer5 = gameObject.layer;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj2;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)layer5).parent = transform;
		UnityEngine.Object.DestroyImmediate(gameObject, (byte)(int)parent != 0);
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S2_v31 (Il2CppMethodInfo)+18]");
		object obj23 = 0;
		object obj24 = obj23;
		object obj25 = obj24 & 0x1FFF;
		object obj26 = obj25 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v411 @ S3_v4 (should have been resolved before IL gen)");
		object obj28 = default;
		object obj27 = obj28 + 12;
		object obj29 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj29) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27))
		{
			object obj30 = obj28 + 16;
			object obj31 = obj29 << 2;
			object obj32 = obj30 + obj31;
			string text = ((Component)obj32).tag;
			nint num14 = (nint)typeof(Layers);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S1_v66 (Il2CppClass<Layers>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num15 = (nint)typeof(Layers);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ S1_v75 (Il2CppClass<Layers>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool startupFinished = LoadLevelCtrl.StartupFinished;
			object obj34 = (startupFinished ? 1 : 0) - -64;
			((GameObject)(object)text).SetActive((byte)(int)obj34 != 0);
			object obj35 = obj29 + 1;
			obj29 = obj35;
		}
		object obj36 = this + 208;
		obj36 = gameObject;
		return (Renderer)(object)gameObject;
		IL_0911:
		throw new IndexOutOfRangeException();
	}

	public void RemoveCurrentHoverboard()
	{
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected Obj, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		//IL_0112: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		nint num = (nint)typeof(Characters);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Info.Characters>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Characters);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SYBO.Subway.Info.Characters>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Boards.BoardId currentBoardId = PlayerSave.currentBoardId;
		Characters.Model model = Characters.characterData.get_Item((Characters.CharacterId)currentBoardId);
		Characters.CharacterId currentCharacterId = PlayerSave.currentCharacterId;
		SetCharacterModel(model.modelName, (int)currentCharacterId, useSpecialAsset: false, deleteSpecialAsset: true);
		object obj2 = this + 148;
		CharacterRig characterRig = _characterRig;
		obj2 = characterRig.outfitModel;
		string text = tag;
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S2_v6 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65 @ S3_v7 (should have been resolved before IL gen)");
		RunnerAnimPlayer runnerAnimPlayer = default;
		runnerAnimPlayer.InitializeHoverboardClips();
		string text2 = tag;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S2_v10 (Il2CppMethodInfo)+18]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v82 @ S3_v11 (should have been resolved before IL gen)");
		KeyframeBehaviour keyframeBehaviour = default;
		keyframeBehaviour._002Ector();
	}

	private void SetupBoard(HoverboardBundle board, bool isMenu)
	{
		//IL_017f: Expected Obj, but got I
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00c1: Expected Obj, but got I
		//IL_005e: Expected I, but got Obj
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_00ec: Expected I, but got Obj
		GameObject gameObject = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [board @ L1 (HoverboardBundle)+A4]");
		GameObject parentInternal = ((Component)0).gameObject;
		((Transform)(object)gameObject).parentInternal = (Transform)(object)parentInternal;
		GameObject gameObject2 = base.gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v39 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj3 + 48);
		transform = (Transform)obj2;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v14+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = base.gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v21 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v35 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj3 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj5;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v26+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		GameObject gameObject4 = base.gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj3;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject4).parent = transform;
	}

	public void AddCustomHoverboardVanityMenuFX(GameObject modelPrefab, Transform parent)
	{
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_0049: Expected I, but got Obj
		//IL_005f: Expected Obj, but got I
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected Obj, but got Unknown
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_008a: Expected I, but got Obj
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected Obj, but got Unknown
		//IL_0118: Expected I, but got Obj
		DeleteBoardModels();
		object obj = modelPrefab + 36;
		obj = this;
		((HoverboardModelPreviewFactory)(object)modelPrefab).HandleOnPopupShown((string)(object)parent);
		object obj2 = this + 40;
		string text = ((Component)(object)modelPrefab).tag;
		obj2 = text;
		GameObject gameObject = ((Component)(object)modelPrefab).gameObject;
		((Transform)(object)gameObject).parentInternal = _attachPoint1;
		GameObject gameObject2 = ((Component)(object)modelPrefab).gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v15 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v45 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = default;
		object obj4 = obj5 + 32;
		Vector3 one = Vector3.one;
		Transform transform = (Transform)(obj5 + 48);
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v20+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		GameObject gameObject3 = ((Component)(object)modelPrefab).gameObject;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v27 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v41 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj5 + 16;
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj7;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v32+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		GameObject gameObject4 = ((Component)(object)modelPrefab).gameObject;
		Vector3 forward = Vector3.forward;
		transform = (Transform)obj5;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject4).parent = transform;
	}

	public void DeleteBoardModels()
	{
		throw new IndexOutOfRangeException();
	}

	public void HideAllPowerups()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Expected Obj, but got I4
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_0071: Expected I, but got Obj
		//IL_0087: Expected Obj, but got I
		//IL_01c6: Expected Obj, but got I
		//IL_00b2: Expected I, but got Obj
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		List<GameObject> currentCustomBoardModels = _currentCustomBoardModels;
		if (currentCustomBoardModels._size <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj5 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v85 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v94 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj7 = obj4 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj4 + obj9;
		obj10 = 65;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj11 = (nint)0 << 2;
			object obj12 = obj4 + obj11;
			if ((nint)obj12 == 65)
			{
				object obj13 = obj4 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				goto IL_0329;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0329;
		IL_0329:
		throw new IndexOutOfRangeException();
	}

	public void HideBlobShadow()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_039a: Expected Obj, but got I4
		//IL_03a8: Expected I, but got Obj
		//IL_03be: Expected Obj, but got I
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_00c0: Expected I, but got Obj
		//IL_01c5: Expected I, but got Obj
		//IL_01db: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_0268: Expected I, but got Obj
		//IL_027e: Expected Obj, but got I
		//IL_0206: Expected I, but got Obj
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected Obj, but got Unknown
		//IL_0324: Expected Obj, but got I4
		//IL_02a9: Expected I, but got Obj
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_035b: Expected Obj, but got I4
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v74 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_currentHoverboard).FindKernel((string)null) != 0)
		{
			_currentHoverboard.tag = null;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v69 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_meshJetpack).FindKernel((string)null) != 0)
		{
			_meshJetpack.shadowCastingMode = ShadowCastingMode.Off;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_meshSuperSneaker).FindKernel((string)null) != 0)
		{
			_meshSuperSneaker.shadowCastingMode = ShadowCastingMode.Off;
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S1_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v59 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_meshCoinMagnet).FindKernel((string)null) != 0)
		{
			_meshCoinMagnet.shadowCastingMode = ShadowCastingMode.Off;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_sprayCanModel).FindKernel((string)null) != 0)
		{
			_sprayCanModel.tag = null;
		}
		ParticleSystem[] componentsInChildren = _sprayCanModel.GetComponentsInChildren<ParticleSystem>(includeInactive: true);
		object obj8 = componentsInChildren + 12;
		object obj9 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8))
		{
			object obj10 = componentsInChildren + 16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			obj = 0;
			obj = obj12;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11747");
			object obj13 = obj9 + 1;
			obj9 = obj13;
		}
	}

	public void ShowCurrentHoverboard()
	{
		_meshBlobShadow.shadowCastingMode = ShadowCastingMode.Off;
	}

	public void HideCurrentHoverboard()
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)currentHoverboard).FindKernel((string)null) != 0)
		{
			currentHoverboard.tag = (string)1;
		}
	}

	public void StartEyeAnimations(UIModelController.ModelScreen modelScreen)
	{
		_meshBlobShadow.shadowCastingMode = (ShadowCastingMode)modelScreen;
	}

	public void StopEyeAnimations()
	{
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)currentHoverboard).FindKernel((string)null) != 0)
		{
			currentHoverboard.tag = null;
		}
	}

	public void StartIdleAnimations(UIModelController.ModelScreen modelScreen)
	{
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00e9: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_model != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animEye).FindKernel((string)null) != 0)
		{
			Vector3 vector = ((AvatarEyeAnimation)modelScreen).GetFocusPoint();
		}
	}

	public void StartIdlePopupAnimations()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_model != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animEye).FindKernel((string)null) != 0)
		{
			_animEye.ForceBlink();
		}
	}

	public void StartCustomAnimation(UIModelController.ModelScreen modelScreen, bool useUnscaledTime, AnimationClip[] clips)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ce: Expected Obj, but got I4
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0031: Expected I4, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_003e: Expected VT, but got Obj
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_00a8: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = modelScreen;
		object obj3 = obj2 + 16;
		obj3 = clips;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Material material = default;
		material._002Ector((string)(object)this);
		object obj4 = obj2 + 12;
		obj4 = material;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		string text = string.ConcatArray((string[])0, (int)"_low");
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<Texture2D> action = default;
		object obj5 = action + 16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+14]");
		bool asynchronous = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22 (T)+24]");
		((AssetBundleFactory<Texture2D>)0).RequestItemInstance(text, action, asynchronous);
	}

	public void StopIdleAnimations()
	{
		//IL_019f: Expected I, but got Obj
		//IL_01b5: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_013f: Expected I, but got Obj
		//IL_0188: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_model != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_anim).FindKernel((string)null) != 0)
		{
			_anim.StopIdleAnimations();
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animEye).FindKernel((string)null) != 0)
		{
			Vector3 vector = ((AvatarEyeAnimation)3).GetFocusPoint();
		}
	}

	public void PauseIdleAnimations()
	{
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_013f: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_model != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_anim).FindKernel((string)null) != 0)
		{
			_anim.PauseIdleAnimations();
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_animEye).FindKernel((string)null) != 0)
		{
			_animEye.ForceBlink();
		}
	}

	public void ResumeIdleAnimations()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_model != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_anim).FindKernel((string)null) != 0)
		{
			_anim.ResumeIdleAnimations();
		}
	}

	private void CheckForCharactersToBeInSyncWithStaticData()
	{
		//IL_00fe: Expected I, but got Obj
		//IL_0114: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v20 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_model != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_anim).FindKernel((string)null) != 0)
		{
			_anim._002Ector();
		}
	}

	private void OnDestroy()
	{
	}

	public CharacterModel()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DontDestroyOnLoad(focusPoint);
		UnityEngine.Object.DestroyImmediate(_focusPoint);
		UnityEngine.Object.DontDestroyOnLoad(focusPoint);
	}
}
