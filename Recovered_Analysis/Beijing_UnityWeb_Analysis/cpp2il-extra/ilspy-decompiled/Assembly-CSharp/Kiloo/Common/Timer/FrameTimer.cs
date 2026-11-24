using System;
using System.Diagnostics.Tracing;
using System.Threading;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.Security;
using Kiloo.Common.Utility;
using UnityEngine;

namespace Kiloo.Common.Timer;

public class FrameTimer : BaseTimer
{
	private int _elapsedFrames;

	private int _framesToDelay;

	private unsafe FrameTimer(int framesToDelay, bool oneShot = false)
	{
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_0121: Expected Obj, but got I4
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected Obj, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected Obj, but got Unknown
		//IL_014a: Expected Obj, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected Obj, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected Obj, but got Unknown
		//IL_00ea: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = framesToDelay;
		object obj3 = obj2 + 12;
		obj3 = this;
		object obj4 = obj2 + 16;
		obj4 = oneShot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = obj2;
		object obj8 = default;
		object obj7 = obj8 + 8;
		obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EventSource eventSource = default;
		eventSource._002Ector();
		object obj9 = obj8 + 12;
		obj9 = eventSource;
		nint num2 = (nint)typeof(ThreadPooling);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v30 (Il2CppClass<Kiloo.Common.Utility.ThreadPooling>)+5C]");
		object obj10 = (nint)0 + (nint)4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		WaitCallback waitCallback = default;
		((Delegate)waitCallback).method_ptr = method_ptr;
		((Delegate)waitCallback).method = (nint)(delegate*<object, void>)(&ThreadPooling.RunAction);
		object obj12 = waitCallback + 16;
		obj12 = 0;
		bool flag = ThreadPool.UnsafeQueueUserWorkItem(waitCallback, obj8);
	}

	public static void ExecuteWithDelay(int framesToDelay, Action action)
	{
		//IL_0030: Expected Obj, but got I
		//IL_0088: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [framesToDelay @ L0 (System.Int32)+10]");
		Delegate obj = (Delegate)0;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)action);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = framesToDelay + 16;
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

	public override void Start()
	{
		TransformExtensions.Reset((Transform)(object)base.intervalElapsed);
	}

	public override void Stop()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected Obj, but got Unknown
		if (~(_running ? 1u : 0u) != 0)
		{
			_running = true;
			string text = TOTP.NewTOTP();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			Action<float> action = default;
			object obj = action + 16;
			obj = this;
			((StaticUpdater)(object)text).onUpdate -= action;
		}
	}

	private void Update(float deltaTime)
	{
		base.interval__BackingField = deltaTime;
	}
}
