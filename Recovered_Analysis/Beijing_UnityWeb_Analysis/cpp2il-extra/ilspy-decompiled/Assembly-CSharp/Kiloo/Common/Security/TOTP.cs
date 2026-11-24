using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.Plugins.Notifications;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Security;

public class TOTP
{
	private static string _appString;

	public static string NewTOTP()
	{
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		//IL_007c: Expected VT, but got Obj
		//IL_0085: Expected Obj, but got VT
		//IL_0093: Expected I, but got Obj
		//IL_00a9: Expected Obj, but got I
		//IL_00d4: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (StaticUpdater._instance != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GameObject gameObject = default;
			gameObject.layer = (int)"StaticUpdater";
			_0021_00210 val = (_0021_00210)GameObjectExtensions.GetComponentInParents<T>(gameObject);
			StaticUpdater._instance = (StaticUpdater)val;
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
		}
		return (string)(object)StaticUpdater._instance;
	}

	private unsafe static string Eius()
	{
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected Obj, but got Unknown
		//IL_0514: Expected Obj, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_052b: Expected Obj, but got I4
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected Obj, but got Unknown
		//IL_0542: Expected Obj, but got I4
		//IL_054b: Expected Obj, but got I4
		//IL_0559: Expected I, but got Obj
		//IL_056f: Expected Obj, but got I
		//IL_06e4: Expected I, but got Obj
		//IL_06fa: Expected Obj, but got I
		//IL_05ac: Expected I, but got Obj
		//IL_05c2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_05f0: Expected Obj, but got I8
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00f5: Expected Obj, but got I4
		//IL_0661: Expected I, but got Obj
		//IL_0677: Expected Obj, but got I
		//IL_014f: Expected Obj, but got I4
		//IL_0174: Expected I, but got Obj
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected Obj, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected Obj, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected Obj, but got Unknown
		//IL_0269: Expected Obj, but got I4
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected Obj, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected Obj, but got Unknown
		//IL_02ba: Expected Obj, but got I4
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected Obj, but got Unknown
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected Obj, but got Unknown
		//IL_031e: Expected I4, but got Obj
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected Obj, but got Unknown
		//IL_035a: Expected I4, but got Obj
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_0396: Expected I4, but got Obj
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		//IL_03d2: Expected I4, but got Obj
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_040e: Expected I4, but got Obj
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected Obj, but got Unknown
		//IL_044a: Expected I4, but got Obj
		//IL_047d: Expected I, but got Obj
		//IL_0493: Expected Obj, but got I
		//IL_06c4: Expected Obj, but got I4
		//IL_04be: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = 0;
		obj2 = 0;
		nint num = (nint)typeof(TOTP);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<Kiloo.Common.Security.TOTP>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(TOTP);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v117 (Il2CppClass<Kiloo.Common.Security.TOTP>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		INotifications instance = Notifications.instance;
		nint num3 = (nint)typeof(TimeSpan);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v23 (Il2CppClass<System.TimeSpan>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(TimeSpan);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v113 (Il2CppClass<System.TimeSpan>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3EB");
		object obj7 = default;
		obj = obj7;
		nint num5 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v29 (Il2CppClass<System.DateTime>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num6 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v109 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		obj2 = systemTimeAsFileTime;
		object obj9 = obj2 & 0x3FFFFFFFFFFFFFFFL;
		object obj10;
		if (obj == null)
		{
			obj10 = 0;
		}
		else
		{
			bool flag = (long)obj9 == long.MinValue;
			bool flag2 = (nint)obj == -1;
			object obj11 = flag & flag2;
			obj10 = ((obj11 == null) ? (obj9 / obj) : ((object)0));
		}
		object obj12 = obj * obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC7F");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC95");
		object obj13 = default;
		obj4 = obj13;
		nint num7 = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v37 (Il2CppClass<System.BitConverter>)+BA]");
		object obj14 = (nint)0 & (nint)0x200;
		if (obj14 != null)
		{
			nint num8 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v105 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		char hexValue = BitConverter.GetHexValue(4407627);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBA");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E22C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCBA");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E22C");
		Encoding uTF = Encoding.UTF32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7308");
		bool receiveNotifications = default;
		INotifications notifications = Notifications.Init(receiveNotifications);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		TOTP tOTP = default;
		object obj15 = tOTP + 16;
		string text = ((bool*)(ushort)hexValue)->ToString(null);
		obj15 = text;
		object obj16 = tOTP + 20;
		bool flag3 = default;
		string text2 = (flag3 ? ((bool*)1) : ((bool*)null))->ToString(null);
		obj16 = text2;
		object obj17 = tOTP + 24;
		string text3 = (flag3 ? ((bool*)1) : ((bool*)null))->ToString((IFormatProvider)4);
		obj17 = text3;
		object obj18 = tOTP + 28;
		bool flag4 = default;
		string text4 = (flag4 ? ((bool*)1) : ((bool*)null))->ToString(null);
		obj18 = text4;
		object obj19 = tOTP + 32;
		string text5 = (flag4 ? ((bool*)1) : ((bool*)null))->ToString((IFormatProvider)4);
		obj19 = text5;
		object obj20 = tOTP + 36;
		string text6 = ((bool*)notifications)->ToString(null);
		obj20 = text6;
		tOTP._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj21 = tOTP + 16;
		char hexValue2 = BitConverter.GetHexValue((int)obj21);
		int num9 = default;
		*(decimal*)(int)hexValue2 = new decimal(0, num9, 0, 4);
		object obj22 = tOTP + 20;
		char hexValue3 = BitConverter.GetHexValue((int)obj22);
		*(decimal*)(int)hexValue3 = new decimal(0, num9, 4, 4);
		object obj23 = tOTP + 24;
		char hexValue4 = BitConverter.GetHexValue((int)obj23);
		*(decimal*)(int)hexValue4 = new decimal(0, num9, 8, 4);
		object obj24 = tOTP + 28;
		char hexValue5 = BitConverter.GetHexValue((int)obj24);
		*(decimal*)(int)hexValue5 = new decimal(0, num9, 12, 4);
		object obj25 = tOTP + 32;
		char hexValue6 = BitConverter.GetHexValue((int)obj25);
		*(decimal*)(int)hexValue6 = new decimal(0, num9, 16, 4);
		object obj26 = tOTP + 36;
		char hexValue7 = BitConverter.GetHexValue((int)obj26);
		*(decimal*)(int)hexValue7 = new decimal(0, num9, 20, 4);
		nint num10 = (nint)typeof(Convert);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v95 (Il2CppClass<System.Convert>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num11 = (nint)typeof(Convert);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v101 (Il2CppClass<System.Convert>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (string)(object)Convert.FromBase64String((string)num9);
	}

	private static byte[] Amare(byte[] input)
	{
		//IL_001f: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [input @ L0 (System.Byte[])+9]");
		bool flag = (nint)0 != 0;
		return (byte[])flag;
	}

	private static void Quia(uint[] words)
	{
	}

	public TOTP()
	{
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected Obj, but got Unknown
		//IL_03e8: Expected Obj, but got I4
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected Obj, but got Unknown
		//IL_03ff: Expected Obj, but got I4
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected Obj, but got Unknown
		//IL_0416: Expected Obj, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected Obj, but got Unknown
		//IL_042d: Expected Obj, but got I4
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected Obj, but got Unknown
		//IL_044e: Expected Obj, but got I4
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected Obj, but got Unknown
		//IL_0465: Expected Obj, but got I4
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected Obj, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_00a0: Expected Obj, but got I4
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected Obj, but got Unknown
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected Obj, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected Obj, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected Obj, but got Unknown
		//IL_00e8: Expected Obj, but got I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected Obj, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected Obj, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected Obj, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected Obj, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected Obj, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected Obj, but got Unknown
		//IL_021e: Expected Obj, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = -1129001104;
		object obj3 = obj2 + 20;
		obj3 = -197885817;
		object obj4 = obj2 + 24;
		obj4 = 750882823;
		object obj5 = obj2 + 28;
		obj5 = -1338053744;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj7 = default;
		object obj6 = obj7 + 16;
		obj6 = -443996793;
		object obj8 = obj7 + 20;
		obj8 = 371777625;
		object obj9 = this + 12;
		object obj10 = default;
		object obj74 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj10) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9))
		{
			object obj11 = this + 16;
			object obj12 = obj10 << 2;
			object obj13 = obj11 + obj12;
			object obj14 = obj7 + 16;
			object obj15 = obj14 ^ obj13;
			obj13 = obj15;
			object obj16 = obj10 << 2;
			object obj17 = (object)this + obj16;
			object obj18 = obj17 + 20;
			object obj19 = obj7 + 20;
			object obj20 = obj19 ^ obj18;
			obj18 = obj20;
			object obj21 = 32;
			while (true)
			{
				object obj22 = obj21 - 1;
				if (obj21 == null)
				{
					break;
				}
				object obj23 = this + 16;
				object obj24 = obj10 << 2;
				object obj25 = obj23 + obj24;
				object obj26 = obj2 + 16;
				object obj27 = 0 & 3;
				object obj28 = obj27 << 2;
				object obj29 = obj26 + obj28;
				object obj30 = obj29 + 0;
				object obj31 = obj10 << 2;
				object obj32 = (object)this + obj31;
				object obj33 = obj32 + 20;
				object obj34 = obj10 << 2;
				object obj35 = (object)this + obj34;
				object obj36 = obj35 + 20;
				object obj37 = obj36 >> 5;
				object obj38 = obj10 << 2;
				object obj39 = (object)this + obj38;
				object obj40 = obj39 + 20;
				object obj41 = obj40 << 4;
				object obj42 = obj37 ^ obj41;
				object obj43 = obj33 + obj42;
				object obj44 = obj30 ^ obj43;
				object obj45 = obj44 + obj25;
				obj25 = obj45;
				object obj46 = obj10 << 2;
				object obj47 = (object)this + obj46;
				object obj48 = obj47 + 20;
				object obj49 = obj2 + 16;
				object obj50 = 0 + -1640531527;
				object obj51 = obj50 >> 11;
				object obj52 = obj51 & 3;
				object obj53 = obj52 << 2;
				object obj54 = obj49 + obj53;
				object obj55 = obj54 + obj50;
				object obj56 = this + 16;
				object obj57 = obj10 << 2;
				object obj58 = obj56 + obj57;
				object obj59 = this + 16;
				object obj60 = obj10 << 2;
				object obj61 = obj59 + obj60;
				object obj62 = obj61 >> 5;
				object obj63 = this + 16;
				object obj64 = obj10 << 2;
				object obj65 = obj63 + obj64;
				object obj66 = obj65 << 4;
				object obj67 = obj62 ^ obj66;
				object obj68 = obj58 + obj67;
				object obj69 = obj55 ^ obj68;
				object obj70 = obj69 + obj48;
				obj48 = obj70;
				obj21 = obj22;
			}
			object obj71 = obj7 + 16;
			object obj72 = this + 16;
			object obj73 = obj74 << 2;
			object obj75 = obj72 + obj73;
			obj71 = obj75;
			object obj76 = obj7 + 20;
			object obj77 = obj74 << 2;
			object obj78 = (object)this + obj77;
			object obj79 = obj78 + 20;
			obj76 = obj79;
			obj10 = obj74 + 2;
		}
	}

	static TOTP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		throw new ArrayTypeMismatchException();
	}
}
