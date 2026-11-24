using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using SYBO.Subway;
using UnityEngine;

namespace SYBO.Common.Utilities;

public class SemiRandomlyOrderedList<T>
{
	private List<T> _readyEntries;

	private List<T> _usedEntries;

	private List<T> _allEntries;

	private HashSet<T> _evaluatedEntries;

	public bool IsEmpty
	{
		get
		{
			//IL_012b: Expected Obj, but got F4
			//IL_014c: Expected Obj, but got I
			//IL_0164: Expected Obj, but got I
			//IL_0174: Expected Obj, but got I
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Expected Obj, but got Unknown
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected Obj, but got Unknown
			//IL_01a3: Expected Obj, but got I4
			//IL_001d: Expected Obj, but got I
			//IL_002d: Expected Obj, but got I
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected Obj, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected Obj, but got Unknown
			//IL_0122: Expected I4, but got Obj
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected Obj, but got Unknown
			//IL_00c5: Expected I4, but got Obj
			object obj = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			StringBuilder stringBuilder = default;
			System.Text.StringBuilderCache.Release(stringBuilder);
			nint num = default;
			object obj2 = num + 12;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v7+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v8+C]");
			object obj5 = 0;
			object obj6 = obj5 & 0x3FFF;
			object obj7 = obj6 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S2_v5 (should have been resolved before IL gen)");
			object obj8 = 0;
			object obj9 = default;
			object obj15 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S3_v5+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v6+10]");
				object obj12 = 0;
				object obj13 = obj12 & 0xFF;
				object obj14 = obj13 + 1279;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v51 @ S4_v5 (should have been resolved before IL gen)");
				obj = obj15;
				OverflowException value = new OverflowException();
				StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)(object)value);
				object obj16 = obj9 - 1;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj16))
				{
					CharacterController charactercontroller = Game.Charactercontroller;
					StringBuilder stringBuilder3 = stringBuilder.Append((int)charactercontroller);
				}
				object obj17 = obj8 + 1;
				obj8 = obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string item = default;
			list.Add(item);
			return (byte)(int)list != 0;
		}
	}

	public int TotalEntries
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected Obj, but got Unknown
			//IL_009f: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected Obj, but got Unknown
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v4+18]");
			object obj4 = 0;
			object obj5 = obj4 & 0x3FFF;
			object obj6 = obj5 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
			object obj7 = default;
			if (obj7 != null)
			{
				return 0;
			}
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v8+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v9+18]");
			object obj10 = 0;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S2_v10 (should have been resolved before IL gen)");
			object obj13 = default;
			return (obj13 == null) ? 1 : 0;
		}
	}

	public List<T> ReadyEntries
	{
		get
		{
			//IL_000e: Expected Obj, but got I
			//IL_0026: Expected Obj, but got I
			//IL_0036: Expected Obj, but got I
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected Obj, but got Unknown
			//IL_0074: Expected Obj, but got I
			//IL_0084: Expected Obj, but got I
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Expected Obj, but got Unknown
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v3+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v4+18]");
			object obj4 = 0;
			object obj5 = obj4 & 0x3FFF;
			object obj6 = obj5 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
			object obj7 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v7+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v8+18]");
			object obj9 = 0;
			object obj10 = obj9 & 0x3FFF;
			object obj11 = obj10 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S2_v9 (should have been resolved before IL gen)");
			object obj12 = default;
			object obj13 = default;
			return (List<T>)(object)(obj12 + obj13);
		}
	}

	public List<T> UsedEntries => _readyEntries;

	public List<T> AllEntries => _usedEntries;

	public void Build(IEnumerable<T> sourceList, SyboRandom random)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 121922;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S5_v4 (should have been resolved before IL gen)");
	}

	public void Add(T entry)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S0_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S2_v2+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S2_v3+4]");
		object obj6 = 0;
		object obj7 = obj6 & 0x3FFF;
		object obj8 = obj7 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v23 @ S3_v4 (should have been resolved before IL gen)");
		object obj9 = this + 8;
		object obj10 = default;
		obj9 = obj10;
	}

	public void Clear()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v4+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S1_v8+1C]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S2_v9 (should have been resolved before IL gen)");
	}

	public void Reset(SyboRandom random)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S2_v4+8]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S3_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S2_v8+8]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v9 (should have been resolved before IL gen)");
	}

	public T GetNext(SyboRandom random)
	{
		//IL_001a: Expected Obj, but got I
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		string tag = ((Component)this).tag;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L2 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x1FFF;
		object obj4 = obj3 + 30963;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S4_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public T GetNextMatching(SyboRandom random, Func<T, bool> matchSelector)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [methodInfo @ L3 (Il2CppMethodInfo)+18]");
		object obj = 0;
		object obj2 = obj;
		object obj3 = obj2 & 0x7FF;
		object obj4 = obj3 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S5_v4 (should have been resolved before IL gen)");
		T result = default;
		return result;
	}

	public void Consume(T entry, SyboRandom random)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		//IL_006c: Expected Obj, but got I
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_00b2: Expected Obj, but got I
		//IL_00c2: Expected Obj, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected Obj, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S2_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v19 @ S3_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v7+60]");
		object obj8 = 0;
		object obj9 = obj8;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v9 (should have been resolved before IL gen)");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v11+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v12+4]");
		object obj14 = 0;
		object obj15 = obj14 & 0x3FFF;
		object obj16 = obj15 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S3_v13 (should have been resolved before IL gen)");
	}

	private void RegenerateIfNeeded(SyboRandom random)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ S2_v4+10]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v18 @ S3_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v8+14]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v9 (should have been resolved before IL gen)");
	}

	private void Regenerate(SyboRandom random)
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0155: Expected Obj, but got I
		//IL_0165: Expected Obj, but got I
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected Obj, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected Obj, but got Unknown
		//IL_02e8: Expected Obj, but got I
		//IL_02f8: Expected Obj, but got I
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected Obj, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected Obj, but got Unknown
		//IL_0094: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected Obj, but got Unknown
		//IL_01cb: Expected Obj, but got I
		//IL_01db: Expected Obj, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected Obj, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected Obj, but got Unknown
		//IL_0294: Expected Obj, but got I
		//IL_02a4: Expected Obj, but got I
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I
		//IL_0112: Expected Obj, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0241: Expected Obj, but got I
		//IL_0251: Expected Obj, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v4+18]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 < 4)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v28+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v29+18]");
			object obj10 = 0;
			object obj11 = obj10 & 0x3FFF;
			object obj12 = obj11 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S2_v32 (should have been resolved before IL gen)");
			object obj13 = default;
			if ((nint)obj13 > 3)
			{
				object obj14 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S2_v34+60]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S2_v35+10]");
				object obj16 = 0;
				object obj17 = obj16 & 0x3FFF;
				object obj18 = obj17 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v72 @ S3_v25 (should have been resolved before IL gen)");
				return;
			}
		}
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S1_v10+60]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v11+18]");
		object obj21 = 0;
		object obj22 = obj21 & 0x3FFF;
		object obj23 = obj22 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v54 @ S2_v11 (should have been resolved before IL gen)");
		object obj24 = default;
		if ((nint)obj24 < 3)
		{
			object obj25 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v22+60]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S1_v23+18]");
			object obj27 = 0;
			object obj28 = obj27 & 0x3FFF;
			object obj29 = obj28 + 6161;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v86 @ S2_v24 (should have been resolved before IL gen)");
			object obj30 = default;
			if ((nint)obj30 > 2)
			{
				object obj31 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S2_v26+60]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S2_v27+10]");
				object obj33 = 0;
				object obj34 = obj33 & 0x3FFF;
				object obj35 = obj34 + 97173;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v128 @ S3_v19 (should have been resolved before IL gen)");
				return;
			}
		}
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v16+60]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S1_v17+18]");
		object obj38 = 0;
		object obj39 = obj38 & 0x3FFF;
		object obj40 = obj39 + 6161;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S2_v16 (should have been resolved before IL gen)");
		object obj41 = default;
		if ((nint)obj41 < 2)
		{
			object obj42 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S2_v18+60]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S2_v19+10]");
			object obj44 = 0;
			object obj45 = obj44 & 0x3FFF;
			object obj46 = obj45 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v129 @ S3_v13 (should have been resolved before IL gen)");
		}
	}

	public static void TestUniformity()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0028: Expected Obj, but got I
		//IL_0060: Expected Obj, but got I
		//IL_0070: Expected Obj, but got I
		//IL_008a: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00cf: Expected Obj, but got I
		//IL_00e9: Expected Obj, but got I
		nint num = default;
		object obj = num + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ S0_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v11+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v12+4]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v4+60]");
		object obj5 = 0;
		object obj6 = obj4 & 0x3FFF;
		object obj7 = obj6 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v29 @ S2_v3 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21+5C]");
		object obj9 = 0;
		object obj10 = default;
		obj9 = obj10;
	}

	public SemiRandomlyOrderedList()
	{
		//IL_000e: Expected Obj, but got I
		//IL_0026: Expected Obj, but got I
		//IL_0036: Expected Obj, but got I
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I
		//IL_0084: Expected Obj, but got I
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00c2: Expected Obj, but got I
		//IL_00d2: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected Obj, but got Unknown
		nint num = default;
		object obj = num + 12;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ S1_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S1_v4+C]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17 @ S2_v5 (should have been resolved before IL gen)");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v7+60]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v8+C]");
		object obj9 = 0;
		object obj10 = obj9 & 0x3FFF;
		object obj11 = obj10 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S2_v9 (should have been resolved before IL gen)");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v11+60]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v12+C]");
		object obj14 = 0;
		object obj15 = obj14 & 0x3FFF;
		object obj16 = obj15 + 80504;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S2_v13 (should have been resolved before IL gen)");
	}
}
