using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class CharacterScaler : MonoBehaviour
{
	public enum ScaleAnchorType
	{
		CharacterAnchor,
		GameOverAnchor,
		TutorialPupupAnchor,
		CelebrationPopupAnchor,
		LimitedCharacterPopupAnchor,
		BirthdayAnchor,
		BoardPromotionPopupAnchor
	}

	public bool lookAtCamera;

	private Camera _camera;

	private ScaleAnchorType _anchorType;

	private float _posX;

	private float _posY;

	private float _scaleMultiplierForRotation;

	private float _scaleFactor;

	private float _scaleDelta;

	private const float STANDARD_ASPECT_RATIO = 1.5f;

	private UIRoot _root;

	private void Start()
	{
		((UpgradeScreen)this).Start();
	}

	private void Update()
	{
		//IL_0199: Expected I, but got Obj
		//IL_01af: Expected Obj, but got I
		//IL_01da: Expected I, but got Obj
		//IL_01f0: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I
		//IL_02b4: Expected I, but got Obj
		//IL_02ca: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected Obj, but got Unknown
		//IL_0225: Expected VT, but got Obj
		//IL_022d: Expected Obj, but got VT
		//IL_0145: Expected I, but got Obj
		//IL_00ab: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v33 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_camera != null)
		{
			string trans = tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v30 (Il2CppClass<NGUITools>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v36 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj3 = this + 16;
			_0021_00210 val = (_0021_00210)NGUITools.FindInParents<T>((Transform)(object)trans);
			obj3 = val;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v23 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = this + 44;
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v12 (System.Boolean)+3C]");
		obj5 = 0;
		ScaleCharacter();
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S1_v24 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = _root != null;
		RotateCharacter();
		this._002Ector();
		PositionCharacter();
	}

	private void SetScreenRelatedSettings()
	{
		if (~(lookAtCamera ? 1u : 0u) == 0)
		{
			PositionCharacter();
			lookAtCamera = false;
		}
	}

	private void ScaleCharacter()
	{
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected Obj, but got Unknown
		//IL_0255: Expected I, but got Obj
		//IL_026b: Expected Obj, but got I
		//IL_04aa: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_0296: Expected I, but got Obj
		//IL_02e3: Expected I, but got Obj
		//IL_054e: Expected I, but got Obj
		//IL_0564: Expected Obj, but got I
		//IL_00f1: Expected F4, but got I4
		//IL_0372: Expected I, but got Obj
		//IL_01b8: Expected VT, but got Obj
		//IL_03bf: Expected I, but got Obj
		//IL_03d5: Expected Obj, but got I
		//IL_01c7: Expected F4, but got Obj
		//IL_01de: Expected VT, but got Obj
		//IL_01f5: Expected F4, but got I
		//IL_0400: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 12);
		if (_anchorType != ScaleAnchorType.CharacterAnchor)
		{
			if (_anchorType != ScaleAnchorType.GameOverAnchor)
			{
				if (_anchorType == ScaleAnchorType.TutorialPupupAnchor)
				{
					_posX = 92f;
					_posY = 40f;
					_scaleMultiplierForRotation = 0f;
					_scaleDelta = 380f;
				}
				else if (_anchorType == ScaleAnchorType.CelebrationPopupAnchor)
				{
					_posX = 0f;
					_posY = 0f;
					_scaleMultiplierForRotation = 0f;
					UIRoot root = _root;
					_scaleDelta = root.manualHeight;
				}
				else if (_anchorType == ScaleAnchorType.LimitedCharacterPopupAnchor)
				{
					_posX = -75f;
					UIRoot root2 = _root;
					float num = (float)root2.manualHeight * 0.5f;
					float posY = num - 45f;
					_posY = posY;
					_scaleMultiplierForRotation = 56f;
					_scaleDelta = -400f;
				}
				else if (_anchorType == ScaleAnchorType.BirthdayAnchor)
				{
					GameObject gameObject = base.gameObject;
					transform.localPosition = (Vector3)gameObject;
					_posX = (float)transform;
					GameObject gameObject2 = base.gameObject;
					transform2.localPosition = (Vector3)gameObject2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Transform)+4]");
					_posY = 0f;
					_scaleDelta = 450f;
				}
				return;
			}
			_posX = -70f;
			UIRoot root3 = _root;
			int num2 = root3.manualHeight / 2;
			float posY2 = (float)num2 - 230f;
			_posY = posY2;
			nint num3 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v27 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num4 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v70 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float soundVolume = NGUITools.soundVolume;
			nint num5 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v34 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num6 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v66 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num7 = soundVolume - 1.5f;
			float num8 = 15f * num7;
			float num9 = default;
			if (num8 < 0f)
			{
				num8 = 0f;
			}
			else if (num8 > num9)
			{
				num8 = num9;
			}
			float posY3 = _posY + num8;
			_posY = posY3;
			nint num10 = (nint)typeof(IPhoneXSupport);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v40 (Il2CppClass<IPhoneXSupport>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num11 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v62 (Il2CppClass<IPhoneXSupport>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (IPhoneXSupport.CheckIsiPhoneXDevice())
			{
				nint num12 = (nint)typeof(IPhoneXSupport);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v51 (Il2CppClass<IPhoneXSupport>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num13 = (nint)typeof(IPhoneXSupport);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v56 (Il2CppClass<IPhoneXSupport>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num14 = (float)IPhoneXSupport.OFFSET_TOP * 0.5f;
				float posY4 = _posY - num14;
				_posY = posY4;
			}
			_scaleMultiplierForRotation = 32f;
		}
		else
		{
			_posX = -75f;
			_posY = -45f;
			_scaleMultiplierForRotation = 56f;
		}
		_scaleDelta = 450f;
	}

	private void RotateCharacter()
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected Obj, but got Unknown
		//IL_003e: Expected VT, but got Obj
		object obj = 0;
		_ = 0;
		UIRoot root = _root;
		Transform transform = (Transform)(obj + 12);
		GameObject gameObject = base.gameObject;
		transform.localPosition = (Vector3)gameObject;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		if (_scaleDelta == 0f)
		{
			float num = 0f;
		}
		else
		{
			float num = (float)root.manualHeight - _scaleDelta;
		}
		GameObject gameObject2 = ((Component)(object)gameObject).gameObject;
		transform = (Transform)obj;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
	}

	private unsafe void PositionCharacter()
	{
		//IL_028f: Expected Obj, but got Ref
		//IL_0298: Expected Obj, but got I4
		//IL_02ac: Expected I, but got Obj
		//IL_02c2: Expected Obj, but got I
		//IL_0495: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_02f5: Expected Obj, but got VT
		//IL_00a1: Expected I, but got Obj
		//IL_04cb: Expected Obj, but got F4
		//IL_0519: Expected I, but got Obj
		//IL_052f: Expected Obj, but got I
		//IL_045a: Expected Ref, but got VT
		//IL_0470: Expected Obj, but got Ref
		//IL_0122: Expected I, but got Obj
		//IL_0138: Expected Obj, but got I
		//IL_0241: Expected I, but got Obj
		//IL_03c3: Expected I, but got Obj
		//IL_03d9: Expected Obj, but got I
		//IL_0163: Expected I, but got Obj
		//IL_01b0: Expected I, but got Obj
		ref Quaternion reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 28));
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref Quaternion reference2 = ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40);
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 16));
		if (((ComputeShader)(object)_camera).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v17 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v74 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		obj = reference2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v12 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		UIRoot root = _root;
		float num5 = (float)root.manualHeight - 480f;
		float num6;
		if (_scaleMultiplierForRotation == 0f)
		{
			num6 = 0f;
		}
		else
		{
			float num7 = num5 / _scaleMultiplierForRotation;
			num6 = num7 + 5f;
		}
		bool flag = _anchorType == ScaleAnchorType.GameOverAnchor;
		bool flag2 = !flag;
		float num8 = num6;
		if (!flag2)
		{
			nint num9 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v43 (Il2CppClass<Utils>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v66 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float soundVolume = NGUITools.soundVolume;
			float num11 = soundVolume - 1.5f;
			float num12 = num11 + 1f;
			float num13 = num6 * num12;
			nint num14 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S0_v50 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num15 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v62 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (num13 < 5f)
			{
				num13 = 5f;
			}
			else if (num13 > 25f)
			{
				num13 = 25f;
			}
			num8 = num13;
		}
		object obj7 = 0f - num8;
		obj = obj7;
		_ = 0f;
		_ = 0f;
		string text = tag;
		int layer = ((GameObject)(object)text).layer;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num16 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v37 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num17 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v47 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		reference2 = ref *(Quaternion*)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14+8]");
		_ = 0;
		Quaternion.Inverse_Injected(ref reference, out reference2);
		reference2 = ref *(Quaternion*)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (UnityEngine.Quaternion&)+8]");
		_ = 0;
		Vector3 localScale = ((Transform)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2)).localScale;
	}

	public CharacterScaler()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected Obj, but got Unknown
		//IL_00c5: Expected Obj, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00f0: Expected VT, but got Obj
		//IL_010c: Expected Obj, but got F4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0020: Expected VT, but got Obj
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0179: Expected VT, but got Obj
		//IL_006f: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 24);
		GameObject gameObject = base.gameObject;
		transform.localPosition = (Vector3)gameObject;
		obj = transform;
		_ = ((UnityEngine.Object)transform).m_CachedPtr;
		obj = _posX;
		_ = _posY;
		Transform transform2 = (Transform)(obj2 + 48);
		transform2 = (Transform)obj;
		Transform transform3 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform2.eulerAngles;
		Transform transform4 = (Transform)(obj2 + 12);
		transform4.localScale = (Vector3)gameObject;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v41 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		transform2 = transform4;
		((UnityEngine.Object)transform2).m_CachedPtr = ((UnityEngine.Object)transform4).m_CachedPtr;
		Vector3 vector = (Vector3)transform2 / _scaleFactor;
		transform2 = (Transform)obj2;
		Transform transform5 = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		((Transform)(object)gameObject).parent = transform2;
	}
}
