using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.U2D;

public class UICenterOnChild : MonoBehaviour
{
	public delegate void OnCenterCallback(GameObject centeredObject);

	public float springStrength;

	public float nextPageThreshold;

	public SpringPanel.OnFinished onFinished;

	public OnCenterCallback onCenter;

	private UIScrollView mScrollView;

	private GameObject mCenteredObject;

	public GameObject centeredObject
	{
		get
		{
			//IL_000a: Expected Obj, but got I4
			return (GameObject)isActiveAndEnabled;
		}
	}

	private void Start()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0017: Expected Obj, but got I4
		//IL_0026: Expected Obj, but got F4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got F4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 12;
		obj = 0;
		_ = 0;
		obj = 1.1f;
		_ = 1.1f;
		_ = 1.1f;
		object obj3 = obj2 + 24;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		_ = 0;
		object obj4 = this + 16;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj2 = 1.05f;
		_ = 1.05f;
		_ = 1.05f;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj5 = this + 28;
		obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11+8]");
		_ = 0;
		_ = 0.2f;
		CancelInvoke();
	}

	private void OnEnable()
	{
		this._002Ector();
	}

	private void OnDisable()
	{
		//IL_0081: Expected I, but got Obj
		//IL_0097: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mScrollView))
		{
			object obj2 = mScrollView + 200;
			obj2 = this;
			this._002Ector();
		}
	}

	private void OnDragFinished()
	{
		//IL_007e: Expected I, but got Obj
		//IL_0094: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v11 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mScrollView))
		{
			object obj2 = mScrollView + 200;
			obj2 = 0;
		}
	}

	private void OnValidate()
	{
		if (isActiveAndEnabled)
		{
			this._002Ector();
		}
	}

	public void Recenter()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v13 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = Math.Abs(nextPageThreshold);
		nextPageThreshold = num3;
	}

	private void CenterOn(Transform target, Vector3 panelCenter)
	{
		//IL_0086: Expected I4, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UICenterOnChild)+64]");
		if ((nint)0 == 0)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UICenterOnChild)+6C]");
		if (0 != (nint)target)
		{
			((UIButtonMessage)this).OnHover((byte)(int)panelCenter != 0);
		}
	}

	public void CenterOn(Transform target)
	{
		//IL_00ba: Expected I4, but got Obj
		//IL_0030: Expected I, but got Obj
		//IL_0046: Expected Obj, but got I
		//IL_0071: Expected I, but got Obj
		if (!isActiveAndEnabled)
		{
			return;
		}
		if ((object)target != null)
		{
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v19 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			KeyCode currentKey = UICamera.currentKey;
			if (currentKey != (KeyCode)2)
			{
				return;
			}
		}
		((UIButtonScale)this).OnSelect((byte)(int)target != 0);
	}

	public unsafe UICenterOnChild()
	{
		//IL_1484: Unknown result type (might be due to invalid IL or missing references)
		//IL_1489: Expected Obj, but got Unknown
		//IL_1492: Expected Obj, but got I4
		//IL_14a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Expected Ref, but got Unknown
		//IL_14be: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c3: Expected Obj, but got Unknown
		//IL_14cc: Expected Obj, but got I4
		//IL_14db: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e0: Expected Obj, but got Unknown
		//IL_14e9: Expected Obj, but got I4
		//IL_14fd: Expected I, but got Obj
		//IL_1513: Expected Obj, but got I
		//IL_1e22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e27: Expected VT, but got Unknown
		//IL_1e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e35: Expected VT, but got Unknown
		//IL_1e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e43: Expected Obj, but got Unknown
		//IL_1e4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e51: Expected Obj, but got Unknown
		//IL_1e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5f: Expected Obj, but got Unknown
		//IL_1e68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6d: Expected Obj, but got Unknown
		//IL_1e76: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e7b: Expected VT, but got Unknown
		//IL_1e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e89: Expected Obj, but got Unknown
		//IL_1e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e97: Expected Obj, but got Unknown
		//IL_1ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea5: Expected Obj, but got Unknown
		//IL_1eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb3: Expected Obj, but got Unknown
		//IL_1ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ec1: Expected Obj, but got Unknown
		//IL_1548: Expected I, but got Obj
		//IL_155e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0555: Expected I, but got Obj
		//IL_1581: Unknown result type (might be due to invalid IL or missing references)
		//IL_1586: Expected Obj, but got Unknown
		//IL_15a9: Expected I, but got Obj
		//IL_15bf: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_02dc: Expected I, but got Obj
		//IL_02f2: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected Obj, but got Unknown
		//IL_063d: Expected I, but got Obj
		//IL_0653: Expected Obj, but got I
		//IL_16ab: Expected I, but got Obj
		//IL_16c1: Expected Obj, but got I
		//IL_031d: Expected I, but got Obj
		//IL_1736: Expected F4, but got Obj
		//IL_1731: Expected native int or pointer, but got VT
		//IL_1748: Expected F4, but got I
		//IL_1743: Expected native int or pointer, but got VT
		//IL_1755: Expected F4, but got Obj
		//IL_1750: Expected native int or pointer, but got VT
		//IL_176a: Expected F4, but got I
		//IL_1765: Expected native int or pointer, but got VT
		//IL_1788: Expected F4, but got Obj
		//IL_1783: Expected native int or pointer, but got VT
		//IL_179a: Expected F4, but got I
		//IL_1795: Expected native int or pointer, but got VT
		//IL_17cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d1: Expected Obj, but got Unknown
		//IL_17de: Expected F4, but got Obj
		//IL_17d9: Expected native int or pointer, but got VT
		//IL_17f3: Expected F4, but got I
		//IL_17ee: Expected native int or pointer, but got VT
		//IL_180a: Expected native int or pointer, but got VT
		//IL_181c: Expected native int or pointer, but got VT
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected Obj, but got Unknown
		//IL_06f6: Expected F4, but got Obj
		//IL_06f1: Expected native int or pointer, but got VT
		//IL_070b: Expected F4, but got I
		//IL_0706: Expected native int or pointer, but got VT
		//IL_067e: Expected I, but got Obj
		//IL_16f6: Expected I, but got Obj
		//IL_170c: Expected Obj, but got I
		//IL_0384: Expected I, but got Obj
		//IL_072f: Expected F4, but got Obj
		//IL_072a: Expected native int or pointer, but got VT
		//IL_0744: Expected F4, but got I
		//IL_073f: Expected native int or pointer, but got VT
		//IL_0751: Expected F4, but got Obj
		//IL_074c: Expected native int or pointer, but got VT
		//IL_0766: Expected F4, but got I
		//IL_0761: Expected native int or pointer, but got VT
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_07a9: Expected I, but got Obj
		//IL_07bf: Expected Obj, but got I
		//IL_046c: Expected I, but got Obj
		//IL_1846: Expected Obj, but got VT
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected Obj, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_1891: Expected Obj, but got I4
		//IL_189a: Expected Obj, but got I4
		//IL_07ea: Expected I, but got Obj
		//IL_0832: Expected Obj, but got VT
		//IL_085b: Expected Obj, but got I4
		//IL_0864: Expected Obj, but got I4
		//IL_09c8: Expected Obj, but got I4
		//IL_09a1: Expected I4, but got Obj
		//IL_09a9: Expected Obj, but got I4
		//IL_1a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a19: Expected Obj, but got Unknown
		//IL_1d3b: Expected F4, but got Obj
		//IL_1d36: Expected native int or pointer, but got VT
		//IL_1d50: Expected F4, but got I
		//IL_1d4b: Expected native int or pointer, but got VT
		//IL_1d5e: Expected I4, but got VT
		//IL_087b: Expected Obj, but got I4
		//IL_0a08: Expected VT, but got I4
		//IL_0a2b: Expected I, but got Obj
		//IL_0a41: Expected Obj, but got I
		//IL_0ade: Expected I, but got Obj
		//IL_0af4: Expected Obj, but got I
		//IL_1a33: Expected F4, but got Obj
		//IL_1a2e: Expected native int or pointer, but got VT
		//IL_1a45: Expected F4, but got I
		//IL_1a40: Expected native int or pointer, but got VT
		//IL_1a52: Expected F4, but got Obj
		//IL_1a4d: Expected native int or pointer, but got VT
		//IL_1a67: Expected F4, but got I
		//IL_1a62: Expected native int or pointer, but got VT
		//IL_1a85: Expected F4, but got Obj
		//IL_1a80: Expected native int or pointer, but got VT
		//IL_1a97: Expected F4, but got I
		//IL_1a92: Expected native int or pointer, but got VT
		//IL_1b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b35: Expected Obj, but got Unknown
		//IL_0a6c: Expected I, but got Obj
		//IL_0b1f: Expected I, but got Obj
		//IL_08c8: Expected VT, but got Obj
		//IL_08eb: Expected I, but got Obj
		//IL_0901: Expected Obj, but got I
		//IL_0b6c: Expected I, but got Obj
		//IL_0b82: Expected Obj, but got I
		//IL_18fa: Expected F4, but got Obj
		//IL_18f5: Expected native int or pointer, but got VT
		//IL_190c: Expected F4, but got I
		//IL_1907: Expected native int or pointer, but got VT
		//IL_1919: Expected F4, but got Obj
		//IL_1914: Expected native int or pointer, but got VT
		//IL_192e: Expected F4, but got I
		//IL_1929: Expected native int or pointer, but got VT
		//IL_194c: Expected F4, but got Obj
		//IL_1947: Expected native int or pointer, but got VT
		//IL_195e: Expected F4, but got I
		//IL_1959: Expected native int or pointer, but got VT
		//IL_19f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fc: Expected Obj, but got Unknown
		//IL_092c: Expected I, but got Obj
		//IL_0bad: Expected I, but got Obj
		//IL_0c51: Expected Obj, but got I4
		//IL_0c5d: Expected Obj, but got I4
		//IL_0c70: Expected I, but got Obj
		//IL_0c86: Expected Obj, but got I
		//IL_0c33: Expected Obj, but got I4
		//IL_1b9c: Expected Obj, but got I4
		//IL_0cb1: Expected I, but got Obj
		//IL_0cfe: Expected I, but got Obj
		//IL_0d14: Expected Obj, but got I
		//IL_1bcf: Expected Obj, but got VT
		//IL_1bdd: Expected I, but got Obj
		//IL_1bf3: Expected Obj, but got I
		//IL_1c25: Expected F4, but got Obj
		//IL_1c20: Expected native int or pointer, but got VT
		//IL_1c5e: Expected VT, but got Obj
		//IL_0d3f: Expected I, but got Obj
		//IL_0dba: Expected I, but got Obj
		//IL_0dd0: Expected Obj, but got I
		//IL_0d72: Expected I, but got Obj
		//IL_1c70: Expected F4, but got Obj
		//IL_1c6b: Expected native int or pointer, but got VT
		//IL_1c82: Expected F4, but got I
		//IL_1c7d: Expected native int or pointer, but got VT
		//IL_1c8f: Expected F4, but got Obj
		//IL_1c8a: Expected native int or pointer, but got VT
		//IL_1ca4: Expected F4, but got I
		//IL_1c9f: Expected native int or pointer, but got VT
		//IL_1cb5: Expected Ref, but got VT
		//IL_1cc2: Expected Obj, but got F4
		//IL_0e54: Expected F4, but got Obj
		//IL_0e4f: Expected native int or pointer, but got VT
		//IL_0e69: Expected F4, but got I
		//IL_0e64: Expected native int or pointer, but got VT
		//IL_0dfb: Expected I, but got Obj
		//IL_0ecd: Expected I, but got Obj
		//IL_0ee3: Expected Obj, but got I
		//IL_0e88: Expected F4, but got Obj
		//IL_0e83: Expected native int or pointer, but got VT
		//IL_0e9d: Expected F4, but got I
		//IL_0e98: Expected native int or pointer, but got VT
		//IL_0f0e: Expected I, but got Obj
		//IL_11c7: Expected Obj, but got F4
		//IL_11cf: Invalid comparison between F4 and Obj
		//IL_1351: Expected Obj, but got I4
		//IL_1102: Expected I, but got Obj
		//IL_1118: Expected Obj, but got I
		//IL_13bc: Expected I, but got Obj
		//IL_13d2: Expected Obj, but got I
		//IL_121d: Expected Obj, but got I
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected Obj, but got Unknown
		//IL_10e5: Expected Obj, but got I4
		//IL_0fec: Expected I, but got Obj
		//IL_1002: Expected Obj, but got I
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_139f: Expected Obj, but got I4
		//IL_1288: Expected I, but got Obj
		//IL_129e: Expected Obj, but got I
		//IL_119e: Expected Obj, but got I4
		//IL_11b7: Expected Obj, but got I4
		//IL_1143: Expected I, but got Obj
		//IL_0fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb6: Expected I4, but got Unknown
		//IL_0fc3: Expected Obj, but got I4
		//IL_1476: Expected Obj, but got I4
		//IL_13fd: Expected I, but got Obj
		//IL_124d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1252: Expected I4, but got Unknown
		//IL_125f: Expected Obj, but got I4
		//IL_117e: Expected Obj, but got I4
		//IL_108c: Expected Obj, but got I4
		//IL_102d: Expected I, but got Obj
		//IL_143d: Expected Obj, but got I4
		//IL_1328: Expected Obj, but got I4
		//IL_12c9: Expected I, but got Obj
		//IL_1060: Expected Obj, but got I4
		//IL_145b: Expected Obj, but got I4
		//IL_1311: Expected Obj, but got I4
		Transform transform = default;
		object obj = transform + 160;
		obj = 0;
		_ = 0;
		ref Vector2 reference = ref *(Vector2*)(transform + 148);
		reference = ref *(Vector2*)null;
		_ = 0;
		object obj2 = transform + 136;
		obj2 = 0;
		_ = 0;
		object obj3 = transform + 124;
		obj3 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v469 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(transform + 192);
		Vector3 vector2 = (Vector3)(transform + 176);
		object obj5 = transform + 172;
		object obj6 = transform + 112;
		Transform transform2 = (Transform)(transform + 96);
		object obj7 = transform + 84;
		Quaternion quaternion = (Quaternion)(transform + 72);
		object obj8 = transform + 60;
		object obj9 = transform + 48;
		object obj10 = transform + 36;
		object obj11 = transform + 24;
		object obj12 = transform + 16;
		if (mScrollView != null)
		{
			string go = tag;
			nint num3 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v385 (Il2CppClass<NGUITools>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num4 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v465 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj14 = this + 28;
			UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>((GameObject)(object)go);
			obj14 = uIScrollView;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v356 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S1_v450 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mScrollView != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11995");
				throw new ArrayTypeMismatchException();
			}
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S1_v362 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj16 = (nint)0 & (nint)0x200;
			if (obj16 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v411 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)mScrollView))
			{
				object obj17 = mScrollView + 200;
				obj17 = this;
			}
			UIScrollView uIScrollView2 = mScrollView;
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S1_v369 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S1_v405 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIScrollView2.horizontalScrollBar).FindKernel((string)null) != 0)
			{
				UIScrollView uIScrollView3 = mScrollView;
				UIProgressBar horizontalScrollBar = uIScrollView3.horizontalScrollBar;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				Delegate obj19 = default;
				obj19.method_ptr = method_ptr;
				obj19.method = (nint)__ldftn(UICenterOnChild.OnDragFinished);
				object obj20 = obj19 + 16;
				obj20 = this;
				object obj21 = uIScrollView3.horizontalScrollBar + 12;
				Delegate obj22 = ((Delegate)horizontalScrollBar.onDragFinished).CombineImpl(obj19);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj23 = default;
				obj21 = obj23;
			}
			UIScrollView uIScrollView4 = mScrollView;
			nint num11 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ S1_v376 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj24 = (nint)0 & (nint)0x200;
			if (obj24 != null)
			{
				nint num12 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S1_v391 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uIScrollView4.verticalScrollBar).FindKernel((string)null) != 0)
			{
				UIScrollView uIScrollView5 = mScrollView;
				UIProgressBar verticalScrollBar = uIScrollView5.verticalScrollBar;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr2 = 0;
				Delegate obj25 = default;
				obj25.method_ptr = method_ptr2;
				obj25.method = (nint)__ldftn(UICenterOnChild.OnDragFinished);
				object obj26 = obj25 + 16;
				obj26 = this;
				object obj27 = uIScrollView5.verticalScrollBar + 12;
				Delegate obj28 = ((Delegate)verticalScrollBar.onDragFinished).CombineImpl(obj25);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj29 = default;
				obj27 = obj29;
			}
		}
		UIScrollView uIScrollView6 = mScrollView;
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj30 = (nint)0 & (nint)0x200;
		if (obj30 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S1_v346 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uIScrollView6.mPanel != null)
		{
			return;
		}
		GameObject gameObject = base.gameObject;
		if (((Transform)(object)gameObject).GetSiblingIndex() == 0)
		{
			return;
		}
		UIScrollView uIScrollView7 = mScrollView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj32 = default;
		object obj31 = obj32 + 40;
		transform = (Transform)obj31;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S1_v41+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj33 = obj32 + 16;
		obj6 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S1_v46+8]");
		_ = 0;
		nint num15 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ S0_v70 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num16 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S0_v378 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector2)->x = (float)transform;
		((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		((Vector3*)(nint)vector)->x = (float)obj6;
		Vector3 vector3 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		Vector3 vector4 = vector2 - vector;
		((Vector3*)(nint)vector)->x = (float)transform2;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 vector5 = vector / 0.5f;
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+8]");
		_ = 0;
		object obj35 = mScrollView + 140;
		((Quaternion*)(nint)quaternion)->x = (float)obj35;
		Quaternion quaternion2 = quaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S1_v71+8]");
		((Quaternion*)(nint)quaternion2)->z = 0f;
		UIScrollView uIScrollView8 = mScrollView;
		((Vector3*)(nint)vector)->x = quaternion.x;
		((Vector3*)(nint)vector)->z = quaternion.z;
		Vector3 vector6 = vector / uIScrollView8.momentumAmount;
		reference = ref *(Vector2*)obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v42+8]");
		_ = 0;
		Vector2 vector7 = NGUIMath.SpringDampen(ref reference, 9f, 2f);
		((Vector3*)(nint)vector)->x = (float)obj9;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v44+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		Vector3 vector9 = vector / 0.01f;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj10;
		Vector3 vector10 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v46+8]");
		((Vector3*)(nint)vector10)->z = 0f;
		Quaternion quaternion3 = Quaternion.FromToRotation(vector2, vector);
		obj2 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v48+8]");
		_ = 0;
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		nint num17 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v590 @ S0_v108 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj36 = (nint)0 & (nint)0x200;
		if (obj36 != null)
		{
			nint num18 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S0_v374 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num21;
		object obj38;
		Transform trans;
		bool flag2;
		if (((ComputeShader)componentInChildren).FindKernel(null) != 0)
		{
			bool isEnabled = ((UIImageButton)componentInChildren).isEnabled;
			int num19 = 0;
			float num20 = float.MaxValue;
			num21 = 0;
			object obj37 = 0;
			obj38 = 0;
			trans = null;
			while (true)
			{
				int num22 = num19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ S0_v324 (System.Boolean)+C]");
				bool flag = (nint)num22 >= (nint)0;
				flag2 = isEnabled;
				if (flag)
				{
					break;
				}
				Transform transform4 = ((List<Transform>)isEnabled).get_Item(num19);
				string text = transform4.tag;
				string text2 = ((GameObject)(object)text).tag;
				if (text2 != null)
				{
					transform.position = (Vector3)transform4;
					obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
					_ = 0;
					nint num23 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ S0_v346 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj39 = (nint)0 & (nint)0x200;
					if (obj39 != null)
					{
						nint num24 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ S0_v370 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)transform;
					((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					((Vector3*)(nint)vector)->x = (float)obj6;
					Vector3 vector11 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34+8]");
					((Vector3*)(nint)vector11)->z = 0f;
					quaternion3 = Quaternion.FromToRotation(vector2, vector);
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					float num25 = vector.x * vector.x;
					float num26 = vector.y * vector.y;
					float num27 = num25 + num26;
					float num28 = vector.z * vector.z;
					float num29 = num27 + num28;
					if (num29 < num20)
					{
						num20 = num29;
						num21 = num19;
						obj38 = obj37;
						trans = transform4;
					}
					object obj40 = obj37 + 1;
					obj37 = obj40;
				}
				int num30 = num19 + 1;
				num19 = num30;
			}
		}
		else
		{
			int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
			Sprite sprite = null;
			float num31 = float.MaxValue;
			Sprite sprite2 = null;
			object obj41 = 0;
			obj38 = 0;
			bool flag3 = false;
			while ((nint)sprite < siblingIndex)
			{
				bool flag4 = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite);
				string text3 = ((Component)flag4).tag;
				string text4 = ((GameObject)(object)text3).tag;
				if (text4 != null)
				{
					transform.position = (Vector3)flag4;
					obj6 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v15+8]");
					_ = 0;
					nint num32 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ S0_v294 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj42 = (nint)0 & (nint)0x200;
					if (obj42 != null)
					{
						nint num33 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ S0_v318 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					((Vector3*)(nint)vector2)->x = (float)transform;
					((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
					((Vector3*)(nint)vector)->x = (float)obj6;
					Vector3 vector12 = vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34+8]");
					((Vector3*)(nint)vector12)->z = 0f;
					quaternion3 = Quaternion.FromToRotation(vector2, vector);
					((Vector3*)(nint)vector)->x = (float)transform2;
					((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
					float num34 = vector.x * vector.x;
					float num35 = vector.y * vector.y;
					float num36 = num34 + num35;
					float num37 = vector.z * vector.z;
					float num38 = num36 + num37;
					if (num38 < num31)
					{
						num31 = num38;
						sprite2 = sprite;
						obj38 = obj41;
						flag3 = flag4;
					}
					object obj43 = obj41 + 1;
					obj41 = obj43;
				}
				Sprite sprite3 = (Sprite)(sprite + 1);
				sprite = sprite3;
			}
			flag2 = false;
			num21 = (int)sprite2;
			trans = (Transform)flag3;
		}
		if (nextPageThreshold > 0f)
		{
			nint num39 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ S0_v124 (Il2CppClass<UICamera>)+BA]");
			object obj44 = (nint)0 & (nint)0x200;
			if (obj44 != null)
			{
				nint num40 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v266 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (UICamera.currentTouch != null)
			{
				nint num41 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v862 @ S1_v117 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					nint num42 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v888 @ S1_v266 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)mCenteredObject).FindKernel((string)null) != 0)
				{
					int layer = mCenteredObject.layer;
					bool flag5 = flag2;
					UnityEngine.Object obj46;
					if (flag5)
					{
						Transform transform5 = ((List<Transform>)flag2).get_Item(num21);
						obj46 = transform5;
					}
					else
					{
						bool flag6 = ((SpriteAtlas)(object)gameObject).CanBindTo((Sprite)num21);
						obj46 = (UnityEngine.Object)flag6;
					}
					nint num43 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ S2_v27 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj47 = (nint)0 & (nint)0x200;
					if (obj47 != null)
					{
						nint num44 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ S2_v79 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if ((UnityEngine.Object)layer != obj46)
					{
						nint num45 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ S0_v139 (Il2CppClass<UICamera>)+BA]");
						object obj48 = (nint)0 & (nint)0x200;
						if (obj48 != null)
						{
							nint num46 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S0_v261 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						UICamera.MouseOrTouch currentTouch = UICamera.currentTouch;
						transform = (Transform)currentTouch.totalDelta;
						nint num47 = (nint)typeof(Vector2);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ S0_v145 (Il2CppClass<UnityEngine.Vector2>)+BA]");
						object obj49 = (nint)0 & (nint)0x200;
						if (obj49 != null)
						{
							nint num48 = (nint)typeof(Vector2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ S0_v258 (Il2CppClass<UnityEngine.Vector2>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj12 = transform;
						((Vector3*)(nint)vector)->x = (float)obj12;
						Vector3 vector13 = (Vector4)vector;
						obj3 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v34+8]");
						_ = 0;
						GameObject gameObject2 = base.gameObject;
						transform2.rotation = (Quaternion)gameObject2;
						obj7 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
						_ = 0;
						nint num49 = (nint)typeof(Quaternion);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ S0_v158 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
						object obj50 = (nint)0 & (nint)0x200;
						if (obj50 != null)
						{
							nint num50 = (nint)typeof(Quaternion);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1145 @ S0_v255 (Il2CppClass<UnityEngine.Quaternion>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((Vector3*)(nint)vector2)->x = (float)transform2;
						((Vector3*)(nint)vector2)->z = (nint)((UnityEngine.Object)transform2).m_CachedPtr;
						((Vector3*)(nint)vector)->x = (float)obj7;
						Vector3 vector14 = vector;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v38+8]");
						((Vector3*)(nint)vector14)->z = 0f;
						((Quaternion*)quaternion)->SetLookRotation(vector2, vector);
						obj3 = quaternion.x;
						_ = quaternion.z;
						UIScrollView uIScrollView9 = mScrollView;
						float num51 = default;
						if (uIScrollView9.movement != UIScrollView.Movement.Horizontal)
						{
							if (uIScrollView9.movement == UIScrollView.Movement.Vertical)
							{
								((Vector3*)(nint)vector)->x = (float)obj3;
								Vector3 vector15 = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
								((Vector3*)(nint)vector15)->z = 0f;
								num51 = 0f - vector.y;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11468");
							}
						}
						else
						{
							((Vector3*)(nint)vector)->x = (float)obj3;
							Vector3 vector16 = vector;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+8]");
							((Vector3*)(nint)vector16)->z = 0f;
							num51 = vector.x;
						}
						nint num52 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1197 @ S0_v174 (Il2CppClass<UnityEngine.Mathf>)+BA]");
						object obj51 = (nint)0 & (nint)0x200;
						if (obj51 != null)
						{
							nint num53 = (nint)typeof(Mathf);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1202 @ S0_v241 (Il2CppClass<UnityEngine.Mathf>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						float num54 = Math.Abs(num51);
						if (num54 > nextPageThreshold)
						{
							if (num51 > nextPageThreshold)
							{
								bool flag7 = (nint)obj38 < 1;
								Transform transform7;
								if (flag5)
								{
									if (!flag7)
									{
										int index = obj38 - 1;
										Transform transform6 = ((List<Transform>)flag2).get_Item(index);
										trans = transform6;
										goto IL_1d2e;
									}
									UIWrapContent component = GetComponent<UIWrapContent>();
									nint num55 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1258 @ S1_v236 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj52 = (nint)0 & (nint)0x200;
									if (obj52 != null)
									{
										nint num56 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1282 @ S1_v248 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									if (component != null)
									{
										transform7 = ((List<Transform>)flag2).get_Item(0);
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ L6_v3 (System.Boolean)+C]");
										int index2 = (int)(-1);
										transform7 = ((List<Transform>)flag2).get_Item(index2);
									}
								}
								else
								{
									if (!flag7)
									{
										Sprite sprite4 = (Sprite)(obj38 - 1);
										bool flag8 = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite4);
										trans = (Transform)flag8;
										goto IL_1d2e;
									}
									UIWrapContent component2 = GetComponent<UIWrapContent>();
									nint num57 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1265 @ S1_v219 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj53 = (nint)0 & (nint)0x200;
									if (obj53 != null)
									{
										nint num58 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1289 @ S1_v228 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									if (component2 != null)
									{
										bool flag9 = ((SpriteAtlas)(object)gameObject).CanBindTo((Sprite)null);
										transform7 = (Transform)flag9;
									}
									else
									{
										int siblingIndex2 = ((Transform)(object)gameObject).GetSiblingIndex();
										Sprite sprite5 = (Sprite)(siblingIndex2 - 1);
										bool flag10 = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite5);
										transform7 = (Transform)flag10;
									}
								}
								trans = transform7;
							}
							else
							{
								object obj54 = 0f - nextPageThreshold;
								if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num51) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj54))
								{
									Transform transform9;
									if (flag5)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ L6_v3 (System.Boolean)+C]");
										object obj55 = -1;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj55))
										{
											int index3 = obj38 + 1;
											Transform transform8 = ((List<Transform>)flag2).get_Item(index3);
											trans = transform8;
											goto IL_1d2e;
										}
										UIWrapContent component3 = GetComponent<UIWrapContent>();
										nint num59 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1297 @ S1_v197 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj56 = (nint)0 & (nint)0x200;
										if (obj56 != null)
										{
											nint num60 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1312 @ S1_v209 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										if (component3 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ L6_v3 (System.Boolean)+C]");
											int index4 = (int)(-1);
											transform9 = ((List<Transform>)flag2).get_Item(index4);
										}
										else
										{
											transform9 = ((List<Transform>)flag2).get_Item(0);
										}
									}
									else
									{
										int siblingIndex3 = ((Transform)(object)gameObject).GetSiblingIndex();
										object obj57 = siblingIndex3 - 1;
										if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj38) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj57))
										{
											Sprite sprite6 = (Sprite)(obj38 + 1);
											bool flag11 = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite6);
											trans = (Transform)flag11;
											goto IL_1d2e;
										}
										UIWrapContent component4 = GetComponent<UIWrapContent>();
										nint num61 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ S1_v177 (Il2CppClass<UnityEngine.Object>)+BA]");
										object obj58 = (nint)0 & (nint)0x200;
										if (obj58 != null)
										{
											nint num62 = (nint)typeof(UnityEngine.Object);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1350 @ S1_v186 (Il2CppClass<UnityEngine.Object>)+74]");
											if ((nint)0 == 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
											}
										}
										if (component4 != null)
										{
											int siblingIndex4 = ((Transform)(object)gameObject).GetSiblingIndex();
											Sprite sprite7 = (Sprite)(siblingIndex4 - 1);
											bool flag12 = ((SpriteAtlas)(object)gameObject).CanBindTo(sprite7);
											transform9 = (Transform)flag12;
										}
										else
										{
											bool flag13 = ((SpriteAtlas)(object)gameObject).CanBindTo((Sprite)null);
											transform9 = (Transform)flag13;
										}
									}
									trans = transform9;
								}
							}
						}
					}
				}
			}
		}
		goto IL_1d2e;
		IL_1d2e:
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector17 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector17)->z = 0f;
		((UIGrid)this).AddChild(trans, (byte)(int)vector != 0);
	}
}
