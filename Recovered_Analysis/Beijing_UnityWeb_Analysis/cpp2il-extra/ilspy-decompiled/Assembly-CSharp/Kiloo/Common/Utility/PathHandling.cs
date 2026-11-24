using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class PathHandling
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__2_0;

		public static Predicate<string> _003C_003E9__2_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			FileUtil._003C_003Ec obj = default;
			FileUtil._003C_003Ec._003C_003E9 = obj;
		}

		internal bool _003CRelativeToAbsolutePath_003Eb__2_0(string s)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}

		internal bool _003CRelativeToAbsolutePath_003Eb__2_1(string s)
		{
			bool flag = s.EndsWith("..", StringComparison.Ordinal);
			return !flag;
		}
	}

	public unsafe static string UnifyDirectorySeparators(string path)
	{
		//IL_00f2: Expected Obj, but got I4
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0095: Expected Obj, but got I4
		//IL_0082: Expected Obj, but got I4
		//IL_00e4: Expected Obj, but got I4
		IFormatProvider formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v30 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string fileName = Path.GetFileName(path);
		string result;
		if (fileName == null || fileName.m_stringLength == 0)
		{
			result = (string)(-1);
		}
		else
		{
			string text = fileName.Trim((char[])1);
			bool flag = ((int*)text)->System_002EIConvertible_002EToBoolean(formatProvider);
			bool flag2 = !flag;
			bool flag3 = !flag2;
			result = (string)(object)formatProvider;
			if (!flag3)
			{
				result = (string)(-1);
			}
		}
		return result;
	}

	public static string RelativeToAbsolutePath(string filePath)
	{
		//IL_0065: Expected I, but got Obj
		//IL_007b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00c2: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_00d9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = filePath.Replace((string)92, (string)Path.DirectorySeparatorChar);
		string text2 = text.Replace((string)47, (string)Path.DirectorySeparatorChar);
		return text2.Replace((string)Path.AltDirectorySeparatorChar, (string)Path.DirectorySeparatorChar);
	}

	public unsafe static string RelativeToAbsolutePath(string filePath, string basePath)
	{
		//IL_0185: Expected Obj, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0047: Expected I4, but got Obj
		//IL_0042: Expected native int or pointer, but got VT
		//IL_0055: Expected Obj, but got I4
		//IL_005e: Expected Obj, but got I4
		//IL_0072: Expected Obj, but got I4
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		//IL_00ce: Expected I, but got Obj
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected Obj, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected I4, but got Unknown
		//IL_012b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		object obj = default;
		int num3;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			decimal num = default;
			object obj2 = num + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			int num2 = default;
			*(decimal*)(nint)num = new decimal(0, num2, 0, (int)obj2);
			object obj3 = num2 + 12;
			object obj4 = 0;
			while (true)
			{
				bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3);
				num3 = num2;
				if (flag)
				{
					break;
				}
				object obj5 = num2 + 16;
				object obj6 = obj5 + obj4;
				nint num4 = (nint)typeof(ObfuscatedMemory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v25 (Il2CppClass<Kiloo.Common.Utility.ObfuscatedMemory>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num5 = (nint)typeof(ObfuscatedMemory);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v32 (Il2CppClass<Kiloo.Common.Utility.ObfuscatedMemory>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj8 = ObfuscatedMemory.Key + 16;
				byte[] key = ObfuscatedMemory.Key;
				object obj10;
				if (key.Length != 0)
				{
					int num6 = obj4 / key.Length;
					object obj9 = num6 * key.Length;
					obj10 = obj4 - obj9;
				}
				else
				{
					obj10 = 0;
				}
				object obj11 = obj8 + obj10;
				object obj12 = obj11 ^ obj6;
				obj6 = obj12;
				object obj13 = obj4 + 1;
				obj4 = obj13;
			}
		}
		else
		{
			num3 = 0;
		}
		return (string)num3;
	}

	public static string AbsoluteToRelativePath(string filePath)
	{
		string persistentDataPath = Application.persistentDataPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @ADE2");
		string result = default;
		return result;
	}

	public static string AbsoluteToRelativePath(string filePath, string basePath)
	{
		//IL_0518: Expected Obj, but got I4
		//IL_0549: Expected Obj, but got I4
		//IL_0552: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00a1: Expected Obj, but got I4
		//IL_00aa: Expected Obj, but got I4
		//IL_00db: Expected I, but got Obj
		//IL_00f1: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_011c: Expected I, but got Obj
		//IL_0627: Expected I, but got Obj
		//IL_063d: Expected Obj, but got I
		//IL_0169: Expected I, but got Obj
		//IL_017f: Expected Obj, but got I
		//IL_0849: Expected Obj, but got I4
		//IL_0849: Expected Obj, but got I4
		//IL_085a: Expected I4, but got Obj
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected Obj, but got Unknown
		//IL_05ee: Expected I, but got Obj
		//IL_0604: Expected Obj, but got I
		//IL_04d0: Expected I, but got Obj
		//IL_06bf: Expected Obj, but got I4
		//IL_01aa: Expected I, but got Obj
		//IL_02ad: Expected I, but got Obj
		//IL_02c3: Expected Obj, but got I
		//IL_021f: Expected I, but got Obj
		//IL_0235: Expected Obj, but got I
		//IL_02ee: Expected I, but got Obj
		//IL_0663: Expected Obj, but got I4
		//IL_033b: Expected I, but got Obj
		//IL_0351: Expected Obj, but got I
		//IL_0260: Expected I, but got Obj
		//IL_0730: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Expected Obj, but got Unknown
		//IL_074c: Expected I, but got Obj
		//IL_0762: Expected Obj, but got I
		//IL_037c: Expected I, but got Obj
		object obj = 0;
		string text = default;
		string text2 = default;
		string text3 = default;
		if (text != null)
		{
			text2 = RelativeToAbsolutePath(string.Empty);
			text3 = RelativeToAbsolutePath(basePath);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			nint num = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v10 (Il2CppClass<System.IO.Path>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v80 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
		}
		int num3 = default;
		object obj3 = num3 + 16;
		obj3 = Path.DirectorySeparatorChar;
		string source = text2.Substring(num3);
		List<string> source2 = Enumerable.ToList((IEnumerable<string>)(object)source);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num4 = default;
		object obj4 = num4 + 16;
		obj4 = Path.DirectorySeparatorChar;
		string source3 = text3.Substring(num4);
		List<string> list = Enumerable.ToList((IEnumerable<string>)(object)source3);
		nint num5 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v23 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v171 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__2_0 == null;
		bool flag2 = !flag;
		Func<string, bool> predicate = _003C_003Ec._003C_003E9__2_0;
		if (!flag2)
		{
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v145 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v165 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			_ = 0;
			Func<string, bool> func = default;
			object obj7 = func + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v162 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)4;
			obj8 = func;
			predicate = func;
		}
		int num11 = Enumerable.Count(source2, predicate);
		if (num11 != 0)
		{
			int num12 = 0;
			string text4 = string.Empty;
			IFormatProvider provider = default;
			while (true)
			{
				int num13 = Enumerable.Count(list);
				object obj9 = num13 - num11;
				if (num12 >= (nint)obj9)
				{
					break;
				}
				string type = list.get_Item(num12);
				nint num14 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v129 (Il2CppClass<System.IO.Path>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num15 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ S0_v138 (Il2CppClass<System.IO.Path>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj = Path.DirectorySeparatorChar;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E2B3");
				object obj11 = ((IConvertible)text4).ToType((Type)(object)type, provider);
				int num16 = num12 + 1;
				num12 = num16;
				text4 = (string)obj11;
			}
			nint num17 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v57 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num18 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v120 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003Ec._003C_003E9__2_1 == null)
			{
				nint num19 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S0_v94 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num20 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ S0_v114 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num21 = 0;
				_ = 0;
				object obj15 = default;
				object obj14 = obj15 + 16;
				obj14 = _003C_003Ec._003C_003E9;
				nint num22 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v111 (Il2CppClass<Kiloo.Common.Utility.PathHandling+<>c>)+5C]");
				object obj16 = (nint)0 + (nint)8;
				obj16 = obj15;
			}
			throw new NullReferenceException();
		}
		nint num23 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S0_v38 (Il2CppClass<System.IO.Path>)+BA]");
		object obj17 = (nint)0 & (nint)0x200;
		if (obj17 != null)
		{
			nint num24 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v45 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string values = basePath.Replace((string)Path.AltDirectorySeparatorChar, (string)Path.DirectorySeparatorChar);
		return string.ConcatArray((string[])(object)values, (int)text2);
	}

	public static void OpenPathInExplorer(string path)
	{
		//IL_0025: Expected Obj, but got I
		//IL_0035: Expected Obj, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected Obj, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = path + 8;
		object obj7 = default;
		obj6 = obj7;
	}
}
