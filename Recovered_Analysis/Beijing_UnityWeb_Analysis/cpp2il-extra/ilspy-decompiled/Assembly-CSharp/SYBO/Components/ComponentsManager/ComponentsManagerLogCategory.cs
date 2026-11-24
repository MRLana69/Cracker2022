using System.IO;
using Cpp2ILInjected;
using SYBO.Components.Logging;

namespace SYBO.Components.ComponentsManager;

public class ComponentsManagerLogCategory : LogCategory
{
	public ComponentsManagerLogCategory(int categoryId)
	{
		//IL_00c9: Expected I, but got Obj
		//IL_00df: Expected Obj, but got I
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0177: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(LogCategory);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(LogCategory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<SYBO.Components.Logging.LogCategory>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CategoryId = categoryId;
		nint num3 = (nint)typeof(Log);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v12 (Il2CppClass<SYBO.Components.Logging.Log>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 == null;
		nint num4 = (nint)typeof(Log);
		if (!flag)
		{
			nint num5 = (nint)typeof(Log);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v21 (Il2CppClass<SYBO.Components.Logging.Log>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num4 = (nint)typeof(Log);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num4 = (nint)typeof(Log);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L1_v2 (Il2CppClass<SYBO.Components.Logging.Log>)+5C]");
		object obj3 = (nint)0 + (nint)12;
		obj3 = this;
		object obj4 = this + 12;
		obj4 = "Compression";
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0479: Expected I4, but got Obj
		//IL_0055: Expected Obj, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_016e: Expected Obj, but got I4
		//IL_0177: Expected Obj, but got I4
		//IL_0299: Expected Obj, but got I
		//IL_02c5: Expected Obj, but got I4
		//IL_03ad: Expected Obj, but got I
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		MemoryStream memoryStream = default;
		memoryStream.Dispose((byte)(int)this != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v20+2C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj5 = default;
		object obj4 = obj5 + 12;
		object obj6 = obj4;
		object obj8 = default;
		for (object obj7 = obj4; obj7 == obj6; obj7 = obj8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
			obj6 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj9 = obj2 + 4;
		object obj10 = obj9 + 1;
		obj9 = obj10;
		object obj11 = obj10 << 2;
		object obj12 = obj2 + obj11;
		obj12 = 100;
		object obj13 = 0;
		string[] array2 = default;
		string[] array = array2;
		object obj14 = default;
		if (obj14 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		string[] result = default;
		object obj18 = default;
		if ((nint)0 == -1)
		{
			if (obj13 == null)
			{
				result = array;
				goto IL_0548;
			}
		}
		else
		{
			bool flag = obj13 != null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj15 = (nint)0 << 2;
			object obj16 = obj2 + obj15;
			bool flag2 = (nint)obj16 != 100;
			object obj17 = flag & flag2;
			if (obj17 == null)
			{
				obj18 = obj13;
				result = array;
				goto IL_0548;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj20 = default;
		object obj19 = obj20;
		object obj22 = default;
		object obj21 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj23 = default;
		if (obj21 == obj23)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj24 = default;
			obj18 = obj24;
			result = array;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0548;
		IL_0548:
		if (memoryStream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj25 = (nint)0 << 2;
			object obj26 = obj2 + obj25;
			if ((nint)obj26 == 100)
			{
				object obj27 = obj2 + 4;
				if ((nint)obj27 > -1)
				{
					object obj28 = obj27 + -1;
					obj27 = obj28;
				}
				goto IL_05c3;
			}
		}
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05c3;
		IL_05c3:
		return result;
	}
}
