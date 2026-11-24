using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.HTTP;
using Kiloo.Common.Utility;
using UnityEngine;

[StructLayout((LayoutKind)0, Size = 4)]
public struct IntMask
{
	private int mask;

	// C# has no syntax for parameterized property 'Item'.
	public unsafe bool get_Item(int bit)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0028: Expected Obj, but got Ref
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = bit;
		return flag;
	}

	public unsafe void set_Item(int bit, bool value)
	{
		//IL_00d2: Expected VT, but got I
		//IL_00e9: Expected Obj, but got I
		//IL_0035: Expected VT, but got I4
		//IL_0050: Expected Obj, but got Ref
		//IL_0056: Expected Obj, but got Ref
		//IL_0062: Expected Obj, but got I4
		//IL_0073: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got Ref
		if (bit != 0)
		{
			int pixelLightCount = QualitySettings.pixelLightCount;
			GL.Color((Color)(-1));
			_ = 1;
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80));
			bool flag = ((FPSLog)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)).TestGoogleConnection();
			obj = flag;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IntMask)+50]");
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IntMask)+60]");
			if ((nint)0 == 0)
			{
				((FPSLog)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)).SetFPSAutoLength(-1);
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IntMask)+4C]");
			GL.Color((Color)0);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (IntMask)+50]");
			CoroutineUtil.StopCoroutine((Coroutine)0);
			Application.SetLogCallbackDefined(true);
		}
	}

	public IntMask(int i)
	{
		int num = i ^ 1;
		int num2 = num & 1;
	}

	public static implicit operator int(IntMask i)
	{
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Obj, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected VT, but got Unknown
		//IL_0071: Expected VT, but got Obj
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		//IL_009a: Expected Obj, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_00c1: Expected Obj, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected Obj, but got Unknown
		//IL_00df: Expected VT, but got Obj
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected Obj, but got Unknown
		//IL_0103: Expected Obj, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected Obj, but got Unknown
		//IL_0133: Expected VT, but got Obj
		//IL_0153: Expected I, but got Obj
		//IL_0169: Expected Obj, but got I
		//IL_02ae: Expected I4, but got Obj
		//IL_0194: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		object obj = default;
		UIPopupList uIPopupList = (UIPopupList)(obj + 48);
		uIPopupList = (UIPopupList)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Uri uri = default;
		uri.CreateThisFromUri((Uri)(object)"https://script.google.com/macros/s/AKfycbz2lBaGXHu05CgN1mXAr217sresz20BwK_3YwuHO2sHx_eJu5g/exec");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<KeyValuePair<string, string>> list = default;
		list._002Ector();
		object obj2 = obj + 32;
		obj2 = 0;
		obj2 = "ssid";
		object obj3 = obj2 + 4;
		obj3 = "1d4AZJWVKm1c438UX21RZIMHGpzjRd013Bmk10_n5tmU";
		object obj4 = obj + 40;
		obj4 = obj2;
		KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)(obj + 56);
		keyValuePair = (KeyValuePair<string, string>)obj4;
		list.Add(keyValuePair);
		object obj5 = obj + 24;
		obj5 = 0;
		obj5 = "sheet";
		object obj6 = obj5 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [i @ L0 (IntMask)+54]");
		obj6 = 0;
		object obj7 = obj + 16;
		obj7 = obj5;
		keyValuePair = (KeyValuePair<string, string>)obj7;
		list.Add(keyValuePair);
		object obj8 = obj + 8;
		obj8 = 0;
		obj8 = "action";
		object obj9 = obj8 + 4;
		obj9 = "ConnectionTest";
		obj = obj8;
		keyValuePair = (KeyValuePair<string, string>)obj;
		list.Add(keyValuePair);
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v62 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num2 = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v82 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Uri uri2 = WebClient.AddQueryParametersToUri((string)(object)uri, list);
		string localPath = uri2.LocalPath;
		uIPopupList.AnimatePosition((UIWidget)null, (byte)(int)localPath != 0, 5f);
		if ((object)uIPopupList != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (UIPopupList)+4]");
			if ((string)0 != "Connection Established")
			{
				return 1;
			}
		}
		return 0;
	}

	public unsafe static implicit operator IntMask(int i)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0012: Expected VT, but got Obj
		object obj = ((int*)i)->m_value;
		return (IntMask)obj;
	}
}
