using Cpp2ILInjected;
using UI;
using UI.Screens;
using UnityEngine;

public class MeButtonNotificationHelper : MonoBehaviour
{
	private BreadCrumbHelper breadCrumbHelper;

	private UISprite notificationIcon;

	private UILabel notificationLabel;

	private UISprite exclamationMark;

	private void OnEnable()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 8;
		object obj2 = default;
		obj = obj2;
	}

	private void RefreshNotification()
	{
		this._002Ector();
	}

	public MeButtonNotificationHelper()
	{
		//IL_01ea: Expected I, but got Obj
		//IL_0200: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I4
		//IL_011d: Expected Obj, but got I4
		//IL_015e: Expected Obj, but got I4
		//IL_017c: Expected Obj, but got I4
		CoinsForVideoManager instance = CoinsForVideoManager.instance;
		string welcomePackInAppID = WelcomePackManager.WelcomePackInAppID;
		object obj = welcomePackInAppID + instance;
		object obj2 = obj;
		nint num = (nint)typeof(FirstPurchaseBonusManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v12 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(FirstPurchaseBonusManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v44 (Il2CppClass<UI.Screens.FirstPurchaseBonusManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((nint)obj >= 1)
		{
			nint num3 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v29 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)this.breadCrumbHelper).FindKernel((string)null) != 0)
			{
				BreadCrumbHelper breadCrumbHelper = this.breadCrumbHelper;
				if (breadCrumbHelper._currentState == BreadCrumbHelper.BreadCrumbStates.inactive)
				{
					notificationIcon.tag = (string)1;
					notificationLabel.tag = (string)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
					int fontSize = default;
					notificationLabel.fontSize = fontSize;
					bool flag = (nint)obj2 == 1;
					exclamationMark.tag = (string)flag;
					bool flag2 = (nint)obj2 > 1;
					notificationLabel.tag = (string)flag2;
					return;
				}
			}
		}
		notificationIcon.tag = null;
		notificationLabel.tag = null;
		exclamationMark.tag = null;
	}
}
