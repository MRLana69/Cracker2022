using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public static class Localization
{
	public delegate byte[] LoadFunction(string path);

	public delegate void OnLocalizeNotification();

	public static LoadFunction loadFunction;

	public static OnLocalizeNotification onLocalize;

	public static bool localizationHasBeenSet;

	private static string[] mLanguages;

	private static Dictionary<string, string> mOldDictionary;

	private static Dictionary<string, string[]> mDictionary;

	private static Dictionary<string, string> mReplacement;

	private static int mLanguageIndex;

	private static string mLanguage;

	private static bool mMerging;

	public static Dictionary<string, string[]> dictionary
	{
		get
		{
			//IL_022e: Expected I, but got Obj
			//IL_0244: Expected Obj, but got I
			//IL_02da: Expected I, but got Obj
			//IL_02f0: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_00ad: Expected I, but got Obj
			//IL_00c3: Expected Obj, but got I
			//IL_026f: Expected I, but got Obj
			//IL_0285: Expected Obj, but got I
			//IL_00ee: Expected I, but got Obj
			//IL_0196: Expected I, but got Obj
			//IL_01ac: Expected Obj, but got I
			//IL_013b: Expected I, but got Obj
			//IL_02c7: Expected Obj, but got I4
			//IL_0183: Expected Obj, but got I4
			//IL_01d7: Expected I, but got Obj
			nint num = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPopupList>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v48 (Il2CppClass<UIPopupList>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v25 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)UIPopupList.current).FindKernel((string)null) != 0)
			{
				nint num5 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UIPopupList>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v42 (Il2CppClass<UIPopupList>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)UIPopupList.mChild).FindKernel((string)null) != 0)
				{
					return (Dictionary<string, string[]>)1;
				}
				nint num9 = (nint)typeof(UIPopupList);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v27 (Il2CppClass<UIPopupList>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num10 = (nint)typeof(UIPopupList);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v35 (Il2CppClass<UIPopupList>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float unscaledDeltaTime = Time.unscaledDeltaTime;
				bool flag = UIPopupList.mFadeOutComplete > unscaledDeltaTime;
				return (Dictionary<string, string[]>)flag;
			}
			return null;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			if (value == null)
			{
				return;
			}
			int num = default;
			int num2 = default;
			while (num < (nint)value.entries)
			{
				EventDelegate eventDelegate = ((List<EventDelegate>)(object)value).get_Item(num);
				if (eventDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (num >= (nint)value.entries)
					{
						break;
					}
					EventDelegate eventDelegate2 = ((List<EventDelegate>)(object)value).get_Item(num);
					if (eventDelegate2 != eventDelegate)
					{
						continue;
					}
					if (~(eventDelegate.oneShot ? 1u : 0u) == 0)
					{
						((List<EventDelegate>)(object)value).RemoveAt(num);
						continue;
					}
				}
				num = num2 + 1;
			}
		}
	}

	public static string[] knownLanguages
	{
		get
		{
			//IL_018f: Expected I, but got Obj
			//IL_01a5: Expected Obj, but got I
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0061: Expected I4, but got Obj
			//IL_0061: Expected I4, but got Obj
			//IL_0073: Expected I, but got Obj
			//IL_0089: Expected Obj, but got I
			//IL_0142: Expected I, but got Obj
			//IL_01d0: Expected Obj, but got I4
			//IL_00b4: Expected I, but got Obj
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(localizationHasBeenSet ? 1u : 0u) != 0)
			{
				int num3 = UnityEngine.Random.Range((int)"Language", (int)"English");
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v8 (Il2CppClass<Localization>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v13 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = LoadCSV((TextAsset)num3);
			}
			nint num6 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<Localization>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string[])(object)mDictionary;
		}
	}

	public static string language
	{
		get
		{
			//IL_018f: Expected I, but got Obj
			//IL_01a5: Expected Obj, but got I
			//IL_0101: Expected I, but got Obj
			//IL_0117: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0061: Expected I4, but got Obj
			//IL_0061: Expected I4, but got Obj
			//IL_0073: Expected I, but got Obj
			//IL_0089: Expected Obj, but got I
			//IL_0142: Expected I, but got Obj
			//IL_01d0: Expected Obj, but got I4
			//IL_00b4: Expected I, but got Obj
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v33 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(localizationHasBeenSet ? 1u : 0u) != 0)
			{
				int num3 = UnityEngine.Random.Range((int)"Language", (int)"English");
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v8 (Il2CppClass<Localization>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S1_v13 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = LoadCSV((TextAsset)num3);
			}
			nint num6 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<Localization>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v23 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (string)(object)mLanguages;
		}
		set
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00bc: Expected I, but got Obj
			//IL_00d2: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = value != null;
			localizationHasBeenSet = flag;
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v13 (Il2CppClass<Localization>)+5C]");
			object obj2 = (nint)0 + (nint)20;
			obj2 = value;
		}
	}

	public static bool isActive
	{
		get
		{
			//IL_0218: Expected I, but got Obj
			//IL_022e: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_017c: Expected I, but got Obj
			//IL_0192: Expected Obj, but got I
			//IL_00a1: Expected I, but got Obj
			//IL_00ee: Expected I, but got Obj
			//IL_0104: Expected Obj, but got I
			//IL_01bd: Expected I, but got Obj
			//IL_012f: Expected I, but got Obj
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v60 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			localizationHasBeenSet = false;
			if (LoadCSV((TextAsset)(object)mLanguage, merge: true))
			{
				nint num3 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20 (Il2CppClass<Localization>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v54 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (onLocalize != null)
				{
					nint num5 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v41 (Il2CppClass<Localization>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v48 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					onLocalize();
				}
				nint num7 = (nint)typeof(UIRoot);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v29 (Il2CppClass<UIRoot>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UIRoot);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v36 (Il2CppClass<UIRoot>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((UIRoot)(object)"OnLocalize")._002Ector();
				return true;
			}
			return false;
		}
	}

	public static bool Reload()
	{
		//IL_01e0: Expected I, but got Obj
		//IL_01f6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0152: Expected I, but got Obj
		//IL_0168: Expected Obj, but got I
		//IL_0263: Expected I4, but got Obj
		//IL_0088: Expected I4, but got Obj
		//IL_0088: Expected I4, but got Obj
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_00cd: Expected I, but got Obj
		//IL_0193: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_024a: Expected Obj, but got I4
		//IL_00e9: Expected I, but got Obj
		//IL_0119: Expected I, but got Obj
		//IL_013f: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v55 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = mLanguage;
		if (mLanguage == null || text.m_stringLength == 0)
		{
			int num3 = UnityEngine.Random.Range((int)"Language", (int)"English");
			nint num4 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v33 (Il2CppClass<Localization>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag = obj2 == null;
			nint num5 = (nint)typeof(Localization);
			if (!flag)
			{
				nint num6 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v45 (Il2CppClass<Localization>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num5 = (nint)typeof(Localization);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num5 = (nint)typeof(Localization);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ L0_v9 (Il2CppClass<Localization>)+5C]");
			object obj3 = (nint)0 + (nint)32;
			obj3 = num3;
			bool flag4 = HasLanguage(mLanguage);
		}
		nint num7 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16 (Il2CppClass<Localization>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v23 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)mLanguage != 0;
	}

	private static bool LoadDictionary(string value, bool merge = false)
	{
		bool result;
		if (value != null)
		{
			int num = 0;
			object obj = default;
			while (true)
			{
				bool flag = num >= value.m_firstChar;
				result = false;
				if (flag)
				{
					break;
				}
				EventDelegate eventDelegate = ((List<EventDelegate>)(object)value).get_Item(num);
				if (eventDelegate != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
					if (obj != null)
					{
						((List<EventDelegate>)(object)value).RemoveAt(num);
						result = true;
						break;
					}
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	private static bool LoadAndSelect(string value)
	{
		bool result;
		if (value != null)
		{
			int num = 0;
			while (true)
			{
				bool flag = num >= value.m_firstChar;
				result = false;
				if (flag)
				{
					break;
				}
				EventDelegate eventDelegate = ((List<EventDelegate>)(object)value).get_Item(num);
				if (eventDelegate != null)
				{
					bool isEnabled = eventDelegate.isEnabled;
					result = true;
					if (isEnabled)
					{
						break;
					}
				}
				int num2 = num + 1;
				num = num2;
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	public static void Load(TextAsset asset)
	{
		//IL_0119: Expected I, but got Obj
		//IL_012f: Expected Obj, but got I
		//IL_018a: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_0162: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0105: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mLanguage.get_Chars((int)asset) == '\0')
		{
			return;
		}
		nint num3 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<Localization>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(Localization);
		if (!flag)
		{
			nint num5 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v25 (Il2CppClass<Localization>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Localization);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Localization);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ L1_v5 (Il2CppClass<Localization>)+5C]");
		object obj3 = (nint)0 + (nint)32;
		obj3 = asset;
		bool flag4 = HasLanguage((string)(object)asset);
	}

	public static void Set(string languageName, byte[] bytes)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00c0: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		bool flag = bytes[4] != 0;
		nint num = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<EventDelegate>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v14 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AddCSV((BetterList<string>)(object)languageName, (string[])(object)bytes, (Dictionary<string, int>)flag);
	}

	public static void ReplaceKey(string key, string val)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ByteReader byteReader = default;
		object obj = byteReader + 8;
		obj = val;
		BetterList<string> value = byteReader.ReadCSV();
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v12 (Il2CppClass<Localization>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v17 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Set(key, (string)(object)value);
	}

	public static void ClearReplacements()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int s_Hash = default;
		EventDelegate.s_Hash = s_Hash;
	}

	public static bool LoadCSV(TextAsset asset, bool merge = false)
	{
		//IL_0667: Expected I, but got Obj
		//IL_067d: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_01aa: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_06a8: Expected I, but got Obj
		//IL_06be: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_01d5: Expected I, but got Obj
		//IL_028b: Expected I, but got Obj
		//IL_071f: Expected I, but got Obj
		//IL_0735: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_023e: Expected I, but got Obj
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_036b: Expected I, but got Obj
		//IL_03fa: Expected I, but got Obj
		//IL_0410: Expected Obj, but got I
		//IL_0523: Expected I, but got Obj
		//IL_0539: Expected Obj, but got I
		//IL_043b: Expected I, but got Obj
		//IL_0488: Expected I, but got Obj
		//IL_049e: Expected Obj, but got I
		//IL_0564: Expected I, but got Obj
		//IL_04c9: Expected I, but got Obj
		//IL_05cb: Expected I, but got Obj
		//IL_05e1: Expected Obj, but got I
		//IL_060c: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v161 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text;
		if (~(localizationHasBeenSet ? 1u : 0u) == 0)
		{
			text = null;
		}
		else
		{
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v114 (Il2CppClass<Localization>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v154 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (loadFunction != null)
			{
				nint num5 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v140 (Il2CppClass<Localization>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v148 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				text = (string)(object)loadFunction.EndInvoke((IAsyncResult)(object)"Localization");
			}
			else
			{
				TextAsset textAsset = Resources.Load<TextAsset>("Localization");
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v126 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v135 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				text = ((((ComputeShader)(object)textAsset).FindKernel((string)null) == 0) ? null : textAsset.ToString());
			}
			nint num9 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S1_v23 (Il2CppClass<Localization>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num10 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v29 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			localizationHasBeenSet = true;
		}
		nint num11 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v15 (Il2CppClass<Localization>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num12 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v109 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text2 = Get(text, merge);
		if (text2 != null)
		{
			return true;
		}
		TextAsset textAsset2;
		if ((object)asset == null || ((UnityEngine.Object)asset).m_CachedPtr == (IntPtr)0)
		{
			nint num13 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ S0_v91 (Il2CppClass<Localization>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num14 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v98 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			textAsset2 = (TextAsset)(object)mLanguage;
		}
		else
		{
			textAsset2 = asset;
		}
		if ((object)textAsset2 == null || ((UnityEngine.Object)textAsset2).m_CachedPtr == (IntPtr)0)
		{
			return false;
		}
		nint num15 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v27 (Il2CppClass<Localization>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num16 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v78 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text4;
		if (loadFunction != null)
		{
			nint num17 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v64 (Il2CppClass<Localization>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num18 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v72 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text3 = (string)(object)loadFunction.EndInvoke((IAsyncResult)textAsset2);
			text4 = text3;
		}
		else
		{
			TextAsset textAsset3 = Resources.Load<TextAsset>((string)(object)textAsset2);
			nint num19 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num20 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ S0_v59 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num21 = ((ComputeShader)(object)textAsset3).FindKernel((string)null);
			bool flag = num21 == 0;
			text4 = text;
			if (!flag)
			{
				string text5 = textAsset3.ToString();
				text4 = text5;
			}
		}
		if (text4 != null)
		{
			nint num22 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S0_v38 (Il2CppClass<Localization>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num23 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ S0_v44 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ReplaceKey((string)(object)textAsset2, text4);
			return true;
		}
		return false;
	}

	public static bool LoadCSV(byte[] bytes, bool merge = false)
	{
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00ae: Expected Obj, but got I4
		//IL_00b2: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		string added = ((TextAsset)(object)bytes).ToString();
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)ExtractStrings((BetterList<string>)(object)added, null, (Dictionary<string, int>)merge) != 0;
	}

	private static bool HasLanguage(string languageName)
	{
		//IL_01f2: Expected I, but got Obj
		//IL_0208: Expected Obj, but got I
		//IL_0448: Expected Obj, but got I4
		//IL_003a: Expected I, but got Obj
		//IL_0050: Expected Obj, but got I
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0233: Expected I, but got Obj
		//IL_039d: Expected Obj, but got I4
		//IL_0156: Expected I, but got Obj
		//IL_016c: Expected Obj, but got I
		//IL_007b: Expected I, but got Obj
		//IL_02cf: Expected I, but got Obj
		//IL_00c8: Expected I, but got Obj
		//IL_00de: Expected Obj, but got I
		//IL_0197: Expected I, but got Obj
		//IL_0109: Expected I, but got Obj
		bool result;
		if (languageName != null && languageName.m_stringLength != 0)
		{
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v58 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v94 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Dictionary<string, string[]> dictionary = mDictionary;
			object obj2 = dictionary.count - dictionary.freeCount;
			if (obj2 == null)
			{
				nint num3 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v85 (Il2CppClass<Localization>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S0_v90 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = LoadCSV((TextAsset)(object)languageName);
				bool flag2 = !flag;
				result = false;
				if (flag2)
				{
					goto IL_03f9;
				}
			}
			nint num5 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v72 (Il2CppClass<Localization>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v80 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Localize(languageName);
			if (text != null)
			{
				result = true;
				goto IL_03f9;
			}
		}
		nint num7 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v10 (Il2CppClass<Localization>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v51 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string> dictionary2 = mOldDictionary;
		object obj6 = dictionary2.count - dictionary2.freeCount;
		if ((nint)obj6 > 0)
		{
			result = true;
			goto IL_03f9;
		}
		nint num9 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v23 (Il2CppClass<Localization>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num10 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S0_v44 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		throw new IndexOutOfRangeException();
		IL_03f9:
		return result;
	}

	private static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge = false)
	{
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_00a4: Expected I4, but got Obj
		//IL_0045: Expected I4, but got Obj
		bool result;
		if (bytes == null)
		{
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v8 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogAssertion("Attempting to add a callback to a list that's null");
			result = false;
		}
		else
		{
			int num3 = default;
			object obj2 = default;
			int num4 = default;
			EventDelegate eventDelegate2 = default;
			while (true)
			{
				if (num3 < bytes.Length)
				{
					EventDelegate eventDelegate = ((List<EventDelegate>)(object)bytes).get_Item(num3);
					if (eventDelegate != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
						result = (byte)(int)eventDelegate != 0;
						if (obj2 != null)
						{
							break;
						}
					}
					num3 = num4 + 1;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				eventDelegate2.Set((EventDelegate.Callback)(object)asset);
				eventDelegate2.oneShot = merge;
				((List<EventDelegate>)(object)bytes).Add(eventDelegate2);
				result = (byte)(int)eventDelegate2 != 0;
				break;
			}
		}
		return result;
	}

	private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
		//IL_0383: Expected I, but got Obj
		//IL_0399: Expected Obj, but got I
		//IL_04ec: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03c4: Expected I, but got Obj
		//IL_042e: Expected Obj, but got I
		//IL_009d: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0230: Expected Obj, but got I4
		//IL_0230: Expected Obj, but got I
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected I4, but got Unknown
		//IL_015d: Expected I, but got Obj
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_02e6: Expected Obj, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		if (newLanguages[3] == null)
		{
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newLanguages @ L1 (System.String[])+8]");
			if ((UnityEngine.Object)0 == null)
			{
				object obj2 = newLanguages.Length;
				bool flag;
				if (newLanguages.Length != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v26+8]");
					flag = (nint)0 == 0;
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					if (newValues == null)
					{
						nint num3 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v74 (Il2CppClass<UnityEngine.Debug>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num4 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v80 (Il2CppClass<UnityEngine.Debug>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Debug.LogAssertion("Attempting to add a callback to a list that's null");
						return;
					}
					int num5 = 0;
					object obj4 = default;
					EventDelegate eventDelegate2 = default;
					object obj6 = default;
					while (true)
					{
						if (num5 < newValues.size)
						{
							EventDelegate eventDelegate = ((List<EventDelegate>)(object)newValues).get_Item(num5);
							if (eventDelegate != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
								if (obj4 != null)
								{
									break;
								}
							}
							int num6 = num5 + 1;
							num5 = num6;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [newLanguages @ L1 (System.String[])+8]");
						eventDelegate2.Set((MonoBehaviour)0, (string)newLanguages.Length);
						bool oneShot = (byte)(languageIndices & 1) != 0;
						eventDelegate2.oneShot = oneShot;
						if (newLanguages[0] != null)
						{
							string text = newLanguages[0];
							if (text.m_firstChar != '\0')
							{
								object obj5 = eventDelegate2 + 16;
								string text2 = newLanguages[0];
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
								obj5 = obj6;
								object obj7 = 0;
								string text3 = newLanguages[0];
								if ((nint)obj7 < (int)text3.m_firstChar)
								{
									object obj8 = newLanguages[0] + 16;
									object obj9 = obj7 << 2;
									object obj10 = obj8 + obj9;
									throw new ArrayTypeMismatchException();
								}
							}
						}
						((List<EventDelegate>)(object)newValues).Add(eventDelegate2);
						break;
					}
					return;
				}
			}
		}
		nint num7 = (nint)typeof(EventDelegate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v12 (Il2CppClass<EventDelegate>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num8 = (nint)typeof(EventDelegate);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v18 (Il2CppClass<EventDelegate>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag2 = LoadCSV((byte[])(object)newValues, (TextAsset)(object)newLanguages[2], (byte)(int)languageIndices != 0);
	}

	private unsafe static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected Obj, but got Unknown
		//IL_1193: Expected Obj, but got I4
		//IL_11a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ad: Expected Obj, but got Unknown
		//IL_11b6: Expected Obj, but got I4
		//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c4: Expected Obj, but got Unknown
		//IL_11cd: Expected Obj, but got I4
		//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected Obj, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_00ce: Expected I, but got Obj
		//IL_188a: Expected I, but got Obj
		//IL_18a0: Expected Obj, but got I
		//IL_0142: Expected I, but got Obj
		//IL_0158: Expected Obj, but got I
		//IL_0998: Expected I, but got Obj
		//IL_09ae: Expected Obj, but got I
		//IL_01d0: Expected I, but got Obj
		//IL_0183: Expected I, but got Obj
		//IL_09d9: Expected I, but got Obj
		//IL_02d3: Expected I, but got Obj
		//IL_02e9: Expected Obj, but got I
		//IL_0245: Expected I, but got Obj
		//IL_025b: Expected Obj, but got I
		//IL_0314: Expected I, but got Obj
		//IL_0361: Expected I, but got Obj
		//IL_0377: Expected Obj, but got I
		//IL_0286: Expected I, but got Obj
		//IL_03a2: Expected I, but got Obj
		//IL_03f4: Expected Obj, but got I4
		//IL_048b: Expected Obj, but got I4
		//IL_040c: Expected Obj, but got I
		//IL_04a8: Expected Obj, but got I
		//IL_04d1: Expected I, but got Obj
		//IL_04e7: Expected Obj, but got I
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138a: Expected Obj, but got Unknown
		//IL_0512: Expected I, but got Obj
		//IL_1302: Expected Obj, but got I
		//IL_1312: Expected Obj, but got I
		//IL_1323: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Expected Obj, but got Unknown
		//IL_1331: Unknown result type (might be due to invalid IL or missing references)
		//IL_1336: Expected Obj, but got Unknown
		//IL_055f: Expected I, but got Obj
		//IL_0575: Expected Obj, but got I
		//IL_1924: Expected I, but got Obj
		//IL_193a: Expected Obj, but got I
		//IL_139d: Expected I, but got Obj
		//IL_13ec: Expected Obj, but got I
		//IL_05a0: Expected I, but got Obj
		//IL_0c1f: Expected I, but got Obj
		//IL_0e14: Expected I, but got Obj
		//IL_0e2a: Expected Obj, but got I
		//IL_0c6c: Expected I, but got Obj
		//IL_0c82: Expected Obj, but got I
		//IL_1670: Unknown result type (might be due to invalid IL or missing references)
		//IL_1675: Expected Obj, but got Unknown
		//IL_16a6: Expected Obj, but got I
		//IL_16b6: Expected Obj, but got I
		//IL_16c6: Expected Obj, but got I
		//IL_16cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Expected Obj, but got Unknown
		//IL_16dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Expected Obj, but got Unknown
		//IL_16f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fa: Expected Obj, but got Unknown
		//IL_170b: Expected Obj, but got I4
		//IL_0e55: Expected I, but got Obj
		//IL_0cad: Expected I, but got Obj
		//IL_1163: Expected Obj, but got I4
		//IL_0ea2: Expected I, but got Obj
		//IL_0eb8: Expected Obj, but got I
		//IL_0d24: Expected Obj, but got I
		//IL_0fbe: Expected I, but got Obj
		//IL_0fd4: Expected Obj, but got I
		//IL_0ee3: Expected I, but got Obj
		//IL_10da: Expected I, but got Obj
		//IL_10f0: Expected Obj, but got I
		//IL_0fff: Expected I, but got Obj
		//IL_0f30: Expected I, but got Obj
		//IL_0f46: Expected Obj, but got I
		//IL_104c: Expected I, but got Obj
		//IL_1062: Expected Obj, but got I
		//IL_17d6: Expected I, but got Obj
		//IL_17ec: Expected Obj, but got I
		//IL_17f5: Expected Obj, but got I4
		//IL_180d: Expected I, but got Obj
		//IL_1823: Expected Obj, but got I
		//IL_0d81: Expected I, but got Obj
		//IL_0d97: Expected Obj, but got I
		//IL_111b: Expected I, but got Obj
		//IL_0f71: Expected I, but got Obj
		//IL_174e: Expected Obj, but got I4
		//IL_108d: Expected I, but got Obj
		//IL_0dc2: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 48;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 + 40;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		if (added != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			EventDelegate eventDelegate = default;
			object obj7 = eventDelegate + 8;
			obj7 = added;
			MonoBehaviour target = eventDelegate.target;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (UnityEngine.MonoBehaviour)+C]");
			if ((nint)0 > (nint)1)
			{
				((BetterList<>)(object)target).Sort((BetterList<T>.CompareFunc)null);
				nint num = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v37 (Il2CppClass<Localization>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num2 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v556 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text = mLanguage;
				if (mLanguage == null || text.m_stringLength == 0)
				{
					nint num3 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v540 (Il2CppClass<Localization>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num4 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v546 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					localizationHasBeenSet = false;
				}
				nint num5 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v47 (Il2CppClass<Localization>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num6 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v533 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (~(localizationHasBeenSet ? 1u : 0u) == 0)
				{
					if (languageIndices == null)
					{
						nint num7 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ S0_v519 (Il2CppClass<Localization>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num8 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ S0_v527 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (~(mMerging ? 1u : 0u) != 0)
						{
							goto IL_098a;
						}
					}
					nint num9 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S0_v319 (Il2CppClass<Localization>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num10 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v512 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mLanguages != null)
					{
						nint num11 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v328 (Il2CppClass<Localization>)+BA]");
						object obj13 = (nint)0 & (nint)0x200;
						if (obj13 != null)
						{
							nint num12 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ S0_v506 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string[] array = mLanguages;
						if (array.Length != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (UnityEngine.MonoBehaviour)+C]");
							if ((nint)obj14 < 0)
							{
								object obj15 = (nint)((UnityEngine.Object)target).m_CachedPtr + 16;
								object obj16 = obj14 << 2;
								object obj17 = obj15 + obj16;
								throw new ArrayTypeMismatchException();
							}
							object obj18 = 0;
							object obj20 = default;
							object obj29 = default;
							while (true)
							{
								object obj19 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v30 (UnityEngine.MonoBehaviour)+C]");
								if ((nint)obj19 >= 0)
								{
									break;
								}
								object obj21 = (nint)((UnityEngine.Object)target).m_CachedPtr + 16;
								object obj22 = obj20 << 2;
								object obj23 = obj21 + obj22;
								nint num13 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S1_v126 (Il2CppClass<Localization>)+BA]");
								object obj24 = (nint)0 & (nint)0x200;
								if (obj24 != null)
								{
									nint num14 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ S1_v220 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (!SelectLanguage((string)obj23))
								{
									nint num15 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S0_v361 (Il2CppClass<Localization>)+BA]");
									object obj25 = (nint)0 & (nint)0x200;
									if (obj25 != null)
									{
										nint num16 = (nint)typeof(Localization);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ S0_v494 (Il2CppClass<Localization>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									nint num17 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ S0_v366 (Il2CppClass<Localization>)+5C]");
									ref string[] array2 = ref *(string[]*)((nint)0 + (nint)12);
									string[] array3 = mLanguages;
									int newSize = array3.Length + 1;
									Array.Resize(ref array2, newSize);
									object obj26 = (nint)((UnityEngine.Object)target).m_CachedPtr + 16;
									object obj27 = obj20 << 2;
									object obj28 = obj26 + obj27;
									throw new ArrayTypeMismatchException();
								}
								obj20 = obj29 + 1;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ S3_v5 (Il2CppMethodInfo)+C]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ S3_v6+60]");
							object obj31 = 0;
							object obj32 = obj31;
							object obj33 = obj32 & 0x1FFF;
							object obj34 = obj33 + 113696;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v527 @ S4_v7 (should have been resolved before IL gen)");
							string text2 = null;
							while (true)
							{
								nint num19 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v62 (Il2CppClass<Localization>)+BA]");
								object obj35 = (nint)0 & (nint)0x200;
								if (obj35 != null)
								{
									nint num20 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v216 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string[] array4 = mLanguages;
								if ((nint)text2 >= array4.Length)
								{
									break;
								}
								nint num21 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ S0_v202 (Il2CppClass<Localization>)+BA]");
								object obj36 = (nint)0 & (nint)0x200;
								if (obj36 != null)
								{
									nint num22 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ S0_v210 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj37 = mLanguages + 16;
								object obj38 = (object)text2 << 2;
								object obj39 = obj37 + obj38;
								nint num23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ S4_v10 (Il2CppMethodInfo)+C]");
								object obj40 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ S4_v11+60]");
								object obj41 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ S4_v12+48]");
								object obj42 = 0;
								object obj43 = obj42 & 0x7FF;
								object obj44 = obj43 + 39195;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v570 @ S5_v10 (should have been resolved before IL gen)");
								string text3 = text2 + 1;
								text2 = text3;
								obj32 = 2;
							}
							string key = default;
							string text4 = default;
							while (true)
							{
								MonoBehaviour target2 = eventDelegate.target;
								if ((object)target2 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ S0_v70 (UnityEngine.MonoBehaviour)+C]");
								if ((nint)0 == 0)
								{
									break;
								}
								object obj45 = (nint)((UnityEngine.Object)target2).m_CachedPtr + 16;
								object obj46 = obj45;
								bool flag;
								if (obj45 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ S0_v183+8]");
									flag = (nint)0 == 0;
								}
								else
								{
									flag = true;
								}
								if (flag)
								{
									continue;
								}
								nint num24 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ S0_v188 (Il2CppClass<Localization>)+BA]");
								object obj47 = (nint)0 & (nint)0x200;
								if (obj47 != null)
								{
									nint num25 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ S0_v193 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								Set((string)(object)target2, key, text4);
								obj32 = 0;
							}
							nint num26 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ S0_v74 (Il2CppClass<Localization>)+BA]");
							object obj48 = (nint)0 & (nint)0x200;
							if (obj48 != null)
							{
								nint num27 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ S0_v169 (Il2CppClass<Localization>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (~(mMerging ? 1u : 0u) != 0)
							{
								nint num28 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ S0_v127 (Il2CppClass<Localization>)+BA]");
								object obj49 = (nint)0 & (nint)0x200;
								if (obj49 != null)
								{
									nint num29 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v870 @ S0_v163 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (onLocalize != null)
								{
									nint num30 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v918 @ S0_v135 (Il2CppClass<Localization>)+BA]");
									object obj50 = (nint)0 & (nint)0x200;
									if (obj50 != null)
									{
										nint num31 = (nint)typeof(Localization);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v964 @ S0_v157 (Il2CppClass<Localization>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									mMerging = true;
									nint num32 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ S0_v146 (Il2CppClass<Localization>)+5C]");
									object obj51 = (nint)0 + (nint)4;
									obj51 = 0;
									onLocalize();
									nint num33 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1020 @ S0_v151 (Il2CppClass<Localization>)+5C]");
									object obj52 = (nint)0 + (nint)4;
									obj52 = onLocalize;
									mMerging = false;
								}
							}
							if (languageIndices != null)
							{
								nint num34 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ S0_v87 (Il2CppClass<Localization>)+BA]");
								object obj53 = (nint)0 & (nint)0x200;
								if (obj53 != null)
								{
									nint num35 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ S0_v120 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								if (onLocalize != null)
								{
									nint num36 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ S0_v107 (Il2CppClass<Localization>)+BA]");
									object obj54 = (nint)0 & (nint)0x200;
									if (obj54 != null)
									{
										nint num37 = (nint)typeof(Localization);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ S0_v114 (Il2CppClass<Localization>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									onLocalize();
								}
								nint num38 = (nint)typeof(UIRoot);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ S0_v96 (Il2CppClass<UIRoot>)+BA]");
								object obj55 = (nint)0 & (nint)0x200;
								if (obj55 != null)
								{
									nint num39 = (nint)typeof(UIRoot);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1037 @ S0_v102 (Il2CppClass<UIRoot>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								((UIRoot)(object)"OnLocalize")._002Ector();
							}
							return (string[])1;
						}
					}
				}
				goto IL_098a;
			}
			return null;
		}
		return null;
		IL_098a:
		nint num40 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S0_v224 (Il2CppClass<Localization>)+BA]");
		object obj56 = (nint)0 & (nint)0x200;
		if (obj56 != null)
		{
			nint num41 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ S0_v309 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		throw new IndexOutOfRangeException();
	}

	private static bool SelectLanguage(string language)
	{
		//IL_010f: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v38 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string[] array = mLanguages;
		object obj2 = default;
		bool result;
		object obj7 = default;
		while (true)
		{
			bool flag = (nint)obj2 >= array.Length;
			result = false;
			if (flag)
			{
				break;
			}
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v18 (Il2CppClass<Localization>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v32 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = mLanguages + 16;
			object obj5 = obj2 << 2;
			object obj6 = obj4 + obj5;
			if ((string)obj6 != language)
			{
				result = true;
				break;
			}
			obj2 = obj7 + 1;
		}
		return result;
	}

	public static void Set(string languageName, Dictionary<string, string> dictionary)
	{
		//IL_0106: Expected I, but got Obj
		//IL_011c: Expected Obj, but got I
		//IL_0192: Expected Obj, but got I
		//IL_01a2: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_00b9: Expected I, but got Obj
		//IL_0053: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj != null;
		if (dictionary == null || dictionary.buckets == null)
		{
			if (flag)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v31 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = mReplacement.Remove(languageName);
			return;
		}
		if (flag)
		{
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v19 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S4_v4+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S4_v5+48]");
		object obj4 = 0;
		object obj5 = obj4 & 0x7FF;
		object obj6 = obj5 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v76 @ S5_v5 (should have been resolved before IL gen)");
	}

	public static void Set(string key, string value)
	{
		//IL_01f8: Expected I, but got Obj
		//IL_020e: Expected Obj, but got I
		//IL_022b: Expected I, but got Obj
		//IL_0269: Expected Obj, but got I
		//IL_028e: Expected I, but got Obj
		//IL_02a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(Localization);
		if (!flag)
		{
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v64 (Il2CppClass<Localization>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(Localization);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(Localization);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L2_v2 (Il2CppClass<Localization>)+5C]");
		object obj2 = (nint)0 + (nint)32;
		obj2 = key;
		((TooltipAttribute)(object)"Language")._002Ector(mLanguage);
		nint num4 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v16 (Il2CppClass<Localization>)+5C]");
		object obj3 = (nint)0 + (nint)16;
		obj3 = value;
		localizationHasBeenSet = true;
		mLanguageIndex = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static string Get(string key, bool warnIfMissing = true)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)ExtractStrings((BetterList<string>)(object)key, null, (Dictionary<string, int>)warnIfMissing);
	}

	public unsafe static string Format(string key, object[] parameters)
	{
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0173: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_0085: Expected I, but got Obj
		//IL_00d3: Expected I4, but got Obj
		//IL_00d3: Expected I4, but got Obj
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_028f: Expected I, but got Obj
		//IL_02a5: Expected Obj, but got I
		//IL_01b4: Expected I, but got Obj
		//IL_1003: Expected Obj, but got I4
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_0126: Expected I, but got Obj
		//IL_1610: Expected I, but got Obj
		//IL_1626: Expected Obj, but got I
		//IL_02d0: Expected I, but got Obj
		//IL_0242: Expected I, but got Obj
		//IL_05d7: Expected I, but got Obj
		//IL_05ed: Expected Obj, but got I
		//IL_04af: Expected I, but got Obj
		//IL_1117: Expected I, but got Obj
		//IL_112d: Expected Obj, but got I
		//IL_1215: Expected Obj, but got I4
		//IL_04fc: Expected I, but got Obj
		//IL_0512: Expected Obj, but got I
		//IL_0687: Expected I4, but got Obj
		//IL_0699: Expected I, but got Obj
		//IL_06af: Expected Obj, but got I
		//IL_0618: Expected I, but got Obj
		//IL_1170: Expected I, but got Obj
		//IL_1186: Expected Obj, but got I
		//IL_1190: Unknown result type (might be due to invalid IL or missing references)
		//IL_1195: Expected Obj, but got Unknown
		//IL_11bd: Expected I, but got Obj
		//IL_11d3: Expected Obj, but got I
		//IL_032b: Expected I, but got Obj
		//IL_053d: Expected I, but got Obj
		//IL_0378: Expected I, but got Obj
		//IL_038e: Expected Obj, but got I
		//IL_0735: Expected I, but got Obj
		//IL_074b: Expected Obj, but got I
		//IL_06da: Expected I, but got Obj
		//IL_097f: Expected I4, but got Obj
		//IL_0991: Expected I, but got Obj
		//IL_09a7: Expected Obj, but got I
		//IL_058a: Expected I, but got Obj
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected Obj, but got Unknown
		//IL_10cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d4: Expected Obj, but got Unknown
		//IL_10e1: Expected Obj, but got I4
		//IL_0421: Expected I, but got Obj
		//IL_0437: Expected Obj, but got I
		//IL_03b9: Expected I, but got Obj
		//IL_1680: Expected I, but got Obj
		//IL_1696: Expected Obj, but got I
		//IL_0776: Expected I, but got Obj
		//IL_0a2d: Expected I, but got Obj
		//IL_0a43: Expected Obj, but got I
		//IL_09d2: Expected I, but got Obj
		//IL_1240: Expected I, but got Obj
		//IL_1256: Expected Obj, but got I
		//IL_07c3: Expected I, but got Obj
		//IL_07d9: Expected Obj, but got I
		//IL_0462: Expected I, but got Obj
		//IL_091f: Expected I, but got Obj
		//IL_16c1: Expected I, but got Obj
		//IL_16d7: Expected Obj, but got I
		//IL_0a6e: Expected I, but got Obj
		//IL_0ccd: Expected I, but got Obj
		//IL_0ce3: Expected Obj, but got I
		//IL_0c72: Expected I, but got Obj
		//IL_0804: Expected I, but got Obj
		//IL_0abb: Expected I, but got Obj
		//IL_0ad1: Expected Obj, but got I
		//IL_0837: Expected I, but got Obj
		//IL_084d: Expected Obj, but got I
		//IL_0c17: Expected I, but got Obj
		//IL_1702: Expected I, but got Obj
		//IL_1718: Expected Obj, but got I
		//IL_0d0e: Expected I, but got Obj
		//IL_0afc: Expected I, but got Obj
		//IL_0d5b: Expected I, but got Obj
		//IL_0d71: Expected Obj, but got I
		//IL_0878: Expected I, but got Obj
		//IL_0b2f: Expected I, but got Obj
		//IL_0b45: Expected Obj, but got I
		//IL_0f2f: Expected I, but got Obj
		//IL_08ab: Expected I, but got Obj
		//IL_08c1: Expected Obj, but got I
		//IL_0d9c: Expected I, but got Obj
		//IL_1331: Unknown result type (might be due to invalid IL or missing references)
		//IL_1336: Expected Obj, but got Unknown
		//IL_134d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1352: Expected Obj, but got Unknown
		//IL_0b70: Expected I, but got Obj
		//IL_0de9: Expected I, but got Obj
		//IL_0dff: Expected Obj, but got I
		//IL_08ec: Expected I, but got Obj
		//IL_0ba3: Expected I, but got Obj
		//IL_0bb9: Expected Obj, but got I
		//IL_144c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1451: Expected Obj, but got Unknown
		//IL_1468: Unknown result type (might be due to invalid IL or missing references)
		//IL_146d: Expected Obj, but got Unknown
		//IL_0e78: Expected I, but got Obj
		//IL_0e8e: Expected Obj, but got I
		//IL_0e2a: Expected I, but got Obj
		//IL_0be4: Expected I, but got Obj
		//IL_1543: Unknown result type (might be due to invalid IL or missing references)
		//IL_1548: Expected Obj, but got Unknown
		//IL_155f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1564: Expected Obj, but got Unknown
		//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5d: Expected Obj, but got Unknown
		//IL_0eb9: Expected I, but got Obj
		//IL_0f0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Expected Obj, but got Unknown
		ref string[] reference2 = default;
		ref string reference = ref System.Runtime.CompilerServices.Unsafe.As<string[], string>(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference2, 4));
		reference = ref *(string*)null;
		reference2 = ref *(string[]*)null;
		string text = default;
		if (text == null || text.m_stringLength == 0)
		{
			text = null;
		}
		else
		{
			nint num = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Localization>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v465 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(localizationHasBeenSet ? 1u : 0u) != 0)
			{
				int num3 = UnityEngine.Random.Range((int)"Language", (int)"English");
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S1_v123 (Il2CppClass<Localization>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v128 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = LoadCSV((TextAsset)num3);
			}
			nint num6 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v27 (Il2CppClass<Localization>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v455 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mLanguages == null)
			{
				nint num8 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ S0_v444 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v451 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogException((Exception)(object)"No localization data present");
				text = null;
			}
			else
			{
				nint num10 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S0_v36 (Il2CppClass<Localization>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num11 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v439 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag2 = Reload();
				if (mLanguageIndex == -1)
				{
					int num12 = 0;
					while (true)
					{
						nint num13 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v393 (Il2CppClass<Localization>)+BA]");
						object obj6 = (nint)0 & (nint)0x200;
						if (obj6 != null)
						{
							nint num14 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ S0_v433 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						string[] array = mLanguages;
						if (num12 >= array.Length)
						{
							break;
						}
						nint num15 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v400 (Il2CppClass<Localization>)+BA]");
						object obj7 = (nint)0 & (nint)0x200;
						if (obj7 != null)
						{
							nint num16 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v427 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj8 = mLanguages + 16;
						int num17 = num12 << 2;
						object obj9 = obj8 + num17;
						if (!((string)obj9 != (string)flag2))
						{
							int num18 = num12 + 1;
							num12 = num18;
							continue;
						}
						nint num19 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ S0_v413 (Il2CppClass<Localization>)+BA]");
						object obj10 = (nint)0 & (nint)0x200;
						if (obj10 != null)
						{
							nint num20 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v419 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						mLanguageIndex = num12;
						break;
					}
				}
				nint num21 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ S0_v49 (Il2CppClass<Localization>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num22 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v384 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mLanguageIndex == -1)
				{
					nint num23 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v365 (Il2CppClass<Localization>)+BA]");
					object obj12 = (nint)0 & (nint)0x200;
					if (obj12 != null)
					{
						nint num24 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v378 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					mLanguageIndex = 0;
					nint num25 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ S0_v372 (Il2CppClass<Localization>)+5C]");
					object obj13 = (nint)0 + (nint)32;
					object obj14 = mLanguages + 16;
					obj13 = obj14;
					string message = string.ConcatArray((string[])(object)"Language not found: ", flag2 ? 1 : 0);
					nint num26 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ S1_v95 (Il2CppClass<UnityEngine.Debug>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num27 = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ S1_v100 (Il2CppClass<UnityEngine.Debug>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Debug.LogAssertion(message);
				}
				nint num28 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ S0_v59 (Il2CppClass<UICamera>)+BA]");
				object obj16 = (nint)0 & (nint)0x200;
				if (obj16 != null)
				{
					nint num29 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v360 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				KeyCode currentKey = UICamera.currentKey;
				object obj17 = currentKey - 1;
				if (currentKey != (KeyCode)1)
				{
					if ((nint)obj17 != 1)
					{
						goto IL_1232;
					}
					string key2 = string.ConcatArray((string[])(object)text, (int)" Controller");
					nint num30 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ S0_v269 (Il2CppClass<Localization>)+BA]");
					object obj18 = (nint)0 & (nint)0x200;
					if (obj18 != null)
					{
						nint num31 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v354 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mReplacement.TryGetValue(key2, out reference))
					{
						text = reference;
					}
					else
					{
						nint num32 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ S0_v278 (Il2CppClass<Localization>)+BA]");
						object obj19 = (nint)0 & (nint)0x200;
						if (obj19 != null)
						{
							nint num33 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v346 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (mLanguageIndex != -1)
						{
							nint num34 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ S0_v305 (Il2CppClass<Localization>)+BA]");
							object obj20 = (nint)0 & (nint)0x200;
							if (obj20 != null)
							{
								nint num35 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ S0_v341 (Il2CppClass<Localization>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (mDictionary.TryGetValue(key2, out reference2))
							{
								nint num36 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ S0_v314 (Il2CppClass<Localization>)+BA]");
								object obj21 = (nint)0 & (nint)0x200;
								if (obj21 != null)
								{
									nint num37 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ S0_v336 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string[] array2 = reference2;
								if (mLanguageIndex < array2.Length)
								{
									nint num38 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ S0_v323 (Il2CppClass<Localization>)+BA]");
									object obj22 = (nint)0 & (nint)0x200;
									if (obj22 != null)
									{
										nint num39 = (nint)typeof(Localization);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v873 @ S0_v331 (Il2CppClass<Localization>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									object obj23 = array2 + 16;
									int num40 = mLanguageIndex << 2;
									object obj24 = obj23 + num40;
									text = (string)obj24;
									goto IL_1049;
								}
							}
						}
						nint num41 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v673 @ S0_v288 (Il2CppClass<Localization>)+BA]");
						object obj25 = (nint)0 & (nint)0x200;
						if (obj25 != null)
						{
							nint num42 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ S0_v298 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (!mOldDictionary.TryGetValue(key2, out reference))
						{
							goto IL_1232;
						}
						text = reference;
					}
				}
				else
				{
					string key3 = string.ConcatArray((string[])(object)text, (int)" Mobile");
					nint num43 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S0_v175 (Il2CppClass<Localization>)+BA]");
					object obj26 = (nint)0 & (nint)0x200;
					if (obj26 != null)
					{
						nint num44 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S0_v260 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (mReplacement.TryGetValue(key3, out reference))
					{
						text = reference;
					}
					else
					{
						nint num45 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ S0_v184 (Il2CppClass<Localization>)+BA]");
						object obj27 = (nint)0 & (nint)0x200;
						if (obj27 != null)
						{
							nint num46 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ S0_v252 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (mLanguageIndex != -1)
						{
							nint num47 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ S0_v211 (Il2CppClass<Localization>)+BA]");
							object obj28 = (nint)0 & (nint)0x200;
							if (obj28 != null)
							{
								nint num48 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S0_v247 (Il2CppClass<Localization>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (mDictionary.TryGetValue(key3, out reference2))
							{
								nint num49 = (nint)typeof(Localization);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ S0_v220 (Il2CppClass<Localization>)+BA]");
								object obj29 = (nint)0 & (nint)0x200;
								if (obj29 != null)
								{
									nint num50 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ S0_v242 (Il2CppClass<Localization>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								string[] array3 = reference2;
								if (mLanguageIndex < array3.Length)
								{
									nint num51 = (nint)typeof(Localization);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ S0_v229 (Il2CppClass<Localization>)+BA]");
									object obj30 = (nint)0 & (nint)0x200;
									if (obj30 != null)
									{
										nint num52 = (nint)typeof(Localization);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ S0_v237 (Il2CppClass<Localization>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									object obj31 = array3 + 16;
									int num53 = mLanguageIndex << 2;
									object obj32 = obj31 + num53;
									text = (string)obj32;
									goto IL_1049;
								}
							}
						}
						nint num54 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ S0_v194 (Il2CppClass<Localization>)+BA]");
						object obj33 = (nint)0 & (nint)0x200;
						if (obj33 != null)
						{
							nint num55 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ S0_v204 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (!mOldDictionary.TryGetValue(key3, out reference))
						{
							goto IL_1232;
						}
						text = reference;
					}
				}
			}
		}
		goto IL_1049;
		IL_1049:
		return text;
		IL_1232:
		nint num56 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ S0_v68 (Il2CppClass<Localization>)+BA]");
		object obj34 = (nint)0 & (nint)0x200;
		if (obj34 != null)
		{
			nint num57 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v166 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (mReplacement.TryGetValue(text, out reference))
		{
			text = reference;
		}
		else
		{
			nint num58 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v77 (Il2CppClass<Localization>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num59 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S0_v158 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mLanguageIndex != -1)
			{
				nint num60 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S0_v103 (Il2CppClass<Localization>)+BA]");
				object obj36 = (nint)0 & (nint)0x200;
				if (obj36 != null)
				{
					nint num61 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ S0_v152 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (mDictionary.TryGetValue(text, out reference2))
				{
					nint num62 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ S0_v112 (Il2CppClass<Localization>)+BA]");
					object obj37 = (nint)0 & (nint)0x200;
					if (obj37 != null)
					{
						nint num63 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ S0_v147 (Il2CppClass<Localization>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string[] array4 = reference2;
					if (mLanguageIndex >= array4.Length)
					{
						object obj38 = array4 + 16;
						text = (string)obj38;
					}
					else
					{
						nint num64 = (nint)typeof(Localization);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ S0_v121 (Il2CppClass<Localization>)+BA]");
						object obj39 = (nint)0 & (nint)0x200;
						if (obj39 != null)
						{
							nint num65 = (nint)typeof(Localization);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ S0_v139 (Il2CppClass<Localization>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						object obj40 = array4 + 16;
						int num66 = mLanguageIndex << 2;
						object obj41 = obj40 + num66;
						string text2 = (string)obj41;
						bool flag3 = obj41 == null || text2.m_stringLength == 0;
						bool flag4 = !flag3;
						text = (string)obj41;
						if (!flag4)
						{
							object obj42 = reference2 + 16;
							text = (string)obj42;
						}
					}
					goto IL_1049;
				}
			}
			nint num67 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ S0_v87 (Il2CppClass<Localization>)+BA]");
			object obj43 = (nint)0 & (nint)0x200;
			if (obj43 != null)
			{
				nint num68 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v714 @ S0_v96 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (mOldDictionary.TryGetValue(text, out reference))
			{
				text = reference;
			}
		}
		goto IL_1049;
	}

	public static string Localize(string key)
	{
		//IL_0343: Expected I, but got Obj
		//IL_0359: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected Obj, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_018f: Expected I, but got Obj
		//IL_01a5: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_01d0: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v114 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mLanguageIndex = -1;
		Dictionary<string, string[]> dictionary = mDictionary;
		string result;
		if (dictionary.count != dictionary.freeCount)
		{
			nint num3 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v23 (Il2CppClass<Localization>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v108 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = mLanguages;
			int num5 = default;
			int num9 = default;
			while (true)
			{
				bool flag = num5 >= array.Length;
				result = null;
				if (flag)
				{
					break;
				}
				nint num6 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v34 (Il2CppClass<Localization>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v102 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj4 = mLanguages + 16;
				int num8 = num5 << 2;
				object obj5 = obj4 + num8;
				if (!((string)obj5 != key))
				{
					num5 = num9 + 1;
					continue;
				}
				nint num10 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v47 (Il2CppClass<Localization>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num11 = (nint)typeof(Localization);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v94 (Il2CppClass<Localization>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				throw new IndexOutOfRangeException();
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public static bool Exists(string key)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Localization>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)Format(key, null) != 0;
	}

	public static void Set(string language, string key, string text)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		//IL_0059: Invalid comparison between VT and I4
		//IL_0080: Expected I, but got Obj
		//IL_0096: Expected Obj, but got I
		//IL_04b0: Expected I4, but got Obj
		//IL_04b0: Expected I4, but got Obj
		//IL_04ca: Expected Obj, but got I
		//IL_04da: Expected Obj, but got I
		//IL_04ea: Expected Obj, but got I
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected Obj, but got Unknown
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected Obj, but got Unknown
		//IL_052d: Expected I, but got Obj
		//IL_0543: Expected Obj, but got I
		//IL_00c1: Expected I, but got Obj
		//IL_0242: Expected I, but got Obj
		//IL_0581: Expected Obj, but got I
		//IL_0591: Expected Obj, but got I
		//IL_05a1: Expected Obj, but got I
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected Obj, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected Obj, but got Unknown
		//IL_0132: Expected I, but got Obj
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_01d7: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (language.m_firstChar <= '\u0001')
		{
			return;
		}
		object obj3 = language.m_stringLength + 16;
		Type type = (Type)obj3;
		if (obj3 == null || type._impl == (RuntimeTypeHandle)(object)0)
		{
			return;
		}
		nint num = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v27 (Il2CppClass<Localization>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v124 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		BMSymbol symbol = NGUIText.GetSymbol(language, (int)key, (int)text);
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S2_v4 (Il2CppMethodInfo)+C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ S2_v5+60]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v6+44]");
		object obj7 = 0;
		object obj8 = obj7 & 0x1FFF;
		object obj9 = obj8 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v161 @ S3_v6 (should have been resolved before IL gen)");
		object obj10 = default;
		bool flag = (nint)obj10 > -1;
		nint num4 = (nint)typeof(Localization);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S1_v14 (Il2CppClass<Localization>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		bool flag2 = obj11 == null;
		if (flag)
		{
			if (!flag2)
			{
				nint num5 = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v118 (Il2CppClass<Localization>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S4_v8 (Il2CppMethodInfo)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S4_v9+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S4_v10+48]");
			object obj14 = 0;
			object obj15 = obj14 & 0x7FF;
			object obj16 = obj15 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S5_v5 (should have been resolved before IL gen)");
			if (key != null)
			{
				return;
			}
			object message = ((IConvertible)"Localization key '").ToType((Type)obj3, (IFormatProvider)(object)"' is already present");
			nint num7 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ S1_v52 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj17 = (nint)0 & (nint)0x200;
			if (obj17 != null)
			{
				nint num8 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ S1_v57 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogAssertion(message);
			return;
		}
		if (!flag2)
		{
			nint num9 = (nint)typeof(Localization);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v96 (Il2CppClass<Localization>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
	}

	static Localization()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
		throw new IndexOutOfRangeException();
	}
}
