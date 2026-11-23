using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class HoverboardCustomizationData
{
	private class CustomizationData
	{
		public bool ownsTheme;

		public bool isThemeActive;

		public bool themeHasBeenSeen;

		public unsafe override string ToString()
		{
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			bool flag = (byte)(this + 8) != 0;
			string text = (flag ? ((bool*)1) : ((bool*)null))->ToString();
			throw new ArrayTypeMismatchException();
		}
	}

	public const int MAX_THEMES_PER_BOARD = 2;

	private const char DATA_CHUNK_SEPARATOR = ';';

	private const char DATA_ASSIGNATION_SEPARATOR = '=';

	private const char DATA_VALUE_GROUP_SEPARATOR = ',';

	private const char DATA_VALUE_SEPARATOR = ':';

	private const char DATA_THEME_IDENTIFIER_SEPARATOR = '#';

	private bool _dirty;

	private Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> _customizationData;

	public bool IsDirty
	{
		get
		{
			return _dirty;
		}
		private set
		{
		}
	}

	public HoverboardCustomizationData(string boardCustomizationData)
	{
		LoadCustomizationData(boardCustomizationData);
	}

	private void LoadCustomizationData(string boardCustmoizationData)
	{
		Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> customizationData = ParseCustomizationData(boardCustmoizationData);
		_customizationData = customizationData;
	}

	private Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> ParseCustomizationData(string rawData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected Obj, but got Unknown
		//IL_0038: Expected Obj, but got I4
		//IL_001c: Expected Obj, but got I4
		//IL_005d: Expected Obj, but got I4
		//IL_00f5: Expected Obj, but got I
		//IL_00fa: Expected I, but got Obj
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected Obj, but got Unknown
		//IL_0153: Expected Obj, but got I
		//IL_0158: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_01a8: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_01f8: Expected I, but got Obj
		//IL_0243: Expected Obj, but got I
		//IL_0248: Expected I, but got Obj
		//IL_04ba: Expected Obj, but got I
		//IL_04e5: Expected Obj, but got I
		//IL_050a: Expected Obj, but got I
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_056c: Expected Obj, but got I
		//IL_0293: Expected Obj, but got I
		//IL_0298: Expected I, but got Obj
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fd: Expected Obj, but got Unknown
		//IL_02e3: Expected Obj, but got I
		//IL_02e8: Expected I, but got Obj
		//IL_0333: Expected Obj, but got I
		//IL_0338: Expected I, but got Obj
		//IL_0386: Expected Obj, but got I
		//IL_039c: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>>)+4…");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v36 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>>)+4] (shoul…");
		object obj4;
		if (rawData != null)
		{
			obj4 = 0;
			if (rawData._stringLength != 0)
			{
				goto IL_06dc;
			}
		}
		obj4 = 1;
		goto IL_06dc;
		IL_06dc:
		if (obj4 == null)
		{
			string[] array = rawData.Split(';');
			object obj27;
			object obj8 = default;
			object obj11;
			nint num4;
			object obj10 = default;
			object obj12 = default;
			object obj13 = default;
			Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> dictionary = default;
			object obj15 = default;
			object obj16 = default;
			string text2 = default;
			Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> dictionary2 = default;
			for (object obj5 = 0; (nint)obj5 < array.Length; obj27 = obj5 + 1, obj8 = obj11, obj5 = obj27, num3 = num4)
			{
				object obj6 = obj5 << 2;
				object obj7 = (object)array + obj6;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj8 = 0;
					num3 = unchecked((nint)null);
					if (!flag)
					{
						_ = 0;
						object obj9 = obj10 + 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj8 = 0;
						num3 = unchecked((nint)null);
						if (!flag2)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag3 = (nint)0 == 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj8 = 0;
							num3 = unchecked((nint)null);
							if (!flag3)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag4 = (nint)0 == 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								obj8 = 0;
								num3 = unchecked((nint)null);
								if (!flag4)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									bool flag5 = (nint)0 == 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									obj8 = 0;
									num3 = unchecked((nint)null);
									if (!flag5)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag6 = (nint)0 == 1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										obj8 = 0;
										num3 = unchecked((nint)null);
										if (!flag6)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag7 = (nint)0 == 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											obj8 = 0;
											num3 = unchecked((nint)null);
											if (!flag7)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag8 = (nint)0 == 1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												obj8 = 0;
												num3 = unchecked((nint)null);
												if (!flag8)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													bool flag9 = (nint)0 != 1;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													obj8 = 0;
													num3 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													obj11 = 0;
													num4 = 0;
													if (flag9)
													{
														continue;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag10 = obj12 != obj13;
				Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> result = dictionary;
				if (!flag10)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj14 = obj15;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
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
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v381 @ S1_v56+D4] (should have been resolved before IL gen)");
								string text = "HoverboardCustomizationData parse failed for item ERROR = " + text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj25 = -1;
								obj11 = obj8;
								num4 = num3;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj26 = obj15;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								break;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag11 = (nint)0 != 1;
					result = dictionary2;
					if (!flag11)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						break;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				return result;
			}
		}
		Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> result2 = default;
		return result2;
	}

	private Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> GetCustomizationValues(string rawValues)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_0056: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_00e9: Expected Obj, but got I
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_01aa: Expected VT, but got Obj
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+4] (should have been resolved before IL gen)");
		object obj;
		if (rawValues != null)
		{
			obj = 0;
			if (rawValues._stringLength != 0)
			{
				goto IL_0245;
			}
		}
		obj = 1;
		goto IL_0245;
		IL_0245:
		if (obj == null)
		{
			string[] array = rawValues.Split(',');
			object obj2 = array.Length - 1;
			bool flag = (nint)obj2 <= 1;
			bool flag2 = !flag;
			object obj3 = 0;
			if (!flag2)
			{
				while ((nint)obj3 < array.Length)
				{
					object obj4 = obj3 << 2;
					object obj5 = (object)array + obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v26+10]");
					string[] array2 = ((string)0).Split('#');
					string[] array3 = array2[1].Split(':');
					if (array3.Length == 3)
					{
						bool flag3 = bool.Parse(array3[0]);
						bool flag4 = bool.Parse(array3[1]);
						bool flag5 = bool.Parse(array3[2]);
						Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(HoverboardThemes.ThemeIdentifier));
						object obj6 = Enum.Parse(typeFromHandle, array2[0]);
						throw new NullReferenceException();
					}
					object obj7 = obj3 + 1;
					obj3 = obj7;
				}
				Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> result = default;
				return result;
			}
		}
		return null;
	}

	public bool IsThemeOwned(Hoverboards.BoardType boardType, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0047: Expected Obj, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected Obj, but got Unknown
		bool result = true;
		if (!Globals.DEBUG_ALL_BOARDS)
		{
			bool flag = themeId == HoverboardThemes.ThemeIdentifier.none;
			result = false;
			if (!flag)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+54]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S3_v5+4] (should have been resolved before IL gen)");
				object obj3 = default;
				object obj2 = obj3 ^ -1;
				object obj4 = obj2 >> 31;
				bool flag2 = obj4 == null;
				result = false;
				if (!flag2)
				{
					Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary = _customizationData.get_Item(boardType);
					bool flag3 = dictionary == null;
					result = false;
					if (!flag3)
					{
						nint num3 = 0;
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+54]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v87 @ S3_v10+4] (should have been resolved before IL gen)");
						object obj7 = default;
						object obj6 = obj7 ^ -1;
						object obj8 = obj6 >> 31;
						bool flag4 = obj8 == null;
						result = false;
						if (!flag4)
						{
							CustomizationData customizationData = dictionary.get_Item(themeId);
							bool ownsTheme = customizationData.ownsTheme;
							result = ownsTheme;
						}
					}
				}
			}
		}
		return result;
	}

	public bool IsThemeActive(Hoverboards.BoardType boardType, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		bool flag = themeId == HoverboardThemes.ThemeIdentifier.none;
		bool result = false;
		if (!flag)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			bool flag2 = obj4 == null;
			result = false;
			if (!flag2)
			{
				Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary = _customizationData.get_Item(boardType);
				bool flag3 = dictionary == null;
				result = false;
				if (!flag3)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+54]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S3_v10+4] (should have been resolved before IL gen)");
					object obj7 = default;
					object obj6 = obj7 ^ -1;
					object obj8 = obj6 >> 31;
					bool flag4 = obj8 == null;
					result = false;
					if (!flag4)
					{
						CustomizationData customizationData = dictionary.get_Item(themeId);
						bool isThemeActive = customizationData.isThemeActive;
						result = isThemeActive;
					}
				}
			}
		}
		return result;
	}

	public bool HasThemeBeenSeen(Hoverboards.BoardType boardType, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected Obj, but got Unknown
		bool flag = themeId == HoverboardThemes.ThemeIdentifier.none;
		bool result = false;
		if (!flag)
		{
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+54]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v5+4] (should have been resolved before IL gen)");
			object obj3 = default;
			object obj2 = obj3 ^ -1;
			object obj4 = obj2 >> 31;
			bool flag2 = obj4 == null;
			result = false;
			if (!flag2)
			{
				Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary = _customizationData.get_Item(boardType);
				bool flag3 = dictionary == null;
				result = false;
				if (!flag3)
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v9 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+54]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v78 @ S3_v10+4] (should have been resolved before IL gen)");
					object obj7 = default;
					object obj6 = obj7 ^ -1;
					object obj8 = obj6 >> 31;
					bool flag4 = obj8 == null;
					result = false;
					if (!flag4)
					{
						CustomizationData customizationData = dictionary.get_Item(themeId);
						bool themeHasBeenSeen = customizationData.themeHasBeenSeen;
						result = themeHasBeenSeen;
					}
				}
			}
		}
		return result;
	}

	public void SetThemeAcquired(Hoverboards.BoardType boardType, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_002c: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		if (themeId == HoverboardThemes.ThemeIdentifier.none)
		{
			return;
		}
		_dirty = true;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary = _customizationData.get_Item(boardType);
			if (dictionary != null)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S3_v17 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+54]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S3_v18+4] (should have been resolved before IL gen)");
				object obj7 = default;
				object obj6 = obj7 ^ -1;
				object obj8 = obj6 >> 31;
				if (obj8 != null)
				{
					Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary2 = _customizationData.get_Item(boardType);
					CustomizationData customizationData = dictionary2.get_Item(themeId);
					_ = 1;
					_ = customizationData.isThemeActive;
					_ = customizationData.themeHasBeenSeen;
					Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary3 = _customizationData.get_Item(boardType);
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ S5_v19+4] (should have been resolved before IL gen)");
					return;
				}
			}
			_ = 1;
			_ = 1;
			Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary4 = _customizationData.get_Item(boardType);
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ S5_v14+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num9 = 0;
			nint num10 = 0;
			IntPtr intPtr = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+4] (should have been resolved before IL gen)");
			_ = 1;
			_ = 1;
			nint num11 = 0;
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S5_v4+4] (should have been resolved before IL gen)");
			nint num13 = 0;
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+5C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ S5_v9+4] (should have been resolved before IL gen)");
		}
	}

	public void SetThemeActive(Hoverboards.BoardType boardType, HoverboardThemes.ThemeIdentifier themeId, bool active)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		//IL_00d3: Expected Obj, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_01f4: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 48;
		if (themeId == HoverboardThemes.ThemeIdentifier.none)
		{
			return;
		}
		_dirty = true;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S3_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+54]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v39 @ S3_v5+4] (should have been resolved before IL gen)");
		object obj5 = default;
		object obj4 = obj5 ^ -1;
		object obj6 = obj4 >> 31;
		if (obj6 != null)
		{
			Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary = _customizationData.get_Item(boardType);
			if (dictionary != null)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S3_v10 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+54]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v133 @ S3_v11+4] (should have been resolved before IL gen)");
				object obj9 = default;
				object obj8 = obj9 ^ -1;
				object obj10 = obj8 >> 31;
				if (obj10 != null)
				{
					Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary2 = _customizationData.get_Item(boardType);
					CustomizationData customizationData = dictionary2.get_Item(themeId);
					if (~(customizationData.ownsTheme ? 1u : 0u) == 0 || ~(Globals.DEBUG_ALL_BOARDS ? 1u : 0u) == 0)
					{
						Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary3 = _customizationData.get_Item(boardType);
						CustomizationData customizationData2 = dictionary3.get_Item(themeId);
						_ = customizationData2.ownsTheme;
						_ = customizationData2.themeHasBeenSeen;
						Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary4 = _customizationData.get_Item(boardType);
						nint num5 = 0;
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S5_v4 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v341 @ S5_v5+4] (should have been resolved before IL gen)");
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
					throw new ArrayTypeMismatchException();
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void SetThemeSeen(Hoverboards.BoardType boardType, HoverboardThemes.ThemeIdentifier themeId)
	{
		//IL_002c: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_0216: Expected Obj, but got I
		//IL_023c: Expected Obj, but got I
		//IL_01c0: Expected Obj, but got I
		//IL_00bb: Expected Obj, but got I
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_0175: Expected Obj, but got I
		if (themeId == HoverboardThemes.ThemeIdentifier.none)
		{
			return;
		}
		_dirty = true;
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v30 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		object obj4 = obj2 >> 31;
		if (obj4 != null)
		{
			Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary = _customizationData.get_Item(boardType);
			if (dictionary != null)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S3_v17 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+54]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S3_v18+4] (should have been resolved before IL gen)");
				object obj7 = default;
				object obj6 = obj7 ^ -1;
				object obj8 = obj6 >> 31;
				if (obj8 != null)
				{
					Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary2 = _customizationData.get_Item(boardType);
					CustomizationData customizationData = dictionary2.get_Item(themeId);
					_ = customizationData.ownsTheme;
					_ = 1;
					_ = customizationData.isThemeActive;
					Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary3 = _customizationData.get_Item(boardType);
					nint num5 = 0;
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ S5_v19+4] (should have been resolved before IL gen)");
					return;
				}
			}
			_ = 1;
			_ = 0;
			Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData> dictionary4 = _customizationData.get_Item(boardType);
			nint num7 = 0;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v200 @ S5_v14+4] (should have been resolved before IL gen)");
		}
		else
		{
			nint num9 = 0;
			nint num10 = 0;
			IntPtr intPtr = num10;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v111 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+4] (should have been resolved before IL gen)");
			_ = 1;
			_ = 0;
			nint num11 = 0;
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+5C]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v159 @ S5_v4+4] (should have been resolved before IL gen)");
			nint num13 = 0;
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>>)+5C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ S5_v9+4] (should have been resolved before IL gen)");
		}
	}

	public unsafe string ToSerializedString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0a10: Expected Obj, but got I
		//IL_0a23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected Obj, but got Unknown
		//IL_0a62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Expected Obj, but got Unknown
		//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b92: Expected Obj, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b1: Expected Obj, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected Obj, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected I4, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Expected Obj, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae1: Expected Obj, but got Unknown
		//IL_0534: Expected Obj, but got I4
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected Obj, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected Obj, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Expected Obj, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected Obj, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected Obj, but got Unknown
		//IL_0468: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 128;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Dictionary<Hoverboards.BoardType, Dictionary<HoverboardThemes.ThemeIdentifier, CustomizationData>> customizationData = _customizationData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v17 (System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v17 (System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.Dictionary`2<HoverboardThemes+ThemeIdentifier, HoverboardCustomizationData+CustomizationData>>)+18]");
		object obj3 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj4 = obj + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj5 = obj + 104;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		object obj7 = default;
		object obj11 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		string text;
		string text2 = default;
		object obj21 = default;
		string text3 = default;
		object obj23 = default;
		string text4 = default;
		object obj24 = default;
		string text5 = default;
		string[] array = default;
		object obj32 = default;
		string result = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj20;
			if ((nint)0 != 1)
			{
				if (obj7 == null)
				{
					goto IL_08a3;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+74]");
				_ = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
					_ = 0;
					_ = 0;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									object obj8 = obj + 24;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BE7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+28]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+20]");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
										_ = 0;
										object obj9 = obj + 72;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
										_ = 0;
										while (true)
										{
											_ = 0;
											object obj10 = obj + 72;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 == 1)
											{
												break;
											}
											if (obj11 != null)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+54]");
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
												_ = 0;
												_ = 0;
												object obj12 = obj - -64;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = -1;
												_ = typeof(HoverboardThemes.ThemeIdentifier);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+3C]");
												_ = 0;
												_ = 0;
												object obj13 = obj + 24;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												object obj14 = obj - -64;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 == 1)
												{
													break;
												}
												object obj15 = 0 << 2;
												object obj16 = obj17 + obj15;
												continue;
											}
											goto IL_052b;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
										bool flag = obj18 != obj19;
										obj20 = obj18;
										text = text2;
										if (!flag)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												text = null;
												goto IL_0b19;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
											obj20 = obj21;
											text = text3;
										}
										_ = 0;
										object obj22 = obj + 8;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 == 1)
										{
											goto IL_097e;
										}
										goto IL_0bc7;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0835;
			IL_0835:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj20 = obj23;
			text = text4;
			goto IL_0bc7;
			IL_0bc7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj24 == obj20)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_08a3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				text = text5;
			}
			_ = 0;
			object obj25 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
				break;
			}
			goto IL_097e;
			IL_052b:
			text = (string)6;
			goto IL_0b19;
			IL_08a3:
			object obj26 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @52A3");
			_ = 59;
			char c = (char)(obj + 58);
			string separator = ((char*)(ushort)c)->ToString();
			string text6 = string.Join(separator, array);
			text = text6;
			break;
			IL_0b19:
			_ = 0;
			object obj27 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag2 = (nint)text != 6;
				if (text == null)
				{
					flag2 = false;
				}
				if (flag2)
				{
					object obj28 = obj + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @52A3");
					break;
				}
				_ = 44;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					object obj29 = obj + 58;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
								_ = 0;
								_ = -1;
								_ = typeof(Hoverboards.BoardType);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
								_ = 0;
								_ = 0;
								object obj30 = obj + 24;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											object obj31 = obj32 << 2;
											object obj33 = (object)array + obj31;
											continue;
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0835;
			IL_097e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return result;
		}
		return text;
	}

	public bool DoesBoardHaveThemes(Hoverboards.BoardType boardType)
	{
		//IL_0021: Expected Obj, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		nint num = 0;
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S3_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<Hoverboards+BoardType, System.Collections.Generic.List`1<HoverboardThemes+HoverboardTheme>>>)+54]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v28 @ S3_v4+4] (should have been resolved before IL gen)");
		object obj3 = default;
		object obj2 = obj3 ^ -1;
		return (byte)(obj2 >> 31) != 0;
	}

	public bool AreAllNewThemesSeenForBoard(Hoverboards.BoardType boardType)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_005c: Expected Obj, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected Obj, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected I4, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0123: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		object obj3 = obj + 16;
		List<HoverboardThemes.HoverboardTheme> list = HoverboardThemes.hoverboardCustomThemes.get_Item(boardType);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B5");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		object obj4 = obj + 32;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj5 = 1;
		object obj7 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj14 = default;
		object obj15 = default;
		while (true)
		{
			_ = 0;
			object obj6 = obj + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj7 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+2C]");
				object obj8 = 0;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v71+18]");
					if ((nint)0 == 0)
					{
						continue;
					}
					object obj9 = obj5 & 1;
					if (obj9 == null)
					{
						obj5 = 0;
						continue;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						obj5 = obj10;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj11 == obj12;
			bool flag2 = !flag;
			object obj13 = obj14;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj13 = obj15;
			}
			_ = 0;
			object obj16 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
		}
		object obj17 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A71");
		return (byte)(obj5 & 1) != 0;
	}
}
