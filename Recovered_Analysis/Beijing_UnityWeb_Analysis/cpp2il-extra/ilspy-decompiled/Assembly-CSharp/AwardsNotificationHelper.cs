using System;
using System.Collections;
using Cpp2ILInjected;
using Missions;
using UnityEngine;

public class AwardsNotificationHelper : MonoBehaviour
{
	private UISprite notificationIcon;

	private UILabel notificationLabel;

	private UISprite exclamationMark;

	private bool _hasGoneToZero;

	private void OnEnable()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		object obj = this + 36;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void Update()
	{
		this._002Ector();
	}

	private void RefreshNotification()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00ed: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		if (~(_hasGoneToZero ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v19 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		IEnumerator enumerator = ((UIScreenController)flag).DelayHideMainCamera();
		if ((string)(object)enumerator != "AwardsScreen")
		{
			this._002Ector();
		}
	}

	public AwardsNotificationHelper()
	{
		//IL_0119: Expected Obj, but got I4
		//IL_0127: Expected I, but got Obj
		//IL_013d: Expected Obj, but got I
		//IL_0178: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00ab: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00ec: Expected Obj, but got I4
		//IL_010a: Expected Obj, but got I4
		object obj = 0;
		nint num = (nint)typeof(AwardsManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Missions.AwardsManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AwardsManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v36 (Il2CppClass<Missions.AwardsManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		MissionsManager instance = MissionsManager.Instance;
		int totalAwardTiers = ((AwardsManager)(object)instance).GetTotalAwardTiers();
		obj = totalAwardTiers;
		if (totalAwardTiers < 1)
		{
			notificationIcon.tag = null;
			notificationLabel.tag = null;
			exclamationMark.tag = null;
			_hasGoneToZero = true;
			return;
		}
		notificationIcon.tag = (string)1;
		notificationLabel.tag = (string)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		notificationLabel.fontSize = fontSize;
		bool flag = (nint)obj == 1;
		exclamationMark.tag = (string)flag;
		bool flag2 = (nint)obj > 1;
		notificationLabel.tag = (string)flag2;
	}
}
