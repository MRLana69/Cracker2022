using Cpp2ILInjected;
using UnityEngine;

public class InAppPurchaseOverlay : MonoBehaviour
{
	private UILabel titleLabel;

	public unsafe void UpdateLabel(string text)
	{
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected VT, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected Obj, but got Unknown
		//IL_050b: Expected Obj, but got I4
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected Obj, but got Unknown
		//IL_0528: Expected Obj, but got I4
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected Obj, but got Unknown
		//IL_0545: Expected Obj, but got I4
		//IL_0052: Expected Obj, but got F4
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_001d: Expected F4, but got Obj
		//IL_0018: Expected native int or pointer, but got VT
		//IL_0032: Expected F4, but got I
		//IL_002d: Expected native int or pointer, but got VT
		//IL_057d: Expected F4, but got Obj
		//IL_0578: Expected native int or pointer, but got VT
		//IL_0592: Expected F4, but got I
		//IL_058d: Expected native int or pointer, but got VT
		//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Expected Obj, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b1: Expected Obj, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected VT, but got Unknown
		//IL_05c8: Expected native int or pointer, but got VT
		//IL_05d6: Expected native int or pointer, but got VT
		//IL_05e4: Expected native int or pointer, but got VT
		//IL_05f2: Expected native int or pointer, but got VT
		//IL_060c: Expected F4, but got I
		//IL_0607: Expected native int or pointer, but got VT
		//IL_0621: Expected F4, but got I
		//IL_061c: Expected native int or pointer, but got VT
		//IL_062e: Expected native int or pointer, but got VT
		//IL_0640: Expected native int or pointer, but got VT
		//IL_0666: Expected Obj, but got I
		//IL_0666: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0137: Expected Obj, but got F4
		//IL_014f: Expected I, but got Obj
		//IL_0165: Expected Obj, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected Obj, but got Unknown
		//IL_0102: Expected F4, but got Obj
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_0117: Expected F4, but got I
		//IL_0112: Expected native int or pointer, but got VT
		//IL_0698: Expected F4, but got Obj
		//IL_0693: Expected native int or pointer, but got VT
		//IL_06ad: Expected F4, but got I
		//IL_06a8: Expected native int or pointer, but got VT
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected Obj, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06d5: Expected native int or pointer, but got VT
		//IL_06e3: Expected native int or pointer, but got VT
		//IL_06f1: Expected native int or pointer, but got VT
		//IL_06ff: Expected native int or pointer, but got VT
		//IL_0719: Expected F4, but got I
		//IL_0714: Expected native int or pointer, but got VT
		//IL_072e: Expected F4, but got I
		//IL_0729: Expected native int or pointer, but got VT
		//IL_073b: Expected native int or pointer, but got VT
		//IL_074d: Expected native int or pointer, but got VT
		//IL_0773: Expected Obj, but got I
		//IL_0773: Expected Obj, but got I
		//IL_0190: Expected I, but got Obj
		//IL_021c: Expected Obj, but got F4
		//IL_0234: Expected I, but got Obj
		//IL_024a: Expected Obj, but got I
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01e7: Expected F4, but got Obj
		//IL_01e2: Expected native int or pointer, but got VT
		//IL_01fc: Expected F4, but got I
		//IL_01f7: Expected native int or pointer, but got VT
		//IL_07a5: Expected F4, but got Obj
		//IL_07a0: Expected native int or pointer, but got VT
		//IL_07ba: Expected F4, but got I
		//IL_07b5: Expected native int or pointer, but got VT
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected Obj, but got Unknown
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_07e2: Expected native int or pointer, but got VT
		//IL_07f0: Expected native int or pointer, but got VT
		//IL_07fe: Expected native int or pointer, but got VT
		//IL_080c: Expected native int or pointer, but got VT
		//IL_0826: Expected F4, but got I
		//IL_0821: Expected native int or pointer, but got VT
		//IL_083b: Expected F4, but got I
		//IL_0836: Expected native int or pointer, but got VT
		//IL_0848: Expected native int or pointer, but got VT
		//IL_085a: Expected native int or pointer, but got VT
		//IL_0880: Expected Obj, but got I
		//IL_0880: Expected Obj, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected Obj, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected Obj, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected Obj, but got Unknown
		//IL_0406: Expected F4, but got Obj
		//IL_0401: Expected native int or pointer, but got VT
		//IL_041b: Expected F4, but got I
		//IL_0416: Expected native int or pointer, but got VT
		//IL_0428: Expected F4, but got Obj
		//IL_0423: Expected native int or pointer, but got VT
		//IL_043d: Expected F4, but got I
		//IL_0438: Expected native int or pointer, but got VT
		//IL_0275: Expected I, but got Obj
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_048a: Expected F4, but got Obj
		//IL_0485: Expected native int or pointer, but got VT
		//IL_049f: Expected F4, but got I
		//IL_049a: Expected native int or pointer, but got VT
		//IL_04ac: Expected native int or pointer, but got VT
		//IL_04be: Expected native int or pointer, but got VT
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04db: Expected Obj, but got F4
		//IL_02d4: Expected native int or pointer, but got VT
		//IL_02e2: Expected native int or pointer, but got VT
		//IL_02f0: Expected native int or pointer, but got VT
		//IL_02fe: Expected native int or pointer, but got VT
		//IL_0310: Expected F4, but got I4
		//IL_030b: Expected native int or pointer, but got VT
		//IL_031d: Expected F4, but got I4
		//IL_0318: Expected native int or pointer, but got VT
		//IL_032b: Expected I, but got Obj
		//IL_0341: Expected Obj, but got I
		//IL_08b2: Expected native int or pointer, but got VT
		//IL_08c4: Expected native int or pointer, but got VT
		//IL_08d2: Expected I4, but got VT
		//IL_036c: Expected I, but got Obj
		object obj = default;
		Rect rect = (Rect)(obj + 96);
		object obj2 = obj - -64;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 48;
		obj3 = 0;
		_ = 0;
		object obj4 = obj + 32;
		obj4 = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+1C]");
		if ((nint)0 != 0)
		{
			object obj5 = this + 56;
			((Rect*)(nint)rect)->m_XMin = (float)obj5;
			Rect rect2 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v149+8]");
			((Rect*)(nint)rect2)->m_Width = 0f;
		}
		else
		{
			Color black = Color.black;
		}
		obj2 = rect.m_XMin;
		_ = rect.m_Width;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v25 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v176 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Rect*)(nint)rect)->m_XMin = (float)obj2;
		Rect rect3 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
		((Rect*)(nint)rect3)->m_Width = 0f;
		Color backgroundColor = GUI.backgroundColor;
		object obj7 = this + 12;
		object obj8 = this + 12;
		Rect rect4 = (Rect)(obj + 80);
		((Rect*)(nint)rect4)->m_XMin = 0f;
		((Rect*)(nint)rect4)->m_Width = 0f;
		((Rect*)(nint)rect4)->m_XMin = 0f;
		((Rect*)(nint)rect4)->m_YMin = -20f;
		Rect rect5 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v33+8]");
		((Rect*)(nint)rect5)->m_Width = 0f;
		Rect rect6 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v36+C]");
		((Rect*)(nint)rect6)->m_Height = 0f;
		((Rect*)(nint)rect)->m_XMin = rect4.m_XMin;
		((Rect*)(nint)rect)->m_Width = rect4.m_Width;
		Rect position = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+88]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+94]");
		GUI.Label(position, (GUIContent)num3, (GUIStyle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+1C]");
		if ((nint)0 != 0)
		{
			object obj9 = this + 72;
			((Rect*)(nint)rect)->m_XMin = (float)obj9;
			Rect rect7 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v143+8]");
			((Rect*)(nint)rect7)->m_Width = 0f;
		}
		else
		{
			Color black2 = Color.black;
		}
		obj3 = rect.m_XMin;
		_ = rect.m_Width;
		nint num4 = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v58 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num5 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ S0_v169 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Rect*)(nint)rect)->m_XMin = (float)obj3;
		Rect rect8 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
		((Rect*)(nint)rect8)->m_Width = 0f;
		Color backgroundColor2 = GUI.backgroundColor;
		object obj11 = this + 12;
		object obj12 = this + 12;
		((Rect*)(nint)rect4)->m_XMin = 0f;
		((Rect*)(nint)rect4)->m_Width = 0f;
		((Rect*)(nint)rect4)->m_XMin = 0f;
		((Rect*)(nint)rect4)->m_YMin = 0f;
		Rect rect9 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v66+8]");
		((Rect*)(nint)rect9)->m_Width = 0f;
		Rect rect10 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v69+C]");
		((Rect*)(nint)rect10)->m_Height = 0f;
		((Rect*)(nint)rect)->m_XMin = rect4.m_XMin;
		((Rect*)(nint)rect)->m_Width = rect4.m_Width;
		Rect position2 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+8C]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+94]");
		GUI.Label(position2, (GUIContent)num6, (GUIStyle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+1C]");
		if ((nint)0 != 0)
		{
			object obj13 = this + 88;
			((Rect*)(nint)rect)->m_XMin = (float)obj13;
			Rect rect11 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S1_v137+8]");
			((Rect*)(nint)rect11)->m_Width = 0f;
		}
		else
		{
			Color black3 = Color.black;
		}
		obj4 = rect.m_XMin;
		_ = rect.m_Width;
		nint num7 = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v90 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v162 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Rect*)(nint)rect)->m_XMin = (float)obj4;
		Rect rect12 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+8]");
		((Rect*)(nint)rect12)->m_Width = 0f;
		Color backgroundColor3 = GUI.backgroundColor;
		object obj15 = this + 12;
		object obj16 = this + 12;
		((Rect*)(nint)rect4)->m_XMin = 0f;
		((Rect*)(nint)rect4)->m_Width = 0f;
		((Rect*)(nint)rect4)->m_XMin = 0f;
		((Rect*)(nint)rect4)->m_YMin = 20f;
		Rect rect13 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v98+8]");
		((Rect*)(nint)rect13)->m_Width = 0f;
		Rect rect14 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v101+C]");
		((Rect*)(nint)rect14)->m_Height = 0f;
		((Rect*)(nint)rect)->m_XMin = rect4.m_XMin;
		((Rect*)(nint)rect)->m_Width = rect4.m_Width;
		Rect position3 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+90]");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+94]");
		GUI.Label(position3, (GUIContent)num9, (GUIStyle)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchaseOverlay)+1D]");
		if ((nint)0 != 0)
		{
			int height = Screen.height;
			int sleepTimeout = Screen.sleepTimeout;
			((Rect*)(nint)rect4)->m_XMin = 0f;
			((Rect*)(nint)rect4)->m_Width = 0f;
			((Rect*)(nint)rect4)->m_XMin = 0f;
			((Rect*)(nint)rect4)->m_YMin = 0f;
			((Rect*)(nint)rect4)->m_Width = height;
			((Rect*)(nint)rect4)->m_Height = sleepTimeout;
			nint num10 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ S0_v151 (Il2CppClass<UnityEngine.GUI>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num11 = (nint)typeof(GUI);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S0_v158 (Il2CppClass<UnityEngine.GUI>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((Rect*)(nint)rect)->m_XMin = rect4.m_XMin;
			((Rect*)(nint)rect)->m_Width = rect4.m_Width;
			GUI.scrollTroughSide = (int)rect;
		}
		object obj18 = obj + 16;
		object obj19 = this + 12;
		obj18 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S1_v89+8]");
		_ = 0;
		object obj20 = this + 120;
		obj = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S1_v94+8]");
		_ = 0;
		((Rect*)(nint)rect4)->m_XMin = (float)obj18;
		Rect rect15 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S0_v120+8]");
		((Rect*)(nint)rect15)->m_Width = 0f;
		((Rect*)(nint)rect)->m_XMin = (float)obj;
		Rect rect16 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Rect*)(nint)rect16)->m_Width = 0f;
		if (rect4 == rect)
		{
			((HUDFPS)this).OnGUI();
		}
		object obj21 = this + 12;
		((Rect*)(nint)rect4)->m_XMin = (float)obj21;
		Rect rect17 = rect4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ S1_v109+8]");
		((Rect*)(nint)rect17)->m_Width = 0f;
		((Rect*)(nint)rect)->m_XMin = rect4.m_XMin;
		((Rect*)(nint)rect)->m_Width = rect4.m_Width;
		object obj22 = this + 120;
		obj22 = rect.m_XMin;
		_ = rect.m_Width;
	}

	public InAppPurchaseOverlay()
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_00af: Expected Obj, but got F4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		_ = 0;
		obj = 10f;
		_ = 70f;
		_ = 200f;
		_ = 100f;
		object obj3 = obj2 - -64;
		obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj4 = this + 12;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
		_ = 0;
		_ = 1;
		_ = 1;
		_ = 0.5f;
		_ = 1;
		object obj5 = obj2 + 32;
		Color black = Color.black;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v26+8]");
		_ = 0;
		object obj6 = this + 56;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
		_ = 0;
		object obj7 = obj2 + 16;
		Color black2 = Color.black;
		obj3 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v33+8]");
		_ = 0;
		object obj8 = this + 72;
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
		_ = 0;
		Color black3 = Color.black;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj9 = this + 88;
		obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v16+8]");
		_ = 0;
		_ = float.MaxValue;
		_ = float.MaxValue;
		object obj10 = this + 136;
		obj10 = "";
		object obj11 = this + 140;
		obj11 = "";
		object obj12 = this + 144;
		obj12 = "";
		CancelInvoke();
	}
}
