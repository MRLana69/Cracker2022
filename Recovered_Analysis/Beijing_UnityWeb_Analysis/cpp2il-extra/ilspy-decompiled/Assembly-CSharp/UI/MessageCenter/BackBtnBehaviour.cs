using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using UI.FreeStuff;
using UI.ModelCamera;
using UnityEngine;

namespace UI.MessageCenter;

public class BackBtnBehaviour : MonoBehaviour
{
	public enum ScreenChangeType
	{
		PushScreen,
		ClosePopup,
		ExitGame,
		SaveMePopup,
		NotEnoughCurrency
	}

	public ScreenChangeType screenChangeType;

	public string screenNameToOpen;

	private void Update()
	{
		//IL_0065: Expected Obj, but got I
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		screenNameToOpen = null;
		((GameObject)(nint)((Object)this).m_CachedPtr).tag = null;
		string popupName = ((UIButtonChangeScreen)this).PopupName;
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v13 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		NGUITools.DestroyImmediate((Object)(object)popupName);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UI.MessageCenter.BackBtnBehaviour)+14]");
		((UIBasicButton)null).OnHover(false);
	}

	private void Send()
	{
		//IL_000a: Expected Obj, but got I4
		if (Input.GetKeyDown((string)27))
		{
			this._002Ector();
		}
	}

	private static void LogFlurry()
	{
		//IL_0db9: Expected Obj, but got I
		//IL_0dc9: Expected Obj, but got I
		//IL_0dda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddf: Expected Obj, but got Unknown
		//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ded: Expected Obj, but got Unknown
		//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e21: Expected Obj, but got Unknown
		//IL_0e2a: Expected Obj, but got I4
		//IL_0e39: Expected Obj, but got F4
		//IL_0e4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e53: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got F4
		//IL_00e9: Expected Obj, but got I
		//IL_00f9: Expected Obj, but got I
		//IL_0109: Expected Obj, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected Obj, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_015c: Expected Obj, but got I4
		//IL_016b: Expected Obj, but got F4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I4
		//IL_01c7: Expected Obj, but got F4
		//IL_0208: Expected Obj, but got I
		//IL_0218: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected Obj, but got Unknown
		//IL_0280: Expected Obj, but got I4
		//IL_028f: Expected Obj, but got F4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected Obj, but got Unknown
		//IL_02d7: Expected Obj, but got I4
		//IL_02e6: Expected Obj, but got F4
		//IL_032c: Expected Obj, but got I
		//IL_033c: Expected Obj, but got I
		//IL_034c: Expected Obj, but got I
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_039f: Expected Obj, but got I4
		//IL_03ae: Expected Obj, but got F4
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fb: Expected Obj, but got I4
		//IL_040a: Expected Obj, but got F4
		//IL_044b: Expected Obj, but got I
		//IL_045b: Expected Obj, but got I
		//IL_046b: Expected Obj, but got I
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected Obj, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected Obj, but got Unknown
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected Obj, but got Unknown
		//IL_04c3: Expected Obj, but got I4
		//IL_04d2: Expected Obj, but got F4
		//IL_050c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected Obj, but got Unknown
		//IL_051a: Expected Obj, but got I4
		//IL_0529: Expected Obj, but got F4
		//IL_056f: Expected Obj, but got I
		//IL_057f: Expected Obj, but got I
		//IL_058f: Expected Obj, but got I
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected Obj, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected Obj, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d9: Expected Obj, but got Unknown
		//IL_05e2: Expected Obj, but got I4
		//IL_05f1: Expected Obj, but got F4
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected Obj, but got Unknown
		//IL_063e: Expected Obj, but got I4
		//IL_064d: Expected Obj, but got F4
		//IL_068e: Expected Obj, but got I
		//IL_069e: Expected Obj, but got I
		//IL_06ae: Expected Obj, but got I
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected Obj, but got Unknown
		//IL_06c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected Obj, but got Unknown
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_0706: Expected Obj, but got I4
		//IL_0715: Expected Obj, but got F4
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected Obj, but got Unknown
		//IL_075d: Expected Obj, but got I4
		//IL_076c: Expected Obj, but got F4
		//IL_07b2: Expected Obj, but got I
		//IL_07c2: Expected Obj, but got I
		//IL_07d2: Expected Obj, but got I
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected Obj, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected Obj, but got Unknown
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I4
		//IL_0834: Expected Obj, but got F4
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected Obj, but got Unknown
		//IL_0881: Expected Obj, but got I4
		//IL_0890: Expected Obj, but got F4
		//IL_08d1: Expected Obj, but got I
		//IL_08e1: Expected Obj, but got I
		//IL_08f1: Expected Obj, but got I
		//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ff: Expected Obj, but got Unknown
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_090d: Expected Obj, but got Unknown
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected Obj, but got Unknown
		//IL_0949: Expected Obj, but got I4
		//IL_0958: Expected Obj, but got F4
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_09a0: Expected Obj, but got I4
		//IL_09af: Expected Obj, but got F4
		//IL_09f5: Expected Obj, but got I
		//IL_0a05: Expected Obj, but got I
		//IL_0a15: Expected Obj, but got I
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a23: Expected Obj, but got Unknown
		//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a31: Expected Obj, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Expected Obj, but got Unknown
		//IL_0a68: Expected Obj, but got I4
		//IL_0a77: Expected Obj, but got F4
		//IL_0ab6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abb: Expected Obj, but got Unknown
		//IL_0ac4: Expected Obj, but got I4
		//IL_0ad3: Expected Obj, but got F4
		//IL_0b14: Expected Obj, but got I
		//IL_0b24: Expected Obj, but got I
		//IL_0b34: Expected Obj, but got I
		//IL_0b3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected Obj, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b50: Expected Obj, but got Unknown
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected Obj, but got Unknown
		//IL_0b8c: Expected Obj, but got I4
		//IL_0b9b: Expected Obj, but got F4
		//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected Obj, but got Unknown
		//IL_0be3: Expected Obj, but got I4
		//IL_0bf2: Expected Obj, but got F4
		//IL_0c38: Expected Obj, but got I
		//IL_0c48: Expected Obj, but got I
		//IL_0c58: Expected Obj, but got I
		//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Expected Obj, but got Unknown
		//IL_0c6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected Obj, but got Unknown
		//IL_0c9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca2: Expected Obj, but got Unknown
		//IL_0cab: Expected Obj, but got I4
		//IL_0cba: Expected Obj, but got F4
		//IL_0cf9: Expected Obj, but got I4
		//IL_0d08: Expected Obj, but got F4
		//IL_0d49: Expected Obj, but got I
		//IL_0d59: Expected Obj, but got I
		//IL_0d69: Expected Obj, but got I
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Expected Obj, but got Unknown
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d85: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		_ = 21;
		object obj7 = default;
		object obj6 = obj7 + 276;
		obj6 = 0;
		_ = 0;
		obj6 = 0f;
		_ = 180f;
		_ = 0f;
		object obj8 = obj7 + 288;
		obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v17+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S4_v7+60]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S4_v8+48]");
		object obj11 = 0;
		object obj12 = obj11 & 0x7FF;
		object obj13 = obj12 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v86 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		_ = 18;
		object obj14 = obj7 + 264;
		obj14 = 0;
		_ = 0;
		obj14 = 0f;
		_ = 180f;
		_ = 0f;
		obj8 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v34+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S4_v12+60]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S4_v13+48]");
		object obj17 = 0;
		object obj18 = obj17 & 0x7FF;
		object obj19 = obj18 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v135 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj20 = obj7 + 252;
		obj20 = 0;
		_ = 0;
		obj20 = -30f;
		_ = 0f;
		_ = 100f;
		obj8 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v49+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj21 = obj7 + 240;
		obj21 = 0;
		_ = 0;
		obj21 = 20f;
		_ = 154.5f;
		_ = 358f;
		obj8 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v59+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S4_v17+60]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S4_v18+48]");
		object obj24 = 0;
		object obj25 = obj24 & 0x7FF;
		object obj26 = obj25 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v207 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj27 = obj7 + 228;
		obj27 = 0;
		_ = 0;
		obj27 = -85f;
		_ = -110f;
		_ = -200f;
		obj8 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v74+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj28 = obj7 + 216;
		obj28 = 0;
		_ = 0;
		obj28 = 0f;
		_ = 180f;
		_ = 0f;
		obj8 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v84+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S4_v22+60]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ S4_v23+48]");
		object obj31 = 0;
		object obj32 = obj31 & 0x7FF;
		object obj33 = obj32 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v279 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj34 = obj7 + 204;
		obj34 = 0;
		_ = 0;
		obj34 = -85f;
		_ = -110f;
		_ = -200f;
		obj8 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v99+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj35 = obj7 + 192;
		obj35 = 0;
		_ = 0;
		obj35 = 0f;
		_ = 180f;
		_ = 0f;
		obj8 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v109+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S4_v27+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ S4_v28+48]");
		object obj38 = 0;
		object obj39 = obj38 & 0x7FF;
		object obj40 = obj39 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v351 @ S5_v22 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj41 = obj7 + 180;
		obj41 = 0;
		_ = 0;
		obj41 = -80f;
		_ = -100f;
		_ = 0f;
		obj8 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S0_v124+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj42 = obj7 + 168;
		obj42 = 0;
		_ = 0;
		obj42 = 30f;
		_ = 210f;
		_ = 10f;
		obj8 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S0_v134+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ S4_v32+60]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ S4_v33+48]");
		object obj45 = 0;
		object obj46 = obj45 & 0x7FF;
		object obj47 = obj46 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v423 @ S5_v26 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj48 = obj7 + 156;
		obj48 = 0;
		_ = 0;
		obj48 = -80f;
		_ = -100f;
		_ = 0f;
		obj8 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ S0_v149+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj49 = obj7 + 144;
		obj49 = 0;
		_ = 0;
		obj49 = 30f;
		_ = 210f;
		_ = 10f;
		obj8 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ S0_v159+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ S4_v36 (Il2CppMethodInfo)+C]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ S4_v37+60]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ S4_v38+48]");
		object obj52 = 0;
		object obj53 = obj52 & 0x7FF;
		object obj54 = obj53 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v495 @ S5_v30 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj55 = obj7 + 132;
		obj55 = 0;
		_ = 0;
		obj55 = 0f;
		_ = -56f;
		_ = 0f;
		obj8 = obj55;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v174+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj56 = obj7 + 120;
		obj56 = 0;
		_ = 0;
		obj56 = -8f;
		_ = 180f;
		_ = 0f;
		obj8 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ S0_v184+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ S4_v41 (Il2CppMethodInfo)+C]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ S4_v42+60]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ S4_v43+48]");
		object obj59 = 0;
		object obj60 = obj59 & 0x7FF;
		object obj61 = obj60 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v567 @ S5_v34 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj62 = obj7 + 108;
		obj62 = 0;
		_ = 0;
		obj62 = -30f;
		_ = -56f;
		_ = 100f;
		obj8 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ S0_v199+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj63 = obj7 + 96;
		obj63 = 0;
		_ = 0;
		obj63 = 12f;
		_ = 154.5f;
		_ = 358f;
		obj8 = obj63;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S0_v209+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ S4_v46 (Il2CppMethodInfo)+C]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ S4_v47+60]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ S4_v48+48]");
		object obj66 = 0;
		object obj67 = obj66 & 0x7FF;
		object obj68 = obj67 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v639 @ S5_v38 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj69 = obj7 + 84;
		obj69 = 0;
		_ = 0;
		obj69 = 0f;
		_ = 0f;
		_ = 100f;
		obj8 = obj69;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ S0_v224+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		object obj70 = obj7 + 72;
		obj70 = 0;
		_ = 0;
		obj70 = 10f;
		_ = 165f;
		_ = 0f;
		obj8 = obj70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ S0_v234+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ S4_v51 (Il2CppMethodInfo)+C]");
		object obj71 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ S4_v52+60]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v703 @ S4_v53+48]");
		object obj73 = 0;
		object obj74 = obj73 & 0x7FF;
		object obj75 = obj74 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v711 @ S5_v42 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj76 = obj7 + 60;
		obj76 = 0;
		_ = 0;
		obj76 = 26f;
		_ = -29f;
		_ = 0f;
		obj8 = obj76;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ S0_v249+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 18;
		object obj77 = obj7 + 48;
		obj77 = 0;
		_ = 0;
		obj77 = 0f;
		_ = 180f;
		_ = 0f;
		obj8 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ S0_v259+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ S4_v56 (Il2CppMethodInfo)+C]");
		object obj78 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ S4_v57+60]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ S4_v58+48]");
		object obj80 = 0;
		object obj81 = obj80 & 0x7FF;
		object obj82 = obj81 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v783 @ S5_v46 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj83 = obj7 + 36;
		obj83 = 0;
		_ = 0;
		obj83 = 26f;
		_ = -29f;
		_ = 0f;
		obj8 = obj83;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S0_v274+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 18;
		object obj84 = obj7 + 24;
		obj84 = 0;
		_ = 0;
		obj84 = 0f;
		_ = 180f;
		_ = 0f;
		obj8 = obj84;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ S0_v284+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ S4_v61 (Il2CppMethodInfo)+C]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ S4_v62+60]");
		object obj86 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ S4_v63+48]");
		object obj87 = 0;
		object obj88 = obj87 & 0x7FF;
		object obj89 = obj88 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v855 @ S5_v50 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = -1;
		_ = -1;
		object obj90 = obj7 + 12;
		obj90 = 0;
		_ = 0;
		obj90 = 107f;
		_ = -97f;
		_ = 0f;
		obj8 = obj90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ S0_v299+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @73CB");
		_ = 21;
		obj7 = 0;
		_ = 0;
		obj7 = 0f;
		_ = 180f;
		_ = 0f;
		obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7518");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ S4_v66 (Il2CppMethodInfo)+C]");
		object obj91 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ S4_v67+60]");
		object obj92 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v916 @ S4_v68+48]");
		object obj93 = 0;
		object obj94 = obj93 & 0x7FF;
		object obj95 = obj94 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v924 @ S5_v54 (should have been resolved before IL gen)");
		Dictionary<UIModelController.ModelScreen, ModelScreenSetup> setups = default;
		ModelScreenSetups._setups = setups;
	}

	public BackBtnBehaviour()
	{
		//IL_082f: Expected I, but got Obj
		//IL_0845: Expected Obj, but got I
		//IL_0a63: Expected Obj, but got I4
		//IL_0a75: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0874: Expected Obj, but got I4
		//IL_00c5: Expected I, but got Obj
		//IL_0112: Expected I, but got Obj
		//IL_0128: Expected Obj, but got I
		//IL_08ae: Expected Obj, but got I4
		//IL_0153: Expected I, but got Obj
		//IL_01a0: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_01e1: Expected I, but got Obj
		//IL_022e: Expected I, but got Obj
		//IL_0244: Expected Obj, but got I
		//IL_0908: Expected Obj, but got I4
		//IL_026f: Expected I, but got Obj
		//IL_0443: Expected I, but got Obj
		//IL_0459: Expected Obj, but got I
		//IL_0948: Expected Obj, but got I4
		//IL_0484: Expected I, but got Obj
		//IL_04d1: Expected I, but got Obj
		//IL_04e7: Expected Obj, but got I
		//IL_039c: Expected I4, but got Obj
		//IL_095f: Expected Obj, but got I4
		//IL_056b: Expected Obj, but got I4
		//IL_0512: Expected I, but got Obj
		//IL_062e: Expected I, but got Obj
		//IL_0644: Expected Obj, but got I
		//IL_099b: Expected Obj, but got I4
		//IL_066f: Expected I, but got Obj
		//IL_059b: Expected I, but got Obj
		//IL_05b1: Expected Obj, but got I
		//IL_0984: Expected Obj, but got I4
		//IL_06c6: Expected I, but got Obj
		//IL_06dc: Expected Obj, but got I
		//IL_05dc: Expected I, but got Obj
		//IL_09bb: Expected Obj, but got I4
		//IL_09c9: Expected I, but got Obj
		//IL_09df: Expected Obj, but got I
		//IL_0a15: Expected Obj, but got I
		//IL_0707: Expected I, but got Obj
		//IL_0754: Expected I, but got Obj
		//IL_07a1: Expected I, but got Obj
		//IL_07b7: Expected Obj, but got I
		//IL_07e2: Expected I, but got Obj
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v171 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		bool isShowingPopup = ((UIScreenController)flag).isShowingPopup;
		if ((string)isShowingPopup != "CelebrationPopup")
		{
			return;
		}
		nint num3 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<UIScreenController>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num4 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v167 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).IsAdsOverlayVisible())
		{
			return;
		}
		nint num5 = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v26 (Il2CppClass<UIScreenController>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num6 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v163 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).DelayInputOnOverlay() != null)
		{
			nint num7 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v141 (Il2CppClass<UIScreenController>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num8 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v159 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if ((object)UIScreenController.Instance == null)
			{
				return;
			}
			nint num9 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v149 (Il2CppClass<UIScreenController>)+BA]");
			if ((object)((nint)0 & (nint)0x200) != null)
			{
				nint num10 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v155 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).ShowTransitionAdsOverlay();
		}
		else
		{
			if (!isActiveAndEnabled || ((GameObject)(object)tag).tag == null)
			{
				return;
			}
			string text = screenNameToOpen;
			if ((screenNameToOpen == null || text.m_stringLength == 0) && screenChangeType == ScreenChangeType.PushScreen)
			{
				SDebug.LogFormat(string.ConcatArray((string[])(object)Object.Instantiate((Object)this), (int)" tried to send an empty Change Screen message"), null);
			}
			if (screenChangeType != ScreenChangeType.PushScreen)
			{
				if (screenChangeType != ScreenChangeType.ClosePopup)
				{
					if (screenChangeType != ScreenChangeType.ExitGame)
					{
						if (screenChangeType != ScreenChangeType.SaveMePopup)
						{
							if (screenChangeType == ScreenChangeType.NotEnoughCurrency)
							{
								nint num11 = (nint)typeof(UIScreenController);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v96 (Il2CppClass<UIScreenController>)+BA]");
								if ((object)((nint)0 & (nint)0x200) != null)
								{
									nint num12 = (nint)typeof(UIScreenController);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v126 (Il2CppClass<UIScreenController>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).ClosePopup((GameObject)(object)"NotEnoughCurrencyPopup");
								nint num13 = (nint)typeof(Game);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v103 (Il2CppClass<SYBO.Subway.Game>)+BA]");
								if ((object)((nint)0 & (nint)0x200) != null)
								{
									nint num14 = (nint)typeof(Game);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v122 (Il2CppClass<SYBO.Subway.Game>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool isInstantiated = Game.IsInstantiated;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ S0_v108 (System.Boolean)+60]");
								object obj = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v109+8]");
								if ((nint)0 != 0)
								{
									nint num15 = (nint)typeof(Revive);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ S0_v112 (Il2CppClass<Revive>)+BA]");
									if ((object)((nint)0 & (nint)0x200) != null)
									{
										nint num16 = (nint)typeof(Revive);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S0_v118 (Il2CppClass<Revive>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									((Revive)(object)RemoteNotificationControl.GetDeviceToken())._002Ector();
								}
							}
						}
						else
						{
							CelebrationTesterPopup.RewardDebugCelebrationReward();
						}
					}
					else
					{
						nint num17 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v83 (Il2CppClass<UIScreenController>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num18 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v90 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						IEnumerator enumerator = ((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).HideInAppPurchaceOverlayDelayedCoroutine();
					}
				}
				else
				{
					nint num19 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v58 (Il2CppClass<UIScreenController>)+BA]");
					if ((object)((nint)0 & (nint)0x200) != null)
					{
						nint num20 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v78 (Il2CppClass<UIScreenController>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if ((string)((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).isShowingPopup != (string)(object)Object.Instantiate((Object)(object)tag))
					{
						nint num21 = (nint)typeof(UIScreenController);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ S0_v68 (Il2CppClass<UIScreenController>)+BA]");
						if ((object)((nint)0 & (nint)0x200) != null)
						{
							nint num22 = (nint)typeof(UIScreenController);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v74 (Il2CppClass<UIScreenController>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).DebugCloseAllPopups();
					}
				}
			}
			else
			{
				nint num23 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v47 (Il2CppClass<UIScreenController>)+BA]");
				if ((object)((nint)0 & (nint)0x200) != null)
				{
					nint num24 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v53 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((UIScreenController)UIScreenController.ShouldShowOnlineScreen()).SwitchScreen(screenNameToOpen);
			}
			RewardForVideoButtonHelper._002Ecctor();
		}
	}
}
