using System;
using System.Text;
using Cpp2ILInjected;

namespace SYBO.Components.Analytics;

public static class MTRandomGenTest
{
	public static string TestIncrement()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_02ac: Expected Obj, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_024f: Expected I, but got Obj
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		_ = 0;
		MTRandomGen mTRandomGen = default;
		mTRandomGen._002Ector(123554u, 0);
		object obj3 = 0;
		while ((nint)obj3 < 10000)
		{
			uint num = mTRandomGen.NextUint();
			object obj4 = obj3 + 1;
			obj3 = obj4;
		}
		MTRandomGen mTRandomGen2 = default;
		mTRandomGen2._002Ector(mTRandomGen._initialSeed, mTRandomGen._randomIncrement);
		StringBuilder stringBuilder = default;
		stringBuilder._002Ector();
		object obj5 = default;
		object obj6 = default;
		while ((nint)obj5 < 100)
		{
			uint num2 = mTRandomGen.NextUint();
			uint num3 = mTRandomGen2.NextUint();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C]");
			if ((nint)0 != (int)num3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				throw new ArrayTypeMismatchException();
			}
			obj5 = obj6 + 1;
		}
		if (true)
		{
			nint num4 = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v103 @ S1_v16 (Il2CppClass<System.Text.StringBuilder>)+D4] (should have been resolved before IL gen)");
			string text = default;
			return "MTRandomGenTest.TestIncrement: FAILED\n" + text;
		}
		return "MTRandomGenTest.TestIncrement: SUCCESS";
	}
}
