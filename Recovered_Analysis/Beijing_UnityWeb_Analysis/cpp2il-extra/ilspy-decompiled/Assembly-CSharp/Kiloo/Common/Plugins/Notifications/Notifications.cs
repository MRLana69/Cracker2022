using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Security;

namespace Kiloo.Common.Plugins.Notifications;

public static class Notifications
{
	public unsafe static INotifications instance
	{
		get
		{
			//IL_029a: Expected I, but got Obj
			//IL_02b0: Expected Obj, but got I
			//IL_03a3: Expected I, but got Obj
			//IL_03b9: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_024d: Expected I, but got Obj
			//IL_00ab: Expected I, but got Obj
			//IL_0172: Expected I, but got Obj
			//IL_0188: Expected Obj, but got I
			//IL_0313: Expected Obj, but got I4
			//IL_0325: Expected I, but got Obj
			//IL_033b: Expected Obj, but got I
			//IL_01b3: Expected I, but got Obj
			//IL_0200: Expected I, but got Obj
			nint num = (nint)typeof(TOTP);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Security.TOTP>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(TOTP);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v73 (Il2CppClass<Kiloo.Common.Security.TOTP>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (TOTP._appString == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				nint num3 = (nint)typeof(BitConverter);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v33 (Il2CppClass<System.BitConverter>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(BitConverter);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v69 (Il2CppClass<System.BitConverter>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				char hexValue = BitConverter.GetHexValue(1815265164);
				int num5 = default;
				*(decimal*)(int)hexValue = new decimal(0, num5, 0, 4);
				char hexValue2 = BitConverter.GetHexValue(-471734266);
				*(decimal*)(int)hexValue2 = new decimal(0, num5, 4, 4);
				char hexValue3 = BitConverter.GetHexValue(-1862354926);
				*(decimal*)(int)hexValue3 = new decimal(0, num5, 8, 4);
				char hexValue4 = BitConverter.GetHexValue(2115385361);
				*(decimal*)(int)hexValue4 = new decimal(0, num5, 12, 4);
				nint num6 = (nint)typeof(Convert);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v46 (Il2CppClass<System.Convert>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num7 = (nint)typeof(Convert);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S0_v65 (Il2CppClass<System.Convert>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				byte[] appString = Convert.FromBase64String((string)num5);
				nint num8 = (nint)typeof(TOTP);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v53 (Il2CppClass<Kiloo.Common.Security.TOTP>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(TOTP);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v59 (Il2CppClass<Kiloo.Common.Security.TOTP>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				TOTP._appString = (string)(object)appString;
			}
			nint num10 = (nint)typeof(TOTP);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v16 (Il2CppClass<Kiloo.Common.Security.TOTP>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num11 = (nint)typeof(TOTP);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v23 (Il2CppClass<Kiloo.Common.Security.TOTP>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (INotifications)(object)TOTP._appString;
		}
		private set
		{
		}
	}

	public static INotifications Init(bool receiveNotifications)
	{
		//IL_014b: Expected Obj, but got I4
		//IL_0154: Expected Obj, but got I4
		//IL_015d: Expected Obj, but got I4
		//IL_00bd: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_01f5: Expected I4, but got Obj
		//IL_0202: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected Obj, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00fe: Expected I, but got Obj
		object obj = (receiveNotifications ? 1 : 0) + 12;
		object obj2 = 0;
		object obj3 = 1;
		object obj4 = default;
		object obj7 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj5 = (receiveNotifications ? 1 : 0) + 16;
			object obj6 = obj5 + obj7;
			object obj8 = obj6 + obj3;
			object obj9 = obj8 / 65521;
			object obj10 = obj9 * 65521;
			object obj11 = obj8 - obj10;
			object obj12 = obj11 + obj2;
			object obj13 = obj12 / 65521;
			object obj14 = obj13 * 65521;
			object obj15 = obj12 - obj14;
			obj4 = obj7 + 1;
			obj2 = obj15;
			obj3 = obj11;
		}
		nint num = (nint)typeof(BitConverter);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v13 (Il2CppClass<System.BitConverter>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num2 = (nint)typeof(BitConverter);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v25 (Il2CppClass<System.BitConverter>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj17 = obj2 << 16;
		object obj18 = obj3 | obj17;
		object obj19 = obj3 << 21;
		object obj20 = obj18 ^ obj19;
		object obj21 = obj20 >> 3;
		object obj22 = obj21 ^ obj20;
		object obj23 = obj22 << 4;
		int i = obj23 ^ obj22;
		return (INotifications)BitConverter.GetHexValue(i);
	}
}
