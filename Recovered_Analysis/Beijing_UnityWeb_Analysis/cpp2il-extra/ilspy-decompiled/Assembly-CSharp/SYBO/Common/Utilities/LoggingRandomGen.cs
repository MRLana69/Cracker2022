using System;
using Cpp2ILInjected;

namespace SYBO.Common.Utilities;

public class LoggingRandomGen : IMTRandomGen, IRandomGen
{
	private IMTRandomGen _gen;

	public uint Seed
	{
		get
		{
			//IL_0108: Expected Obj, but got I
			//IL_0123: Expected Obj, but got I
			//IL_0139: Expected Obj, but got I
			//IL_015c: Expected Obj, but got I
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected Obj, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected Obj, but got Unknown
			//IL_00ba: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.LoggingRandomGen)+10]");
			if ((nint)0 >= (nint)624)
			{
				((UnsyncedMTRandomGen)this)._002Ector();
				_ = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.LoggingRandomGen)+10]");
			object obj = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.LoggingRandomGen)+C]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.LoggingRandomGen)+10]");
			object obj3 = (nint)0 << 2;
			object obj4 = obj2 + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.LoggingRandomGen)+18]");
			object obj5 = (nint)0 + (nint)1;
			if (_gen != null)
			{
				IMTRandomGen gen = _gen;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Utilities.LoggingRandomGen)+18]");
				gen(0);
			}
			object obj6 = obj4 >> 11;
			object obj7 = obj6 ^ obj4;
			object obj8 = obj7 << 7;
			object obj9 = obj8 & -1658038656;
			object obj10 = obj9 ^ obj7;
			object obj11 = obj10 << 15;
			object obj12 = obj11 & -272236544;
			object obj13 = obj12 ^ obj10;
			object obj14 = obj13 >> 18;
			return (uint)(obj14 ^ obj13);
		}
	}

	public int SeedIncrement
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			int result = default;
			return result;
		}
	}

	public LoggingRandomGen(IMTRandomGen gen)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = (Delegate)_gen;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)gen);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 8;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public uint NextUint()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		uint result = default;
		return result;
	}
}
