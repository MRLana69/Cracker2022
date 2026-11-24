using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Data.Save;
using InApp;
using UI.DebugPopup;

namespace TopRun;

public static class TopRunMaintenance
{
	private static readonly CultureInfo _datetimeCultureinfo;

	public static bool IsActive()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_011e: Expected I, but got Obj
		//IL_0134: Expected Obj, but got I
		//IL_00fe: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool wordHuntPayedOut = EventsSave.wordHuntPayedOut;
		nint num3 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v11 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SSEventType lastEventTypeShown = UserSave.lastEventTypeShown;
		bool flag = wordHuntPayedOut;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S1_v9 (SSEventType)+8]");
		return (byte)((string)flag).get_Chars(0) != 0;
	}

	public unsafe static void GetMessage(out string line1, out string line2, out string line3)
	{
		//IL_0008: Expected Obj, but got Ref
		//IL_0018: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_0135: Expected Obj, but got I
		//IL_0152: Expected Obj, but got I4
		//IL_062d: Expected Obj, but got I
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected Ref, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Ref, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_05c8: Expected Obj, but got I
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected Ref, but got Unknown
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Ref, but got Unknown
		//IL_040b: Expected Obj, but got I
		//IL_029a: Expected Obj, but got I
		//IL_04d7: Expected Obj, but got I
		//IL_02fa: Expected Obj, but got I
		//IL_049b: Expected Obj, but got I
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Expected Ref, but got Unknown
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref line1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [line1 @ L0 (System.String&)+34]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [line1 @ L0 (System.String&)+34]");
		object obj4;
		object obj5;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [line1 @ L0 (System.String&)+34]");
			object obj3 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj4 = 0;
			obj5 = obj3;
		}
		else
		{
			obj5 = obj;
			obj4 = 1;
		}
		object obj6 = default;
		object obj26 = default;
		object obj18 = default;
		object obj24 = default;
		for (; obj6 != obj4; obj6 = obj26 + 1)
		{
			object obj7 = obj6 << 2;
			object obj8 = obj5 + obj7;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+14]");
			ref string reference = ref *(string*)null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String&)+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String&)+2A]");
			bool flag = (nint)0 == 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String&)+24]");
			object obj11 = (nint)0 & (nint)0x10;
			bool flag2 = obj11 == null;
			object obj12 = (flag2 ? 1 : 0) ^ 1;
			ref string reference3;
			ref string reference2;
			if (obj12 != null)
			{
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x3FFF;
					reference2 = ref *(string*)(obj13 + 97173);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.String&) (should have been resolved before IL gen)");
					reference3 = ref *(string*)97173;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
					object obj14 = (nint)0 & (nint)0x1FFF;
					reference3 = ref *(string*)(obj14 + 113696);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.String&) (should have been resolved before IL gen)");
					reference2 = ref reference;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String&)+28]");
			bool flag3 = (nint)0 != -1;
			if (!flag)
			{
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
					bool flag4;
					if ((nint)0 != 0)
					{
						object obj15 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v94+9C]");
						object obj16 = (nint)0 & (nint)0x100;
						flag4 = obj16 != null;
					}
					else
					{
						flag4 = false;
					}
					if (!flag4)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [line1 @ L0 (System.String&)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String&)+2B]");
							object obj17 = (nint)0 & (nint)3;
							bool flag5 = (nint)obj17 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag5)
							{
								if (obj18 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A75");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A76");
								}
							}
							else if (obj18 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
								reference2 = ref line3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
				object obj19 = (nint)0 & (nint)0x3FFF;
				reference2 = ref *(string*)(obj19 + 97173);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.String&) (should have been resolved before IL gen)");
				reference3 = ref *(string*)97173;
				continue;
			}
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
				bool flag6;
				if ((nint)0 != 0)
				{
					object obj20 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S0_v66+9C]");
					object obj21 = (nint)0 & (nint)0x100;
					flag6 = obj21 != null;
				}
				else
				{
					flag6 = false;
				}
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [line1 @ L0 (System.String&)+C]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
							object obj22 = (nint)0 & (nint)0x3FFF;
							reference2 = ref *(string*)(obj22 + 97173);
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v188 @ S3_v16 (System.String&) (should have been resolved before IL gen)");
							reference3 = ref *(string*)97173;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (System.String&)+2B]");
						object obj23 = (nint)0 & (nint)3;
						bool flag7 = (nint)obj23 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag7)
						{
							if (obj24 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
								reference2 = ref line3;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
								reference2 = ref line3;
							}
						}
						else if (obj24 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
							reference3 = ref line3;
							reference2 = ref line2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
							reference2 = ref line3;
						}
						continue;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
			object obj25 = (nint)0 & (nint)0x1FFF;
			reference3 = ref *(string*)(obj25 + 113696);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v186 @ S4_v6 (System.String&) (should have been resolved before IL gen)");
			reference2 = ref reference;
		}
	}

	static TopRunMaintenance()
	{
		//IL_039b: Expected Obj, but got I
		//IL_03ab: Expected Obj, but got I
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected Obj, but got Unknown
		//IL_0408: Expected I, but got Obj
		//IL_041e: Expected Obj, but got I
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected Obj, but got Unknown
		//IL_04ba: Expected Obj, but got I
		//IL_04ca: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected Obj, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f6: Expected Obj, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected Obj, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0541: Expected Obj, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected Obj, but got Unknown
		//IL_0577: Expected Obj, but got I
		//IL_0587: Expected Obj, but got I
		//IL_0597: Expected Obj, but got I
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected Obj, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_0108: Expected Obj, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected Obj, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got I
		//IL_01ba: Expected Obj, but got I
		//IL_01ca: Expected Obj, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected Obj, but got Unknown
		//IL_063c: Expected Obj, but got I
		//IL_064c: Expected Obj, but got I
		//IL_065c: Expected Obj, but got I
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected Obj, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Expected Obj, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected Obj, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected Obj, but got Unknown
		//IL_0260: Expected I, but got Obj
		//IL_032b: Expected Obj, but got I
		//IL_033b: Expected Obj, but got I
		//IL_034b: Expected Obj, but got I
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected Obj, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = "NotEnoughCurrencyPopup";
		nint num2 = (nint)typeof(InAppData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v13 (Il2CppClass<InApp.InAppData>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(InAppData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v107 (Il2CppClass<InApp.InAppData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj7 + 28;
		InAppItemModel inAppItemModel = InAppData.inAppData.get_Item("com.kiloo.subwaysurfers.coinstier1");
		obj9 = inAppItemModel;
		_ = 1;
		_ = 75322;
		_ = 1;
		object obj10 = obj7 + 12;
		obj10 = "75322 Coins needed";
		object obj11 = obj7 + 8;
		obj11 = "Not enough coins?";
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S4_v6 (Il2CppMethodInfo)+C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S4_v7+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S4_v8+48]");
		object obj14 = 0;
		object obj15 = obj14 & 0x7FF;
		object obj16 = obj15 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v97 @ S5_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj18 = default;
		object obj17 = obj18 + 16;
		obj17 = "NotEnoughCurrencyPopup";
		_ = 0;
		_ = 75322;
		_ = 1;
		object obj19 = obj18 + 12;
		obj19 = "75322 Coins needed";
		object obj20 = obj18 + 8;
		obj20 = "Not enough coins?";
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S4_v11 (Il2CppMethodInfo)+C]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S4_v12+60]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S4_v13+48]");
		object obj23 = 0;
		object obj24 = obj23 & 0x7FF;
		object obj25 = obj24 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v139 @ S5_v10 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj27 = default;
		object obj26 = obj27 + 16;
		obj26 = "NotEnoughCurrencyPopup";
		object obj28 = obj27 + 28;
		InAppItemModel inAppItemModel2 = InAppData.inAppData.get_Item("com.kiloo.subwaysurfers.keystier1");
		obj28 = inAppItemModel2;
		_ = 1;
		_ = 23;
		_ = 0;
		object obj29 = obj27 + 12;
		obj29 = "23 Keys needed";
		object obj30 = obj27 + 8;
		obj30 = "Not enough keys?";
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v16 (Il2CppMethodInfo)+C]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S4_v17+60]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S4_v18+48]");
		object obj33 = 0;
		object obj34 = obj33 & 0x7FF;
		object obj35 = obj34 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v192 @ S5_v14 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj37 = default;
		object obj36 = obj37 + 16;
		obj36 = "NotEnoughCurrencyPopup";
		_ = 0;
		_ = 23;
		_ = 0;
		object obj38 = obj37 + 12;
		obj38 = "23 Keys needed";
		object obj39 = obj37 + 8;
		obj39 = "Not enough keys?";
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S4_v21 (Il2CppMethodInfo)+C]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S4_v22+60]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S4_v23+48]");
		object obj42 = 0;
		object obj43 = obj42 & 0x7FF;
		object obj44 = obj43 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v233 @ S5_v18 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj46 = default;
		object obj45 = obj46 + 16;
		obj45 = "PurchaseErrorPopup";
		nint num8 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v74 (Il2CppClass<Strings>)+BA]");
		object obj47 = (nint)0 & (nint)0x200;
		if (obj47 != null)
		{
			nint num9 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ S0_v103 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj48 = obj46 + 8;
		string text = Strings.GetDefault("PURCHASE_FAILED_TITLE");
		obj48 = text;
		object obj49 = obj46 + 12;
		string text2 = Strings.GetDefault("PURCHASE_FAILED_BODY");
		obj49 = text2;
		_ = 0;
		_ = 0;
		_ = 1;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S4_v26 (Il2CppMethodInfo)+C]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S4_v27+60]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ S4_v28+48]");
		object obj52 = 0;
		object obj53 = obj52 & 0x7FF;
		object obj54 = obj53 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v292 @ S5_v22 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj56 = default;
		object obj55 = obj56 + 16;
		obj55 = "PurchaseErrorPopup";
		object obj57 = obj56 + 8;
		string text3 = Strings.GetDefault("PURCHASE_FAILED_TITLE");
		obj57 = text3;
		object obj58 = obj56 + 12;
		string text4 = Strings.GetDefault("PURCHASE_FAILED_BODY");
		obj58 = text4;
		_ = 0;
		_ = 0;
		_ = 1;
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ S4_v31 (Il2CppMethodInfo)+C]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ S4_v32+60]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S4_v33+48]");
		object obj61 = 0;
		object obj62 = obj61 & 0x7FF;
		object obj63 = obj62 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v337 @ S5_v26 (should have been resolved before IL gen)");
		Dictionary<InAppManagerPopupType, InAppManagerPopupData> appManagerPopupDatas = default;
		InAppManagerDebugPopupDataEntries._appManagerPopupDatas = appManagerPopupDatas;
	}
}
