using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.LocalizationManager;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Plugins.DeviceUtility.Internal;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIArea : IDisposable
{
	public unsafe GUIArea(Rect area)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got F4
		//IL_00ca: Expected I4, but got F4
		//IL_00e1: Expected Obj, but got F4
		//IL_00f3: Expected I4, but got F4
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v22 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Color color = default;
		GUI.color = color;
		string text = (string)(color + 16);
		text = (string)color.r;
		text.m_stringLength = (int)color.b;
		((LegalTextData)this).SetLocale(text);
		text = (string)area.m_XMin;
		text.m_stringLength = (int)area.m_Width;
		Gizmos.set_color_Injected(ref *(Color*)text);
	}

	public GUIArea(Rect area, string content)
	{
		//IL_0027: Invalid comparison between VT and I4
		//IL_0012: Expected Obj, but got VT
		if (area != (Rect)(object)0)
		{
			((Action<string>)area)(content);
		}
		((DeviceUtilitySimulated)this)._002Ector();
	}

	public GUIArea(Rect area, string content, string style)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0136: Expected I4, but got VT
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v23 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!DeviceUtility.IsSupportedOnPlatform())
		{
			return;
		}
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((CloudWorkingCopy)this)._002Ector((int)area, content, (ICloudServer)null, (IFileSaver)null, style);
	}

	public unsafe void Dispose()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Ref, but got Unknown
		object obj = this + 8;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S1_v3+8]");
		_ = 0;
		ref Color reference = ref *(Color*)(obj2 + 16);
		reference = ref *(Color*)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Gizmos.set_color_Injected(ref reference);
	}
}
