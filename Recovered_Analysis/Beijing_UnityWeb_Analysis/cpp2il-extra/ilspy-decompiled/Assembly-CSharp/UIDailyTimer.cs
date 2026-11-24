using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Data.Save;
using Info;
using UnityEngine;

public class UIDailyTimer : MonoBehaviour
{
	private UILabel _timerLabel;

	private bool _refreshPage;

	private int _totalSeconds;

	private void Update()
	{
		//IL_00a5: Expected I, but got Obj
		//IL_00bb: Expected Obj, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected Obj, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected Obj, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v32 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj4 = this + 24;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v15+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj5 = this + 36;
		object obj6 = default;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<Outfit> list = default;
		list._002Ector();
		object obj7 = this + 52;
		obj7 = list;
		CancelInvoke();
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_006d: Expected Obj, but got I
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		bool isInstanced = UIScreenController.IsInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S1_v3 (System.Boolean)+84]");
		((UIMessageHelper)this).ShowMessage((string)0, paused);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (UIDailyTimer)+28]");
		if ((nint)0 != 0)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v37 @ S3_v6 (should have been resolved before IL gen)");
		}
	}

	public UIDailyTimer()
	{
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected Obj, but got Unknown
		//IL_01f0: Expected Obj, but got I4
		//IL_01fe: Expected I, but got Obj
		//IL_0214: Expected Obj, but got I
		//IL_02d0: Expected Obj, but got VT
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00e9: Expected F8, but got I4
		//IL_028e: Expected Obj, but got I8
		//IL_029d: Invalid comparison between I4 and F8
		//IL_0126: Expected F8, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0163: Expected F8, but got I4
		//IL_0172: Expected I4, but got F8
		//IL_01c9: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		nint num = (nint)typeof(EventsSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Data.Save.EventsSave>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v44 (Il2CppClass<Data.Save.EventsSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		DateTime wordHuntExpireDeviceTime = EventsSave.wordHuntExpireDeviceTime;
		obj = wordHuntExpireDeviceTime;
		if ((nint)obj <= 0)
		{
			nint num3 = (nint)typeof(EventsSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v35 (Il2CppClass<Data.Save.EventsSave>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(EventsSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v40 (Il2CppClass<Data.Save.EventsSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			long lastEventID = EventsSave.lastEventID;
			obj = lastEventID;
		}
		object obj5 = obj2 + 16;
		double num5 = (double)obj * 1E-07;
		if (num5 != num5)
		{
			num5 = -2147483648.0;
		}
		else if (!(num5 < 2147483648.0))
		{
			num5 = -2147483648.0;
		}
		else if (!(num5 > -2147483649.0))
		{
			num5 = -2147483648.0;
		}
		if ((double)_totalSeconds != num5)
		{
			_totalSeconds = (int)num5;
			obj2 = obj;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A56A");
			int fontSize = default;
			_timerLabel.fontSize = fontSize;
			if (~(_refreshPage ? 1u : 0u) == 0)
			{
				SendMessage("RefreshDailyChallenge", 1);
				_refreshPage = false;
			}
		}
	}
}
