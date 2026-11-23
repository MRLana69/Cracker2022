using System;
using System.Collections.Generic;
using Cpp2ILInjected;

public class CollectCoinsDummyData
{
	public class CollectCoinsDummy
	{
		public int index;

		public string name;

		public bool hasBeenCollected;

		public int fakeProgress;

		public override string ToString()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}

		public void Collected()
		{
			hasBeenCollected = true;
		}

		public bool ParseDummy(string rawDummyData)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Expected Obj, but got Unknown
			//IL_0066: Expected I4, but got Obj
			//IL_00fa: Expected I4, but got Obj
			//IL_0358: Expected Obj, but got I
			//IL_013f: Expected I4, but got Obj
			//IL_044f: Expected Obj, but got I
			//IL_047a: Expected Obj, but got I
			//IL_049f: Expected Obj, but got I
			//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Expected Obj, but got Unknown
			//IL_04d0: Expected Obj, but got I
			//IL_03c8: Expected I4, but got Obj
			//IL_02ec: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 - 16;
			object obj3 = obj + 8;
			_ = 0;
			string text = default;
			string[] array = text.Split(':');
			object obj10;
			object obj6;
			if (array.Length == 4)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				string text2 = default;
				if ((nint)0 != 1)
				{
					index = (int)text2;
					name = array[1];
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						string text3 = default;
						if ((nint)0 != 1)
						{
							hasBeenCollected = (byte)(int)text3 != 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							string text4 = default;
							if ((nint)0 != 1)
							{
								fakeProgress = (int)text4;
								goto IL_0376;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							text = text4;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							text = text3;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						text = array[2];
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					text = text2;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				object obj4 = default;
				object obj5 = default;
				bool flag = obj4 == obj5;
				bool flag2 = !flag;
				object obj7 = default;
				obj6 = obj7;
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj9 = default;
						object obj8 = obj9;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							obj10 = obj9;
							object obj11 = default;
							if (obj11 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
								object obj12 = obj9;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag3 = (nint)0 != 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								obj10 = 0;
								if (!flag3)
								{
									goto IL_02fa;
								}
							}
							goto IL_0439;
						}
					}
					goto IL_02fa;
				}
				goto IL_0366;
			}
			goto IL_041d;
			IL_02fa:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag4 = (nint)0 == 1;
			object obj13 = default;
			obj6 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			text = (string)0;
			if (!flag4)
			{
				goto IL_0366;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			obj10 = obj13;
			goto IL_0439;
			IL_041d:
			string text5 = "Unexpected number of parameters: " + text + ". Aborting parsing.";
			goto IL_0376;
			IL_0376:
			return array.Length == 4;
			IL_0366:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			goto IL_041d;
			IL_0439:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj3 + obj14;
			obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
			object obj16 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj17 + obj3;
			object obj19 = obj18 - 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
			object obj20 = -1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (byte)(int)obj19 != 0;
		}
	}

	private const char DATA_VALUE_SEPARATOR = ':';

	private const char DATA_CHUNK_SEPARATOR = ';';

	private static bool _dirty = false;

	private static bool _initialized = false;

	private static Dictionary<int, CollectCoinsDummy> _dummyData = null;

	private static Dictionary<int, CollectCoinsDummy> _defaultDummyList;

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

	public CollectCoinsDummyData(string rawData)
	{
		LoadCustomizationData(rawData);
	}

	public static Dictionary<int, CollectCoinsDummy> GetDummyData()
	{
		if (~(_initialized ? 1u : 0u) == 0)
		{
			return _dummyData;
		}
		return null;
	}

	private void LoadCustomizationData(string rawDummyData)
	{
		Dictionary<int, CollectCoinsDummy> dummyData = ((CollectCoinsDummyData)(object)rawDummyData).ParseDummyData(rawDummyData);
		_dummyData = dummyData;
		_initialized = true;
	}

	private Dictionary<int, CollectCoinsDummy> ParseDummyData(string rawData)
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v26 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>>)+4] (should have been resolved before IL gen)");
		object obj;
		if (rawData != null)
		{
			obj = 0;
			if (rawData._stringLength != 0)
			{
				goto IL_0123;
			}
		}
		obj = 1;
		goto IL_0123;
		IL_0136:
		Dictionary<int, CollectCoinsDummy> result = _defaultDummyList;
		goto IL_0131;
		IL_0131:
		return result;
		IL_0123:
		if (obj == null)
		{
			string[] array = rawData.Split(';');
			object obj2 = 0;
			Dictionary<int, CollectCoinsDummy> dictionary = default;
			CollectCoinsDummy collectCoinsDummy = default;
			while (true)
			{
				bool flag = (nint)obj2 >= array.Length;
				result = dictionary;
				if (flag)
				{
					break;
				}
				object obj3 = obj2 << 2;
				object obj4 = (object)array + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v27+10]");
				if (collectCoinsDummy.ParseDummy((string)0))
				{
					nint num3 = 0;
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S5_v6 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ S5_v7+4] (should have been resolved before IL gen)");
					object obj6 = obj2 + 1;
					obj2 = obj6;
					continue;
				}
				goto IL_0136;
			}
			goto IL_0131;
		}
		goto IL_0136;
	}

	public void DummyCollected(int index)
	{
		CollectCoinsDummy collectCoinsDummy = _dummyData.get_Item(index);
		collectCoinsDummy.hasBeenCollected = true;
		_dirty = true;
		PlayerInfo instance = PlayerInfo.Instance;
		instance.SaveIfDirty();
	}

	public string ToSerializedString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected Obj, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_0046: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @442");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj4 = obj + 40;
		obj = obj4;
		_ = 0;
		string text = string.Empty;
		object obj6 = default;
		object obj7 = default;
		string text3 = default;
		string text4 = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			object obj5 = obj + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			object obj8;
			if ((nint)0 != 1)
			{
				if (obj6 == null)
				{
					goto IL_02c3;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+34]");
				obj = 0;
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
						string text2;
						if (obj7 == null)
						{
							text2 = text;
						}
						else
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag = (nint)0 == 1;
							text2 = text3;
							if (flag)
							{
								goto IL_022a;
							}
						}
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								bool flag2 = (nint)0 != 1;
								text = text4;
								if (flag2)
								{
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
						text = text2;
						obj8 = obj9;
						goto IL_024b;
					}
				}
			}
			goto IL_022a;
			IL_024b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			if (obj10 != obj11)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_02c3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj8 = obj12;
			break;
			IL_022a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			obj8 = obj13;
			goto IL_024b;
			IL_02c3:
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3C3F");
			return text;
		}
		_ = 0;
		object obj15 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		string result = default;
		return result;
	}

	static CollectCoinsDummyData()
	{
		//IL_03bf: Expected Obj, but got I
		//IL_0039: Expected Obj, but got I
		//IL_0077: Expected Obj, but got I
		//IL_00ba: Expected Obj, but got I
		//IL_00f8: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_01bc: Expected Obj, but got I
		//IL_01fa: Expected Obj, but got I
		//IL_023d: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_02be: Expected Obj, but got I
		//IL_02fc: Expected Obj, but got I
		//IL_033f: Expected Obj, but got I
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v41 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>>)+4] (should have been resolved before IL gen)");
		_ = 0;
		_ = 0;
		_ = 0;
		nint num3 = 0;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S5_v3 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v70 @ S5_v4+4] (should have been resolved before IL gen)");
		_ = 1;
		_ = 0;
		_ = 0;
		nint num5 = 0;
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S5_v8 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ S5_v9+4] (should have been resolved before IL gen)");
		_ = 2;
		_ = 0;
		_ = 0;
		nint num7 = 0;
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S5_v13 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v128 @ S5_v14+4] (should have been resolved before IL gen)");
		_ = 3;
		_ = 48;
		_ = 1;
		nint num9 = 0;
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S5_v18 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v157 @ S5_v19+4] (should have been resolved before IL gen)");
		_ = 4;
		_ = 41;
		_ = 1;
		nint num11 = 0;
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S5_v23 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v186 @ S5_v24+4] (should have been resolved before IL gen)");
		_ = 5;
		_ = 35;
		_ = 1;
		nint num13 = 0;
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S5_v28 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v215 @ S5_v29+4] (should have been resolved before IL gen)");
		_ = 6;
		_ = 26;
		_ = 1;
		nint num15 = 0;
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S5_v33 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v244 @ S5_v34+4] (should have been resolved before IL gen)");
		_ = 7;
		_ = 22;
		_ = 1;
		nint num17 = 0;
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ S5_v38 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v273 @ S5_v39+4] (should have been resolved before IL gen)");
		_ = 8;
		_ = 14;
		_ = 1;
		nint num19 = 0;
		nint num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ S5_v43 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v302 @ S5_v44+4] (should have been resolved before IL gen)");
		_ = 9;
		_ = 7;
		_ = 1;
		nint num21 = 0;
		nint num22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S5_v48 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ S5_v49+4] (should have been resolved before IL gen)");
		_ = 10;
		_ = 2;
		_ = 1;
		nint num23 = 0;
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ S5_v53 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ S5_v54+4] (should have been resolved before IL gen)");
		_ = 10;
		_ = 2;
		_ = 1;
		nint num25 = 0;
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S5_v58 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ S5_v59+4] (should have been resolved before IL gen)");
		_ = 10;
		_ = 1;
		_ = 1;
		nint num27 = 0;
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ S5_v63 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v417 @ S5_v64+4] (should have been resolved before IL gen)");
		_ = 10;
		_ = 0;
		_ = 1;
		nint num29 = 0;
		nint num30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ S5_v68 (Il2CppRgctx<System.Collections.Generic.Dictionary`2<System.Int32, CollectCoinsDummyData+CollectCoinsDummy>>)+5C]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v445 @ S5_v69+4] (should have been resolved before IL gen)");
		Dictionary<int, CollectCoinsDummy> defaultDummyList = default;
		_defaultDummyList = defaultDummyList;
	}
}
