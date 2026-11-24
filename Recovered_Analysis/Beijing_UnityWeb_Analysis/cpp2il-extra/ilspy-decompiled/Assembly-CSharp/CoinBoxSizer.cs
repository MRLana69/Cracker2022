using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using Info;
using Kiloo.Common.Extensions;
using SYBO.Subway.Info;
using UnityEngine;
using UnityEngine.U2D;

public class CoinBoxSizer : MonoBehaviour
{
	private UISprite _addFundsSprite;

	private UISprite _grayFGCoins;

	private UISprite _coinIcon;

	private UISprite _grayFGKeys;

	private UISprite _keyIcon;

	private UISprite _shadow;

	private GameObject _fundsParent;

	private GameObject _coinsParent;

	private GameObject _keysParent;

	private BoxCollider _boxCollider;

	public UILabel coinAmountLabel;

	public UILabel keyAmountLabel;

	private UIAnchor parentAnchor;

	private bool _updateAutomatically;

	private bool _shadowEnabled;

	private float _cachedCoinsFGWidth;

	private float _cachedCoinIconWidth;

	private float _cachedCoinIconOffset;

	private float _cachedKeysFGWidth;

	private float _cachedKeysIconWidth;

	private float _depthOffset_default;

	private float _shadowWidthOffset;

	private float COINS_FG_SCALE_OFFSET;

	private float KEYS_FG_SCALE_OFFSET;

	private const float BOX_COLLIDER_DEPTH = -15f;

	private bool isInitialized;

	private UIPanel _panel;

	public bool updateAutomatically
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CharacterManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return CharacterManager.IsCollectionComplete((Characters.CharacterId)this);
		}
		set
		{
			//IL_0094: Expected I, but got Obj
			//IL_00aa: Expected Obj, but got I
			//IL_00d6: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_0065: Expected Obj, but got I4
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)_keyIcon).FindKernel((string)value) != 0)
			{
				object obj2 = this + 28;
				obj2 = value;
				TransformExtensions.Reset((Transform)(object)_addFundsSprite);
			}
			else
			{
				TransformExtensions.Reset((Transform)(object)_grayFGCoins);
			}
		}
	}

	public void Init(UIWidget widgetAnchor, bool fundsEnabled, bool coinsEnabled, bool keysEnabled, float xOffset_custom = 0f, float yOffset_custom = 0f, float zOffset_custom = 0f)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
	}

	private void CacheCoinsSegmentElements()
	{
		CancelInvoke();
	}

	private void CacheKeysSegmentElements()
	{
		//IL_007a: Expected F4, but got I4
		//IL_0093: Expected F4, but got I4
		bool activeInHierarchy = _coinsParent.activeInHierarchy;
		UISprite coinIcon = _coinIcon;
		if (activeInHierarchy)
		{
			float num = (float)((UIWidget)coinIcon).mWidth * 2f;
			float cachedCoinIconOffset = num / 3f;
			_cachedCoinIconOffset = cachedCoinIconOffset;
			UISprite coinIcon2 = _coinIcon;
			_cachedCoinIconWidth = ((UIWidget)coinIcon2).mWidth;
			UISprite grayFGCoins = _grayFGCoins;
			_cachedCoinsFGWidth = ((UIWidget)grayFGCoins).mWidth;
		}
		else
		{
			float cachedCoinIconOffset2 = (float)((UIWidget)coinIcon).mWidth / 3f;
			_cachedCoinIconOffset = cachedCoinIconOffset2;
			_cachedCoinIconWidth = 0f;
			_cachedCoinsFGWidth = 0f;
		}
	}

	private unsafe void EnableElements(bool fundsEnabled, bool coinsEnabled, bool keysEnabled)
	{
		//IL_006f: Expected Obj, but got I4
		//IL_00b7: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		GameObject selectedObject = ((CenterOnChild)this).selectedObject;
		if ((object)selectedObject == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7723");
		}
		string text = _grayFGCoins.tag;
		bool activeInHierarchy = ((GameObject)(object)text).activeInHierarchy;
		object obj = activeInHierarchy ^ coinsEnabled;
		if (obj != null)
		{
			string text2 = _grayFGCoins.tag;
			((GameObject)(object)text2).tag = (string)coinsEnabled;
		}
		_coinIcon = (UISprite)keysEnabled;
		Transform transform = (Transform)((bool*)(fundsEnabled ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [fundsEnabled @ L1 (System.Boolean)+8]");
		((UnityEngine.Object)transform).m_CachedPtr = (IntPtr)0;
		Quaternion localRotation = transform.localRotation;
		((CenterOnChild)this).selectedObjectChanged += null;
	}

	private void PlaceSegments()
	{
		//IL_0019: Expected F4, but got I4
		//IL_005a: Expected F4, but got I4
		UISprite keyIcon = _keyIcon;
		_cachedKeysIconWidth = ((UIWidget)keyIcon).mWidth;
		if (_keysParent.activeInHierarchy)
		{
			UISprite grayFGKeys = _grayFGKeys;
			_cachedKeysFGWidth = ((UIWidget)grayFGKeys).mWidth;
		}
		else
		{
			_cachedKeysFGWidth = 0f;
		}
	}

	private void ScaleElementsThatStrechTheBox()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		//IL_004f: Expected VT, but got Obj
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_007e: Expected VT, but got Obj
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected Obj, but got Unknown
		//IL_00ad: Expected VT, but got Obj
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Obj, but got Unknown
		//IL_00c4: Expected Obj, but got I4
		//IL_0104: Expected Obj, but got F4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_0196: Expected VT, but got Obj
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01c5: Expected VT, but got Obj
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01f4: Expected VT, but got Obj
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected Obj, but got Unknown
		//IL_020b: Expected Obj, but got I4
		//IL_022a: Expected Obj, but got F4
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02ae: Expected VT, but got Obj
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected Obj, but got Unknown
		//IL_02dd: Expected VT, but got Obj
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_030c: Expected VT, but got Obj
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected Obj, but got Unknown
		//IL_0323: Expected Obj, but got I4
		//IL_0342: Expected Obj, but got F4
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected Obj, but got Unknown
		//IL_03c6: Expected VT, but got Obj
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03f5: Expected VT, but got Obj
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected Obj, but got Unknown
		//IL_0424: Expected VT, but got Obj
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected Obj, but got Unknown
		//IL_043b: Expected Obj, but got I4
		//IL_047b: Expected Obj, but got F4
		//IL_04f1: Expected VT, but got Obj
		CacheKeysSegmentElements();
		PlaceSegments();
		GameObject gameObject = _coinIcon.gameObject;
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 192);
		GameObject gameObject2 = _grayFGCoins.gameObject;
		transform.localPosition = (Vector3)gameObject2;
		Transform transform3 = (Transform)(transform2 + 180);
		GameObject gameObject3 = _grayFGCoins.gameObject;
		transform3.localPosition = (Vector3)gameObject3;
		Transform transform4 = (Transform)(transform2 + 168);
		GameObject gameObject4 = _grayFGCoins.gameObject;
		transform4.localPosition = (Vector3)gameObject4;
		object obj = transform2 + 156;
		obj = 0;
		_ = 0;
		float num = (float)transform - _cachedCoinsFGWidth;
		float num2 = _cachedCoinIconWidth * 0.5f;
		float num3 = num - num2;
		obj = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v14 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform4).m_CachedPtr;
		Transform transform5 = (Transform)(transform2 + 204);
		transform5 = (Transform)obj;
		Transform transform6 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v22+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform5.eulerAngles;
		GameObject gameObject5 = _grayFGKeys.gameObject;
		Transform transform7 = (Transform)(transform2 + 144);
		GameObject gameObject6 = _grayFGCoins.gameObject;
		transform7.localPosition = (Vector3)gameObject6;
		Transform transform8 = (Transform)(transform2 + 132);
		GameObject gameObject7 = _grayFGKeys.gameObject;
		transform8.localPosition = (Vector3)gameObject7;
		Transform transform9 = (Transform)(transform2 + 120);
		GameObject gameObject8 = _grayFGKeys.gameObject;
		transform9.localPosition = (Vector3)gameObject8;
		object obj2 = transform2 + 108;
		obj2 = 0;
		_ = 0;
		float num4 = (float)transform7 - _cachedCoinsFGWidth;
		obj2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v39 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform9).m_CachedPtr;
		transform5 = (Transform)obj2;
		Transform transform10 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v47+8]");
		((UnityEngine.Object)transform10).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles2 = transform5.eulerAngles;
		GameObject gameObject9 = keyAmountLabel.gameObject;
		Transform transform11 = (Transform)(transform2 + 96);
		GameObject gameObject10 = _grayFGKeys.gameObject;
		transform11.localPosition = (Vector3)gameObject10;
		Transform transform12 = (Transform)(transform2 + 84);
		GameObject gameObject11 = keyAmountLabel.gameObject;
		transform12.localPosition = (Vector3)gameObject11;
		Transform transform13 = (Transform)(transform2 + 72);
		GameObject gameObject12 = keyAmountLabel.gameObject;
		transform13.localPosition = (Vector3)gameObject12;
		object obj3 = transform2 + 60;
		obj3 = 0;
		_ = 0;
		float num5 = (float)transform11 - _cachedCoinIconOffset;
		obj3 = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S1_v63 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform13).m_CachedPtr;
		transform5 = (Transform)obj3;
		Transform transform14 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S1_v71+8]");
		((UnityEngine.Object)transform14).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles3 = transform5.eulerAngles;
		GameObject gameObject13 = _keyIcon.gameObject;
		Transform transform15 = (Transform)(transform2 + 48);
		GameObject gameObject14 = _grayFGKeys.gameObject;
		transform15.localPosition = (Vector3)gameObject14;
		Transform transform16 = (Transform)(transform2 + 36);
		GameObject gameObject15 = _keyIcon.gameObject;
		transform16.localPosition = (Vector3)gameObject15;
		Transform transform17 = (Transform)(transform2 + 24);
		GameObject gameObject16 = _keyIcon.gameObject;
		transform17.localPosition = (Vector3)gameObject16;
		object obj4 = transform2 + 12;
		obj4 = 0;
		_ = 0;
		float num6 = (float)transform15 - _cachedKeysFGWidth;
		float num7 = _cachedKeysIconWidth * 0.5f;
		float num8 = num6 - num7;
		obj4 = num8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S1_v89 (UnityEngine.Transform)+4]");
		_ = 0;
		_ = ((UnityEngine.Object)transform17).m_CachedPtr;
		transform5 = (Transform)obj4;
		Transform transform18 = transform5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S1_v97+8]");
		((UnityEngine.Object)transform18).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles4 = transform5.eulerAngles;
		GameObject gameObject17 = _shadow.gameObject;
		GameObject gameObject18 = _grayFGCoins.gameObject;
		transform2.localPosition = (Vector3)gameObject18;
		transform5 = transform2;
		((UnityEngine.Object)transform5).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 eulerAngles5 = transform5.eulerAngles;
		OnEnable();
	}

	private unsafe Vector3 CalculateCoinboxPosition(UIWidget widgetAnchor, Vector3 defaultPosition, float xOffset_custom, float yOffset_custom)
	{
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Expected VT, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected Obj, but got Unknown
		//IL_03ab: Expected Obj, but got VT
		//IL_03c5: Expected Obj, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected Obj, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected Obj, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected Obj, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected Obj, but got Unknown
		//IL_0425: Expected Obj, but got VT
		//IL_043f: Expected Obj, but got I
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected Obj, but got Unknown
		//IL_0486: Expected Obj, but got I
		//IL_0026: Expected I4, but got Obj
		//IL_0026: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0045: Expected Obj, but got I
		//IL_0063: Expected I4, but got Obj
		//IL_0063: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_0085: Expected Obj, but got I
		//IL_00a0: Expected Obj, but got I
		//IL_00b6: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Expected Obj, but got VT
		//IL_012c: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_016b: Expected Obj, but got I4
		//IL_04d9: Expected Obj, but got I
		//IL_0377: Expected Obj, but got VT
		//IL_0186: Expected Obj, but got I
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected Obj, but got Unknown
		//IL_0237: Expected Obj, but got I4
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected Obj, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_0303: Expected F4, but got Obj
		//IL_02fe: Expected native int or pointer, but got VT
		//IL_0318: Expected F4, but got I
		//IL_0313: Expected native int or pointer, but got VT
		//IL_033f: Expected Obj, but got I
		//IL_02b8: Expected Obj, but got VT
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected Obj, but got Unknown
		//IL_0364: Expected Obj, but got I4
		object obj = default;
		Vector4 vector = (Vector4)(obj + 16);
		Vector3 vector2 = default;
		object obj2 = vector2 + 52;
		string text = ((Component)vector2).tag;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v2 (Il2CppMethodInfo)+18]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S4_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		obj2 = obj7;
		object obj8 = vector2 + 20;
		obj8 = this;
		object obj9 = vector2 + 32;
		string text2 = ((Component)vector2).tag;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v6 (Il2CppMethodInfo)+18]");
		object obj10 = 0;
		object obj11 = obj10;
		object obj12 = obj11 & 0x1FFF;
		object obj13 = obj12 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S4_v8 (should have been resolved before IL gen)");
		object obj14 = default;
		obj9 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
		UnityEngine.Object obj15 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
		((AnimationState)num3).AddMixingTransform((Transform)0, (byte)(int)obj15 != 0);
		object obj16 = vector2 + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+14]");
		UnityEngine.Object obj17 = UnityEngine.Object.Instantiate((UnityEngine.Object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+20]");
		bool flag = ((Animation)0).Play((PlayMode)obj17);
		obj16 = flag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+24]");
		((AnimationState)0).wrapMode = WrapMode.Once;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+24]");
		((CharacterController)0).height = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+24]");
		((AnimationState)0).time = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+24]");
		((AnimationState)0).AddMixingTransform(null);
		Vector3 point = ((RaycastHit*)null)->point;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+24]");
		((AnimationState)0).layer = 2;
		object obj18 = vector2 + 40;
		string text3 = ((Component)vector2).tag;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S3_v14 (Il2CppMethodInfo)+18]");
		object obj19 = 0;
		object obj20 = obj19;
		object obj21 = obj20 & 0x1FFF;
		object obj22 = obj21 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v133 @ S4_v12 (should have been resolved before IL gen)");
		object obj23 = default;
		obj18 = obj23;
		object obj24 = 0;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+28]");
			object obj25 = 0;
			object obj26 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v34+C]");
			if ((nint)obj26 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+28]");
			object obj27 = (nint)0 + (nint)16;
			object obj28 = obj24 << 2;
			object obj29 = obj27 + obj28;
			string original = ((Component)obj29).tag;
			UnityEngine.Object obj30 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
			if ((string)(object)obj30 != "shadowPlane_blob")
			{
				object obj31 = vector2 + 48;
				Material sharedMaterial = ((Renderer)obj29).sharedMaterial;
				obj31 = sharedMaterial;
			}
			else
			{
				Material material = ((Renderer)obj29).material;
				object obj32 = material + 12;
				object obj33 = 0;
				while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj33) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj32))
				{
					object obj34 = material + 16;
					object obj35 = obj33 << 2;
					object obj36 = obj34 + obj35;
					Texture mainTexture = ((Material)obj36).mainTexture;
					UnityEngine.Object obj37 = UnityEngine.Object.Instantiate((UnityEngine.Object)mainTexture);
					if ((string)(object)obj37 != "Custom/Distorted/Character seperated alpha")
					{
						Color color = ((Material)defaultPosition).color;
					}
					else
					{
						Color color2 = ((Material)(object)widgetAnchor).color;
					}
					object obj38 = vector2 + 56;
					obj = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S1_v60+8]");
					_ = 0;
					((Vector4*)(nint)vector)->x = (float)obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((Vector4*)(nint)vector)->z = 0f;
					((Material)obj36).SetVector("_Color", vector);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector3)+2C]");
					((List<Material>)0).Add((Material)obj36);
					object obj39 = obj33 + 1;
					obj33 = obj39;
					obj20 = 0;
				}
			}
			object obj40 = obj24 + 1;
			obj24 = obj40;
		}
		((playThruster)vector2)._003CPlayEffects_003Eb__22_0(1f);
		return vector2;
	}

	private unsafe Vector2 CalculateDistanceToBounds(UIWidget widget)
	{
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_096f: Expected Obj, but got Unknown
		//IL_0978: Expected Obj, but got I4
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected Obj, but got Unknown
		//IL_0995: Expected Obj, but got I4
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_09b2: Expected Obj, but got I4
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Expected Obj, but got Unknown
		//IL_09cf: Expected Obj, but got I4
		//IL_09e3: Expected I, but got Obj
		//IL_09f9: Expected Obj, but got I
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected VT, but got Unknown
		//IL_0f71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f76: Expected VT, but got Unknown
		//IL_0f7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f84: Expected Obj, but got Unknown
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f92: Expected Obj, but got Unknown
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected Obj, but got Unknown
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected Obj, but got Unknown
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected Obj, but got Unknown
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected Obj, but got Unknown
		//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Expected Obj, but got Unknown
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe6: Expected Obj, but got Unknown
		//IL_0fef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff4: Expected Obj, but got Unknown
		//IL_1006: Expected Obj, but got I
		//IL_01af: Expected Obj, but got I
		//IL_01bd: Expected I, but got Obj
		//IL_01d3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0ac0: Expected Obj, but got I
		//IL_005b: Expected Obj, but got VT
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_01fe: Expected I, but got Obj
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected Obj, but got Unknown
		//IL_0a47: Expected I, but got Obj
		//IL_0a5d: Expected Obj, but got I
		//IL_0246: Expected Obj, but got VT
		//IL_0a8c: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected Obj, but got Unknown
		//IL_0177: Expected Obj, but got VT
		//IL_018d: Expected Obj, but got I
		//IL_00fb: Expected I, but got Obj
		//IL_0144: Expected Obj, but got VT
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_0af2: Expected Obj, but got I4
		//IL_0330: Expected Obj, but got I
		//IL_0341: Expected Obj, but got I
		//IL_0352: Expected Obj, but got F4
		//IL_036c: Expected Obj, but got I
		//IL_037d: Expected Obj, but got I
		//IL_02c6: Expected I, but got Obj
		//IL_0393: Expected VT, but got Obj
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected Obj, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected Obj, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected Obj, but got Unknown
		//IL_043e: Expected F4, but got Obj
		//IL_0439: Expected native int or pointer, but got VT
		//IL_0453: Expected F4, but got I
		//IL_044e: Expected native int or pointer, but got VT
		//IL_0487: Expected I, but got Obj
		//IL_049d: Expected Obj, but got I
		//IL_0b4f: Expected F4, but got Obj
		//IL_0b4a: Expected native int or pointer, but got VT
		//IL_0b64: Expected F4, but got I
		//IL_0b5f: Expected native int or pointer, but got VT
		//IL_0b79: Expected I4, but got VT
		//IL_0b79: Expected Obj, but got I
		//IL_0b87: Expected I, but got Obj
		//IL_0b9d: Expected Obj, but got I
		//IL_04c8: Expected I, but got Obj
		//IL_057e: Expected I4, but got Obj
		//IL_057e: Expected Obj, but got VT
		//IL_0515: Expected I, but got Obj
		//IL_058d: Expected VT, but got Obj
		//IL_059a: Expected F4, but got Obj
		//IL_0595: Expected native int or pointer, but got VT
		//IL_05ac: Expected F4, but got I
		//IL_05a7: Expected native int or pointer, but got VT
		//IL_05bd: Expected Ref, but got VT
		//IL_0562: Expected Obj, but got VT
		//IL_05cf: Expected F4, but got Obj
		//IL_05ca: Expected native int or pointer, but got VT
		//IL_05e4: Expected F4, but got I
		//IL_05df: Expected native int or pointer, but got VT
		//IL_05f5: Expected Ref, but got VT
		//IL_0615: Expected I, but got Obj
		//IL_062b: Expected Obj, but got I
		//IL_0bfa: Expected F4, but got Obj
		//IL_0bf5: Expected native int or pointer, but got VT
		//IL_0c0c: Expected F4, but got I
		//IL_0c07: Expected native int or pointer, but got VT
		//IL_0c19: Expected F4, but got Obj
		//IL_0c14: Expected native int or pointer, but got VT
		//IL_0c2e: Expected F4, but got I
		//IL_0c29: Expected native int or pointer, but got VT
		//IL_0c65: Expected Obj, but got I
		//IL_0c9e: Expected Obj, but got I
		//IL_0656: Expected I, but got Obj
		//IL_069e: Expected Obj, but got F4
		//IL_07cc: Expected VT, but got Obj
		//IL_07f7: Expected I, but got Obj
		//IL_080d: Expected Obj, but got I
		//IL_0d94: Expected F4, but got Obj
		//IL_0d8f: Expected native int or pointer, but got VT
		//IL_0da6: Expected F4, but got I
		//IL_0da1: Expected native int or pointer, but got VT
		//IL_0db3: Expected F4, but got Obj
		//IL_0dae: Expected native int or pointer, but got VT
		//IL_0dc5: Expected F4, but got I
		//IL_0dc0: Expected native int or pointer, but got VT
		//IL_0df8: Expected Obj, but got I
		//IL_0e08: Expected Obj, but got I
		//IL_0e15: Expected Obj, but got VT
		//IL_0e48: Expected Obj, but got I4
		//IL_0e6b: Expected I, but got Obj
		//IL_0e81: Expected Obj, but got I
		//IL_06bf: Expected Obj, but got I
		//IL_06d0: Expected VT, but got Obj
		//IL_0ebb: Expected F4, but got Obj
		//IL_0eb6: Expected native int or pointer, but got VT
		//IL_0ec8: Expected F4, but got Obj
		//IL_0ec3: Expected native int or pointer, but got VT
		//IL_0ee6: Expected F4, but got Obj
		//IL_0ee1: Expected native int or pointer, but got VT
		//IL_0ef3: Expected Obj, but got VT
		//IL_0f00: Expected F4, but got Obj
		//IL_0efb: Expected native int or pointer, but got VT
		//IL_0f15: Expected F4, but got I
		//IL_0f10: Expected native int or pointer, but got VT
		//IL_0f1e: Expected Obj, but got VT
		//IL_0838: Expected I, but got Obj
		//IL_0700: Expected I, but got Obj
		//IL_0716: Expected Obj, but got I
		//IL_08d2: Expected I, but got Obj
		//IL_08e8: Expected Obj, but got I
		//IL_0885: Expected I, but got Obj
		//IL_0d01: Expected F4, but got Obj
		//IL_0cfc: Expected native int or pointer, but got VT
		//IL_0d13: Expected F4, but got I
		//IL_0d0e: Expected native int or pointer, but got VT
		//IL_0d20: Expected F4, but got Obj
		//IL_0d1b: Expected native int or pointer, but got VT
		//IL_0d32: Expected F4, but got I
		//IL_0d2d: Expected native int or pointer, but got VT
		//IL_0d50: Expected F4, but got Obj
		//IL_0d4b: Expected native int or pointer, but got VT
		//IL_0d62: Expected F4, but got I
		//IL_0d5d: Expected native int or pointer, but got VT
		//IL_0f39: Expected Obj, but got I
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_07a4: Expected Obj, but got VT
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected Obj, but got Unknown
		//IL_0741: Expected I, but got Obj
		//IL_0913: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 152;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 140;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 128;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 116;
		obj5 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v232 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 184);
		Vector3 vector2 = (Vector3)(obj2 + 168);
		Transform transform = (Transform)(obj2 + 104);
		Transform transform2 = (Transform)(obj2 + 88);
		Transform transform3 = (Transform)(obj2 + 72);
		object obj7 = obj2 + 8;
		object obj8 = obj2 + 60;
		object obj9 = obj2 + 48;
		object obj10 = obj2 + 40;
		object obj11 = obj2 + 32;
		object obj12 = obj2 + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
		Vector2 vector3 = default;
		if ((UnityEngine.Object)0 != null)
		{
			string go = ((Component)vector3).tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v215 (Il2CppClass<NGUITools>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S0_v228 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj14 = vector3 + 20;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>((GameObject)(object)go);
			obj14 = uIScrollView;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v247 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S1_v261 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
			if ((UnityEngine.Object)0 != null)
			{
				((Component)vector3).tag = null;
				goto IL_0aa9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			object obj17 = default;
			object obj16 = obj17 + 16;
			obj16 = vector3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
			object obj18 = (nint)0 + (nint)68;
			obj18 = obj17;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
		object obj19 = 0;
		nint num8 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S1_v31 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S1_v237 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v56+68]");
		if (!((UnityEngine.Object)0 != null))
		{
			GameObject gameObject = ((Component)vector3).gameObject;
			int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
			Sprite sprite = null;
			object obj33 = default;
			while ((nint)sprite < siblingIndex)
			{
				bool flag = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite);
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S1_v42 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num11 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S1_v233 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (!((UnityEngine.Object)flag != this))
				{
					Sprite sprite2 = (Sprite)(sprite + 1);
					sprite = sprite2;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				object obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S1_v48+68]");
				Vector2 clipSoftness = ((UIPanel)0).clipSoftness;
				obj = vector2.x;
				_ = vector2.z;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S1_v55+68]");
				Camera anchorCamera = ((UIRect)0).anchorCamera;
				transform.localPosition = (Vector3)anchorCamera;
				obj3 = transform;
				_ = ((UnityEngine.Object)transform).m_CachedPtr;
				transform2 = (Transform)obj;
				Transform transform4 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				object obj24 = obj3 + (object)transform2;
				obj3 = obj24;
				object obj25 = obj3 + 4;
				transform3 = (Transform)obj;
				Transform transform5 = transform3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
				object obj26 = obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v36 (UnityEngine.Transform)+4]");
				object obj27 = obj26 + 0;
				obj25 = obj27;
				Transform parentInternal = ((Transform)(object)anchorCamera).parentInternal;
				((Vector3*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 vector4 = parentInternal.InverseTransformPoint(vector);
				obj3 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+8]");
				_ = 0;
				nint num12 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S1_v86 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj28 = (nint)0 & (nint)0x200;
				if (obj28 != null)
				{
					nint num13 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S1_v228 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Vector3 one = Vector3.one;
				((Vector3*)(nint)vector)->x = (float)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v40+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				((UIScrollView)0).UpdateScrollbars((byte)(int)vector != 0);
				nint num14 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v98 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj29 = (nint)0 & (nint)0x200;
				if (obj29 != null)
				{
					nint num15 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ S0_v206 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)this).FindKernel((string)null) == 0)
				{
					((CoinBoxSizer)vector3).updateAutomatically = false;
					break;
				}
				string text = tag;
				((CoinBoxSizer)vector3).updateAutomatically = (byte)(int)text != 0;
				transform.position = (Vector3)this;
				((Vector3*)(nint)vector)->x = (float)transform;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				transform2.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
				((Vector3*)(nint)vector)->x = (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				((Vector3*)(nint)vector)->z = 0f;
				transform3.Internal_LookAt_Injected(ref *(Vector3*)anchorCamera, ref *(Vector3*)vector);
				obj7 = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				nint num16 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ S0_v116 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num17 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ S0_v201 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform2;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Quaternion quaternion = Quaternion.FromToRotation(vector2, vector);
				obj4 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v40+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				if (!((UIScrollView)0).canMoveVertically)
				{
					obj4 = 0f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				if (!((UIScrollView)0).shouldMoveHorizontally)
				{
					_ = 0f;
				}
				_ = 0f;
				if ((object)widget == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
					string go2 = ((Component)0).tag;
					transform.localPosition = (Vector3)anchorCamera;
					transform2 = (Transform)obj4;
					Transform transform6 = transform2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
					((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
					nint num18 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ S1_v201 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj31 = (nint)0 & (nint)0x200;
					if (obj31 != null)
					{
						nint num19 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S1_v221 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)transform;
					((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					Quaternion quaternion2 = Quaternion.FromToRotation(vector2, vector);
					((Vector3*)(nint)vector)->x = (float)transform3;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform3).m_CachedPtr;
					SpringPosition springPosition = SpringPosition.Begin((GameObject)(object)go2, vector, 8f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num20 = 0;
					_ = 0;
					object obj32 = obj33 + 16;
					obj32 = vector3;
					object obj34 = springPosition + 28;
					obj34 = obj33;
					break;
				}
				transform.localPosition = (Vector3)anchorCamera;
				transform2 = (Transform)obj4;
				Transform transform7 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
				nint num21 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ S0_v144 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj35 = (nint)0 & (nint)0x200;
				if (obj35 != null)
				{
					nint num22 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S0_v190 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector2)->x = (float)transform;
				((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
				((Vector3*)(nint)vector)->x = (float)transform2;
				((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
				Quaternion quaternion3 = Quaternion.FromToRotation(vector2, vector);
				obj5 = transform3;
				_ = ((UnityEngine.Object)transform3).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v620 @ S1_v152+68]");
				UIPanel uIPanel = (UIPanel)0;
				obj7 = uIPanel.mClipOffset;
				obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				_ = 0;
				obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
				_ = 0;
				obj2 = 0;
				obj2 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42+4]");
				_ = 0;
				nint num23 = (nint)typeof(Vector2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S0_v168 (Il2CppClass<UnityEngine.Vector2>)+BA]");
				object obj37 = (nint)0 & (nint)0x200;
				if (obj37 != null)
				{
					nint num24 = (nint)typeof(Vector2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S0_v186 (Il2CppClass<UnityEngine.Vector2>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj10 = obj7;
				obj11 = obj2;
				((Vector3*)(nint)vector2)->x = (float)obj10;
				((Vector3*)(nint)vector)->x = (float)obj11;
				Vector2 vector5 = (Vector2)vector2 - (Vector2)vector;
				((Vector3*)(nint)vector)->x = (float)obj12;
				uIPanel.clipTexture = (Texture2D)vector;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Vector3 eulerAngles = ((Transform)vector).eulerAngles;
				nint num25 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S1_v185 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj38 = (nint)0 & (nint)0x200;
				if (obj38 != null)
				{
					nint num26 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v719 @ S1_v192 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0 (UnityEngine.Vector2)+14]");
				if (((ComputeShader)0).FindKernel(null) != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
				}
				break;
			}
		}
		goto IL_0aa9;
		IL_0aa9:
		return vector3;
	}

	private unsafe void OnEnable()
	{
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_0285: Expected Obj, but got I4
		//IL_02cd: Expected I, but got Obj
		//IL_02e3: Expected Obj, but got I
		//IL_031c: Expected I4, but got Obj
		//IL_032a: Expected F4, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00a1: Expected I4, but got Obj
		//IL_00af: Expected F4, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected Obj, but got Unknown
		//IL_0149: Expected Obj, but got I4
		//IL_015c: Expected Obj, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Ref, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected Obj, but got Unknown
		//IL_01e2: Expected VT, but got Obj
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected Obj, but got Unknown
		//IL_0204: Expected VT, but got Obj
		//IL_020d: Expected Obj, but got I4
		//IL_023a: Expected Obj, but got F4
		//IL_0264: Expected Obj, but got Ref
		object obj2 = default;
		object obj = obj2 + 88;
		obj = 0;
		_ = 0;
		_ = 0;
		float num = _cachedCoinsFGWidth + _cachedKeysFGWidth;
		float num2 = num + _shadowWidthOffset;
		UISprite addFundsSprite = _addFundsSprite;
		nint num3 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v66 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GUILayoutOption gUILayoutOption = GUILayout.Width(num2);
		_shadow.height = (int)gUILayoutOption;
		GUILayoutOption gUILayoutOption2 = GUILayout.Width(((UIWidget)addFundsSprite).mHeight);
		Color color = ((UIWidget)(object)gUILayoutOption2).color;
		float num5 = _cachedKeysIconWidth * 0.5f;
		float width = num2 + num5;
		GUILayoutOption gUILayoutOption3 = GUILayout.Width(width);
		_addFundsSprite.height = (int)gUILayoutOption3;
		GUILayoutOption gUILayoutOption4 = GUILayout.Width(((UIWidget)addFundsSprite).mHeight);
		Color color2 = ((UIWidget)(object)gUILayoutOption4).color;
		UISprite addFundsSprite2 = _addFundsSprite;
		UISprite addFundsSprite3 = _addFundsSprite;
		Collider collider = (Collider)(obj2 - -64);
		collider.get_bounds_Injected(out *(Bounds*)_boxCollider);
		obj = collider;
		_ = ((UnityEngine.Object)collider).m_CachedPtr;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v32 (UnityEngine.Collider)+10]");
		_ = 0;
		object obj4 = obj2 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
		object obj5 = obj2 + 36;
		obj5 = 0;
		_ = 0;
		obj5 = ((UIWidget)addFundsSprite2).mWidth;
		int num6 = ((UIWidget)addFundsSprite3).mHeight << 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S1_v37+8]");
		_ = 0;
		ref Vector3 reference = ref *(Vector3*)(obj2 + 112);
		reference = ref *(Vector3*)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v41+8]");
		_ = 0;
		_boxCollider.get_center_Injected(out reference);
		Transform transform = (Transform)(obj2 + 24);
		GameObject gameObject = _addFundsSprite.gameObject;
		transform.localPosition = (Vector3)gameObject;
		BoxCollider boxCollider = (BoxCollider)(obj2 + 12);
		boxCollider.size = (Vector3)_boxCollider;
		obj2 = 0;
		_ = 0;
		float num7 = (float)boxCollider * 0.5f;
		float num8 = (float)transform - num7;
		obj2 = num8;
		_ = 0f;
		_ = -15f;
		reference = ref *(Vector3*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector3 size = ((BoxCollider)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference)).size;
	}

	private unsafe void OnDisable()
	{
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CoinBoxSizer.OnCoinsChanged);
		object obj = action + 16;
		obj = this;
		InventorySave.coinsChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(CoinBoxSizer.OnKeysChanged);
		object obj2 = action2 + 16;
		obj2 = this;
		InventorySave.keysChanged -= action2;
		if (~(isInitialized ? 1u : 0u) == 0)
		{
			OnKeysChanged();
			AdjustCoinsSegmentSize();
		}
	}

	private unsafe void Start()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(CoinBoxSizer.OnCoinsChanged);
		object obj = action + 16;
		obj = this;
		InventorySave.keysChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Action<UpgradeType, int> action2 = default;
		object obj2 = action2 + 16;
		obj2 = this;
		InventorySave.powerupsChanged += action2;
	}

	private void OnCoinsChanged()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_0054: Expected I, but got Obj
		_AdjustKeysSegmentSize();
		this._002Ector();
		string go = tag;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v16 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = this + 108;
		UIPanel uIPanel = NGUITools.FindInParents<UIPanel>((GameObject)(object)go);
		obj2 = uIPanel;
	}

	private void OnKeysChanged()
	{
		//IL_01a2: Expected Obj, but got I4
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_003e: Expected Obj, but got I4
		//IL_00b3: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_00f4: Expected I, but got Obj
		object obj = 0;
		object obj2 = this - -64;
		if (obj2 == null || !_coinsParent.activeInHierarchy)
		{
			return;
		}
		int unrewardedCoins = InventorySave.unrewardedCoins;
		obj = unrewardedCoins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		coinAmountLabel.fontSize = fontSize;
		_AdjustKeysSegmentSize();
		string text = coinAmountLabel.tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v22 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_panel).FindKernel((string)null) != 0)
		{
			UIPanel panel = _panel;
			if (~(panel.widgetsAreStatic ? 1u : 0u) == 0)
			{
				UIPanel panel2 = _panel;
				panel2.widgetsAreStatic = false;
				_panel._002Ector();
				UIPanel panel3 = _panel;
				panel3.widgetsAreStatic = true;
			}
		}
	}

	public void AdjustCoinsSegmentSize()
	{
		//IL_017a: Expected Obj, but got I4
		//IL_0016: Expected Obj, but got I4
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00cc: Expected I, but got Obj
		object obj = 0;
		if (!_keysParent.activeInHierarchy)
		{
			return;
		}
		int coins = InventorySave.coins;
		obj = coins;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		keyAmountLabel.fontSize = fontSize;
		this._002Ector();
		string text = keyAmountLabel.tag;
		string text2 = ((GameObject)(object)text).tag;
		if (text2 == null)
		{
			return;
		}
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_panel).FindKernel((string)null) != 0)
		{
			UIPanel panel = _panel;
			if (~(panel.widgetsAreStatic ? 1u : 0u) == 0)
			{
				UIPanel panel2 = _panel;
				panel2.widgetsAreStatic = false;
				_panel._002Ector();
				UIPanel panel3 = _panel;
				panel3.widgetsAreStatic = true;
			}
		}
	}

	private void _AdjustKeysSegmentSize()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_00fe: Expected I4, but got Obj
		//IL_005e: Expected I, but got Obj
		if (_coinsParent.activeInHierarchy)
		{
			UILabel uILabel = coinAmountLabel;
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float width = (float)((UIWidget)uILabel).mWidth + COINS_FG_SCALE_OFFSET;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			_grayFGCoins.height = (int)gUILayoutOption;
		}
		ScaleElementsThatStrechTheBox();
	}

	public CoinBoxSizer()
	{
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_010f: Expected I4, but got Obj
		//IL_0071: Expected I, but got Obj
		if (_keysParent.activeInHierarchy)
		{
			float num = KEYS_FG_SCALE_OFFSET + _cachedCoinIconOffset;
			UILabel uILabel = keyAmountLabel;
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v15 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float width = (float)((UIWidget)uILabel).mWidth + num;
			GUILayoutOption gUILayoutOption = GUILayout.Width(width);
			_grayFGKeys.height = (int)gUILayoutOption;
		}
		ScaleElementsThatStrechTheBox();
	}
}
