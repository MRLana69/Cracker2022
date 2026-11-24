using System;
using Cpp2ILInjected;
using UnityEngine;

public class UITextShadowHelper : MonoBehaviour
{
	public UILabel shadowLabel;

	public Color frontColor;

	public Color shadowColor;

	public bool updateDynamically;

	public bool fakeHD;

	private UILabel _frontLabel;

	public Vector3 shadowOffset;

	private Transform _frontTransform;

	private Transform _shadowTransform;

	private void Awake()
	{
		CancelInvoke();
	}

	private void Start()
	{
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected Obj, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_001b: Expected I, but got Obj
		//IL_0031: Expected Obj, but got I
		//IL_005c: Expected I, but got Obj
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_0118: Expected I4, but got Obj
		//IL_0129: Expected I4, but got Obj
		object obj = this + 52;
		string text = tag;
		UILabel component = ((GameObject)(object)text).GetComponent<UILabel>();
		obj = component;
		object obj2 = this + 68;
		GameObject gameObject = base.gameObject;
		obj2 = gameObject;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)shadowLabel).FindKernel((string)null) != 0)
		{
			object obj4 = this + 72;
			Camera anchorCamera = shadowLabel.anchorCamera;
			obj4 = anchorCamera;
			UILabel frontLabel = _frontLabel;
			UIWidget uIWidget = (UIWidget)(((UIWidget)frontLabel).mDepth - 1);
			Vector2 localSize = uIWidget.localSize;
			string obj5 = shadowLabel.tag;
			UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string text2 = string.ConcatArray((string[])(object)values, (int)"Shadow");
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj5, (byte)(int)text2 != 0);
		}
	}

	public void UpdateNow()
	{
		Update();
	}

	private void UpdateText()
	{
		Update();
	}

	private unsafe void Update()
	{
		//IL_06ba: Expected I, but got Obj
		//IL_06d0: Expected Obj, but got I
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected I, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected Obj, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_01c4: Expected I, but got Obj
		//IL_0277: Expected I4, but got Obj
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected Obj, but got Unknown
		//IL_0132: Expected I, but got Obj
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected Obj, but got Unknown
		//IL_032f: Expected I, but got Obj
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected Obj, but got Unknown
		//IL_0230: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I
		//IL_03e0: Expected Obj, but got I4
		//IL_02b6: Expected I4, but got Obj
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected Obj, but got Unknown
		//IL_039b: Expected I, but got Obj
		//IL_0477: Expected I4, but got Obj
		//IL_042c: Expected Obj, but got I4
		//IL_048d: Expected I4, but got Obj
		//IL_04fe: Expected I, but got Obj
		//IL_0514: Expected Obj, but got I
		//IL_0735: Expected VT, but got Obj
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected Obj, but got Unknown
		//IL_0763: Expected I, but got Obj
		//IL_0779: Expected Obj, but got I
		//IL_053f: Expected I, but got Obj
		//IL_04da: Expected I4, but got Obj
		//IL_04eb: Expected I4, but got Obj
		//IL_082f: Expected I, but got Obj
		//IL_0849: Expected VT, but got I
		//IL_0849: Expected VT, but got Obj
		//IL_085a: Expected I, but got Obj
		//IL_0870: Expected Obj, but got I
		//IL_066d: Expected I, but got Obj
		//IL_05b1: Expected VT, but got Obj
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_05df: Expected I, but got Obj
		//IL_05f5: Expected Obj, but got I
		//IL_07bd: Expected I, but got Obj
		//IL_07d7: Expected VT, but got I
		//IL_07d7: Expected VT, but got Obj
		//IL_07e8: Expected I, but got Obj
		//IL_07fe: Expected Obj, but got I
		//IL_0620: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		nint num3 = (nint)(obj2 - -64);
		Gradient gradient = (Gradient)(obj2 + 48);
		Transform transform = (Transform)(obj2 + 32);
		object obj3 = obj2 + 16;
		if (shadowLabel != null)
		{
			return;
		}
		object obj4 = _frontLabel + 80;
		transform = (Transform)obj4;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v12+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		object obj5 = this + 16;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v17+8]");
		_ = 0;
		gradient = (Gradient)(object)transform;
		gradient.m_Ptr = ((UnityEngine.Object)transform).m_CachedPtr;
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		if (gradient.Internal_Equals((IntPtr)num3))
		{
			object obj6 = this + 16;
			gradient = (Gradient)obj6;
			Gradient gradient2 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S2_v96+8]");
			gradient2.m_Ptr = (IntPtr)0;
			((IntPtr*)num3)->m_value = (void*)(nint)gradient;
			_ = gradient.m_Ptr;
			_frontLabel.rawPivot = (UIWidget.Pivot)num3;
		}
		object obj7 = _frontLabel + 328;
		transform = (Transform)obj7;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S1_v33+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		object obj8 = this + 32;
		obj3 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S1_v38+8]");
		_ = 0;
		gradient = (Gradient)(object)transform;
		gradient.m_Ptr = ((UnityEngine.Object)transform).m_CachedPtr;
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		if (gradient.Internal_Equals((IntPtr)num3))
		{
			object obj9 = this + 32;
			gradient = (Gradient)obj9;
			Gradient gradient3 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S2_v86+8]");
			gradient3.m_Ptr = (IntPtr)0;
			((IntPtr*)num3)->m_value = (void*)(nint)gradient;
			_ = gradient.m_Ptr;
			Vector2 effectDistance = ((UILabel)num3).effectDistance;
		}
		UILabel uILabel = shadowLabel;
		UILabel frontLabel = _frontLabel;
		if (uILabel.mText.get_Chars((int)frontLabel.mText) != '\0')
		{
			UILabel frontLabel2 = _frontLabel;
			shadowLabel.fontSize = (int)frontLabel2.mText;
		}
		object obj10 = shadowLabel + 80;
		transform = (Transform)obj10;
		Transform transform4 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S1_v58+8]");
		((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
		object obj11 = this + 32;
		obj3 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S1_v63+8]");
		_ = 0;
		gradient = (Gradient)(object)transform;
		gradient.m_Ptr = ((UnityEngine.Object)transform).m_CachedPtr;
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		if (gradient.Internal_Equals((IntPtr)num3))
		{
			object obj12 = this + 32;
			gradient = (Gradient)obj12;
			Gradient gradient4 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S2_v75+8]");
			gradient4.m_Ptr = (IntPtr)0;
			((IntPtr*)num3)->m_value = (void*)(nint)gradient;
			_ = gradient.m_Ptr;
			shadowLabel.rawPivot = (UIWidget.Pivot)num3;
		}
		UILabel uILabel2 = shadowLabel;
		UILabel frontLabel3 = _frontLabel;
		object obj13 = ((UIWidget)frontLabel3).mDepth - 1;
		if (((UIWidget)uILabel2).mDepth != (nint)obj13)
		{
			UILabel frontLabel4 = _frontLabel;
			UIWidget uIWidget = (UIWidget)(((UIWidget)frontLabel4).mDepth - 1);
			Vector2 localSize = uIWidget.localSize;
		}
		string original = shadowLabel.tag;
		UnityEngine.Object obj14 = UnityEngine.Object.Instantiate((UnityEngine.Object)(object)original);
		UnityEngine.Object values = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
		string text = string.ConcatArray((string[])(object)values, (int)"Shadow");
		if (((string)(object)obj14).get_Chars((int)text) != '\0')
		{
			string obj15 = shadowLabel.tag;
			UnityEngine.Object values2 = UnityEngine.Object.Instantiate((UnityEngine.Object)this);
			string text2 = string.ConcatArray((string[])(object)values2, (int)"Shadow");
			UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj15, (byte)(int)text2 != 0);
		}
		nint num4 = (nint)typeof(DeviceInfo);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S0_v78 (Il2CppClass<DeviceInfo>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num5 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S0_v94 (Il2CppClass<DeviceInfo>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v83 (System.Int32)+18]");
		if ((nint)0 == 0 && ~(fakeHD ? 1u : 0u) != 0)
		{
			transform.localPosition = (Vector3)_frontTransform;
			object obj17 = this + 56;
			obj3 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ S2_v49+8]");
			_ = 0;
			nint num6 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ S1_v113 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S1_v125 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			gradient = (Gradient)(object)transform;
			gradient.m_Ptr = ((UnityEngine.Object)transform).m_CachedPtr;
			((IntPtr*)num3)->m_value = (void*)(nint)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
			_ = 0;
			Vector3 vector = (Vector3)gradient - (Vector3)num3;
			((IntPtr*)num3)->m_value = (void*)(nint)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Vector3 eulerAngles = ((Transform)num3).eulerAngles;
			return;
		}
		transform.localPosition = (Vector3)_frontTransform;
		object obj19 = this + 56;
		obj3 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ S2_v27+8]");
		_ = 0;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ S1_v93 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj20 = (nint)0 & (nint)0x200;
		if (obj20 != null)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ S1_v105 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		gradient = (Gradient)(object)transform;
		gradient.m_Ptr = ((UnityEngine.Object)transform).m_CachedPtr;
		((IntPtr*)num3)->m_value = (void*)(nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v22+8]");
		_ = 0;
		Vector3 vector2 = (Vector3)gradient - (Vector3)num3;
		((IntPtr*)num3)->m_value = (void*)(nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Vector3 eulerAngles2 = ((Transform)num3).eulerAngles;
	}

	private void OnDisable()
	{
		//IL_019d: Expected I, but got Obj
		//IL_01b3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0096: Expected I, but got Obj
		//IL_00ac: Expected Obj, but got I
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected Obj, but got Unknown
		//IL_0083: Expected Obj, but got I4
		//IL_00d7: Expected I, but got Obj
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_frontLabel != shadowLabel)
		{
			string args = tag;
			SDebug.LogFormat("front and shadow label are the same!", (object[])(object)args);
			object obj2 = this + 12;
			obj2 = 0;
		}
		if (~(updateDynamically ? 1u : 0u) != 0)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_shadowTransform != null)
		{
			object obj4 = this + 52;
			string text = tag;
			UILabel component = ((GameObject)(object)text).GetComponent<UILabel>();
			obj4 = component;
			object obj5 = this + 68;
			GameObject gameObject = base.gameObject;
			obj5 = gameObject;
			object obj6 = this + 72;
			Camera anchorCamera = shadowLabel.anchorCamera;
			obj6 = anchorCamera;
		}
		Update();
	}

	private void OnEnable()
	{
		//IL_007f: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
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
		if (((ComputeShader)(object)shadowLabel).FindKernel((string)null) != 0)
		{
			string text = shadowLabel.tag;
			((GameObject)(object)text).tag = null;
		}
	}

	public UITextShadowHelper()
	{
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I4
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
		if (((ComputeShader)(object)shadowLabel).FindKernel((string)null) != 0)
		{
			string text = shadowLabel.tag;
			((GameObject)(object)text).tag = (string)1;
		}
	}
}
