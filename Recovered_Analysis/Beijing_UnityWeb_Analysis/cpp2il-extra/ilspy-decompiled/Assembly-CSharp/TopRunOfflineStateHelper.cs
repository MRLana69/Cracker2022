using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using TopRun.UI;
using UI.FreeStuff;
using UI.Generic.Layout;
using UnityEngine;

public class TopRunOfflineStateHelper : MonoBehaviour
{
	public enum OfflineState
	{
		TryAgain,
		Loading
	}

	private GameObject _tryAgainState;

	private GameObject _loadingState;

	private UILabel _tryAgainDescriptionLabel;

	private UILabel _tryAgainButtonLabel;

	private UILabel _loadingLabel;

	private Layout _tryAgainLayout;

	private Layout _loadingLayout;

	private TopRunOnlineScreen _topRunOnlineScreen;

	private TopRunOnlineGameOverScreen _topRunOnlineGameOverScreen;

	public void SetState(OfflineState newState, TopRunOnlineScreen topRunScreen = null, TopRunOnlineGameOverScreen topRunGOScreen = null)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = newState;
		object obj2 = this + 12;
		obj2 = topRunScreen;
		object obj3 = this + 16;
		obj3 = topRunGOScreen;
	}

	private void SetTryAgainState()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected Obj, but got Unknown
		//IL_008a: Expected Obj, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected Obj, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected Obj, but got Unknown
		//IL_00be: Expected Obj, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00dc: Expected Obj, but got F4
		//IL_00ea: Expected I, but got Obj
		//IL_0100: Expected Obj, but got I
		//IL_0126: Expected Obj, but got VT
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = 10;
		object obj3 = obj2 + 20;
		obj3 = 1;
		object obj4 = this + 12;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj6 = default;
		object obj5 = obj6 + 17;
		obj5 = 1;
		object obj7 = this + 16;
		obj7 = obj6;
		_tryAgainLayout = (Layout)10000000f;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v24 (Il2CppClass<System.DateTime>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v34 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = DateTime.MinValue;
		object obj10 = obj9 + 8;
		obj10 = obj9;
		_topRunOnlineScreen = (TopRunOnlineScreen)obj10;
		CancelInvoke();
	}

	private void SetLoadingState()
	{
		//IL_00b9: Expected Obj, but got I4
		//IL_00c7: Expected I, but got Obj
		//IL_00dd: Expected Obj, but got I
		//IL_0117: Expected I4, but got Obj
		//IL_0061: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I4
		_loadingState.tag = null;
		_tryAgainState.tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v20 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("CONNECTION_PROBLEM");
		_tryAgainDescriptionLabel.fontSize = (int)text;
		string text2 = Strings.GetDefault("BUTTON_TRY_AGAIN");
		_tryAgainButtonLabel.fontSize = (int)text2;
		((RewardForVideoButton)(object)_tryAgainLayout).Init((VideoButtonPayload)null);
		string text3 = tag;
		UIButtonOverlayOff component = ((GameObject)(object)text3).GetComponent<UIButtonOverlayOff>();
		component.tag = (string)1;
	}

	private void OnClick()
	{
		//IL_0095: Expected Obj, but got I4
		//IL_00a3: Expected I, but got Obj
		//IL_00b9: Expected Obj, but got I
		//IL_00f3: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		_tryAgainState.tag = null;
		_loadingState.tag = (string)1;
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v5 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S1_v17 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("SOCIAL_BUTTON_FEEDBACK_CONNECTING");
		_loadingLabel.fontSize = (int)text;
		((RewardForVideoButton)(object)_loadingLayout).Init((VideoButtonPayload)null);
		string text2 = tag;
		UIButtonOverlayOff component = ((GameObject)(object)text2).GetComponent<UIButtonOverlayOff>();
		component.tag = null;
	}

	private void EnableLoadingOverlay()
	{
		//IL_0049: Expected Obj, but got I4
		this._002Ector();
		((BundlePurchaseButton)this).OnPurchaseSuccess((string)1, false, (IPurchaseValidationResult)null);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7502");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
		}
	}

	public TopRunOfflineStateHelper()
	{
		//IL_0132: Expected I, but got Obj
		//IL_0148: Expected Obj, but got I
		//IL_0082: Expected I, but got Obj
		//IL_0098: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006f: Expected Obj, but got I4
		//IL_00c3: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v21 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_topRunOnlineScreen).FindKernel((string)null) != 0)
		{
			TopRunOnlineScreen topRunOnlineScreen = _topRunOnlineScreen;
			topRunOnlineScreen.loadingOverlay.tag = (string)1;
			return;
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v16 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_topRunOnlineGameOverScreen).FindKernel((string)null) != 0)
		{
			TopRunOnlineGameOverScreen topRunOnlineGameOverScreen = _topRunOnlineGameOverScreen;
			topRunOnlineGameOverScreen.loadingOverlay.tag = (string)1;
		}
	}
}
