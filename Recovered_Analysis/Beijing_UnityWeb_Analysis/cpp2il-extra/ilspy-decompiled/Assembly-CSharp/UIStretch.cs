using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None,
		Horizontal,
		Vertical,
		Both,
		BasedOnHeight,
		FillKeepingRatio,
		FitInternalKeepingRatio
	}

	public Camera uiCamera;

	public GameObject container;

	public Style style;

	public bool runOnlyOnce;

	public Vector2 relativeSize;

	public Vector2 initialSize;

	public Vector2 borderPadding;

	private UIWidget widgetContainer;

	private Transform mTrans;

	private UIWidget mWidget;

	private UISprite mSprite;

	private UIPanel mPanel;

	private UIRoot mRoot;

	private Animation mAnim;

	private Rect mRect;

	private bool mStarted;

	private void Awake()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = "Sprite";
	}

	private unsafe void OnDestroy()
	{
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected Obj, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_01ab: Expected I, but got Obj
		//IL_01c1: Expected Obj, but got I
		//IL_00b8: Expected I, but got Obj
		object obj = this + 76;
		Animation component = GetComponent<Animation>();
		obj = component;
		object obj2 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		object obj3 = this + 56;
		GameObject gameObject = base.gameObject;
		obj3 = gameObject;
		object obj4 = this + 60;
		UIWidget component2 = GetComponent<UIWidget>();
		obj4 = component2;
		object obj5 = this - -64;
		UISprite component3 = GetComponent<UISprite>();
		obj5 = component3;
		object obj6 = this + 68;
		UIPanel component4 = GetComponent<UIPanel>();
		obj6 = component4;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v18 (Il2CppClass<UICamera>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v30 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj8 = default;
		obj8.method_ptr = method_ptr;
		obj8.method = (nint)__ldftn(UIStretch.ScreenSizeChanged);
		object obj9 = obj8 + 16;
		obj9 = this;
		Delegate obj10 = ((Delegate)UICamera.onScreenResize).CombineImpl(obj8);
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v27 (Il2CppClass<UICamera>)+5C]");
		object obj11 = (nint)0 + (nint)36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj12 = default;
		obj11 = obj12;
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
		obj2.method = (nint)__ldftn(UIStretch.ScreenSizeChanged);
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
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0326: Expected I, but got Obj
		//IL_033c: Expected Obj, but got I
		//IL_0129: Expected I, but got Obj
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_0220: Expected I, but got Obj
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected Obj, but got Unknown
		//IL_0116: Expected Obj, but got I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected Obj, but got Unknown
		//IL_036d: Expected Obj, but got I4
		//IL_01d3: Expected I, but got Obj
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S1_v45 (Il2CppClass<UnityEngine.Object>)+74]");
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
				object obj4 = this + 52;
				obj4 = 0;
			}
		}
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (uiCamera != null)
		{
			string text2 = tag;
			bool activeSelf = ((GameObject)(object)text2).activeSelf;
			nint num7 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v32 (Il2CppClass<NGUITools>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(NGUITools);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v38 (Il2CppClass<NGUITools>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj7 = this + 12;
			string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
			obj7 = typeName;
		}
		string go = tag;
		nint num9 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v16 (Il2CppClass<NGUITools>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v24 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = this + 72;
		UIRoot uIRoot = NGUITools.FindInParents<UIRoot>((GameObject)(object)go);
		obj9 = uIRoot;
		this._002Ector();
		mStarted = true;
	}

	public UIStretch()
	{
		//IL_16f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fd: Expected Obj, but got Unknown
		//IL_1706: Expected Obj, but got I4
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171a: Expected Obj, but got Unknown
		//IL_1723: Expected Obj, but got I4
		//IL_1738: Unknown result type (might be due to invalid IL or missing references)
		//IL_173d: Expected Obj, but got Unknown
		//IL_1746: Expected Obj, but got I4
		//IL_1755: Unknown result type (might be due to invalid IL or missing references)
		//IL_175a: Expected Obj, but got Unknown
		//IL_1763: Expected Obj, but got I4
		//IL_1778: Unknown result type (might be due to invalid IL or missing references)
		//IL_177d: Expected Obj, but got Unknown
		//IL_1786: Expected Obj, but got I4
		//IL_1795: Unknown result type (might be due to invalid IL or missing references)
		//IL_179a: Expected Obj, but got Unknown
		//IL_17a3: Expected Obj, but got I4
		//IL_17b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bd: Expected Obj, but got Unknown
		//IL_17c6: Expected Obj, but got I4
		//IL_17da: Expected I, but got Obj
		//IL_17f0: Expected Obj, but got I
		//IL_1f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Expected Obj, but got Unknown
		//IL_1f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f64: Expected Obj, but got Unknown
		//IL_1f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f72: Expected Obj, but got Unknown
		//IL_1f7b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f80: Expected Obj, but got Unknown
		//IL_1f89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8e: Expected Obj, but got Unknown
		//IL_1f97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9c: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00ac: Expected I, but got Obj
		//IL_00c2: Expected Obj, but got I
		//IL_00ed: Expected I, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_0199: Expected I, but got Obj
		//IL_0292: Expected I, but got Obj
		//IL_02a8: Expected Obj, but got I
		//IL_01e6: Expected I, but got Obj
		//IL_01fc: Expected Obj, but got I
		//IL_03ff: Expected I, but got Obj
		//IL_0415: Expected Obj, but got I
		//IL_02d3: Expected I, but got Obj
		//IL_0227: Expected I, but got Obj
		//IL_06eb: Expected I, but got Obj
		//IL_0701: Expected Obj, but got I
		//IL_0440: Expected I, but got Obj
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected Obj, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected Obj, but got Unknown
		//IL_091f: Expected I, but got Obj
		//IL_0935: Expected Obj, but got I
		//IL_072c: Expected I, but got Obj
		//IL_0610: Expected I, but got Obj
		//IL_0626: Expected Obj, but got I
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected Obj, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected Obj, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got F4
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected Obj, but got Unknown
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected Obj, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Expected Obj, but got Unknown
		//IL_18e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e8: Expected Obj, but got Unknown
		//IL_1900: Unknown result type (might be due to invalid IL or missing references)
		//IL_1905: Expected Obj, but got Unknown
		//IL_1916: Invalid comparison between I and F4
		//IL_1929: Expected Obj, but got I4
		//IL_1948: Expected Obj, but got I
		//IL_1958: Expected Obj, but got I
		//IL_0960: Expected I, but got Obj
		//IL_0795: Expected I, but got Obj
		//IL_07ab: Expected Obj, but got I
		//IL_0651: Expected I, but got Obj
		//IL_1fd7: Expected I, but got Obj
		//IL_1fed: Expected Obj, but got I
		//IL_09ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d3: Expected Obj, but got Unknown
		//IL_09f3: Expected I, but got Obj
		//IL_0a09: Expected Obj, but got I
		//IL_19aa: Expected Obj, but got I4
		//IL_19bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c4: Expected Obj, but got Unknown
		//IL_19d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d9: Expected Obj, but got Unknown
		//IL_19e1: Expected Obj, but got F4
		//IL_1a0a: Expected Obj, but got I4
		//IL_1a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a24: Expected Obj, but got Unknown
		//IL_1a41: Expected Obj, but got I
		//IL_1a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a5b: Expected Obj, but got Unknown
		//IL_1a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a6b: Expected Obj, but got Unknown
		//IL_1a71: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a76: Expected Obj, but got Unknown
		//IL_1a7a: Unsupported input type for neg.
		//IL_1a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7f: Expected Obj, but got Unknown
		//IL_1a97: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9c: Expected Obj, but got Unknown
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa7: Expected Obj, but got Unknown
		//IL_1ab8: Expected Obj, but got I
		//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Expected Obj, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9f: Expected Obj, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected Obj, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac9: Expected Obj, but got Unknown
		//IL_07d6: Expected I, but got Obj
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected I4, but got Unknown
		//IL_0b8f: Expected VT, but got Obj
		//IL_0aec: Expected I, but got Obj
		//IL_0a34: Expected I, but got Obj
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0893: Expected Obj, but got Unknown
		//IL_0822: Expected Obj, but got I4
		//IL_0822: Expected VT, but got Obj
		//IL_0b48: Expected Obj, but got I4
		//IL_0b63: Expected Obj, but got I4
		//IL_0b7b: Expected I, but got F4
		//IL_08b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Expected Obj, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Obj, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected Obj, but got Unknown
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected Obj, but got Unknown
		//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c10: Expected Obj, but got Unknown
		//IL_0c20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c25: Expected Obj, but got Unknown
		//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Expected Obj, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected Obj, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7a: Expected Obj, but got Unknown
		//IL_0c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8f: Expected Obj, but got Unknown
		//IL_203b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2040: Expected Obj, but got Unknown
		//IL_204e: Expected I, but got Obj
		//IL_2064: Expected Obj, but got I
		//IL_0d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d76: Expected Obj, but got Unknown
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d81: Expected Obj, but got Unknown
		//IL_0d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Expected Obj, but got Unknown
		//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da1: Expected Obj, but got Unknown
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected Obj, but got Unknown
		//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d22: Expected Obj, but got Unknown
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected Obj, but got Unknown
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1f: Expected Obj, but got Unknown
		//IL_0e2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e34: Expected Obj, but got Unknown
		//IL_0cde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected Obj, but got Unknown
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected Obj, but got Unknown
		//IL_114b: Expected I, but got Obj
		//IL_1161: Expected Obj, but got I
		//IL_0edd: Expected I, but got Obj
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected Obj, but got Unknown
		//IL_0ec0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec5: Expected Obj, but got Unknown
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0e05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0a: Expected Obj, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f27: Expected Obj, but got Unknown
		//IL_0f3d: Expected I, but got Obj
		//IL_0f53: Expected Obj, but got I
		//IL_13c5: Expected I, but got Obj
		//IL_13db: Expected Obj, but got I
		//IL_118c: Expected I, but got Obj
		//IL_1c17: Expected Obj, but got I
		//IL_0f7e: Expected I, but got Obj
		//IL_14c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c8: Expected Obj, but got Unknown
		//IL_1406: Expected I, but got Obj
		//IL_1c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c43: Expected Obj, but got Unknown
		//IL_1c69: Expected Obj, but got F4
		//IL_1c72: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c77: Expected Obj, but got Unknown
		//IL_1c7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c82: Expected Obj, but got Unknown
		//IL_1cb0: Expected Obj, but got F4
		//IL_0fa9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected Obj, but got Unknown
		//IL_0fc7: Expected Obj, but got I
		//IL_1351: Expected I, but got Obj
		//IL_1367: Expected Obj, but got I
		//IL_1201: Unknown result type (might be due to invalid IL or missing references)
		//IL_1206: Expected Obj, but got Unknown
		//IL_1214: Expected I, but got Obj
		//IL_122a: Expected Obj, but got I
		//IL_1547: Unknown result type (might be due to invalid IL or missing references)
		//IL_154c: Expected Obj, but got Unknown
		//IL_12ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cf: Expected Obj, but got Unknown
		//IL_12dd: Expected I, but got Obj
		//IL_12f3: Expected Obj, but got I
		//IL_1d7b: Expected I4, but got Obj
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected Obj, but got Unknown
		//IL_1014: Expected I, but got Obj
		//IL_102a: Expected Obj, but got I
		//IL_15c0: Expected I, but got Obj
		//IL_15d6: Expected Obj, but got I
		//IL_1586: Unknown result type (might be due to invalid IL or missing references)
		//IL_158b: Expected Obj, but got Unknown
		//IL_15a8: Expected Obj, but got I
		//IL_1ded: Expected VT, but got Obj
		//IL_1e10: Expected I, but got Obj
		//IL_1e26: Expected Obj, but got I
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected Obj, but got Unknown
		//IL_1392: Expected I, but got Obj
		//IL_1255: Expected I, but got Obj
		//IL_10d2: Expected I, but got Obj
		//IL_10e8: Expected Obj, but got I
		//IL_1ce6: Expected F4, but got Obj
		//IL_1cf7: Expected I4, but got Obj
		//IL_1f2b: Expected VT, but got Obj
		//IL_1f2b: Expected VT, but got Obj
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_148b: Expected Obj, but got Unknown
		//IL_1491: Unknown result type (might be due to invalid IL or missing references)
		//IL_1496: Expected Obj, but got Unknown
		//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected Obj, but got Unknown
		//IL_131e: Expected I, but got Obj
		//IL_1d0d: Expected F4, but got I
		//IL_1055: Expected I, but got Obj
		//IL_1601: Expected I, but got Obj
		//IL_1634: Expected I, but got Obj
		//IL_1113: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 200;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 176;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 160;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 136;
		obj5 = 0;
		_ = 0;
		_ = 0;
		object obj6 = obj2 + 120;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 96;
		obj7 = 0;
		_ = 0;
		_ = 0;
		object obj8 = obj2 + 80;
		obj8 = 0;
		_ = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v485 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameObject gameObject = (GameObject)(obj2 + 232);
		Camera camera = (Camera)(obj2 + 216);
		Transform transform = (Transform)(obj2 - -64);
		object obj10 = obj2 + 48;
		object obj11 = obj2 + 32;
		object obj12 = obj2 + 16;
		if ((((ComputeShader)(object)mAnim).FindKernel((string)null) != 0 && mAnim.Play()) || style == Style.None)
		{
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v38 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v497 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIWidget uIWidget = ((!(container != null)) ? container.GetComponent<UIWidget>() : null);
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v66 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v473 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UIPanel uIPanel;
		if (container != null)
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v461 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj15 = (nint)0 & (nint)0x200;
			if (obj15 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v469 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (uIWidget != null)
			{
				uIPanel = null;
				goto IL_0284;
			}
		}
		uIPanel = container.GetComponent<UIPanel>();
		goto IL_0284;
		IL_15b2:
		nint num9 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ S0_v137 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num10 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1356 @ S0_v144 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 forward = Vector3.forward;
		obj = gameObject;
		_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
		goto IL_1dde;
		IL_1dde:
		transform.localScale = (Vector3)mTrans;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1422 @ S0_v112 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1427 @ S0_v131 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		camera = (Camera)(object)transform;
		((UnityEngine.Object)camera).m_CachedPtr = ((UnityEngine.Object)transform).m_CachedPtr;
		gameObject = (GameObject)obj10;
		GameObject gameObject2 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v46+8]");
		((UnityEngine.Object)gameObject2).m_CachedPtr = (IntPtr)0;
		if ((Quaternion)camera == (Quaternion)gameObject)
		{
			gameObject = (GameObject)obj;
			GameObject gameObject3 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)gameObject3).m_CachedPtr = (IntPtr)0;
			mTrans.parent = (Transform)(object)gameObject;
		}
		if (~(runOnlyOnce ? 1u : 0u) == 0 && Application.platform != RuntimePlatform.OSXEditor)
		{
			tag = null;
		}
		return;
		IL_0284:
		nint num13 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v75 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num14 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S0_v452 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num15;
		if (((ComputeShader)(object)uIWidget).FindKernel((string)null) != 0)
		{
			GameObject gameObject4 = base.gameObject;
			Transform parentInternal = ((Transform)(object)gameObject4).parentInternal;
			UICamera.Notify(gameObject, (string)(object)uIWidget, parentInternal);
			obj3 = gameObject;
			_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (UnityEngine.GameObject)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			object obj19 = this + 80;
			obj19 = camera;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
			object obj20 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v44 (UnityEngine.Transform)+4]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			object obj21 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
			object obj22 = this + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v48+4]");
			_ = 0;
			num15 = 1f;
		}
		else
		{
			nint num16 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v306 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num17 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ S0_v431 (Il2CppClass<UnityEngine.Object>)+74]");
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
					Transform transform2 = transform;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
					object obj24 = this + 80;
					float num18 = (float)(nint)((UnityEngine.Object)transform).m_CachedPtr * 0.5f;
					float num19 = (float)camera - num18;
					obj24 = num19;
					obj10 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					obj11 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					object obj25 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v48+C]");
					float num20 = 0f * 0.5f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v46+4]");
					float num21 = 0f - num20;
					obj12 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					object obj26 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v50+8]");
					_ = 0;
					obj2 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
					_ = 0;
					object obj27 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+C]");
					_ = 0;
					num15 = 1f;
				}
				else
				{
					nint num22 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ S1_v382 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj28 = (nint)0 & (nint)0x200;
					if (obj28 != null)
					{
						nint num23 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S1_v422 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					float num25;
					if (((ComputeShader)(object)mRoot).FindKernel((string)null) != 0)
					{
						Texture mainTexture = ((UISprite)(object)mRoot).mainTexture;
						int sleepTimeout = Screen.sleepTimeout;
						int num24 = mainTexture / sleepTimeout;
						num25 = (float)num24 * 0.5f;
					}
					else
					{
						num25 = 0.5f;
					}
					int height = Screen.height;
					object obj29 = -height;
					float num26 = (float)obj29 * num25;
					object obj30 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ S0_v378+8]");
					object obj31 = 0 + obj30;
					obj30 = num26;
					object obj32 = obj31 - obj30;
					int sleepTimeout2 = Screen.sleepTimeout;
					object obj33 = -sleepTimeout2;
					float num27 = (float)obj33 * num25;
					object obj34 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ S0_v387+C]");
					nint num28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ S0_v387+4]");
					object obj35 = num28 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ S0_v387+4]");
					object obj36 = obj35 - 0;
					object obj37 = this + 80;
					object obj38 = this + 80;
					object obj39 = 0 - obj38;
					object obj40 = obj39 - obj37;
					object obj41 = this + 80;
					object obj42 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ S1_v414+4]");
					object obj43 = -0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ S0_v395+4]");
					object obj44 = obj43 - 0;
					num15 = 1f;
				}
			}
			else
			{
				nint num29 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S1_v303 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj45 = (nint)0 & (nint)0x200;
				if (obj45 != null)
				{
					nint num30 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ S1_v377 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)container).FindKernel((string)null) != 0)
				{
					GameObject gameObject5 = base.gameObject;
					Transform parentInternal2 = ((Transform)(object)gameObject5).parentInternal;
					nint num31 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v336 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj46 = (nint)0 & (nint)0x200;
					if (obj46 != null)
					{
						nint num32 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ S0_v364 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					int num33 = ((ComputeShader)(object)parentInternal2).FindKernel((string)null);
					int layer = container.layer;
					if (num33 != 0)
					{
						Vector2 vector = NGUIMath.ScreenToPixels((Vector2)parentInternal2, (Transform)layer);
					}
					else
					{
						Vector2 pivotOffset = NGUIMath.GetPivotOffset((UIWidget.Pivot)layer);
					}
					obj7 = gameObject;
					_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (UnityEngine.GameObject)+10]");
					_ = 0;
					obj5 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26+10]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
					object obj47 = this + 80;
					obj47 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AA");
					object obj48 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v42 (UnityEngine.Camera)+4]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					object obj49 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4A3");
					object obj50 = this + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v46+4]");
					_ = 0;
					num15 = 1f;
				}
				else
				{
					nint num34 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ S1_v309 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj51 = (nint)0 & (nint)0x200;
					if (obj51 != null)
					{
						nint num35 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ S1_v335 (Il2CppClass<UnityEngine.Object>)+74]");
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
					object obj52 = this + 80;
					obj52 = gameObject;
					_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
					nint num36 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ S1_v326 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj53 = (nint)0 & (nint)0x200;
					if (obj53 != null)
					{
						nint num37 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ S1_v332 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					num15 = ((((ComputeShader)(object)mRoot).FindKernel((string)null) == 0) ? 1f : UIRoot.GetPixelSizeAdjustment((GameObject)(object)mRoot));
				}
			}
		}
		object obj54 = this + 80;
		bool flag = num15 != 1f;
		object obj55 = this + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v55+C]");
		bool flag2 = 0f > 1f;
		object obj56 = flag & flag2;
		bool flag3 = obj56 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S1_v51+8]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v55+C]");
		object obj58 = 0;
		if (!flag3)
		{
			Texture mainTexture2 = ((UISprite)(object)mRoot).mainTexture;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v55+C]");
			object obj59 = mainTexture2 / 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ S1_v51+8]");
			object obj60 = 0 * obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S1_v55+C]");
			object obj61 = 0 * obj59;
			obj57 = obj60;
			obj58 = obj61;
		}
		nint num38 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ S1_v60 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj62 = (nint)0 & (nint)0x200;
		if (obj62 != null)
		{
			nint num39 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ S1_v291 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mWidget).FindKernel((string)null) != 0)
		{
			UIWidget uIWidget2 = mWidget;
			UIWidget uIWidget3 = mWidget;
			gameObject = (GameObject)0;
			((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
			gameObject = (GameObject)uIWidget2.mWidth;
			_ = uIWidget3.mHeight;
			((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0f;
		}
		else
		{
			((Transform)(object)gameObject).localScale = (Vector3)mTrans;
		}
		obj8 = gameObject;
		_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
		obj = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v30+8]");
		_ = 0;
		if (style == Style.BasedOnHeight)
		{
			object obj63 = this + 28;
			object obj64 = obj63 * obj58;
			obj = obj64;
			object obj65 = this + 28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ S1_v281+4]");
			object obj66 = 0 * obj58;
		}
		else if (style == Style.FillKeepingRatio)
		{
			object obj67 = this + 36;
			object obj68 = this + 36;
			object obj69 = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ S1_v259+4]");
			object obj70 = obj68 / 0;
			object obj71 = obj57 / obj58;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj70) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj71))
			{
				object obj72 = obj57 / obj67;
				obj = obj57;
				object obj73 = this + 36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ S1_v273+4]");
				object obj74 = 0 * obj72;
			}
			else
			{
				object obj75 = this + 36;
				object obj76 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v827 @ S0_v274+4]");
				object obj77 = obj76 / 0;
				object obj78 = obj75 * obj77;
				obj = obj78;
			}
		}
		else if (style == Style.FitInternalKeepingRatio)
		{
			object obj79 = this + 36;
			object obj80 = this + 36;
			object obj81 = this + 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ S1_v239+4]");
			object obj82 = obj80 / 0;
			object obj83 = obj57 / obj58;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj82) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj83))
			{
				object obj84 = obj57 / obj79;
				obj = obj57;
				object obj85 = this + 36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ S1_v253+4]");
				object obj86 = 0 * obj84;
			}
			else
			{
				object obj87 = this + 36;
				object obj88 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ S0_v260+4]");
				object obj89 = obj88 / 0;
				object obj90 = obj87 * obj89;
				obj = obj90;
			}
		}
		else
		{
			if (style != Style.Vertical)
			{
				object obj91 = this + 28;
				object obj92 = obj91 * obj57;
				obj = obj92;
			}
			if (style != Style.Horizontal)
			{
				object obj93 = this + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ S1_v229+4]");
				object obj94 = 0 * obj58;
			}
		}
		object obj95 = this - -64;
		nint num40 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ S0_v101 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj96 = (nint)0 & (nint)0x200;
		if (obj96 != null)
		{
			nint num41 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ S0_v240 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)obj95).FindKernel((string)null) != 0)
		{
			object obj97 = this - -64;
			object obj98 = obj97;
			nint num42 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ S1_v190 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj99 = (nint)0 & (nint)0x200;
			if (obj99 != null)
			{
				nint num43 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ S1_v220 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ S0_v211+18C]");
			float num44;
			if (((ComputeShader)0).FindKernel(null) != 0)
			{
				object obj100 = this - -64;
				object obj101 = obj100;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ S0_v237+18C]");
				num44 = ((UILabel)0).floatSpacingX;
			}
			else
			{
				num44 = 1f;
			}
			object obj102 = this + 44;
			float num45 = (float)obj102 * num44;
			float num46 = (float)obj - num45;
			obj = num46;
			object obj103 = obj + 4;
			object obj104 = this + 44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1081 @ S2_v81+4]");
			float num47 = 0f * num44;
			float num48 = (float)obj103 - num47;
			obj103 = num48;
			if (style != Style.Vertical)
			{
				object obj105 = this - -64;
				gameObject = (GameObject)obj;
				GameObject gameObject6 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)gameObject6).m_CachedPtr = (IntPtr)0;
				nint num49 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ S2_v105 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj106 = (nint)0 & (nint)0x200;
				if (obj106 != null)
				{
					nint num50 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ S2_v111 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GUILayoutOption gUILayoutOption = GUILayout.Width((float)gameObject);
				((UIWidget)obj105).height = (int)gUILayoutOption;
			}
			if (style != Style.Horizontal)
			{
				gameObject = (GameObject)obj;
				GameObject gameObject7 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)gameObject7).m_CachedPtr = (IntPtr)0;
				nint num51 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1231 @ S2_v91 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj107 = (nint)0 & (nint)0x200;
				if (obj107 != null)
				{
					nint num52 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1285 @ S2_v97 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (UnityEngine.GameObject)+4]");
				GUILayoutOption gUILayoutOption2 = GUILayout.Width(0f);
				Color color = ((UIWidget)(object)gUILayoutOption2).color;
			}
			goto IL_15b2;
		}
		nint num53 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v999 @ S1_v109 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj108 = (nint)0 & (nint)0x200;
		if (obj108 != null)
		{
			nint num54 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ S1_v185 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)mWidget).FindKernel((string)null) != 0)
		{
			if (style != Style.Vertical)
			{
				gameObject = (GameObject)obj;
				GameObject gameObject8 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)gameObject8).m_CachedPtr = (IntPtr)0;
				object obj109 = this + 44;
				nint num55 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1106 @ S3_v26 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj110 = (nint)0 & (nint)0x200;
				if (obj110 != null)
				{
					nint num56 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1166 @ S3_v30 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float width = (float)gameObject - (float)obj109;
				GUILayoutOption gUILayoutOption3 = GUILayout.Width(width);
				mWidget.height = (int)gUILayoutOption3;
			}
			if (style != Style.Horizontal)
			{
				gameObject = (GameObject)obj;
				GameObject gameObject9 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				((UnityEngine.Object)gameObject9).m_CachedPtr = (IntPtr)0;
				object obj111 = this + 44;
				nint num57 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ S3_v17 (Il2CppClass<UnityEngine.Mathf>)+BA]");
				object obj112 = (nint)0 & (nint)0x200;
				if (obj112 != null)
				{
					nint num58 = (nint)typeof(Mathf);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ S3_v21 (Il2CppClass<UnityEngine.Mathf>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (UnityEngine.GameObject)+4]");
				float num59 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ S2_v61+4]");
				float width2 = num59 - 0f;
				GUILayoutOption gUILayoutOption4 = GUILayout.Width(width2);
				Color color2 = ((UIWidget)(object)gUILayoutOption4).color;
			}
			nint num60 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1205 @ S0_v195 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj113 = (nint)0 & (nint)0x200;
			if (obj113 != null)
			{
				nint num61 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ S0_v202 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Vector3 forward2 = Vector3.forward;
			obj = gameObject;
			_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
		}
		else
		{
			nint num62 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ S1_v115 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj114 = (nint)0 & (nint)0x200;
			if (obj114 != null)
			{
				nint num63 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1127 @ S1_v160 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)mPanel).FindKernel((string)null) != 0)
			{
				object obj115 = mPanel + 220;
				gameObject = (GameObject)obj115;
				GameObject gameObject10 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1268 @ S1_v122+8]");
				((UnityEngine.Object)gameObject10).m_CachedPtr = (IntPtr)0;
				obj6 = gameObject;
				_ = ((UnityEngine.Object)gameObject).m_CachedPtr;
				if (style != Style.Vertical)
				{
					gameObject = (GameObject)obj;
					GameObject gameObject11 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((UnityEngine.Object)gameObject11).m_CachedPtr = (IntPtr)0;
					object obj116 = this + 44;
					object obj117 = (object)gameObject - obj116;
				}
				if (style != Style.Horizontal)
				{
					gameObject = (GameObject)obj;
					GameObject gameObject12 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
					((UnityEngine.Object)gameObject12).m_CachedPtr = (IntPtr)0;
					object obj118 = this + 44;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v40 (UnityEngine.GameObject)+4]");
					nint num64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1398 @ S2_v42+4]");
					object obj119 = num64 - 0;
				}
				gameObject = (GameObject)obj6;
				GameObject gameObject13 = gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23+8]");
				((UnityEngine.Object)gameObject13).m_CachedPtr = (IntPtr)0;
				Vector4 finalClipRegion = ((UIPanel)(object)gameObject).finalClipRegion;
				goto IL_15b2;
			}
			if (style != Style.Vertical)
			{
				object obj120 = this + 44;
				object obj121 = obj - obj120;
				obj = obj121;
			}
			if (style != Style.Horizontal)
			{
				object obj122 = obj + 4;
				object obj123 = this + 44;
				object obj124 = obj122;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ S2_v49+4]");
				object obj125 = obj124 - 0;
				obj122 = obj125;
			}
		}
		goto IL_1dde;
	}
}
