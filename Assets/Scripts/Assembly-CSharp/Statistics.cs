using System;
using System.Collections;
using Cpp2ILInjected;
using UnityEngine;

public class Statistics
{
	public delegate void StatChangedDelegate(Stat stat, int newValue);

	public delegate void TempStatChangedDelegate(TempStat tempStat, int newValue);

	public bool dirty;

	private int[] _values;

	private StatChangedDelegate[] _statChangedHandlers;

	private int[] _tempStatValues;

	private TempStatChangedDelegate[] _tempStatChangedHandlers;

	// C# has no syntax for parameterized property 'Item'.
	public int get_Item(Stat stat)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = (int)stat << 2;
		object obj2 = (object)_values + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v3+10]");
		return 0;
	}

	public void set_Item(Stat stat, int value)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		object obj = (int)stat << 2;
		object obj2 = (object)_values + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v3+10]");
		if ((nint)value == 0)
		{
			return;
		}
		object obj3 = (int)stat << 2;
		object obj4 = (object)_values + obj3;
		dirty = true;
		if (_statChangedHandlers != null)
		{
			object obj5 = (int)stat << 2;
			object obj6 = (object)_statChangedHandlers + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S0_v13+C] (should have been resolved before IL gen)");
			}
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public int get_Item(TempStat tempStat)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = (int)tempStat << 2;
		object obj2 = (object)_tempStatValues + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v3+10]");
		return 0;
	}

	public void set_Item(TempStat tempStat, int value)
	{
		//IL_000e: Expected Obj, but got I4
		//IL_004f: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00ba: Expected Obj, but got I
		object obj = (int)tempStat << 2;
		object obj2 = (object)_values + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v3+10]");
		if ((nint)value == 0)
		{
			return;
		}
		object obj3 = (int)tempStat << 2;
		object obj4 = (object)_tempStatValues + obj3;
		dirty = true;
		if (_tempStatChangedHandlers != null)
		{
			object obj5 = (int)tempStat << 2;
			object obj6 = (object)_tempStatChangedHandlers + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v12+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S0_v13+C] (should have been resolved before IL gen)");
			}
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public int get_Item(string stat)
	{
		//IL_005f: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stat));
		object obj = Enum.Parse(typeFromHandle, stat, ignoreCase: true);
		throw new NullReferenceException();
	}

	public void set_Item(string stat, int value)
	{
		//IL_0044: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stat));
		object obj = Enum.Parse(typeFromHandle, stat, ignoreCase: true);
		throw new NullReferenceException();
	}

	public Statistics()
	{
		//IL_0046: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stat));
		string[] names = Enum.GetNames(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		int[] values = default;
		_values = values;
		dirty = false;
	}

	public bool AnyListenerForStat(Stat stat)
	{
		//IL_002d: Expected Obj, but got I4
		bool result;
		if (_statChangedHandlers != null)
		{
			object obj = (int)stat << 2;
			object obj2 = (object)_statChangedHandlers + obj;
			result = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v4+10]");
			if ((nint)0 != 0)
			{
				goto IL_0069;
			}
		}
		result = false;
		goto IL_0069;
		IL_0069:
		return result;
	}

	public void AddStatChangedHandler(Stat stat, StatChangedDelegate handler)
	{
		//IL_009f: Expected Obj, but got I4
		//IL_00c1: Expected Obj, but got I
		bool flag = _statChangedHandlers == null;
		bool flag2 = !flag;
		StatChangedDelegate[] statChangedHandlers = _statChangedHandlers;
		if (!flag2)
		{
			int[] values = _values;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			StatChangedDelegate[] statChangedHandlers2 = default;
			_statChangedHandlers = statChangedHandlers2;
			statChangedHandlers = _statChangedHandlers;
		}
		object obj = (int)stat << 2;
		object obj2 = (object)statChangedHandlers + obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v4+10]");
		Delegate obj3 = Delegate.Combine((Delegate)0, handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
		throw new ArrayTypeMismatchException();
	}

	public void RemoveStatChangedHandler(Stat stat, StatChangedDelegate handler)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_0037: Expected Obj, but got I
		if (_statChangedHandlers != null)
		{
			object obj = (int)stat << 2;
			object obj2 = (object)_statChangedHandlers + obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4+10]");
			Delegate obj3 = Delegate.Remove((Delegate)0, handler);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
			throw new ArrayTypeMismatchException();
		}
	}

	public void Copy(Statistics src)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e4: Expected VT, but got Obj
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stat));
		Array values = Enum.GetValues(typeFromHandle);
		IEnumerator enumerator = values.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
						object obj6 = obj7 << 2;
						object obj8 = (object)src._values + obj6;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_0193;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_0193;
			IL_0193:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj9 == obj10;
			bool flag2 = !flag;
			object obj11 = obj12;
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
				obj11 = obj13;
			}
			_ = 0;
			object obj14 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj15 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public void Clear()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02e4: Expected VT, but got Obj
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 32;
		_ = 0;
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stat));
		Array values = Enum.GetValues(typeFromHandle);
		IEnumerator enumerator = values.GetEnumerator();
		object obj3 = obj + 24;
		object obj4 = obj + 28;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj6;
		object obj7 = default;
		object obj8 = default;
		object obj10 = default;
		object obj11 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				bool flag = obj5 == null;
				obj6 = obj;
				if (flag)
				{
					break;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						goto IL_017b;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_017b;
			IL_017b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag2 = obj7 == obj8;
			bool flag3 = !flag2;
			object obj9 = obj10;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				bool flag4 = (nint)0 != 1;
				obj6 = obj;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj9 = obj11;
			}
			_ = 0;
			object obj12 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				obj6 = 0;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
		}
		object obj13 = obj6 + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01fc: Expected Obj, but got I4
		//IL_006e: Expected VT, but got Obj
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_00ab: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0150: Expected Obj, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		int[] values = _values;
		object obj3 = 0;
		object obj4 = default;
		while (values.Length > (nint)obj3)
		{
			obj4++;
			object obj5 = obj3 << 2;
			object obj6 = (object)values + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v15+10]");
			if ((nint)0 == 0)
			{
				obj4 = obj4;
			}
			object obj7 = obj3 + 1;
			obj3 = obj7;
		}
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(Stat));
		Array values2 = Enum.GetValues(typeFromHandle);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
		object obj8 = 0;
		object obj11 = default;
		object arg = default;
		object arg2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v28+C]");
			if (0 <= (nint)obj8)
			{
				break;
			}
			object obj9 = obj8 << 2;
			object obj10 = obj11 + obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v15+10]");
			object obj12 = (nint)0 << 2;
			object obj13 = (object)_values + obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v43+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v15+10]");
				_ = 0;
				object obj14 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v15+10]");
				object obj15 = (nint)0 << 2;
				object obj16 = (object)_values + obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S1_v25+10]");
				_ = 0;
				object obj17 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				string text = $"{arg}={arg2}";
				throw new ArrayTypeMismatchException();
			}
			object obj18 = obj8 + 1;
			obj8 = obj18;
		}
		string[] value = default;
		return string.Join(";", value);
	}

	public static Statistics Parse(string s)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I4
		//IL_008b: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected Obj, but got Unknown
		//IL_04c1: Expected Obj, but got I
		//IL_01b2: Expected Obj, but got I4
		//IL_050a: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03bc: Expected Obj, but got I
		//IL_03e1: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [52FD16]");
		bool flag = (nint)0 == 0;
		bool flag2 = !flag;
		object obj3 = obj + 8;
		_ = 0;
		Statistics statistics = default;
		statistics._002Ector();
		if (s._stringLength >= 1)
		{
			string[] array = s.Split(';');
			object obj24;
			object obj9 = default;
			object obj11 = default;
			object obj12 = default;
			object obj14 = default;
			object obj16 = default;
			object obj17 = default;
			object obj23 = default;
			for (object obj4 = 0; (nint)obj4 < array.Length; obj24 = obj4 + 1, obj4 = obj24)
			{
				object obj5 = obj4 << 2;
				object obj6 = (object)array + obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v26+10]");
				int num = ((string)0).IndexOf('=');
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v26+10]");
				string text = ((string)0).Substring(0, num);
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
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
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
								object obj7 = num + 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
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
											object obj8 = obj9 << 2;
											object obj10 = (object)statistics._values + obj8;
											continue;
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
				bool flag3 = obj11 != obj12;
				object obj13 = obj14;
				bool flag5;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						object obj15 = obj16;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							flag2 = obj17 == null;
							if (!flag2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj18 = (nint)0 << 2;
								object obj19 = obj3 + obj18;
								obj19 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj20 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
								object obj21 = -1;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
							object obj22 = obj16;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							bool flag4 = (nint)0 != 1;
							obj13 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							obj4 = 0;
							flag5 = flag2;
							if (flag4)
							{
								goto IL_0517;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag6 = (nint)0 != 1;
					obj13 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					obj4 = 0;
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
						obj13 = obj23;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						obj4 = 0;
						flag5 = flag2;
						goto IL_0517;
					}
				}
				goto IL_0584;
				IL_0517:
				flag2 = flag5;
				goto IL_0584;
				IL_0584:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			}
		}
		return statistics;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
