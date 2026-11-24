using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Kiloo.Analytics;
using Kiloo.Plugins;
using Kiloo.Plugins.Facebook;
using UI.Screens.RewardManagement;
using UnityEngine;

namespace Kiloo.Common.Utility;

public static class FileUtil
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FileInfo> _003C_003E9__16_1;

		public static Predicate<FileInfo> _003C_003E9__19_0;

		public static Comparison<FileInfo> _003C_003E9__19_1;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Manager._003C_003Ec obj = default;
			Manager._003C_003Ec._003C_003E9 = obj;
		}

		internal int _003CGetFilesForPath_003Eb__16_1(FileInfo a, FileInfo b)
		{
			//IL_00b5: Expected Obj, but got I4
			//IL_002d: Expected I4, but got Obj
			//IL_002d: Expected Obj, but got I
			//IL_0039: Expected Obj, but got I4
			//IL_0053: Expected I4, but got Obj
			//IL_0053: Expected Obj, but got I
			object obj = 0;
			if (((MarshalByRefObject)a)._identity == ((MarshalByRefObject)b)._identity)
			{
				return -1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.FileUtil+<>c)+8]");
			int num = ((Func<CelebrationRewardOrigin, int>)0)((CelebrationRewardOrigin)((MarshalByRefObject)a)._identity);
			obj = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.FileUtil+<>c)+8]");
			int num2 = ((Func<CelebrationRewardOrigin, int>)0)((CelebrationRewardOrigin)((MarshalByRefObject)b)._identity);
			if ((nint)obj < num2)
			{
				return -1;
			}
			return ((nint)obj > num2) ? 1 : 0;
		}

		internal bool _003CLoad_003Eb__19_0(FileInfo file)
		{
			//IL_001a: Expected Obj, but got I
			//IL_004a: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.FileUtil+<>c)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ S0_v4+8]");
			string text = default;
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Utility.FileUtil+<>c)+8]");
				if (string.Equals(text, (string)0, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			string text2 = PathHandling.UnifyDirectorySeparators(text);
			return (nint)text2 > -1;
		}

		internal int _003CLoad_003Eb__19_1(FileInfo a, FileInfo b)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_00c2: Expected Obj, but got I4
			//IL_00d0: Expected I4, but got Obj
			object obj2 = default;
			object obj = obj2 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
			object obj3 = default;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
			object obj4 = default;
			obj2 = obj4;
			object obj5 = obj2 + 16;
			obj5 = obj2;
			object obj6 = obj & 0x3FFFFFFFFFFFFFFFL;
			object obj7 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				return 1;
			}
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj8 = (flag ? 1u : 0u) << 31;
			return obj8 >> 31;
		}
	}

	public static int CopyTo(Stream stream, Stream destination)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0360: Expected Obj, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_00f0: Expected I, but got Obj
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 32;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = 0;
		object obj6 = obj2 + 16;
		obj6 = obj;
		_ = -1;
		if (stream != null)
		{
			nint num = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v25 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v120 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num3 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v73 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v113 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj5 = destination;
			object obj9 = obj5 + 4;
			obj9 = stream;
			obj2 = obj5;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			object obj10 = obj6 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj6 + obj12;
			obj13 = 78;
			if (obj4 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = obj6 + obj14;
				if ((nint)obj15 == 78)
				{
					object obj16 = obj6 + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					goto IL_0447;
				}
			}
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0447;
		IL_0447:
		int result = default;
		return result;
	}

	public static void ReadFully(Stream s, byte[] buffer)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = s + 8;
		obj = buffer;
	}

	public static void ReadFully(Stream s, byte[] buffer, int offset, int count)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_014c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00d1: Expected Obj, but got I4
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v31 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<int> enumerable = PluginUtil.RemoveHandlers(count);
		if (enumerable != null)
		{
			if ((object)enumerable.GetType() != typeof(FacebookSession.RequestCompleteHandler))
			{
				enumerable = null;
			}
		}
		else
		{
			enumerable = null;
		}
		if (enumerable != null)
		{
			if (offset != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				Manager.LogEvent(text, (Dictionary<string, object>)offset);
				string text2 = text;
			}
			else
			{
				string text2 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
		}
	}

	public static void WriteAllBytes(string filename, byte[] bytes)
	{
		//IL_0018: Expected Obj, but got I4
		StringUtility.ValidateEnumValueString((Type)(object)filename, (string)(object)bytes, mayBeNullOrEmpty: false, (string)bytes.Length);
	}

	public static byte[] ReadAllBytes(string filename)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected Obj, but got Unknown
		//IL_085f: Expected Obj, but got I4
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected Obj, but got Unknown
		//IL_0876: Expected Obj, but got I4
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected Obj, but got Unknown
		//IL_089f: Expected Obj, but got I4
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected Obj, but got Unknown
		//IL_08bc: Expected Obj, but got I4
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d6: Expected Obj, but got Unknown
		//IL_08df: Expected Obj, but got I4
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected Obj, but got Unknown
		//IL_0909: Expected I, but got Obj
		//IL_091f: Expected Obj, but got I
		//IL_0abb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Expected Obj, but got Unknown
		//IL_0ac9: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0b41: Expected Obj, but got I4
		//IL_079e: Expected Obj, but got I
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected Obj, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 128;
		object obj3 = obj2 + 120;
		obj3 = 0;
		object obj4 = obj2 + 92;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 + 80;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 56;
		obj6 = 0;
		_ = 0;
		_ = 0;
		object obj7 = obj2 + 32;
		obj7 = 0;
		object obj8 = obj2 + 48;
		obj8 = obj;
		_ = -1;
		nint num = (nint)typeof(Depository);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v31 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num2 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v378 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj10 = obj2 + 40;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj12 = default;
		object obj11 = obj12;
		object obj14 = default;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj15 = default;
		object obj16 = default;
		if (obj13 == obj15)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj17 = default;
			obj16 = obj17;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj8 + obj18;
			if ((nint)obj19 == 191)
			{
				object obj20 = obj8 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_0b3c;
			}
		}
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b3c;
		IL_0b3c:
		int num3 = default;
		return (byte[])num3;
	}

	public static byte[] ReadAllBytes(Stream stream)
	{
		//IL_000e: Invalid comparison between VT and I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		FileLoadException ex = default;
		ex._002Ector((string)(object)stream);
		DateTime lastWriteTimeUtc = ((FileSystemInfo)(object)ex).LastWriteTimeUtc;
		if (lastWriteTimeUtc > (object)int.MaxValue)
		{
			OverflowException ex2 = new OverflowException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		string filename = ((FileInfo)(object)ex).ToString();
		byte[] array = default;
		WriteAllBytes(filename, array);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		return array;
	}

	public static void SetLastWriteTimeUtc(FileInfo fileInfo, DateTime time)
	{
		//IL_002c: Expected I8, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector("Stream does not support seeking.");
		((System.Security.Cryptography.TailStream)(object)ex).Position = 0L;
	}

	public static DateTime GetLastWriteTimeUtc(FileInfo fileInfo)
	{
		//IL_0006: Expected VT, but got I4
		return (DateTime)(-1);
	}

	public static bool ArraysAreEqual<T>(T[] a, T[] b)
	{
		//IL_0013: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected Obj, but got Unknown
		//IL_0062: Expected Obj, but got I
		//IL_00cc: Expected Obj, but got I4
		//IL_031f: Expected Obj, but got I
		//IL_0343: Expected Obj, but got I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00e1: Expected Obj, but got I4
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I
		//IL_0133: Expected Obj, but got I4
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected Obj, but got Unknown
		//IL_0166: Expected Obj, but got I
		//IL_027b: Expected Obj, but got I
		//IL_02a6: Expected Obj, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got I
		//IL_0386: Expected Obj, but got I4
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_03aa: Expected Obj, but got I4
		//IL_03ba: Expected Obj, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected Obj, but got Unknown
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected Obj, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected Obj, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected Obj, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected Obj, but got Unknown
		//IL_0460: Expected VT, but got Obj
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected Obj, but got Unknown
		//IL_048a: Expected VT, but got Obj
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected Obj, but got Unknown
		//IL_04b4: Expected VT, but got Obj
		//IL_020d: Expected Obj, but got I4
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected Obj, but got Unknown
		//IL_0238: Expected Obj, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ L0 (T[])+8]");
		bool result;
		if ((nint)0 != 0)
		{
			nint num = default;
			object obj = num + 12;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj5 = default;
			object obj4 = obj5 & 0x7FFFFFFF;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ L0 (T[])+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
			object obj9;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
				object obj7 = obj4 / 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v15+C]");
				object obj8 = obj7 * 0;
				obj9 = obj4 - obj8;
			}
			else
			{
				obj9 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ L0 (T[])+8]");
			object obj10 = (nint)0 + (nint)16;
			object obj11 = obj9 << 2;
			object obj12 = obj10 + obj11;
			object obj13 = -1;
			object obj14 = obj12;
			object obj23 = default;
			while (true)
			{
				bool flag = (nint)obj14 < 0;
				result = false;
				if (flag)
				{
					break;
				}
				object obj15 = a.Length + 16;
				object obj16 = obj14 * 20;
				object obj17 = obj15 + obj16;
				if (obj17 == obj4)
				{
					object obj18 = a.Length + 16;
					object obj19 = obj14 * 20;
					object obj20 = obj18 + obj19;
					object obj21 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S1_v29+60]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
					if (obj23 != null)
					{
						if ((nint)obj13 > -1)
						{
							object obj24 = a.Length + 16;
							object obj25 = obj13 * 20;
							object obj26 = obj24 + obj25;
							object obj27 = a.Length + 16;
							object obj28 = obj14 * 20;
							object obj29 = obj27 + obj28;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v73+4]");
							_ = 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [a @ L0 (T[])+8]");
							object obj30 = (nint)0 + (nint)16;
							object obj31 = obj9 << 2;
							object obj32 = obj30 + obj31;
							object obj33 = a.Length + 16;
							object obj34 = obj14 * 20;
							object obj35 = obj33 + obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v65+4]");
							obj32 = 0;
						}
						object obj36 = a.Length + 16;
						object obj37 = obj14 * 20;
						object obj38 = obj36 + obj37;
						obj38 = -1;
						object obj39 = a.Length + 16;
						object obj40 = obj14 * 20;
						object obj41 = obj39 + obj40;
						_ = a[2];
						object obj42 = obj14 * 20;
						object obj43 = a.Length + obj42;
						object obj44 = obj43 + 24;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						object obj45 = obj14 * 20;
						object obj46 = a.Length + obj45;
						object obj47 = obj46 + 28;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						a[2] = (T)obj14;
						object obj48 = a[3] + 1;
						a[3] = (T)obj48;
						object obj49 = a[1] + 1;
						a[1] = (T)obj49;
						result = true;
						break;
					}
				}
				object obj50 = a.Length + 16;
				object obj51 = obj14 * 20;
				object obj52 = obj50 + obj51;
				obj13 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S0_v36+4]");
				obj14 = 0;
			}
		}
		else
		{
			result = false;
		}
		return result;
	}

	public unsafe static Dictionary<E, int> ReadEnumIntDictionary<E>(BinaryReader reader)
	{
		//IL_026f: Expected Obj, but got I
		//IL_001d: Expected Obj, but got I
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_0059: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected I, but got Unknown
		//IL_02bb: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I4
		//IL_02da: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_0100: Expected I, but got Obj
		//IL_0116: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0141: Expected I, but got Obj
		//IL_018e: Expected I, but got Obj
		//IL_01a4: Expected Obj, but got I
		//IL_0336: Expected Obj, but got I4
		//IL_01cf: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		nint num = default;
		object obj = num + 24;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v2+4]");
		object obj4 = 0;
		object obj5 = obj4 & 0x3FFF;
		object obj6 = obj5 + 97173;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v93 @ S3_v6 (should have been resolved before IL gen)");
		object obj7 = obj;
		nint num2 = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v20 (Il2CppClass<System.Type>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v63 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v17+8]");
		object obj9 = 0;
		nint num4 = (nint)(obj9 + 4);
		((IntPtr*)num4)->m_value = (void*)(nint)obj9;
		Type type = Type.internal_from_handle((IntPtr)num4);
		object obj10 = 97173;
		object obj11 = 0;
		object obj12 = default;
		Enum obj14 = default;
		Dictionary<E, int> result = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj12))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v40 (Il2CppClass<System.Enum>)+BA]");
				object obj13 = (nint)0 & (nint)0x200;
				if (obj13 != null)
				{
					nint num6 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v59 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((Enum)(object)type).InternalHasFlag(obj14))
				{
					nint num7 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v50 (Il2CppClass<System.Enum>)+BA]");
					object obj15 = (nint)0 & (nint)0x200;
					if (obj15 != null)
					{
						nint num8 = (nint)typeof(Enum);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v55 (Il2CppClass<System.Enum>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					break;
				}
				object obj16 = obj11 + 1;
				obj11 = obj16;
				continue;
			}
			return result;
		}
		string text = ((Enum)(object)type).ToString((string)(object)obj14, (IFormatProvider)1);
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		throw new NullReferenceException();
	}

	public static void WriteEnumIntDictionary<E>(BinaryWriter writer, IDictionary<E, int> dict)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_089f: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a4: Expected Obj, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected Obj, but got Unknown
		//IL_08c9: Expected Obj, but got I4
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d7: Expected Obj, but got Unknown
		//IL_08f3: Expected Obj, but got I
		//IL_09a4: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected Obj, but got Unknown
		//IL_0075: Expected Obj, but got I4
		//IL_008d: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_0959: Expected Obj, but got I
		//IL_0974: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_00f1: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I4
		//IL_07ec: Expected Obj, but got I
		//IL_0194: Expected Obj, but got I4
		//IL_0134: Expected Obj, but got I4
		//IL_01a7: Expected I, but got Obj
		//IL_01bd: Expected Obj, but got I
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected Obj, but got Unknown
		//IL_098c: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		//IL_01e8: Expected I, but got Obj
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I4
		//IL_022b: Expected Obj, but got I4
		//IL_0289: Expected Obj, but got I4
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected Obj, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected Obj, but got Unknown
		//IL_0751: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 16;
		object obj5 = obj2 + 8;
		obj5 = 0;
		object obj6 = obj2 + 24;
		obj6 = obj;
		_ = -1;
		nint num = default;
		object obj7 = num + 24;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7245");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj11 = default;
		object obj16 = default;
		object obj19 = default;
		object obj10;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 37;
			bool flag = obj11 == null;
			obj10 = 38;
			if (flag)
			{
				break;
			}
			object obj12 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj10 = 9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj10 = 9;
			obj5 = obj2;
			object obj13 = obj7;
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v140 (Il2CppClass<System.Type>)+BA]");
			object obj14 = (nint)0 & (nint)0x200;
			if (obj14 != null)
			{
				nint num3 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ S0_v217 (Il2CppClass<System.Type>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj10 = 10;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v137+C]");
			obj4 = 0;
			obj3 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 18;
			object obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 19;
			obj3 = obj16;
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj10 = 20;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 20;
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ S0_v178 (Il2CppClass<System.Enum>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num5 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ S0_v209 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj10 = 20;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj10 = 23;
			bool flag2 = obj19 == null;
			obj10 = 24;
			if (flag2)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj10 = 35;
			object obj20 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj10 = 36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		}
		object obj21 = obj10 - 9;
		object obj28;
		object obj29 = default;
		if ((nint)obj10 != 9)
		{
			if ((nint)obj21 != 1)
			{
				if ((nint)obj21 == 2 || (nint)obj21 == 3 || (nint)obj21 == 4 || (nint)obj21 == 5 || (nint)obj21 == 6 || (nint)obj21 == 7 || (nint)obj21 == 8)
				{
					goto IL_0a03;
				}
				if ((nint)obj21 != 9)
				{
					if ((nint)obj21 != 10)
					{
						object obj26;
						if ((nint)obj21 != 11)
						{
							if ((nint)obj21 == 12 || (nint)obj21 == 13)
							{
								goto IL_0a03;
							}
							if ((nint)obj21 != 14)
							{
								if ((nint)obj21 != 15)
								{
									if ((nint)obj21 == 16 || (nint)obj21 == 17 || (nint)obj21 == 18 || (nint)obj21 == 19 || (nint)obj21 == 20 || (nint)obj21 == 21 || (nint)obj21 == 22 || (nint)obj21 == 23 || (nint)obj21 == 24 || (nint)obj21 == 25)
									{
										goto IL_0a03;
									}
									if ((nint)obj21 != 26)
									{
										if ((nint)obj21 != 27)
										{
											if ((nint)obj21 != 28)
											{
												if ((nint)obj21 == 29)
												{
													object obj22 = obj6 + 4;
													object obj23 = obj22 + 1;
													obj22 = obj23;
													object obj24 = obj23 << 2;
													object obj25 = obj6 + obj24;
													obj25 = 110;
												}
												goto IL_0a03;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj27 = default;
											obj26 = obj27;
											obj28 = obj29;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj30 = default;
											obj26 = obj30;
											obj28 = obj29;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj31 = default;
										obj26 = obj31;
										obj28 = obj29;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj32 = default;
									obj26 = obj32;
									obj28 = obj29;
								}
								goto IL_09ae;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj33 = default;
						obj26 = obj33;
						obj28 = obj29;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj34 = default;
						object obj26 = obj34;
						obj28 = obj29;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj35 = default;
					object obj26 = obj35;
					obj28 = obj29;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj36 = default;
				object obj26 = obj36;
				obj28 = obj29;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj37 = default;
			object obj26 = obj37;
			obj28 = obj29;
		}
		goto IL_09ae;
		IL_0a03:
		object obj38 = default;
		if (obj38 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18+4]");
			object obj39 = (nint)0 << 2;
			object obj40 = obj6 + obj39;
			if ((nint)obj40 == 110)
			{
				object obj41 = obj6 + 4;
				if ((nint)obj41 > -1)
				{
					object obj42 = obj41 + -1;
					obj41 = obj42;
				}
				return;
			}
		}
		object obj43 = default;
		if (obj43 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		return;
		IL_09ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj44 = default;
		if (obj28 == obj44)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0a03;
	}

	public static Dictionary<E, string> ReadEnumStringDictionary<E>(BinaryReader reader)
	{
		return (Dictionary<E, string>)(object)reader.m_buffer;
	}

	public static void WriteEnumStringDictionary<E>(BinaryWriter writer, IDictionary<E, string> dict)
	{
		//IL_0018: Expected Obj, but got I
		//IL_0081: Expected Obj, but got I4
		//IL_0053: Expected Obj, but got I
		//IL_0063: Expected Obj, but got I
		//IL_00b9: Expected Obj, but got I
		//IL_00c9: Expected Obj, but got I
		//IL_011e: Expected Obj, but got I
		//IL_013b: Expected Obj, but got I4
		//IL_0408: Expected Obj, but got I
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected Obj, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01bf: Expected Obj, but got I4
		//IL_026e: Expected Obj, but got I
		//IL_0337: Expected Obj, but got I
		//IL_02fb: Expected Obj, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected Obj, but got Unknown
		//IL_031c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [writer @ L0 (System.IO.BinaryWriter)+34]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [writer @ L0 (System.IO.BinaryWriter)+34]");
		object obj3;
		object obj4;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [writer @ L0 (System.IO.BinaryWriter)+34]");
			object obj2 = (nint)0 + (nint)16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
			obj3 = 0;
			obj4 = obj2;
		}
		else
		{
			obj4 = writer;
			obj3 = 1;
		}
		object obj5 = default;
		object obj23 = default;
		object obj21 = default;
		for (; obj5 != obj3; obj5 = obj23 + 1)
		{
			object obj6 = obj5 << 2;
			object obj7 = obj4 + obj6;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+10]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+14]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+28]");
			if ((nint)0 == -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+24]");
			object obj11 = (nint)0 & (nint)0x10;
			bool flag = obj11 == null;
			object obj12 = (flag ? 1 : 0) ^ 1;
			IDictionary<E, string> dictionary;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+2A]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
					object obj13 = (nint)0 & (nint)0x3FFF;
					object obj14 = obj13 + 80504;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v110 @ S2_v18 (should have been resolved before IL gen)");
					dictionary = (IDictionary<E, string>)80504;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
					object obj15 = (nint)0 & (nint)0x3FFF;
					dictionary = (IDictionary<E, string>)(obj15 + 97173);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S3_v6 (System.Collections.Generic.IDictionary`2<E, System.String>) (should have been resolved before IL gen)");
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+28]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+10]");
				bool flag2;
				if ((nint)0 != 0)
				{
					object obj16 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S0_v62+9C]");
					object obj17 = (nint)0 & (nint)0x100;
					flag2 = obj17 != null;
				}
				else
				{
					flag2 = false;
				}
				if (!flag2 && writer._buffer != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+10]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
						object obj18 = (nint)0 & (nint)0x3FFF;
						object obj19 = obj18 + 80504;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v159 @ S2_v13 (should have been resolved before IL gen)");
						dictionary = (IDictionary<E, string>)80504;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v19+2B]");
					object obj20 = (nint)0 & (nint)3;
					bool flag3 = (nint)obj20 == 2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
					if (flag3)
					{
						if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A75");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A76");
						}
					}
					else if (obj21 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
						dictionary = dict;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
					}
					continue;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v14+8]");
			object obj22 = (nint)0 & (nint)0x3FFF;
			dictionary = (IDictionary<E, string>)(obj22 + 97173);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S3_v6 (System.Collections.Generic.IDictionary`2<E, System.String>) (should have been resolved before IL gen)");
		}
	}

	public static Dictionary<string, string> ReadStringStringDictionary(BinaryReader reader)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01f7: Expected Obj, but got I4
		//IL_02c1: Expected Obj, but got I
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected Obj, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (reader == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("stream");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		object obj3 = default;
		Dictionary<string, string> result = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Dictionary<string, string> dictionary = default;
			result = dictionary;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj4 = default;
			if (obj4 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7569");
				object obj5 = default;
				if ((nint)obj5 > int.MaxValue)
				{
					OverflowException ex2 = new OverflowException();
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				byte[] array = default;
				bool flag = array.Length == 0;
				result = (Dictionary<string, string>)(object)array;
				if (!flag)
				{
					WriteAllBytes((string)(object)reader, array);
					result = (Dictionary<string, string>)(object)array;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				MemoryStream memoryStream = default;
				memoryStream.EnsureWriteable();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj6 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
					if ((nint)obj6 < 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj7 = obj2 + 4;
				object obj8 = obj7 + 1;
				obj7 = obj8;
				object obj9 = obj8 << 2;
				object obj10 = obj2 + obj9;
				obj10 = 133;
				if (memoryStream != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				Dictionary<string, string> dictionary2 = default;
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj11 = (nint)0 << 2;
					object obj12 = obj2 + obj11;
					if ((nint)obj12 == 133)
					{
						object obj13 = obj2 + 4;
						if ((nint)obj13 > -1)
						{
							object obj14 = obj13 + -1;
							obj13 = obj14;
						}
						result = dictionary2;
						goto IL_0399;
					}
				}
				object obj15 = default;
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				else
				{
					result = dictionary2;
				}
			}
		}
		goto IL_0399;
		IL_0399:
		return result;
	}

	public static void WriteStringStringDictionary(BinaryWriter writer, IDictionary<string, string> dict)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		string text = (string)(dict + 8);
		text = (string)(object)dict;
		((FileSystemInfo)(object)writer).DisplayPath = text;
	}

	private static int GetSlotForPath(string path)
	{
		//IL_00c4: Expected Obj, but got I
		//IL_00d4: Expected Obj, but got I
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected Obj, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected Obj, but got Unknown
		//IL_010b: Expected Obj, but got I4
		//IL_0034: Expected Obj, but got I
		//IL_0044: Expected Obj, but got I
		//IL_0054: Expected Obj, but got I
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S4_v4 (should have been resolved before IL gen)");
		object obj6 = 0;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S4_v7 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S4_v8+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S4_v9+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v44 @ S5_v7 (should have been resolved before IL gen)");
			object obj13 = obj6 + 1;
			obj6 = obj13;
		}
		int result = default;
		return result;
	}

	public static FileInfo[] GetFilesForPath(string path, bool slotsOnly = false)
	{
		if (path == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex = default;
			ex._002Ector("stream");
			CopyTo((Stream)(object)ex, null);
		}
		if (!slotsOnly)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentOutOfRangeException ex2 = default;
			ex2._002Ector("destination");
			CopyTo((Stream)(object)ex2, null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		FileInfo[] array = null;
		object obj = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @730A");
			if ((nint)obj < 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
			FileInfo[] array2 = (FileInfo[])(object)(obj + (object)array);
			array = array2;
		}
		return array;
	}

	private static int GetMostRecentSlot(string path, bool fixTimestamps)
	{
		//IL_02d7: Expected I, but got Obj
		//IL_02ed: Expected Obj, but got I
		//IL_032e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I
		//IL_013e: Expected I4, but got Obj
		//IL_00e8: Expected I, but got Obj
		//IL_03a0: Expected Obj, but got I
		//IL_0130: Expected I4, but got Obj
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_0195: Expected I, but got Obj
		//IL_01ab: Expected Obj, but got I
		//IL_0488: Expected I4, but got Obj
		//IL_01d6: Expected I, but got Obj
		//IL_0223: Expected I, but got Obj
		//IL_0239: Expected Obj, but got I
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected Obj, but got Unknown
		//IL_0443: Expected I, but got Obj
		//IL_0459: Expected Obj, but got I
		//IL_0264: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v105 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string extension = Path.GetExtension(path);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		DirectoryInfo directoryInfo = default;
		directoryInfo.Delete((byte)(int)extension != 0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj4 = default;
			object obj3 = obj4 + 12;
			object obj5 = default;
			obj3 = obj5;
			nint num3 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v32 (Il2CppClass<System.IO.Path>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num4 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v101 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj7 = obj4 + 8;
			string fullPath = Path.GetFullPath(path);
			obj7 = fullPath;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v29+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S2_v7+8]");
			int totalLength = (((nint)0 == 0) ? ((int)"*") : ((int)".*"));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v29+8]");
			string searchPattern = string.ConcatArray((string[])0, totalLength);
			DirectoryInfo[] directories = directoryInfo.GetDirectories(searchPattern);
			if (directories.Length >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Predicate<FileInfo> predicate = default;
				object obj9 = predicate + 16;
				obj9 = obj4;
				FileInfo[] array = Array.FindAll((FileInfo[])(object)directories, predicate);
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ S0_v58 (Il2CppClass<Kiloo.Common.Utility.FileUtil+<>c>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num7 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v95 (Il2CppClass<Kiloo.Common.Utility.FileUtil+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = _003C_003Ec._003C_003E9__16_1 == null;
				bool flag2 = !flag;
				Comparison<FileInfo> comparison = _003C_003Ec._003C_003E9__16_1;
				if (!flag2)
				{
					nint num8 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ S0_v69 (Il2CppClass<Kiloo.Common.Utility.FileUtil+<>c>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num9 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S0_v89 (Il2CppClass<Kiloo.Common.Utility.FileUtil+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num10 = 0;
					_ = 0;
					Comparison<FileInfo> comparison2 = default;
					object obj12 = comparison2 + 16;
					obj12 = _003C_003Ec._003C_003E9;
					nint num11 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S0_v86 (Il2CppClass<Kiloo.Common.Utility.FileUtil+<>c>)+5C]");
					object obj13 = (nint)0 + (nint)4;
					obj13 = comparison2;
					comparison = comparison2;
				}
				Array.Sort(array, comparison);
				return (int)array;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int result = default;
		return result;
	}

	private unsafe static byte[] TryLoadFile(string path, byte[] secretBytes = null)
	{
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected VT, but got Unknown
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected Obj, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected Obj, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected Obj, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected Obj, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected Obj, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected Obj, but got Unknown
		//IL_02ae: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0056: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_0391: Expected Obj, but got VT
		//IL_039e: Expected I8, but got Obj
		//IL_0399: Expected native int or pointer, but got VT
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_0097: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0406: Expected Obj, but got VT
		//IL_0413: Expected I8, but got Obj
		//IL_040e: Expected native int or pointer, but got VT
		//IL_0428: Expected Ref, but got VT
		//IL_043a: Expected I, but got Obj
		//IL_0450: Expected Obj, but got I
		//IL_0487: Expected Obj, but got I8
		//IL_048f: Expected Obj, but got VT
		//IL_049c: Expected I8, but got Obj
		//IL_0497: Expected native int or pointer, but got VT
		//IL_04b7: Expected Obj, but got I4
		//IL_012f: Expected I, but got Obj
		//IL_017c: Expected I, but got Obj
		//IL_01c9: Expected Obj, but got I4
		//IL_01f2: Expected Obj, but got I4
		//IL_0225: Expected I, but got Obj
		//IL_023b: Expected Obj, but got I
		//IL_04fd: Expected I8, but got Obj
		//IL_04f8: Expected native int or pointer, but got VT
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected Obj, but got Unknown
		//IL_0266: Expected I, but got Obj
		object obj = default;
		IFormatProvider formatProvider = (IFormatProvider)(obj + 80);
		DateTime dateTime = (DateTime)(obj - -64);
		object obj2 = obj + 72;
		object obj3 = obj + 56;
		object obj4 = obj + 48;
		object obj5 = obj + 40;
		object obj6 = obj + 32;
		object obj7 = obj + 24;
		object obj8 = obj + 16;
		object obj9 = obj + 8;
		int mostRecentSlot = GetMostRecentSlot(path, fixTimestamps: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v29 (System.Int32)+C]");
		if ((nint)0 > (nint)0)
		{
			object obj10 = mostRecentSlot + 16;
			if (secretBytes != null)
			{
				DateTime today = CDateTime.Today;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
				nint num = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v47 (Il2CppClass<System.DateTime>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num2 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v103 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj12 = default;
				obj2 = obj12;
				obj3 = today;
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj2;
				formatProvider = (IFormatProvider)obj3;
				long num3 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
				object obj13 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
				if (num3 > (long)obj13)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
					nint num4 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v62 (Il2CppClass<System.DateTime>)+BA]");
					object obj14 = (nint)0 & (nint)0x200;
					if (obj14 != null)
					{
						nint num5 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v99 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					object obj15 = default;
					obj4 = obj15;
					obj5 = today;
					((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
					formatProvider = (IFormatProvider)obj5;
					long num6 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
					nint num7 = (nint)typeof(TimeSpan);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S0_v73 (Il2CppClass<System.TimeSpan>)+BA]");
					object obj16 = (nint)0 & (nint)0x200;
					if (obj16 != null)
					{
						nint num8 = (nint)typeof(TimeSpan);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v95 (Il2CppClass<System.TimeSpan>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					TimeSpan timeSpan = TimeSpan.FromSeconds(1.0);
					obj6 = num6;
					obj7 = timeSpan;
					((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj6;
					formatProvider = (IFormatProvider)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3F8");
					object obj17 = 0;
					object obj25 = default;
					object obj26 = default;
					object obj27 = default;
					while (true)
					{
						object obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v29 (System.Int32)+C]");
						if ((nint)obj18 >= 0)
						{
							break;
						}
						object obj19 = mostRecentSlot + 16;
						object obj20 = obj17 << 2;
						object writer = obj19 + obj20;
						object obj21 = mostRecentSlot + 16;
						object obj22 = obj17 << 2;
						object obj23 = obj21 + obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
						nint num9 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ S1_v62 (Il2CppClass<System.DateTime>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						if (obj24 != null)
						{
							nint num10 = (nint)typeof(DateTime);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ S1_v74 (Il2CppClass<System.DateTime>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						obj8 = obj25;
						obj9 = obj26;
						((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj8;
						formatProvider = (IFormatProvider)obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCF2");
						obj = obj27;
						formatProvider = (IFormatProvider)obj;
						WriteStringStringDictionary((BinaryWriter)writer, (IDictionary<string, string>)formatProvider);
						object obj28 = obj17 + 1;
						obj17 = obj28;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string path2 = default;
			return (byte[])(object)PathHandling.UnifyDirectorySeparators(path2);
		}
		return (byte[])(-1);
	}

	public static byte[] Load(string path, string secret = null, string alternatePath = null, bool useLastModifiedPathIfNoSlots = false)
	{
		return null;
	}

	public static void Save(string path, byte[] data, string secret = null, int offset = 0, int length = -1, int redundancy = 0, int slots = 0, string alternatePath = null, int alternateRedundancy = 0, int alternateSlots = 0)
	{
	}

	public static void SafeSave(string path, byte[] data, string secret = null, int offset = 0, int length = -1)
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_017b: Expected I4, but got Obj
		//IL_017b: Expected Obj, but got I4
		//IL_018d: Expected I, but got Obj
		//IL_01a3: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookSession context = FacebookSession.Create((string)length, (FacebookDefaultAudience)path);
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v19 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v15 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<int> enumerable = PluginUtil.RemoveHandlers(context);
	}

	public static void LogError(string msg)
	{
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = msg == null;
		int num3 = ((ComputeShader)(object)CoroutineUtil._coroutineRunner).FindKernel((string)null);
		int num4 = num3 ^ 1;
		if (((flag ? 1u : 0u) | (uint)num4) == 0)
		{
			CoroutineUtil._coroutineRunner.StopCoroutine(msg);
		}
	}

	public static void LogWarning(string msg)
	{
		//IL_0013: Expected I4, but got Obj
		string msg2 = string.ConcatArray((string[])(object)"[FileUtil] ", (int)msg);
		SDebug.LogFormat(msg2, null);
	}

	public static void Log(string msg)
	{
	}
}
