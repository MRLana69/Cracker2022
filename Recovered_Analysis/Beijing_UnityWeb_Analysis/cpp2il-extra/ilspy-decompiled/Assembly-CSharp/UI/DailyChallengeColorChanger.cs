using System;
using Cpp2ILInjected;
using Data.Save;
using UnityEngine;

namespace UI;

public class DailyChallengeColorChanger : MonoBehaviour
{
	public UILabel shadowLabel;

	public Color MyColorActive;

	public Color MyColorInactive;

	public Color shadowColorActive;

	public Color shadowColorInactive;

	private string _letterColorActiveAsString;

	private string _letterColorInactiveAsString;

	private string _shadowColorActiveAsString;

	private string _shadowColorInactiveAsString;

	private UILabel _myLabel;

	private string _cachedText;

	private string _cachedDailyWord;

	private IntMask _cachedDailyMask;

	private void Awake()
	{
		ScriptableObject.CreateScriptableObject((ScriptableObject)(object)this);
	}

	private void OnEnable()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		object obj = this + 96;
		string text = tag;
		UILabel component = ((GameObject)(object)text).GetComponent<UILabel>();
		obj = component;
		UpdateDailyWord();
	}

	private void Update()
	{
		this._002Ector();
	}

	private void EncodeColors()
	{
		this._002Ector();
	}

	private unsafe void UpdateDailyWord()
	{
		//IL_0543: Expected I, but got Obj
		//IL_0559: Expected Obj, but got I
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected Obj, but got Unknown
		//IL_092e: Expected Obj, but got I4
		//IL_0951: Expected I, but got Obj
		//IL_0967: Expected Obj, but got I
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected VT, but got Unknown
		//IL_0591: Expected F4, but got Obj
		//IL_058c: Expected native int or pointer, but got VT
		//IL_05a6: Expected F4, but got I
		//IL_05a1: Expected native int or pointer, but got VT
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected Obj, but got Unknown
		//IL_05eb: Expected Obj, but got I4
		//IL_060d: Expected F4, but got Obj
		//IL_0608: Expected native int or pointer, but got VT
		//IL_0622: Expected F4, but got I
		//IL_061d: Expected native int or pointer, but got VT
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		//IL_00ee: Expected F4, but got Obj
		//IL_00e9: Expected native int or pointer, but got VT
		//IL_0103: Expected F4, but got I
		//IL_00fe: Expected native int or pointer, but got VT
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected Obj, but got Unknown
		//IL_014d: Expected Obj, but got I4
		//IL_016f: Expected F4, but got Obj
		//IL_016a: Expected native int or pointer, but got VT
		//IL_0184: Expected F4, but got I
		//IL_017f: Expected native int or pointer, but got VT
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected Obj, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected Obj, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected Obj, but got Unknown
		//IL_0219: Expected F4, but got Obj
		//IL_0214: Expected native int or pointer, but got VT
		//IL_022e: Expected F4, but got I
		//IL_0229: Expected native int or pointer, but got VT
		//IL_023b: Expected I, but got VT
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_0693: Expected F4, but got Obj
		//IL_068e: Expected native int or pointer, but got VT
		//IL_06a8: Expected F4, but got I
		//IL_06a3: Expected native int or pointer, but got VT
		//IL_06b5: Expected I, but got VT
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0721: Expected Obj, but got Unknown
		//IL_076a: Expected F4, but got Obj
		//IL_0765: Expected native int or pointer, but got VT
		//IL_077f: Expected F4, but got I
		//IL_077a: Expected native int or pointer, but got VT
		//IL_078c: Expected I, but got VT
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0293: Expected I, but got Obj
		//IL_02a9: Expected Obj, but got I
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected Obj, but got Unknown
		//IL_0841: Expected F4, but got Obj
		//IL_083c: Expected native int or pointer, but got VT
		//IL_0856: Expected F4, but got I
		//IL_0851: Expected native int or pointer, but got VT
		//IL_0863: Expected I, but got VT
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0349: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_06df: Expected F4, but got Obj
		//IL_06da: Expected native int or pointer, but got VT
		//IL_06f1: Expected F4, but got I
		//IL_06ec: Expected native int or pointer, but got VT
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected Obj, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected Obj, but got Unknown
		//IL_03ff: Expected I, but got Obj
		//IL_0415: Expected Obj, but got I
		//IL_07b6: Expected F4, but got Obj
		//IL_07b1: Expected native int or pointer, but got VT
		//IL_07c8: Expected F4, but got I
		//IL_07c3: Expected native int or pointer, but got VT
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected Obj, but got Unknown
		//IL_02d4: Expected I, but got Obj
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_04b5: Expected I, but got Obj
		//IL_04cb: Expected Obj, but got I
		//IL_088d: Expected F4, but got Obj
		//IL_0888: Expected native int or pointer, but got VT
		//IL_089f: Expected F4, but got I
		//IL_089a: Expected native int or pointer, but got VT
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_038a: Expected I, but got Obj
		//IL_08d2: Expected F4, but got Obj
		//IL_08cd: Expected native int or pointer, but got VT
		//IL_08e4: Expected F4, but got I
		//IL_08df: Expected native int or pointer, but got VT
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected Obj, but got Unknown
		//IL_0440: Expected I, but got Obj
		//IL_04f6: Expected I, but got Obj
		nint num = (nint)typeof(ColorData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UI.ColorData>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(ColorData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v154 (Il2CppClass<UI.ColorData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 80;
		bool flag = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj4 = (flag ? 1 : 0) + 268;
		obj2 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v7+8]");
		_ = 0;
		nint num3 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v17 (Il2CppClass<NGUIText>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v150 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = (Color)(obj3 + 112);
		((Color*)(nint)color)->r = (float)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		((Color*)(nint)color)->b = 0f;
		object obj6 = this + 80;
		string text = NGUIText.EncodeColor24(color);
		obj6 = text;
		object obj7 = obj3 - -64;
		bool flag2 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj8 = (flag2 ? 1 : 0) + 828;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v23+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+8]");
		((Color*)(nint)color)->b = 0f;
		object obj9 = this + 84;
		string text2 = NGUIText.EncodeColor24(color);
		obj9 = text2;
		object obj10 = obj3 + 48;
		bool flag3 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj11 = (flag3 ? 1 : 0) + 844;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S1_v37+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v34+8]");
		((Color*)(nint)color)->b = 0f;
		object obj12 = this + 88;
		string text3 = NGUIText.EncodeColor24(color);
		obj12 = text3;
		object obj13 = obj3 + 32;
		bool flag4 = HoverboardStickerManager.ShouldShowHoverboardStickerFlow();
		object obj14 = (flag4 ? 1 : 0) + 860;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v51+8]");
		_ = 0;
		((Color*)(nint)color)->r = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v41+8]");
		((Color*)(nint)color)->b = 0f;
		object obj15 = this + 92;
		string text4 = NGUIText.EncodeColor24(color);
		obj15 = text4;
		object obj16 = obj3 + 16;
		object obj17 = this + 16;
		obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v64+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
		Gradient gradient = (Gradient)(obj3 + 96);
		gradient = (Gradient)obj16;
		Gradient gradient2 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v48+8]");
		gradient2.m_Ptr = (IntPtr)0;
		((Color*)(nint)color)->r = (float)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Color*)(nint)color)->b = 0f;
		if (gradient.Internal_Equals((IntPtr)color))
		{
			object obj18 = this + 16;
			gradient = (Gradient)obj18;
			Gradient gradient3 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S1_v168+8]");
			gradient3.m_Ptr = (IntPtr)0;
			nint num5 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v138 (Il2CppClass<NGUIText>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num6 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v146 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color*)(nint)color)->r = (float)gradient;
			((Color*)(nint)color)->b = (nint)gradient.m_Ptr;
			object obj20 = this + 80;
			string text5 = NGUIText.EncodeColor24(color);
			obj20 = text5;
		}
		object obj21 = this + 32;
		obj2 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v81+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
		gradient = (Gradient)obj2;
		Gradient gradient4 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		gradient4.m_Ptr = (IntPtr)0;
		((Color*)(nint)color)->r = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+8]");
		((Color*)(nint)color)->b = 0f;
		if (gradient.Internal_Equals((IntPtr)color))
		{
			object obj22 = this + 32;
			gradient = (Gradient)obj22;
			Gradient gradient5 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v155+8]");
			gradient5.m_Ptr = (IntPtr)0;
			nint num7 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ S0_v123 (Il2CppClass<NGUIText>)+BA]");
			object obj23 = (nint)0 & (nint)0x200;
			if (obj23 != null)
			{
				nint num8 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v131 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color*)(nint)color)->r = (float)gradient;
			((Color*)(nint)color)->b = (nint)gradient.m_Ptr;
			object obj24 = this + 84;
			string text6 = NGUIText.EncodeColor24(color);
			obj24 = text6;
		}
		object obj25 = this + 48;
		obj2 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S1_v97+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
		gradient = (Gradient)obj2;
		Gradient gradient6 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		gradient6.m_Ptr = (IntPtr)0;
		((Color*)(nint)color)->r = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+8]");
		((Color*)(nint)color)->b = 0f;
		if (gradient.Internal_Equals((IntPtr)color))
		{
			object obj26 = this + 48;
			gradient = (Gradient)obj26;
			Gradient gradient7 = gradient;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S1_v142+8]");
			gradient7.m_Ptr = (IntPtr)0;
			nint num9 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v108 (Il2CppClass<NGUIText>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num10 = (nint)typeof(NGUIText);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v116 (Il2CppClass<NGUIText>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Color*)(nint)color)->r = (float)gradient;
			((Color*)(nint)color)->b = (nint)gradient.m_Ptr;
			object obj28 = this + 88;
			string text7 = NGUIText.EncodeColor24(color);
			obj28 = text7;
		}
		object obj29 = this - -64;
		obj2 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S1_v113+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F52F");
		gradient = (Gradient)obj2;
		Gradient gradient8 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
		gradient8.m_Ptr = (IntPtr)0;
		((Color*)(nint)color)->r = (float)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v27+8]");
		((Color*)(nint)color)->b = 0f;
		if (!gradient.Internal_Equals((IntPtr)color))
		{
			return;
		}
		object obj30 = this - -64;
		gradient = (Gradient)obj30;
		Gradient gradient9 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ S1_v129+8]");
		gradient9.m_Ptr = (IntPtr)0;
		nint num11 = (nint)typeof(NGUIText);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ S0_v93 (Il2CppClass<NGUIText>)+BA]");
		object obj31 = (nint)0 & (nint)0x200;
		if (obj31 != null)
		{
			nint num12 = (nint)typeof(NGUIText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v101 (Il2CppClass<NGUIText>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Color*)(nint)color)->r = (float)gradient;
		((Color*)(nint)color)->b = (nint)gradient.m_Ptr;
		object obj32 = this + 92;
		string text8 = NGUIText.EncodeColor24(color);
		obj32 = text8;
	}

	public DailyChallengeColorChanger()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected Obj, but got Unknown
		//IL_04cc: Expected Obj, but got I4
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected Obj, but got Unknown
		//IL_04e3: Expected Obj, but got I4
		//IL_04f1: Expected I, but got Obj
		//IL_0507: Expected Obj, but got I
		//IL_0532: Expected I, but got Obj
		//IL_0548: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_00a2: Expected I, but got Obj
		//IL_0584: Expected I4, but got Obj
		//IL_0136: Expected I4, but got Obj
		//IL_013f: Expected I4, but got Obj
		//IL_05a0: Expected I, but got Obj
		//IL_05b6: Expected Obj, but got I
		//IL_0790: Expected Obj, but got I4
		//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected Obj, but got Unknown
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected Obj, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected Obj, but got Unknown
		//IL_060c: Expected Obj, but got I4
		//IL_0152: Expected I, but got Obj
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected Obj, but got Unknown
		//IL_0208: Expected Obj, but got I4
		//IL_0222: Expected VT, but got Obj
		//IL_019a: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got VT
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected Obj, but got Unknown
		//IL_035a: Expected I4, but got Obj
		//IL_0294: Expected I4, but got Obj
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected Obj, but got Unknown
		//IL_03ac: Expected I4, but got Obj
		//IL_0641: Expected I4, but got Obj
		//IL_0641: Expected I4, but got Obj
		//IL_0652: Expected Obj, but got I4
		//IL_0285: Expected I4, but got Obj
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected Obj, but got Unknown
		//IL_03db: Expected Obj, but got I4
		//IL_02ab: Expected Obj, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected Obj, but got Unknown
		//IL_04b0: Expected I4, but got Obj
		//IL_041e: Expected I4, but got Obj
		//IL_06b3: Expected I4, but got Obj
		//IL_06b3: Expected I4, but got Obj
		//IL_06c4: Expected Obj, but got I4
		//IL_040f: Expected I4, but got Obj
		//IL_0435: Expected Obj, but got I4
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 12;
		obj3 = 0;
		object obj4 = obj2 + 20;
		obj4 = 0;
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v89 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_myLabel != null)
		{
			object obj6 = this + 96;
			string text = tag;
			UILabel component = ((GameObject)(object)text).GetComponent<UILabel>();
			obj6 = component;
		}
		nint num3 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v17 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v119 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
		bool flag;
		if (wordHuntPayedOut)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v22 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		bool flag2 = !flag;
		bool flag3 = !flag2;
		bool flag4 = (byte)(int)"" != 0;
		if (!flag3)
		{
			flag4 = wordHuntPayedOut;
		}
		bool flag5;
		if (Application.platform != RuntimePlatform.OSXEditor)
		{
			flag5 = flag4;
			bool flag6 = flag4;
		}
		else
		{
			flag5 = (byte)(int)"JAKE" != 0;
			bool flag6 = (byte)(int)"JAKE" != 0;
		}
		nint num5 = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v31 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v108 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int wordHuntWordsInRow = EventsSave.wordHuntWordsInRow;
		obj3 = wordHuntWordsInRow;
		if (Application.platform == RuntimePlatform.OSXEditor)
		{
			obj3 = 1;
		}
		object obj9 = obj2 + 16;
		object obj10 = obj2 + 8;
		object obj11 = obj2 + 4;
		if ((string)flag5 != _cachedDailyWord)
		{
			obj10 = obj3;
			obj9 = obj10;
			obj = obj9;
			obj11 = _cachedDailyMask;
			obj9 = obj11;
			obj = obj9;
			if (obj == obj)
			{
				return;
			}
		}
		object obj12 = this + 104;
		obj12 = flag5;
		obj2 = obj3;
		obj9 = obj2;
		_cachedDailyMask = (IntMask)obj9;
		char[] array = null;
		string text2 = string.Empty;
		Type type = default;
		while (true)
		{
			char[] array2 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v28 (System.Boolean)+8]");
			if ((nint)array2 >= 0)
			{
				break;
			}
			object obj13 = array & 0x1F;
			object obj14 = 1 << (int)obj13;
			object obj15 = obj3 & obj14;
			int startIndex = ((obj15 == null) ? ((int)_letterColorInactiveAsString) : ((int)_letterColorActiveAsString));
			int num7 = text2.IndexOf((char)(int)"[", startIndex, (int)"]");
			string[] array3 = ((string)flag5).Split(array);
			obj4 = array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			object obj16 = ((IConvertible)num7).ToType(type, (IFormatProvider)(object)" ");
			char[] array4 = (char[])(array + 1);
			array = array4;
			text2 = (string)obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v28 (System.Boolean)+8]");
		bool flag7 = (nint)0 < (nint)1;
		if (!flag7)
		{
			object obj17 = this + 100;
			int length = text2.m_stringLength - 1;
			string text3 = text2.InternalSubString(0, length);
			obj17 = text3;
			_myLabel.fontSize = (int)_cachedText;
			object obj18 = this + 100;
			int length2 = text2.m_stringLength - 1;
			string text4 = text2.InternalSubString(0, length2);
			obj18 = text4;
			_myLabel.fontSize = (int)_cachedText;
		}
		string text5 = string.Empty;
		char[] array6 = default;
		Type type2 = default;
		char[] array8 = default;
		while (true)
		{
			char[] array5 = array6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v28 (System.Boolean)+8]");
			if ((nint)array5 >= 0)
			{
				break;
			}
			object obj19 = array6 & 0x1F;
			object obj20 = 1 << (int)obj19;
			object obj21 = obj3 & obj20;
			int startIndex2 = ((obj21 == null) ? ((int)_shadowColorInactiveAsString) : ((int)_shadowColorActiveAsString));
			int num8 = text5.IndexOf((char)(int)"[", startIndex2, (int)"]");
			string[] array7 = ((string)flag5).Split(array6);
			obj4 = array7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
			object obj22 = ((IConvertible)num8).ToType(type2, (IFormatProvider)(object)" ");
			array6 = (char[])(array8 + 1);
			text5 = (string)obj22;
		}
		if (!flag7)
		{
			int length3 = text5.m_stringLength - 1;
			string text6 = text5.InternalSubString(0, length3);
			shadowLabel.fontSize = (int)text6;
		}
	}
}
