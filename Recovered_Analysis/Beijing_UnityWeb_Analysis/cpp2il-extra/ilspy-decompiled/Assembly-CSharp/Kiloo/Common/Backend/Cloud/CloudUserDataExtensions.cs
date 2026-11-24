using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;

namespace Kiloo.Common.Backend.Cloud;

public static class CloudUserDataExtensions
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__0_0;

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__0_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudWorkingCopy._003C_003Ec obj = default;
			CloudWorkingCopy._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal string _003CToDictionary_003Eb__0_0(KeyValuePair<string, string> pair)
		{
			//IL_002f: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			string text = default;
			string text2 = default;
			return (string)(text != text2);
		}

		internal string _003CToDictionary_003Eb__0_1(KeyValuePair<string, string> pair)
		{
			//IL_000a: Expected Obj, but got VT
			return (string)pair;
		}
	}

	public static Dictionary<string, string> ToDictionary(ICloudUserData userData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected Obj, but got Unknown
		//IL_0129: Expected Obj, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got I4
		//IL_0149: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected Obj, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj3 = default;
		Dictionary<string, string> result;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj4 = obj2 + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj2 + obj6;
			obj7 = 33;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			Dictionary<string, string> dictionary = default;
			result = dictionary;
		}
		else
		{
			object obj8 = obj2 + 4;
			object obj9 = obj8 + 1;
			obj8 = obj9;
			object obj10 = obj9 << 2;
			object obj11 = obj2 + obj10;
			obj11 = 31;
			result = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj2 + obj12;
			if ((nint)obj13 == 33)
			{
				object obj14 = obj2 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_033d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj2 + obj16;
			if ((nint)obj17 == 31)
			{
				object obj18 = obj2 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_033d;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_033d;
		IL_033d:
		return result;
	}

	public static ICloudUserData ToUserData(IDictionary<string, string> dict)
	{
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_03f4: Expected I, but got Obj
		//IL_040a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_03b3: Expected I, but got Obj
		//IL_03c9: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0286: Expected I, but got Obj
		//IL_029c: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_01c9: Expected I, but got Obj
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_0320: Expected I, but got Obj
		//IL_0336: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v96 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__0_0 == null;
		bool flag2 = !flag;
		Func<KeyValuePair<string, string>, string> keySelector = _003C_003Ec._003C_003E9__0_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v70 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v90 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<KeyValuePair<string, string>, string> func = default;
			object obj3 = func + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v87 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			keySelector = func;
		}
		nint num7 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v16 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v63 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__0_1 == null;
		bool flag4 = !flag3;
		Func<KeyValuePair<string, string>, string> elementSelector = _003C_003Ec._003C_003E9__0_1;
		if (!flag4)
		{
			nint num9 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v37 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num10 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v57 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			Func<KeyValuePair<string, string>, string> func2 = default;
			object obj7 = func2 + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v54 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudUserDataExtensions+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)8;
			obj8 = func2;
			elementSelector = func2;
		}
		nint num13 = (nint)typeof(StringComparer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v26 (Il2CppClass<System.StringComparer>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num14 = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v32 (Il2CppClass<System.StringComparer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
		IEqualityComparer<string> comparer = default;
		return (ICloudUserData)Enumerable.ToDictionary(dict, keySelector, elementSelector, comparer);
	}
}
