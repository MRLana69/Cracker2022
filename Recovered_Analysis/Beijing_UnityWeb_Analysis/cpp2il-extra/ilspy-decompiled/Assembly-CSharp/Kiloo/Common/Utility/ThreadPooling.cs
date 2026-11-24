using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Monetization.FlurryPlugin;
using UnityEngine;

namespace Kiloo.Common.Utility;

public class ThreadPooling : MonoBehaviour
{
	public delegate void ProgressDelegate(Action progress);

	private class Task
	{
		public Action process;

		public StackTrace stackTrace;
	}

	private static ThreadPooling s_instance;

	private readonly List<Action> LockedTasks;

	private readonly List<Action> Tasks;

	private readonly List<Exception> LockedExceptions;

	private readonly List<Exception> Exceptions;

	private static int _numThreads;

	public static void QueueUserWorkItem(Action task, Action callback)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected Obj, but got Unknown
		Delegate obj = (Delegate)((Delegate)task).m_target;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)callback);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = task + 16;
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

	public static void QueueUserWorkItemWithProgress(Action<ProgressDelegate> task, Action callback)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_005d: Expected VT, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = task;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		DateTimeOffset dateTimeOffset = TimeUtility.TrimToWholeSeconds((DateTimeOffset)callback);
	}

	private unsafe void RunAsync(Action<ProgressDelegate> task, Action callback)
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_012a: Expected I4, but got Obj
		//IL_0125: Expected native int or pointer, but got Obj
		//IL_0138: Expected Obj, but got I4
		//IL_0141: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_002e: Expected I, but got Obj
		//IL_0044: Expected Obj, but got I
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected Obj, but got Unknown
		//IL_00e7: Expected Obj, but got I4
		//IL_006f: Expected I, but got Obj
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected I4, but got Unknown
		//IL_00cc: Expected Obj, but got I4
		object obj = callback + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		*(decimal*)(nint)callback = new decimal(0, num, 0, (int)obj);
		object obj2 = num + 12;
		object obj3 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
		{
			object obj4 = num + 16;
			object obj5 = obj4 + obj3;
			nint num2 = (nint)typeof(ObfuscatedMemory);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v18 (Il2CppClass<Kiloo.Common.Utility.ObfuscatedMemory>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num3 = (nint)typeof(ObfuscatedMemory);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v25 (Il2CppClass<Kiloo.Common.Utility.ObfuscatedMemory>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj7 = ObfuscatedMemory.Key + 16;
			byte[] key = ObfuscatedMemory.Key;
			object obj9;
			if (key.Length != 0)
			{
				int num4 = obj3 / key.Length;
				object obj8 = num4 * key.Length;
				obj9 = obj3 - obj8;
			}
			else
			{
				obj9 = 0;
			}
			object obj10 = obj7 + obj9;
			object obj11 = obj10 ^ obj5;
			obj5 = obj11;
			object obj12 = obj3 + 1;
			obj3 = obj12;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
	}

	private static void RunAction(object newTask)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public static void Foreach<T>(IList<T> elements, Action<T, ProgressDelegate> iterate, Action callback)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		object obj = elements + 8;
		obj = iterate;
		object obj2 = elements + 12;
		obj2 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		FlurryVideoAds.LogError(text, (UnityEngine.Object)null);
		object obj3 = elements + 16;
		obj3 = text;
	}

	public static void For(int start, int end, Action<int, ProgressDelegate> iterate, Action callback)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006d: Expected I, but got Obj
		//IL_0083: Expected Obj, but got I
		//IL_00ae: Expected I, but got Obj
		//IL_01e5: Expected I, but got Obj
		//IL_01fb: Expected Obj, but got I
		//IL_02e0: Expected Obj, but got I4
		//IL_0226: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		bool flag;
		if (end != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [end @ L1 (System.Int32)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			if (iterate != null)
			{
				return;
			}
			nint num = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v19 (Il2CppClass<System.Enum>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v28 (Il2CppClass<System.Enum>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string[] array = Enum.InternalGetNames((System.RuntimeType)start);
			string provider = StringUtility.ArrayToString(array);
			object msg = ((IConvertible)(object)callback).ToType((Type)(object)" must be one of: ", (IFormatProvider)(object)provider);
			SDebug.LogFormat((string)msg, null);
			return;
		}
		nint num3 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v34 (Il2CppClass<System.Enum>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v82 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
	}

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected Obj, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0212: Expected Obj, but got I4
		//IL_0370: Expected I, but got Obj
		//IL_0386: Expected Obj, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected Obj, but got Unknown
		//IL_022d: Expected Obj, but got I
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected Obj, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7510");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj3 = obj2 + 4;
		object obj4 = obj3 + 1;
		obj3 = obj4;
		object obj5 = obj4 << 2;
		object obj6 = obj2 + obj5;
		obj6 = 54;
		nint num = (nint)typeof(ThreadPooling);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v22 (Il2CppClass<Kiloo.Common.Utility.ThreadPooling>)+5C]");
		object obj7 = (nint)0 + (nint)4;
		object obj8 = obj7 + -1;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj9 = (nint)0 << 2;
			object obj10 = obj2 + obj9;
			if ((nint)obj10 == 54)
			{
				object obj11 = obj2 + 4;
				if ((nint)obj11 > -1)
				{
					object obj12 = obj11 + -1;
					obj11 = obj12;
				}
				return;
			}
		}
		object obj13 = default;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public unsafe static void Destroy()
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00c4: Expected Obj, but got I
		//IL_012a: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		nint num = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Convert>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v28 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int day = ((DateTime*)"SkYxaKhp/oTeXLy00IHiqg==")->Day;
		ObfuscatedMemory.Key = (byte[])day;
		object obj2 = 0;
		while (true)
		{
			byte[] key = ObfuscatedMemory.Key;
			if ((nint)obj2 < key.Length)
			{
				object obj3 = ObfuscatedMemory.Key + 16;
				object obj4 = obj3 + obj2;
				object obj5 = obj4 ^ -92;
				obj4 = obj5;
				object obj6 = obj2 + 1;
				obj2 = obj6;
				continue;
			}
			break;
		}
	}

	public ThreadPooling()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected Obj, but got Unknown
		//IL_07e8: Expected Obj, but got I4
		//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f6: Expected Obj, but got Unknown
		//IL_07ff: Expected Obj, but got I4
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected Obj, but got Unknown
		//IL_081c: Expected Obj, but got I4
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected Obj, but got Unknown
		//IL_0847: Expected Obj, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected Obj, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected Obj, but got Unknown
		//IL_0104: Expected Obj, but got I4
		//IL_010d: Expected Obj, but got I4
		//IL_01a8: Expected Obj, but got I
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected Obj, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected Obj, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected Obj, but got Unknown
		//IL_02da: Expected Obj, but got I4
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0912: Expected Obj, but got I4
		//IL_038b: Expected Obj, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected Obj, but got Unknown
		//IL_04aa: Expected Obj, but got I4
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected Obj, but got Unknown
		//IL_0583: Expected Obj, but got I
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected Obj, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected Obj, but got Unknown
		//IL_071c: Expected Obj, but got I
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected Obj, but got Unknown
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 56;
		obj3 = 0;
		object obj4 = obj2 + 40;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 24;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 16;
		obj6 = obj;
		_ = -1;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj7 = obj6 + 4;
		object obj8 = obj7 + 1;
		obj7 = obj8;
		object obj9 = obj8 << 2;
		object obj10 = obj6 + obj9;
		obj10 = 68;
		object obj11 = 0;
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj6 + obj12;
			if ((nint)obj13 == 68)
			{
				object obj14 = obj6 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_08e5;
			}
		}
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_08e5;
		IL_0909:
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		object obj16 = obj6 + 4;
		object obj17 = obj16 + 1;
		obj16 = obj17;
		object obj18 = obj17 << 2;
		object obj19 = obj6 + obj18;
		obj19 = 187;
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj6 + obj20;
			if ((nint)obj21 == 187)
			{
				object obj22 = obj6 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0921;
			}
		}
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0921;
		IL_08e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj24 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj24 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		}
		object obj25 = obj6 + 4;
		object obj26 = obj25 + 1;
		obj25 = obj26;
		object obj27 = obj26 << 2;
		object obj28 = obj6 + obj27;
		obj28 = 119;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj29 = (nint)0 << 2;
			object obj30 = obj6 + obj29;
			if ((nint)obj30 == 119)
			{
				object obj31 = obj6 + 4;
				if ((nint)obj31 > -1)
				{
					object obj32 = obj31 + -1;
					obj31 = obj32;
				}
				goto IL_0909;
			}
		}
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0909;
		IL_0921:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj33 = default;
		object obj34 = default;
		bool flag = obj33 != obj34;
		object obj36 = default;
		object obj35 = obj36;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj37 = default;
			obj11 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
				object obj38 = (nint)0 << 2;
				object obj39 = obj6 + obj38;
				if ((nint)obj39 == 235)
				{
					object obj40 = obj6 + 4;
					if ((nint)obj40 > -1)
					{
						object obj41 = obj40 + -1;
						obj40 = obj41;
					}
					return;
				}
			}
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
	}
}
