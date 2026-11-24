using System;
using Cpp2ILInjected;
using UnityEngine;

public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft,
		Left,
		TopLeft,
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		Center
	}

	public Camera uiCamera;

	public GameObject container;

	public Side side;

	public bool runOnlyOnce;

	public Vector2 relativeOffset;

	public Vector2 pixelOffset;

	private UIWidget widgetContainer;

	private Transform mTrans;

	private Animation mAnim;

	private Rect mRect;

	private UIRoot mRoot;

	private bool mStarted;

	private void OnEnable()
	{
		//IL_000b: Expected Obj, but got I4
		container = (GameObject)20;
		side = Side.Left;
		_ = 1;
		CancelInvoke();
	}

	private unsafe void OnDisable()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0135: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = this + 48;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 52;
		Animation component = GetComponent<Animation>();
		obj2 = component;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v10 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v22 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj4 = default;
		obj4.method_ptr = method_ptr;
		obj4.method = (nint)__ldftn(UIAnchor.ScreenSizeChanged);
		object obj5 = obj4 + 16;
		obj5 = this;
		Delegate obj6 = ((Delegate)UICamera.onScreenResize).CombineImpl(obj4);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v19 (Il2CppClass<UICamera>)+5C]");
		object obj7 = (nint)0 + (nint)36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj8 = default;
		obj7 = obj8;
	}

	private unsafe void ScreenSizeChanged()
	{
		//IL_0069: Expected I, but got Obj
		//IL_007f: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00fb: Expected I, but got Obj
		//IL_0111: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v18 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj2 = default;
		obj2.method_ptr = method_ptr;
		obj2.method = (nint)__ldftn(UIAnchor.ScreenSizeChanged);
		object obj3 = obj2 + 16;
		obj3 = this;
		Delegate obj4 = ((Delegate)UICamera.onScreenResize).RemoveImpl(obj2);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v15 (Il2CppClass<UICamera>)+5C]");
		object obj5 = (nint)0 + (nint)36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj6 = default;
		obj5 = obj6;
	}

	private void Start()
	{
		if (~(mStarted ? 1u : 0u) == 0 && ~(runOnlyOnce ? 1u : 0u) == 0)
		{
			this._002Ector();
		}
	}

	private void Update()
	{
		//IL_026d: Expected I, but got Obj
		//IL_0283: Expected Obj, but got I
		//IL_02b8: Expected I, but got Obj
		//IL_02ce: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0129: Expected I, but got Obj
		//IL_0176: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_01df: Expected I, but got Obj
		//IL_01f5: Expected Obj, but got I
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected Obj, but got Unknown
		//IL_03c8: Expected Obj, but got I4
		//IL_0220: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v49 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (container != null)
		{
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)widgetContainer).FindKernel((string)null) != 0)
			{
				object obj3 = this + 16;
				string text = widgetContainer.tag;
				obj3 = text;
				object obj4 = this + 44;
				obj4 = 0;
			}
		}
		string go = tag;
		nint num5 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v12 (Il2CppClass<NGUITools>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v38 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = this + 72;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)go);
		obj6 = uIRoot;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uiCamera != null)
		{
			string text2 = tag;
			bool activeSelf = ((GameObject)(object)text2).activeSelf;
			nint num9 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v28 (Il2CppClass<NGUITools>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num10 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v34 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj9 = this + 12;
			string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
			obj9 = typeName;
		}
		this._002Ector();
		mStarted = true;
	}

	public unsafe UIAnchor()
	{
		//IL_1324: Unknown result type (might be due to invalid IL or missing references)
		//IL_1329: Expected Obj, but got Unknown
		//IL_1332: Expected Obj, but got I4
		//IL_1341: Unknown result type (might be due to invalid IL or missing references)
		//IL_1346: Expected Obj, but got Unknown
		//IL_134f: Expected Obj, but got I4
		//IL_1364: Unknown result type (might be due to invalid IL or missing references)
		//IL_1369: Expected Obj, but got Unknown
		//IL_1372: Expected Obj, but got I4
		//IL_1381: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Expected Obj, but got Unknown
		//IL_138f: Expected Obj, but got I4
		//IL_13a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a9: Expected Obj, but got Unknown
		//IL_13b2: Expected Obj, but got I4
		//IL_13cc: Expected I, but got Obj
		//IL_13e2: Expected Obj, but got I
		//IL_1c86: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c8b: Expected Obj, but got Unknown
		//IL_1c94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c99: Expected Obj, but got Unknown
		//IL_1ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca7: Expected Obj, but got Unknown
		//IL_1cb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb5: Expected Obj, but got Unknown
		//IL_1cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc3: Expected Obj, but got Unknown
		//IL_1ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd1: Expected Obj, but got Unknown
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0184: Expected I, but got Obj
		//IL_01ef: Expected I, but got Obj
		//IL_0205: Expected Obj, but got I
		//IL_0230: Expected I, but got Obj
		//IL_0329: Expected I, but got Obj
		//IL_033f: Expected Obj, but got I
		//IL_027d: Expected I, but got Obj
		//IL_0293: Expected Obj, but got I
		//IL_0492: Expected I, but got Obj
		//IL_04a8: Expected Obj, but got I
		//IL_036a: Expected I, but got Obj
		//IL_02be: Expected I, but got Obj
		//IL_03c1: Expected Obj, but got I4
		//IL_0783: Expected I, but got Obj
		//IL_0799: Expected Obj, but got I
		//IL_04d3: Expected I, but got Obj
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_08e3: Expected Obj, but got I4
		//IL_07c4: Expected I, but got Obj
		//IL_06a8: Expected I, but got Obj
		//IL_06be: Expected Obj, but got I
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected Obj, but got Unknown
		//IL_08fa: Expected I, but got Obj
		//IL_0910: Expected Obj, but got I
		//IL_0811: Expected I, but got Obj
		//IL_0827: Expected Obj, but got I
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected Obj, but got Unknown
		//IL_05c4: Expected Obj, but got F4
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected Obj, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected Obj, but got Unknown
		//IL_067a: Unknown result type (might be due to invalid IL or missing references)
		//IL_067f: Expected Obj, but got Unknown
		//IL_0695: Expected Obj, but got I4
		//IL_14e1: Expected Obj, but got I4
		//IL_06e9: Expected I, but got Obj
		//IL_1517: Unknown result type (might be due to invalid IL or missing references)
		//IL_151c: Expected Obj, but got Unknown
		//IL_1522: Unknown result type (might be due to invalid IL or missing references)
		//IL_1527: Expected Obj, but got Unknown
		//IL_1544: Expected Obj, but got I
		//IL_1554: Unknown result type (might be due to invalid IL or missing references)
		//IL_1559: Expected Obj, but got Unknown
		//IL_156f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected Obj, but got Unknown
		//IL_157a: Unknown result type (might be due to invalid IL or missing references)
		//IL_157f: Expected Obj, but got Unknown
		//IL_158f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1594: Expected Obj, but got Unknown
		//IL_15b9: Expected Obj, but got F4
		//IL_093b: Expected I, but got Obj
		//IL_0852: Expected I, but got Obj
		//IL_1635: Expected Obj, but got I4
		//IL_164a: Unknown result type (might be due to invalid IL or missing references)
		//IL_164f: Expected Obj, but got Unknown
		//IL_165f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1664: Expected Obj, but got Unknown
		//IL_166c: Expected Obj, but got F4
		//IL_1695: Expected Obj, but got I4
		//IL_16aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_16af: Expected Obj, but got Unknown
		//IL_16cc: Expected Obj, but got I
		//IL_16e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e6: Expected Obj, but got Unknown
		//IL_16f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f6: Expected Obj, but got Unknown
		//IL_16fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1701: Expected Obj, but got Unknown
		//IL_1705: Unsupported input type for neg.
		//IL_1705: Unknown result type (might be due to invalid IL or missing references)
		//IL_170a: Expected Obj, but got Unknown
		//IL_1722: Unknown result type (might be due to invalid IL or missing references)
		//IL_1727: Expected Obj, but got Unknown
		//IL_172d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1732: Expected Obj, but got Unknown
		//IL_1743: Expected Obj, but got I
		//IL_1753: Unknown result type (might be due to invalid IL or missing references)
		//IL_1758: Expected Obj, but got Unknown
		//IL_1766: Expected Obj, but got I4
		//IL_1854: Unknown result type (might be due to invalid IL or missing references)
		//IL_1859: Expected Obj, but got Unknown
		//IL_185f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1864: Expected Obj, but got Unknown
		//IL_186a: Unknown result type (might be due to invalid IL or missing references)
		//IL_186f: Expected Obj, but got Unknown
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_187a: Expected Obj, but got Unknown
		//IL_188a: Unknown result type (might be due to invalid IL or missing references)
		//IL_188f: Expected Obj, but got Unknown
		//IL_18ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bf: Expected Obj, but got Unknown
		//IL_18c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ca: Expected Obj, but got Unknown
		//IL_18d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d5: Expected Obj, but got Unknown
		//IL_18f2: Expected Obj, but got I
		//IL_1902: Unknown result type (might be due to invalid IL or missing references)
		//IL_1907: Expected Obj, but got Unknown
		//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected Obj, but got Unknown
		//IL_0987: Expected Obj, but got I4
		//IL_0987: Expected VT, but got Obj
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected Obj, but got Unknown
		//IL_08c6: Expected Obj, but got I4
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected I4, but got Unknown
		//IL_0fce: Expected I, but got Obj
		//IL_0fe4: Expected Obj, but got I
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected Obj, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected Obj, but got Unknown
		//IL_1b40: Expected I, but got Obj
		//IL_1b56: Expected Obj, but got I
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Expected Obj, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected Obj, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected Obj, but got Unknown
		//IL_100f: Expected I, but got Obj
		//IL_1948: Expected VT, but got Obj
		//IL_1971: Expected VT, but got Obj
		//IL_19ab: Expected VT, but got Obj
		//IL_10c3: Expected I, but got Obj
		//IL_10d9: Expected Obj, but got I
		//IL_105c: Expected I, but got Obj
		//IL_0cb3: Expected I, but got Obj
		//IL_0cc9: Expected Obj, but got I
		//IL_1d04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d09: Expected Obj, but got Unknown
		//IL_1d26: Expected Obj, but got I
		//IL_1217: Expected VT, but got Obj
		//IL_123a: Expected I, but got Obj
		//IL_1250: Expected Obj, but got I
		//IL_1bda: Expected VT, but got Obj
		//IL_1104: Expected I, but got Obj
		//IL_11e8: Expected VT, but got Obj
		//IL_1c60: Expected VT, but got Obj
		//IL_1c60: Expected VT, but got Obj
		//IL_0d91: Expected I, but got Obj
		//IL_0da7: Expected Obj, but got I
		//IL_0cf4: Expected I, but got Obj
		//IL_1141: Expected Obj, but got I4
		//IL_127b: Expected I, but got Obj
		//IL_1158: Expected I, but got Obj
		//IL_116e: Expected Obj, but got I
		//IL_0dd2: Expected I, but got Obj
		//IL_1812: Expected Obj, but got F4
		//IL_1199: Expected I, but got Obj
		//IL_0e85: Expected I, but got Obj
		//IL_0e9b: Expected Obj, but got I
		//IL_1a2b: Expected F4, but got Obj
		//IL_1a5d: Expected F4, but got I
		//IL_1a75: Expected VT, but got Obj
		//IL_0f0e: Expected I, but got Obj
		//IL_0f24: Expected Obj, but got I
		//IL_0ec6: Expected I, but got Obj
		//IL_1abe: Expected VT, but got Obj
		//IL_1abe: Expected VT, but got Obj
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected Obj, but got Unknown
		//IL_0f4f: Expected I, but got Obj
		//IL_0c45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 168;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 144;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 128;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 104;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj2 + 80;
		obj6 = 0;
		_ = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v499 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = (GameObject)(obj2 + 200);
		Camera camera = (Camera)(obj2 + 184);
		Transform transform = (Transform)(obj2 - -64);
		object obj8 = obj2 + 48;
		object obj9 = obj2 + 32;
		Transform transform2 = (Transform)(obj2 + 16);
		if (((ComputeShader)(object)mAnim).FindKernel((string)null) != 0 && mAnim.isActiveAndEnabled && mAnim.Play())
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v32 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v452 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mTrans != null)
		{
			return;
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ S1_v448 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget uIWidget = ((!(container != null)) ? container.GetComponent<UIWidget>() : null);
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v62 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v483 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel;
		if (container != null)
		{
			nint num9 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v471 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj13 = (nint)0 & (nint)0x200;
			if (obj13 != null)
			{
				nint num10 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v479 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (uIWidget != null)
			{
				uIPanel = null;
				goto IL_031b;
			}
		}
		uIPanel = container.GetComponent<UIPanel>();
		goto IL_031b;
		IL_14d8:
		object obj14 = 0;
		goto IL_1511;
		IL_1adb:
		if (~(runOnlyOnce ? 1u : 0u) == 0 && Application.platform != RuntimePlatform.OSXEditor)
		{
			tag = null;
		}
		return;
		IL_1bcb:
		((Transform)(object)gameObject).position = (Vector3)mTrans;
		_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
		goto IL_1208;
		IL_1208:
		transform.position = (Vector3)mTrans;
		obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ S0_v110 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj15 = (nint)0 & (nint)0x200;
		if (obj15 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ S0_v122 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		camera = (Camera)(object)transform;
		((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		gameObject = (GameObject)obj8;
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v40+8]");
		((UnityEngine.Object)gameObject2).m_CachedPtr = (IntPtr)0;
		if ((Quaternion)camera == (Quaternion)gameObject)
		{
			gameObject = (GameObject)obj;
			GameObject gameObject3 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)gameObject3).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = ((Transform)(object)gameObject).localPosition;
		}
		goto IL_1adb;
		IL_031b:
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v462 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIWidget).FindKernel((string)null) != 0)
		{
			int layer = container.layer;
			Transform parentInternal = ((Transform)layer).parentInternal;
			UICamera.Notify(gameObject, (string)(object)uIWidget, parentInternal);
			obj3 = gameObject;
			_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v34 (UnityEngine.GameObject)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			object obj17 = this + 56;
			obj17 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			object obj18 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v38 (UnityEngine.Transform)+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			object obj19 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			object obj20 = this + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v42+4]");
			_ = 0;
			goto IL_14d8;
		}
		nint num15 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v322 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj21 = (nint)0 & (nint)0x200;
		if (obj21 != null)
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ S0_v442 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIPanel).FindKernel((string)null) != 0)
		{
			if (uIPanel.mClipping != UIDrawCall.Clipping.None)
			{
				Vector2 clipSoftness = uIPanel.clipSoftness;
				obj4 = gameObject;
				_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
				camera = (Camera)obj4;
				Camera camera2 = camera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				((UnityEngine.Object)camera2).m_CachedPtr = (IntPtr)0;
				transform = (Transform)obj4;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				object obj22 = this + 56;
				float num17 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr * 0.5f;
				float num18 = (float)camera - num17;
				obj22 = num18;
				obj8 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				_ = 0;
				obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				_ = 0;
				object obj23 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v42+C]");
				float num19 = 0f * 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v40+4]");
				float num20 = 0f - num19;
				transform2 = (Transform)obj4;
				Transform transform4 = transform2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
				object obj24 = this + 56;
				_ = ((UnityEngine.Object)transform2).m_CachedPtr;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				_ = 0;
				object obj25 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
				_ = 0;
				obj14 = 0;
			}
			else
			{
				nint num21 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S1_v333 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj26 = (nint)0 & (nint)0x200;
				if (obj26 != null)
				{
					nint num22 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S1_v373 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float num24;
				if (((ComputeShader)(object)mRoot).FindKernel((string)null) != 0)
				{
					Texture mainTexture = ((UISprite)(object)mRoot).mainTexture;
					int sleepTimeout = Screen.sleepTimeout;
					int num23 = mainTexture / sleepTimeout;
					num24 = (float)num23 * 0.5f;
				}
				else
				{
					num24 = 0.5f;
				}
				int height = Screen.height;
				object obj27 = -height;
				float num25 = (float)obj27 * num24;
				object obj28 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ S0_v389+8]");
				object obj29 = 0 + obj28;
				obj28 = num25;
				object obj30 = obj29 - obj28;
				int sleepTimeout2 = Screen.sleepTimeout;
				object obj31 = -sleepTimeout2;
				float num26 = (float)obj31 * num24;
				object obj32 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v398+C]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v398+4]");
				object obj33 = num27 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S0_v398+4]");
				object obj34 = obj33 - 0;
				object obj35 = this + 56;
				object obj36 = this + 56;
				object obj37 = 0 - obj36;
				object obj38 = obj37 - obj35;
				object obj39 = this + 56;
				object obj40 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ S1_v365+4]");
				object obj41 = -0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ S0_v406+4]");
				object obj42 = obj41 - 0;
				obj14 = 0;
			}
		}
		else
		{
			nint num28 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ S1_v265 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj43 = (nint)0 & (nint)0x200;
			if (obj43 != null)
			{
				nint num29 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ S1_v328 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)container).FindKernel((string)null) != 0)
			{
				int layer2 = container.layer;
				Transform parentInternal2 = ((Transform)layer2).parentInternal;
				nint num30 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ S0_v337 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj44 = (nint)0 & (nint)0x200;
				if (obj44 != null)
				{
					nint num31 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ S0_v364 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				int num32 = ((ComputeShader)(object)parentInternal2).FindKernel((string)null);
				int layer3 = container.layer;
				if (num32 != 0)
				{
					Vector2 vector = NGUIMath.ScreenToPixels((Vector2)parentInternal2, (Transform)layer3);
				}
				else
				{
					Vector2 pivotOffset = NGUIMath.GetPivotOffset((UIWidget.Pivot)layer3);
				}
				obj6 = gameObject;
				_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v34 (UnityEngine.GameObject)+10]");
				_ = 0;
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
				object obj45 = this + 56;
				obj45 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
				object obj46 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v36 (UnityEngine.Camera)+4]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
				object obj47 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
				object obj48 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v40+4]");
				_ = 0;
				goto IL_14d8;
			}
			nint num33 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ S1_v309 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj49 = (nint)0 & (nint)0x200;
			if (obj49 != null)
			{
				nint num34 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ S1_v325 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)uiCamera).FindKernel((string)null) == 0)
			{
				return;
			}
			camera.targetTexture = (RenderTexture)(object)uiCamera;
			gameObject = (GameObject)(object)camera;
			((UnityEngine.Object)gameObject).m_CachedPtr = ((UnityEngine.Object)camera).m_CachedPtr;
			object obj50 = this + 56;
			obj50 = gameObject;
			_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
			obj14 = 1;
		}
		goto IL_1511;
		IL_11be:
		gameObject = (GameObject)obj;
		GameObject gameObject4 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)gameObject4).m_CachedPtr = (IntPtr)0;
		Camera camera3;
		Vector3 vector2 = ((Transform)(object)camera3).InverseTransformPoint((Vector3)gameObject);
		obj = camera;
		_ = ((UnityEngine.Object)camera).m_CachedPtr;
		goto IL_1bcb;
		IL_1511:
		object obj51 = this + 56;
		object obj52 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S1_v52+C]");
		nint num35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ S1_v52+4]");
		object obj53 = num35 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ S0_v79+4]");
		object obj54 = 0 + obj53;
		float num36 = (float)obj54 * 0.5f;
		object obj55 = this + 56;
		object obj56 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ S2_v16+8]");
		object obj57 = 0 + obj56;
		object obj58 = obj55 + obj57;
		float num37 = (float)obj58 * 0.5f;
		obj = num37;
		_ = 0f;
		if (side != Side.Center)
		{
			if (side != Side.Right && side != Side.TopRight && side != Side.BottomRight)
			{
				if (side != Side.Top && side != Side.Center && side != Side.Bottom)
				{
					object obj59 = this + 56;
					obj = obj59;
				}
				else
				{
					obj = num37;
				}
			}
			else
			{
				object obj60 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S1_v248+8]");
				object obj61 = 0 + obj60;
				obj = obj61;
			}
			if (side != Side.Top && side != Side.TopRight && side != Side.TopLeft)
			{
				if (side != Side.Left && side != Side.Center && side != Side.Right)
				{
					object obj62 = this + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S1_v244+4]");
					_ = 0;
				}
			}
			else
			{
				object obj63 = this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S1_v233+C]");
				nint num38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ S1_v233+4]");
				object obj64 = num38 + 0;
			}
		}
		object obj65 = this + 56;
		object obj66 = this + 36;
		object obj67 = this + 28;
		object obj68 = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ S4_v4+8]");
		object obj69 = obj67 * 0;
		object obj70 = obj66 + obj69;
		object obj71 = obj + obj70;
		obj = obj71;
		object obj72 = obj + 4;
		object obj73 = this + 36;
		object obj74 = this + 28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ S3_v13+4]");
		nint num39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S0_v91+C]");
		object obj75 = num39 * 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S2_v26+4]");
		object obj76 = 0 + obj75;
		object obj77 = obj72 + obj76;
		obj72 = obj77;
		if (obj14 != null)
		{
			if (uiCamera.transparencySortMode != TransparencySortMode.Default)
			{
				gameObject = (GameObject)obj;
				GameObject gameObject5 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)gameObject5).m_CachedPtr = (IntPtr)0;
				nint num40 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ S0_v260 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj78 = (nint)0 & (nint)0x200;
				if (obj78 != null)
				{
					nint num41 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S0_v268 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
				object obj79 = default;
				obj = obj79;
				camera = (Camera)obj;
				Camera camera4 = camera;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)camera4).m_CachedPtr = (IntPtr)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
			}
			((Transform)(object)camera).position = (Vector3)mTrans;
			gameObject = (GameObject)(object)camera;
			((UnityEngine.Object)gameObject).m_CachedPtr = ((UnityEngine.Object)camera).m_CachedPtr;
			Vector3 vector3 = uiCamera.WorldToViewportPoint((Vector3)gameObject);
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			gameObject = (GameObject)obj;
			GameObject gameObject6 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)gameObject6).m_CachedPtr = (IntPtr)0;
			Vector3 vector4 = uiCamera.ScreenToViewportPoint((Vector3)gameObject);
			obj = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v40+8]");
			_ = 0;
			if (uiCamera.transparencySortMode != TransparencySortMode.Default)
			{
				Transform parentInternal3 = mTrans.parentInternal;
				nint num42 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ S1_v162 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj80 = (nint)0 & (nint)0x200;
				if (obj80 != null)
				{
					nint num43 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1149 @ S1_v210 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)parentInternal3).FindKernel((string)null) != 0)
				{
					Transform parentInternal4 = mTrans.parentInternal;
					gameObject = (GameObject)obj;
					GameObject gameObject7 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((UnityEngine.Object)gameObject7).m_CachedPtr = (IntPtr)0;
					transform.Internal_LookAt_Injected(ref *(Vector3*)parentInternal4, ref *(Vector3*)gameObject);
					obj = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					obj8 = transform;
					_ = ((UnityEngine.Object)transform).m_CachedPtr;
					nint num44 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S0_v224 (Il2CppClass<UnityEngine.Mathf>)+BA]");
					object obj81 = (nint)0 & (nint)0x200;
					if (obj81 != null)
					{
						nint num45 = (nint)typeof(Mathf);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ S0_v252 (Il2CppClass<UnityEngine.Mathf>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					GUILayoutOption gUILayoutOption = GUILayout.Width((float)obj8);
					obj = gUILayoutOption;
					obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v42+4]");
					GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
					transform2.localPosition = (Vector3)mTrans;
					obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					_ = 0;
					nint num46 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1304 @ S0_v236 (Il2CppClass<UnityEngine.Vector3>)+BA]");
					object obj82 = (nint)0 & (nint)0x200;
					if (obj82 != null)
					{
						nint num47 = (nint)typeof(Vector3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1308 @ S0_v249 (Il2CppClass<UnityEngine.Vector3>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					camera = (Camera)(object)transform2;
					((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
					gameObject = (GameObject)obj2;
					GameObject gameObject8 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
					((UnityEngine.Object)gameObject8).m_CachedPtr = (IntPtr)0;
					if ((Quaternion)camera == (Quaternion)gameObject)
					{
						gameObject = (GameObject)obj;
						GameObject gameObject9 = gameObject;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
						((UnityEngine.Object)gameObject9).m_CachedPtr = (IntPtr)0;
						Vector3 eulerAngles = ((Transform)(object)gameObject).eulerAngles;
					}
					goto IL_1adb;
				}
			}
			goto IL_1208;
		}
		gameObject = (GameObject)obj;
		GameObject gameObject10 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)gameObject10).m_CachedPtr = (IntPtr)0;
		nint num48 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v131 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj83 = (nint)0 & (nint)0x200;
		if (obj83 != null)
		{
			nint num49 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S0_v180 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		object obj84 = default;
		obj = obj84;
		camera = (Camera)obj;
		Camera camera5 = camera;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((UnityEngine.Object)camera5).m_CachedPtr = (IntPtr)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72EB");
		nint num50 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ S0_v140 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj85 = (nint)0 & (nint)0x200;
		if (obj85 != null)
		{
			nint num51 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ S0_v176 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)uIPanel).FindKernel((string)null) != 0)
		{
			Camera anchorCamera = uIPanel.anchorCamera;
			camera3 = anchorCamera;
			goto IL_11be;
		}
		nint num52 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ S1_v126 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj86 = (nint)0 & (nint)0x200;
		if (obj86 != null)
		{
			nint num53 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1084 @ S1_v135 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)container).FindKernel((string)null) != 0)
		{
			int layer4 = container.layer;
			Transform parentInternal5 = ((Transform)layer4).parentInternal;
			nint num54 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1233 @ S0_v164 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj87 = (nint)0 & (nint)0x200;
			if (obj87 != null)
			{
				nint num55 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S0_v171 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num56 = ((ComputeShader)(object)parentInternal5).FindKernel((string)null);
			bool flag = num56 == 0;
			camera3 = (Camera)(object)parentInternal5;
			if (!flag)
			{
				goto IL_11be;
			}
		}
		goto IL_1bcb;
	}
}
