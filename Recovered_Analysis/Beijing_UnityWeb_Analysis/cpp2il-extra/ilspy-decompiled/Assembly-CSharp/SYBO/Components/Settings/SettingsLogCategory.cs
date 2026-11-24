using System;
using System.Reflection;
using Cpp2ILInjected;
using SYBO.Components.Logging;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Components.Settings;

public class SettingsLogCategory : LogCategory
{
	public SettingsLogCategory(int categoryId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 8;
		obj = categoryId;
	}

	public override string[] GetCallstackPrefixes()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_0217: Expected Obj, but got I4
		//IL_02d3: Expected Obj, but got I
		//IL_039a: Expected Obj, but got I
		//IL_0174: Expected Obj, but got I4
		//IL_0086: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I
		//IL_05aa: Expected Obj, but got I4
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected Obj, but got Unknown
		//IL_055c: Expected Obj, but got I4
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected Obj, but got Unknown
		//IL_01ca: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected Obj, but got Unknown
		//IL_053b: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Expected I4, but got Unknown
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected Obj, but got Unknown
		//IL_01bc: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		bool isNotSerialized = ((FieldInfo)(object)this).IsNotSerialized;
		bool flag = ReflectionWrapper.HasCustomAttributes((MemberInfo)(object)this, inherit: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		bool flag2 = isNotSerialized;
		object obj3 = default;
		object obj4 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj4 != null)
				{
					nint num = (nint)typeof(StaticSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v97 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num2 = (nint)typeof(StaticSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v113 (Il2CppClass<SYBO.Components.Settings.StaticSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					RuntimeSettings runtime = StaticSettings.Runtime;
					if (runtime.IsFinalBuild)
					{
						object obj6 = obj2 + 4;
						object obj7 = obj6 + 1;
						obj6 = obj7;
						object obj8 = obj7 << 2;
						object obj9 = obj2 + obj8;
						obj9 = 95;
						break;
					}
				}
				object obj11;
				if (obj10 == null)
				{
					obj11 = 0;
				}
				else
				{
					obj11 = ((obj10 != typeof(NonSerializedAttribute)) ? ((object)0) : obj10);
				}
				bool flag3 = obj11 == null;
				object obj12 = flag2 & flag3;
				object obj13;
				if (obj10 == null)
				{
					obj13 = 0;
				}
				else
				{
					obj13 = ((obj10 != typeof(SerializeField)) ? ((object)0) : obj10);
				}
				bool flag4 = obj13 != null;
				bool flag5 = (byte)((obj12 | flag4) ? 1 : 0) != 0;
				flag2 = flag5;
				continue;
			}
			object obj14 = obj2 + 4;
			object obj15 = obj14 + 1;
			obj14 = obj15;
			object obj16 = obj15 << 2;
			object obj17 = obj2 + obj16;
			obj17 = 93;
			break;
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj2 + obj19;
			if ((nint)obj20 == 95)
			{
				object obj21 = obj2 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				goto IL_05a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		bool flag6 = default;
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj2 + obj23;
			if ((nint)obj24 == 93)
			{
				object obj25 = obj2 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				flag6 = flag2;
				goto IL_05a5;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		else
		{
			flag6 = flag2;
		}
		goto IL_05a5;
		IL_05a5:
		return (string[])flag6;
	}
}
