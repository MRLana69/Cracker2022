using Cpp2ILInjected;
using UnityEngine;

public class SaveMeCancelButton : MonoBehaviour
{
	private SaveMePopup _saveMePopup;

	private void OnClick()
	{
		CancelInvoke();
	}

	public static void CloseSaveMe()
	{
		MeFooter.selectedTab = 2;
	}

	public SaveMeCancelButton()
	{
		//IL_00e5: Expected I, but got Obj
		//IL_00fb: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v27 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_saveMePopup).FindKernel((string)null) != 0)
		{
			SaveMePopup saveMePopup = _saveMePopup;
			SaveMePopup saveMePopup2 = _saveMePopup;
			if (~(saveMePopup2._isWatchingVideoForRevive ? 1u : 0u) == 0)
			{
				saveMePopup._isWatchingVideoForRevive = false;
				_saveMePopup.OnVideoOverlayClosed();
			}
			else if (saveMePopup.AnimTimeLeft__BackingField < 3f)
			{
				CelebrationTesterPopup.RewardDebugCelebrationReward();
			}
		}
	}
}
