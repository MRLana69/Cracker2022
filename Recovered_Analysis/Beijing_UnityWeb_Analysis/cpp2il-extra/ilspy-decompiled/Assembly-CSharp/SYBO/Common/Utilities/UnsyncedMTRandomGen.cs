using Cpp2ILInjected;

namespace SYBO.Common.Utilities;

public class UnsyncedMTRandomGen : IMTRandomGen, IRandomGen
{
	private MTRandomGen _gen;

	public uint Seed
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			uint result = default;
			return result;
		}
	}

	public int SeedIncrement
	{
		get
		{
			MTRandomGen gen = _gen;
			return (int)gen._initialSeed;
		}
	}

	public uint NextUint()
	{
		MTRandomGen gen = _gen;
		return (uint)gen._randomIncrement;
	}

	public UnsyncedMTRandomGen()
	{
		//IL_0573: Expected Obj, but got I
		//IL_022c: Expected Obj, but got I
		//IL_0242: Expected Obj, but got I
		//IL_0250: Expected I, but got Obj
		//IL_0266: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected Obj, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_04a0: Expected Obj, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected Obj, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected Obj, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Obj, but got Unknown
		//IL_0196: Expected I, but got Obj
		//IL_01ac: Expected Obj, but got I
		//IL_02e6: Expected Obj, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected Obj, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected Obj, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected Obj, but got Unknown
		//IL_0291: Expected I, but got Obj
		//IL_03c3: Expected Obj, but got I
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected Obj, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected Obj, but got Unknown
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected Obj, but got Unknown
		//IL_00e7: Expected I, but got Obj
		//IL_01d7: Expected I, but got Obj
		object obj = default;
		while ((nint)obj <= 226)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj2 = (nint)0 + (nint)16;
			object obj3 = obj << 2;
			object obj4 = obj2 + obj3;
			object obj5 = obj << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj6 = 0 + obj5;
			object obj7 = obj6 + 20;
			object obj8 = obj << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj9 = 0 + obj8;
			object obj10 = obj9 + 1604;
			nint num = (nint)typeof(MTRandomGen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S1_v66 (Il2CppClass<SYBO.Common.Utilities.MTRandomGen>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num2 = (nint)typeof(MTRandomGen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S1_v77 (Il2CppClass<SYBO.Common.Utilities.MTRandomGen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj12 = (nint)0 + (nint)16;
			object obj13 = obj << 2;
			object obj14 = obj12 + obj13;
			object obj15 = obj7 & 0x7FFFFFFE;
			object obj16 = obj4 & int.MinValue;
			object obj17 = obj15 | obj16;
			object obj18 = obj17 >> 1;
			object obj19 = obj10 ^ obj18;
			object obj20 = MTRandomGen.MAG01 + 16;
			object obj21 = obj7 & 1;
			object obj22 = obj21 << 2;
			object obj23 = obj20 + obj22;
			object obj24 = obj19 ^ obj23;
			obj14 = obj24;
			object obj25 = obj + 1;
			obj = obj25;
		}
		object obj28;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj26 = (nint)0 + (nint)16;
			object obj27 = obj << 2;
			obj28 = obj26 + obj27;
			if ((nint)obj > 622)
			{
				break;
			}
			object obj29 = obj << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj30 = 0 + obj29;
			object obj31 = obj30 + 20;
			object obj32 = obj << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj33 = 0 + obj32;
			object obj34 = obj33 + -892;
			nint num3 = (nint)typeof(MTRandomGen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v37 (Il2CppClass<SYBO.Common.Utilities.MTRandomGen>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num4 = (nint)typeof(MTRandomGen);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S1_v48 (Il2CppClass<SYBO.Common.Utilities.MTRandomGen>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
			object obj36 = (nint)0 + (nint)16;
			object obj37 = obj << 2;
			object obj38 = obj36 + obj37;
			object obj39 = obj31 & 0x7FFFFFFE;
			object obj40 = obj28 & int.MinValue;
			object obj41 = obj39 | obj40;
			object obj42 = obj41 >> 1;
			object obj43 = obj34 ^ obj42;
			object obj44 = MTRandomGen.MAG01 + 16;
			object obj45 = obj31 & 1;
			object obj46 = obj45 << 2;
			object obj47 = obj44 + obj46;
			object obj48 = obj43 ^ obj47;
			obj38 = obj48;
			object obj49 = obj + 1;
			obj = obj49;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
		object obj50 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
		object obj51 = (nint)0 + (nint)1600;
		nint num5 = (nint)typeof(MTRandomGen);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S1_v14 (Il2CppClass<SYBO.Common.Utilities.MTRandomGen>)+BA]");
		object obj52 = (nint)0 & (nint)0x200;
		if (obj52 != null)
		{
			nint num6 = (nint)typeof(MTRandomGen);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v22 (Il2CppClass<SYBO.Common.Utilities.MTRandomGen>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.UnsyncedMTRandomGen)+C]");
		object obj53 = (nint)0 + (nint)2508;
		object obj54 = obj50 & 0x7FFFFFFE;
		object obj55 = obj28 & int.MinValue;
		object obj56 = obj54 | obj55;
		object obj57 = obj56 >> 1;
		object obj58 = obj51 ^ obj57;
		object obj59 = MTRandomGen.MAG01 + 16;
		object obj60 = obj50 & 1;
		object obj61 = obj60 << 2;
		object obj62 = obj59 + obj61;
		object obj63 = obj58 ^ obj62;
		obj53 = obj63;
	}
}
