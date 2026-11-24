using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Backend.Cloud;

public class CloudItemUpdatedArgs : EventArgs
{
	private string file__BackingField;

	private ICloudItem item__BackingField;

	public string file
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool flag = item__BackingField != null;
			return (string)flag;
		}
		private set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			ICloudItem cloudItem = (ICloudItem)(value & 1);
			item__BackingField = cloudItem;
		}
	}

	public ICloudItem item
	{
		get
		{
			return (ICloudItem)(object)file__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
	}

	public CloudItemUpdatedArgs(ICloudItem item, string file)
	{
		//IL_00e2: Expected I, but got Obj
		//IL_00f8: Expected Obj, but got I
		//IL_01a9: Expected Obj, but got I8
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected Obj, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0200: Expected Obj, but got I
		//IL_0123: Expected I, but got Obj
		bool flag;
		if (item != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (Kiloo.Common.Backend.Cloud.ICloudItem)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			ArgumentNullException ex = default;
			ex._002Ector("name parameter cannot be null.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudItemUpdatedArgs)+18]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex2 = default;
			ex2._002Ector("EventLogger.LogEvent: Session not started.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		Coroutine coroutine = ((EventRemoteLogger)null).SendAsync((Action)(object)file);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v21 (Il2CppClass<System.DateTime>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v37 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		long systemTimeAsFileTime = DateTime.GetSystemTimeAsFileTime();
		object obj2 = systemTimeAsFileTime;
		object obj3 = obj2 + 8;
		obj3 = obj2;
		object obj5 = default;
		object obj4 = obj5 + 8;
		obj4 = item;
		object obj6 = obj5 + 12;
		obj6 = coroutine;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudItemUpdatedArgs)+18]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
	}
}
