using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class CelebrationPopupNavigation : MonoBehaviour
{
	private void Update()
	{
		_ = 1;
		CancelInvoke();
	}

	public CelebrationPopupNavigation()
	{
		//IL_011d: Expected Obj, but got I4
		//IL_00b0: Expected Obj, but got I
		//IL_010e: Expected Obj, but got VT
		//IL_000f: Expected Obj, but got I4
		//IL_0139: Expected Obj, but got VT
		//IL_0142: Expected Obj, but got VT
		//IL_002b: Expected Obj, but got I4
		//IL_0047: Expected Obj, but got I4
		//IL_0063: Expected Obj, but got I4
		//IL_007f: Expected Obj, but got I4
		if (!Input.GetKeyDown((string)32) && !Input.GetKeyDown((string)13) && !Input.GetKeyDown((string)274) && !Input.GetKeyDown((string)273) && !Input.GetKeyDown((string)276) && !Input.GetKeyDown((string)275))
		{
			return;
		}
		_0021_00210 componentInChildren = (_0021_00210)((Component)this).GetComponentInChildren<T>();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10 (T)+140]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v11+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v10 (T)+374]");
			if ((nint)0 != 0)
			{
				_ = 0;
			}
			((CelebrationPopup)componentInChildren).StartOneStepUnlock();
			((CelebrationPopup)componentInChildren)._FinishOpening();
		}
		else
		{
			((CelebrationPopup)componentInChildren).ClosePrizeList();
		}
	}
}
