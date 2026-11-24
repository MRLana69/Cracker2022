using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Subway.Info;
using UnityEngine;

namespace Info;

public class Outfits : ScriptableObject
{
	private static Outfits _instance;

	public OutfitSet[] outfitSets;

	public static Outfits instance
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(OnlineSettingsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.OnlineSettingsManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettingsManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<Info.OnlineSettingsManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			OnlineSettingsManager.OnNewSettingsDownloaded();
			return (Outfits)(object)OnlineSettingsManager._localizedOnlineSettings;
		}
	}

	public unsafe static List<Outfit> TryGetOutfitsForCharacter(Characters.CharacterId character)
	{
		//IL_0213: Expected I, but got Obj
		//IL_0229: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0254: Expected Obj, but got I4
		//IL_005b: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I4
		//IL_0112: Expected Obj, but got I4
		//IL_011f: Expected Obj, but got I4
		//IL_0143: Expected I4, but got Obj
		//IL_017b: Expected I, but got Obj
		//IL_0191: Expected Obj, but got I
		//IL_0295: Expected Obj, but got I4
		//IL_02ad: Expected Obj, but got I4
		//IL_01bc: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		List<Outfit> result;
		if (~(Globals.DEBUG_USE_FAKE_ONLINE_SETTINGS ? 1u : 0u) == 0)
		{
			result = (List<Outfit>)1;
		}
		else
		{
			nint num3 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v42 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num5 = ((string)character).IndexOf((string)(object)OnlineSettings.LINEBREAK_CHARS);
			if (num5 >= 1)
			{
				string text = ((string)character).InternalSubString(0, num5);
				char[] trimChars = (char[])(num5 + 1);
				string str = ((string)character).Trim(trimChars);
				string values = string.Copy(str);
				string data = string.ConcatArray((string[])(object)values, (int)"resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg");
				byte[] str2 = Checksum.ComputeMD5(data);
				bool flag = TimeUtility.TryParseSortableNumber((string)(object)str2, out *(DateTime*)null);
				nint num6 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v33 (Il2CppClass<Utils>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v38 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = text.EndsWith((string)flag, StringComparison.InvariantCultureIgnoreCase);
				bool flag3 = !flag2;
				result = (List<Outfit>)1;
				if (flag3)
				{
					goto IL_02bb;
				}
			}
			result = null;
		}
		goto IL_02bb;
		IL_02bb:
		return result;
	}

	public static Outfit GetOutfitForCharacter(Characters.CharacterId character, int outfitIndex)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		return (Outfit)flag;
	}

	public static bool HasCharacter(Characters.CharacterId key)
	{
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_01d8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected Obj, but got Unknown
		//IL_0114: Expected Obj, but got I
		//IL_0124: Expected Obj, but got I
		//IL_0134: Expected Obj, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_00f9: Expected I4, but got Obj
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.Outfits>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v35 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int scoreMultiplier = ScoreMultiplierInfo.scoreMultiplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Int32)+C]");
		object obj2 = (nint)0 + (nint)12;
		bool flag = false;
		object obj3 = default;
		List<Outfit> list = default;
		object obj13 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Int32)+C]");
			object obj4 = (nint)0 + (nint)16;
			object obj5 = obj3 << 2;
			object obj6 = obj4 + obj5;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v22+C]");
			if ((nint)0 == (nint)key)
			{
				if (!flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					list._002Ector();
					flag = (byte)(int)list != 0;
				}
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S3_v4 (Il2CppMethodInfo)+C]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S3_v5+60]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S3_v6+38]");
				object obj10 = 0;
				object obj11 = obj10 & 0x1FFF;
				object obj12 = obj11 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S4_v2 (should have been resolved before IL gen)");
			}
			obj3 = obj13 + 1;
		}
		return flag;
	}

	public static int GetThemeCount(Characters.CharacterId character)
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected Obj, but got Unknown
		//IL_00f3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(Outfits);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.Outfits>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Outfits);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v17 (Il2CppClass<Info.Outfits>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int scoreMultiplier = ScoreMultiplierInfo.scoreMultiplier;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Func<_0021_00210, bool> func = default;
		object obj2 = func + 16;
		object obj3 = default;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (System.Int32)+C]");
		return Enumerable.All<TSource>((IEnumerable<TSource>)0, (Func<TSource, bool>)(object)func) ? 1 : 0;
	}

	unsafe static Outfits()
	{
		//IL_0019: Expected I, but got Obj
		//IL_002f: Expected Obj, but got I
		//IL_0038: Expected Obj, but got I4
		//IL_0050: Expected I, but got Obj
		//IL_0066: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected I4, but got Unknown
		//IL_009a: Expected I4, but got Obj
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		OnlineSettingsManager._onlineSettings = null;
		nint num = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v12 (Il2CppClass<Info.OnlineSettingsManager>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = 0;
		OnlineSettingsManager._initialized = false;
		nint num2 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v19 (Il2CppClass<Info.OnlineSettingsManager>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = 0;
		CallingConvention callingConvention = (CallingConvention)(obj3 + 4);
		((CallingConvention*)(int)callingConvention)->value__ = (int)obj3;
		UnmanagedFunctionPointerAttribute unmanagedFunctionPointerAttribute = default;
		unmanagedFunctionPointerAttribute._002Ector(callingConvention);
		nint num3 = (nint)typeof(OnlineSettingsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v30 (Il2CppClass<Info.OnlineSettingsManager>)+5C]");
		object obj4 = (nint)0 + (nint)20;
		obj4 = unmanagedFunctionPointerAttribute;
	}
}
