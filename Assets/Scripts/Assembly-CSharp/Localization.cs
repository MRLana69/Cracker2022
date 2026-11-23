using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public static class Localization
{
	public delegate byte[] LoadFunction(string path);

	public delegate void OnLocalizeNotification();

	public static LoadFunction loadFunction;

	public static OnLocalizeNotification onLocalize;

	public static bool localizationHasBeenSet = false;

	private static string[] mLanguages = null;

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
			if (~(localizationHasBeenSet ? 1u : 0u) != 0)
			{
				string value = PlayerPrefs.GetString("Language", "English");
				bool flag = LoadDictionary(value);
			}
			return mDictionary;
		}
		set
		{
			bool flag = value != null;
			localizationHasBeenSet = flag;
			mDictionary = value;
		}
	}

	public static string[] knownLanguages
	{
		get
		{
			if (~(localizationHasBeenSet ? 1u : 0u) != 0)
			{
				string value = PlayerPrefs.GetString("Language", "English");
				bool flag = LoadDictionary(value);
			}
			return mLanguages;
		}
	}

	public static string language
	{
		get
		{
			//IL_002a: Expected Obj, but got I4
			//IL_000e: Expected Obj, but got I4
			string text = mLanguage;
			object obj;
			if (mLanguage != null)
			{
				obj = 0;
				if (text._stringLength != 0)
				{
					goto IL_0090;
				}
			}
			obj = 1;
			goto IL_0090;
			IL_0090:
			if (obj != null)
			{
				string text2 = PlayerPrefs.GetString("Language", "English");
				mLanguage = text2;
				bool flag = LoadAndSelect(mLanguage);
			}
			return mLanguage;
		}
		set
		{
			if (mLanguage != value)
			{
				mLanguage = value;
				bool flag = LoadAndSelect(value);
			}
		}
	}

	public static bool isActive => true;

	private static bool LoadDictionary(string value)
	{
		//IL_00f7: Expected Obj, but got I4
		//IL_00db: Expected Obj, but got I4
		bool flag = (byte)(~(localizationHasBeenSet ? 1u : 0u)) != 0;
		bool flag2 = !flag;
		byte[] array = null;
		if (!flag2)
		{
			if (Localization.loadFunction == null)
			{
				TextAsset textAsset = Resources.Load<TextAsset>("Localization");
				bool flag3 = textAsset != null;
				bool flag4 = !flag3;
				array = null;
				if (!flag4)
				{
					byte[] bytes = textAsset.bytes;
					array = bytes;
				}
			}
			else
			{
				LoadFunction loadFunction = Localization.loadFunction;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v67.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				byte[] array2 = default;
				array = array2;
			}
			localizationHasBeenSet = true;
		}
		bool flag5 = LoadCSV(array);
		bool result = true;
		if (flag5)
		{
			goto IL_021e;
		}
		string text = default;
		object obj;
		if ((text != null && text._stringLength == 0) || text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_0228;
			}
		}
		obj = 1;
		goto IL_0228;
		IL_021e:
		return result;
		IL_0228:
		result = false;
		if (obj == null)
		{
			if (Localization.loadFunction == null)
			{
				TextAsset textAsset2 = Resources.Load<TextAsset>(text);
				if (textAsset2 != null)
				{
					byte[] bytes2 = textAsset2.bytes;
					array = bytes2;
				}
			}
			else
			{
				LoadFunction loadFunction2 = Localization.loadFunction;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				byte[] array3 = default;
				array = array3;
			}
			if (array == null)
			{
				return false;
			}
			Set(text, array);
			result = true;
		}
		goto IL_021e;
	}

	private static bool LoadAndSelect(string value)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_00e6: Expected Obj, but got I4
		object obj;
		if (value != null)
		{
			obj = 0;
			if (value._stringLength != 0)
			{
				goto IL_019e;
			}
		}
		obj = 1;
		goto IL_019e;
		IL_017c:
		bool result;
		return result;
		IL_019e:
		if (obj == null)
		{
			Dictionary<string, string[]> dictionary = mDictionary;
			if (dictionary._count == dictionary._freeCount)
			{
				bool flag = LoadDictionary(value);
				bool flag2 = !flag;
				result = false;
				if (flag2)
				{
					goto IL_017c;
				}
			}
			bool flag3 = SelectLanguage(value);
			result = true;
			if (flag3)
			{
				goto IL_017c;
			}
		}
		Dictionary<string, string> dictionary2 = mOldDictionary;
		object obj2 = dictionary2._count - dictionary2._freeCount;
		bool flag4 = (nint)obj2 > 0;
		result = true;
		if (!flag4)
		{
			throw new IndexOutOfRangeException();
		}
		goto IL_017c;
	}

	public static void Load(TextAsset asset)
	{
		ByteReader byteReader = default;
		byteReader._002Ector(asset);
		string name = asset.name;
		Dictionary<string, string> dictionary = byteReader.ReadDictionary();
		Set(name, dictionary);
	}

	public static void Set(string languageName, byte[] bytes)
	{
		ByteReader byteReader = default;
		byteReader.mBuffer = bytes;
		Dictionary<string, string> dictionary = byteReader.ReadDictionary();
		Set(languageName, dictionary);
	}

	public static void ReplaceKey(string key, string val)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_004b: Expected Obj, but got I
		object obj;
		if (val != null)
		{
			obj = 0;
			if (val._stringLength != 0)
			{
				goto IL_0086;
			}
		}
		obj = 1;
		goto IL_0086;
		IL_0086:
		if (obj == null)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v48 @ S5_v4+4] (should have been resolved before IL gen)");
		}
		else
		{
			bool flag = mReplacement.Remove(key);
		}
	}

	public static void ClearReplacements()
	{
		throw new IndexOutOfRangeException();
	}

	public static bool LoadCSV(TextAsset asset, bool merge = false)
	{
		byte[] bytes = asset.bytes;
		return LoadCSV(bytes, (TextAsset)(object)bytes, merge);
	}

	public static bool LoadCSV(byte[] bytes, bool merge = false)
	{
		return LoadCSV(bytes, (TextAsset)(object)bytes, merge);
	}

	private static bool HasLanguage(string languageName)
	{
		//IL_007f: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		string[] array = mLanguages;
		object obj = 0;
		bool flag;
		while (true)
		{
			flag = (nint)obj < array.Length;
			if (!flag)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)mLanguages + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v25+10]");
			if (!((string)0 != languageName))
			{
				break;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		return flag;
	}

	private unsafe static bool LoadCSV(byte[] bytes, TextAsset asset, bool merge = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected Obj, but got Unknown
		//IL_0a6e: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_0b0a: Expected Obj, but got I4
		//IL_027d: Expected Obj, but got I4
		//IL_0312: Expected Obj, but got I
		//IL_08fc: Expected Obj, but got I
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected Obj, but got Unknown
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b56: Expected Obj, but got Unknown
		//IL_034d: Expected I, but got Obj
		//IL_09ae: Expected Obj, but got I4
		//IL_0992: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 80;
		_ = 0;
		object obj3 = obj - -64;
		obj3 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		bool flag = bytes == null;
		bool result = false;
		ByteReader byteReader = default;
		BetterList<string> betterList;
		object obj4;
		if (!flag)
		{
			byteReader.mBuffer = bytes;
			betterList = byteReader.ReadCSV();
			bool flag2 = betterList.size < 2;
			result = false;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B21B");
				string text = mLanguage;
				if (mLanguage != null)
				{
					obj4 = 0;
					if (text._stringLength != 0)
					{
						goto IL_0aab;
					}
				}
				obj4 = 1;
				goto IL_0aab;
			}
		}
		goto IL_0aa6;
		IL_0aa6:
		return result;
		IL_0aab:
		if (obj4 != null)
		{
			localizationHasBeenSet = false;
		}
		if (!merge)
		{
		}
		string[] array = mLanguages;
		if (array.Length == 0)
		{
			throw new IndexOutOfRangeException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		bool flag3 = false;
		bool flag4 = betterList.size > (flag3 ? 1 : 0);
		bool flag5 = !flag4;
		int size = betterList.size;
		if (!flag5)
		{
			object obj5 = (flag3 ? 1u : 0u) << 2;
			object obj6 = (object)betterList.buffer + obj5;
			throw new ArrayTypeMismatchException();
		}
		object obj7 = default;
		string[] newLanguages;
		string[] array2 = default;
		object obj12 = default;
		while (true)
		{
			bool flag6 = size <= (nint)obj7;
			newLanguages = array2;
			if (flag6)
			{
				break;
			}
			object obj8 = obj7 << 2;
			object obj9 = (object)betterList.buffer + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ S0_v216+10]");
			if (!HasLanguage((string)0))
			{
				nint num = (nint)typeof(Localization);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ S0_v231 (Il2CppClass<Localization>)+5C]");
				ref string[] array3 = ref *(string[]*)((nint)0 + (nint)12);
				string[] array4 = mLanguages;
				int newSize = array4.Length + 1;
				Array.Resize(ref array3, newSize);
				object obj10 = obj7 << 2;
				object obj11 = (object)betterList.buffer + obj10;
				throw new ArrayTypeMismatchException();
			}
			obj7 = obj12 + 1;
			size = betterList.size;
		}
		nint num2 = 0;
		nint num3 = 0;
		IntPtr intPtr = num3;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ S4_v6 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>>)+4] (should have been resolved before IL gen)");
		object obj13 = 0;
		while (true)
		{
			string[] array5 = mLanguages;
			if (array5.Length <= (nint)obj13)
			{
				break;
			}
			object obj14 = obj13 << 2;
			object obj15 = (object)mLanguages + obj14;
			nint num4 = 0;
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ S5_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.Int32>>)+5C]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ S5_v6+4] (should have been resolved before IL gen)");
			object obj17 = obj13 + 1;
			obj13 = obj17;
		}
		Dictionary<string, int> languageIndices = default;
		while (true)
		{
			BetterList<string> betterList2 = byteReader.ReadCSV();
			if (betterList2 == null || betterList2.size == 0)
			{
				break;
			}
			string[] buffer = betterList2.buffer;
			string text2 = buffer[0];
			object obj18;
			if (buffer[0] != null)
			{
				obj18 = 0;
				if (text2._stringLength != 0)
				{
					goto IL_0c1e;
				}
			}
			obj18 = 1;
			goto IL_0c1e;
			IL_0c1e:
			if (obj18 == null)
			{
				AddCSV(betterList2, newLanguages, languageIndices);
			}
		}
		result = true;
		if (!mMerging)
		{
			bool flag7 = onLocalize == null;
			result = true;
			if (!flag7)
			{
				mMerging = true;
				OnLocalizeNotification onLocalizeNotification = onLocalize;
				onLocalize = null;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v621.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				onLocalize = onLocalizeNotification;
				mMerging = false;
				result = true;
			}
		}
		goto IL_0aa6;
	}

	private static void AddCSV(BetterList<string> newValues, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I4
		//IL_00b9: Expected Obj, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected Obj, but got Unknown
		//IL_0118: Expected Obj, but got I
		//IL_03f7: Expected Obj, but got I
		//IL_02cc: Expected Obj, but got I
		//IL_02f7: Expected Obj, but got I
		//IL_031c: Expected Obj, but got I
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		if (newValues.size < 2)
		{
			return;
		}
		string[] buffer = newValues.buffer;
		string text = buffer[0];
		object obj4;
		if (buffer[0] != null)
		{
			obj4 = 0;
			if (text._stringLength != 0)
			{
				goto IL_04d0;
			}
		}
		obj4 = 1;
		goto IL_04d0;
		IL_04d0:
		if (obj4 != null)
		{
			return;
		}
		string[] array = ExtractStrings(newValues, newLanguages, languageIndices);
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S3_v5 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String[]>>)+54]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v138 @ S3_v6+4] (should have been resolved before IL gen)");
		object obj7 = default;
		object obj6 = obj7 ^ -1;
		object obj8 = obj6 >> 31;
		if (obj8 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String[]>>)+5C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S5_v5+4] (should have been resolved before IL gen)");
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj10 = default;
		object obj11 = default;
		bool flag = obj10 != obj11;
		object obj13 = default;
		object obj12 = obj13;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj15 = default;
				object obj14 = obj15;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj16 = default;
					if (obj16 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj17 = (nint)0 << 2;
						object obj18 = obj3 + obj17;
						obj18 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj19 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj20 = (nint)0 << 2;
						object obj21 = obj20 + obj3;
						object obj22 = obj21 - 4;
						object obj23 = obj22;
						object obj24 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ S1_v51+E4] (should have been resolved before IL gen)");
						string text3 = default;
						string text2 = "Unable to add '" + buffer[0] + "' to the Localization dictionary.\n" + text3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj25 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj26 = obj15;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj12 = 0;
					if (flag2)
					{
						goto IL_04df;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj27 = default;
			obj12 = obj27;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj12 = obj27;
			}
		}
		goto IL_04df;
		IL_04df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private unsafe static string[] ExtractStrings(BetterList<string> added, string[] newLanguages, Dictionary<string, int> languageIndices)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected Ref, but got Unknown
		//IL_0248: Expected Obj, but got I4
		//IL_01d7: Expected Obj, but got I
		//IL_0213: Expected Obj, but got I4
		//IL_013f: Expected Obj, but got I
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		string[] result;
		if (newLanguages == null)
		{
			string[] array = mLanguages;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			int num = added.size;
			string[] array2 = default;
			int num2 = array2.Length + 1;
			if (added.size >= num2)
			{
				num = num2;
			}
			object obj3 = 1;
			bool flag = num <= (nint)obj3;
			result = array2;
			if (!flag)
			{
				object obj4 = obj3 << 2;
				object obj5 = (object)added.buffer + obj4;
				throw new ArrayTypeMismatchException();
			}
		}
		else
		{
			string[] buffer = added.buffer;
			if (!mDictionary.TryGetValue(buffer[0], out *(string[]*)(obj + 12)))
			{
				string[] array3 = mLanguages;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			}
			object obj6 = 0;
			if ((nint)obj6 < newLanguages.Length)
			{
				object obj7 = obj6 << 2;
				object obj8 = (object)newLanguages + obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v11+10]");
				int num3 = languageIndices.get_Item((string)0);
				object obj9 = obj6 + 1;
				object obj10 = obj9 << 2;
				object obj11 = (object)added.buffer + obj10;
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			result = (string[])0;
		}
		return result;
	}

	private static bool SelectLanguage(string language)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I
		mLanguageIndex = -1;
		Dictionary<string, string[]> dictionary = mDictionary;
		if (dictionary._count != dictionary._freeCount)
		{
			string[] array = mLanguages;
			int num = 0;
			while (num < array.Length)
			{
				int num2 = num << 2;
				object obj = mLanguages + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v37+10]");
				if ((string)0 == language)
				{
					throw new IndexOutOfRangeException();
				}
				int num3 = num + 1;
				num = num3;
			}
		}
		return false;
	}

	public static void Set(string languageName, Dictionary<string, string> dictionary)
	{
		mLanguage = languageName;
		PlayerPrefs.SetString("Language", mLanguage);
		mOldDictionary = dictionary;
		localizationHasBeenSet = true;
		mLanguageIndex = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public static void Set(string key, string value)
	{
		//IL_006f: Expected Obj, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_0048: Expected Obj, but got I
		//IL_0021: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v61 @ S5_v9+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num5 = 0;
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+5C]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v77 @ S5_v4+4] (should have been resolved before IL gen)");
		}
	}

	public unsafe static string Get(string key)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0697: Expected Obj, but got I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected Ref, but got Unknown
		//IL_00ff: Expected Obj, but got I
		//IL_061e: Expected Obj, but got I
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Ref, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Ref, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected Ref, but got Unknown
		//IL_012a: Expected I4, but got Obj
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected Ref, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Ref, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Ref, but got Unknown
		//IL_0250: Expected Obj, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected Ref, but got Unknown
		//IL_05f3: Expected Obj, but got I
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected Ref, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected Obj, but got Unknown
		//IL_02a4: Expected Obj, but got I
		//IL_039e: Expected Obj, but got I
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected Obj, but got Unknown
		//IL_03f2: Expected Obj, but got I
		//IL_04d5: Expected Obj, but got I
		//IL_05b5: Expected Obj, but got I
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected Obj, but got Unknown
		//IL_0531: Expected Obj, but got I
		//IL_057b: Expected Obj, but got I4
		//IL_06d3: Expected Obj, but got I
		//IL_055f: Expected Obj, but got I4
		//IL_0590: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		if (~(localizationHasBeenSet ? 1u : 0u) != 0)
		{
			string value = PlayerPrefs.GetString("Language", "English");
			bool flag = LoadDictionary(value);
		}
		string result;
		if (mLanguages == null)
		{
			result = null;
			goto IL_0652;
		}
		string text = language;
		bool flag2 = mLanguageIndex != -1;
		string text2 = null;
		if (!flag2)
		{
			while (true)
			{
				string[] array = mLanguages;
				if ((nint)text2 >= array.Length)
				{
					break;
				}
				object obj3 = (object)text2 << 2;
				object obj4 = (object)mLanguages + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v222+10]");
				if ((string)0 == text)
				{
					mLanguageIndex = (int)text2;
					break;
				}
				string text3 = text2 + 1;
				text2 = text3;
			}
		}
		if (mLanguageIndex == -1)
		{
			mLanguageIndex = 0;
			string[] array2 = mLanguages;
			mLanguage = array2[0];
		}
		UICamera.ControlScheme currentScheme = UICamera.currentScheme;
		object obj5 = currentScheme - 1;
		if (currentScheme != UICamera.ControlScheme.Touch)
		{
			if ((nint)obj5 != 1)
			{
				goto IL_042e;
			}
			string key2 = key + " Controller";
			if (!mReplacement.TryGetValue(key2, out *(string*)(obj + 12)))
			{
				if (mLanguageIndex != -1 && mDictionary.TryGetValue(key2, out *(string[]*)(obj + 8)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj6 = 0;
					int num = mLanguageIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ S1_v56+C]");
					if ((nint)num < (nint)0)
					{
						int num2 = mLanguageIndex << 2;
						object obj7 = obj6 + num2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v198+10]");
						result = (string)0;
						goto IL_0652;
					}
				}
				if (!mOldDictionary.TryGetValue(key2, out *(string*)(obj + 12)))
				{
					goto IL_042e;
				}
			}
		}
		else
		{
			string key3 = key + " Mobile";
			if (!mReplacement.TryGetValue(key3, out *(string*)(obj + 12)))
			{
				if (mLanguageIndex != -1 && mDictionary.TryGetValue(key3, out *(string[]*)(obj + 8)))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
					object obj8 = 0;
					int num3 = mLanguageIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ S1_v41+C]");
					if ((nint)num3 < (nint)0)
					{
						int num4 = mLanguageIndex << 2;
						object obj9 = obj8 + num4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ S0_v154+10]");
						result = (string)0;
						goto IL_0652;
					}
				}
				if (!mOldDictionary.TryGetValue(key3, out *(string*)(obj + 12)))
				{
					goto IL_042e;
				}
			}
		}
		goto IL_060e;
		IL_06b4:
		object obj10;
		bool flag3 = obj10 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v102+10]");
		result = (string)0;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ S0_v107+10]");
			result = (string)0;
		}
		goto IL_0652;
		IL_0652:
		return result;
		IL_060e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
		result = (string)0;
		goto IL_0652;
		IL_042e:
		if (mReplacement.TryGetValue(key, out *(string*)(obj + 12)))
		{
			goto IL_060e;
		}
		if (mLanguageIndex != -1 && mDictionary.TryGetValue(key, out *(string[]*)(obj + 8)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			object obj12 = 0;
			int num5 = mLanguageIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S1_v22+C]");
			if ((nint)num5 < (nint)0)
			{
				int num6 = mLanguageIndex << 2;
				object obj13 = obj12 + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v102+10]");
				string text4 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v102+10]");
				if ((nint)0 != 0)
				{
					obj10 = 0;
					if (text4._stringLength != 0)
					{
						goto IL_06b4;
					}
				}
				obj10 = 1;
				goto IL_06b4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S1_v22+10]");
			result = (string)0;
		}
		else
		{
			bool flag4 = mOldDictionary.TryGetValue(key, out *(string*)(obj + 12));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			string text5 = (string)0;
			if (!flag4)
			{
				text5 = key;
			}
			result = text5;
		}
		goto IL_0652;
	}

	public static string Format(string key, object[] parameters)
	{
		string format = Get(key);
		return string.Format(format, parameters);
	}

	public static string Localize(string key)
	{
		return Get(key);
	}

	public static bool Exists(string key)
	{
		//IL_005e: Expected Obj, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected Obj, but got Unknown
		//IL_00b7: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_0110: Expected Obj, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected Obj, but got Unknown
		//IL_0169: Expected Obj, but got I
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_018f: Expected I4, but got Obj
		if (~(localizationHasBeenSet ? 1u : 0u) != 0)
		{
			string text = PlayerPrefs.GetString("Language", "English");
			language = text;
		}
		string text2 = key + " Mobile";
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String[]>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		bool result = true;
		if (obj4 == null)
		{
			nint num3 = 0;
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ S3_v10+4] (should have been resolved before IL gen)");
			object obj7 = default;
			object obj6 = obj7 ^ -1;
			object obj8 = obj6 >> 31;
			result = true;
			if (obj8 == null)
			{
				nint num5 = 0;
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S3_v14 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String[]>>)+54]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S3_v15+4] (should have been resolved before IL gen)");
				object obj11 = default;
				object obj10 = obj11 ^ -1;
				object obj12 = obj10 >> 31;
				result = true;
				if (obj12 == null)
				{
					nint num7 = 0;
					nint num8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S3_v19 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>)+54]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v146 @ S3_v20+4] (should have been resolved before IL gen)");
					object obj15 = default;
					object obj14 = obj15 ^ -1;
					bool flag = (byte)(obj14 >> 31) != 0;
					result = flag;
				}
			}
		}
		return result;
	}

	static Localization()
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v37 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> dictionary = default;
		mOldDictionary = dictionary;
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v63 @ S4_v9 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String[]>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string[]> dictionary2 = default;
		mDictionary = dictionary2;
		nint num5 = 0;
		nint num6 = 0;
		IntPtr intPtr3 = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ S4_v14 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.String, System.String>>>)+4] (should have been resolved before IL gen)");
		Dictionary<string, string> dictionary3 = default;
		mReplacement = dictionary3;
		mLanguageIndex = -1;
		mMerging = false;
	}
}
