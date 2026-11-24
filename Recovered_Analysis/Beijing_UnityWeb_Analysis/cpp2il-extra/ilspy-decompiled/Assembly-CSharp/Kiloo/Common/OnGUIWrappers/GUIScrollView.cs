using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.OnGUIWrappers;

public class GUIScrollView : IDisposable
{
	public Vector2 Scroll
	{
		get
		{
			GUILayout.BeginVertical((GUILayoutOption[])(object)this);
			Vector2 result = default;
			return result;
		}
		set
		{
			//IL_0010: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (UnityEngine.Vector2)+8]");
			GUIScrollView gUIScrollView = (GUIScrollView)0;
		}
	}

	public GUIScrollView(Vector2 scrollPosition, GUILayoutOption[] options)
	{
		//IL_000d: Expected Obj, but got VT
		GUILayout.BeginVertical((GUIStyle)scrollPosition, options);
	}

	public GUIScrollView(Vector2 scrollPosition, GUIStyle style, GUILayoutOption[] options)
	{
		//IL_0011: Expected Obj, but got VT
		GUILayout.BeginHorizontal((GUIContent)scrollPosition, style, options);
	}

	public GUIScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollBar, GUIStyle verticalScrollBar, GUILayoutOption[] options)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0139: Expected I4, but got VT
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
		((CloudWorkingCopy)this)._002Ector((int)scrollPosition, (string)(object)horizontalScrollBar, (ICloudServer)(object)verticalScrollBar, (IFileSaver)null, (string)(object)options);
	}

	public void Dispose()
	{
		GUILayout.EndVertical();
	}
}
