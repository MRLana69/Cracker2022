using System;
using Cpp2ILInjected;
using UI.ButtonHelpers;
using UnityEngine;

namespace UI.DebugPopup;

public class FreeMemoryButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private bool _showingCounter;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public void Click()
	{
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_0122: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @83E9");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			string text = ((Component)(object)computeShader).tag;
			string text2 = ((GameObject)(object)text).tag;
			bool showingCounter = (byte)(text2 & 1) != 0;
			_showingCounter = showingCounter;
		}
		bool showingCounter2 = _showingCounter;
		((OkButtonHelper)this).OkButtonClicked += (Action)showingCounter2;
	}

	private void SetupButton(bool enabled)
	{
		//IL_002a: Expected I4, but got Obj
		//IL_0015: Expected I4, but got Obj
		if (enabled)
		{
			_titleLabel.fontSize = (int)"FPS Counter: ON";
		}
		else
		{
			_titleLabel.fontSize = (int)"FPS Counter: OFF";
		}
	}

	public FreeMemoryButton()
	{
		//IL_0216: Expected I, but got Obj
		//IL_022c: Expected Obj, but got I
		//IL_02c1: Expected I, but got Obj
		//IL_02d7: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0129: Expected Obj, but got I
		//IL_0037: Expected I, but got Obj
		//IL_033d: Expected Obj, but got I4
		//IL_01a1: Expected I, but got Obj
		//IL_030e: Expected Obj, but got I
		//IL_031a: Expected Obj, but got I4
		//IL_0154: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @83E9");
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		ComputeShader computeShader = default;
		if (~(_showingCounter ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v60 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader.FindKernel(null) != 0)
			{
				((BoardSelectButton)(object)computeShader).SetSticker(BoardSelectButton.StickerType.None);
				_showingCounter = false;
			}
		}
		else
		{
			if (!flag)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v48 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = computeShader != null;
			bool flag3 = !flag2;
			ComputeShader computeShader2 = computeShader;
			if (!flag3)
			{
				nint num4 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v36 (Il2CppClass<UIScreenController>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num5 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v44 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v41 (System.Boolean)+14]");
				int nbToAnimate = ((AwardCellHelper)0).GetNbToAnimate();
				computeShader2 = (ComputeShader)nbToAnimate;
			}
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (computeShader2.FindKernel(null) != 0)
			{
				((BoardSelectButton)(object)computeShader2).SetSticker(BoardSelectButton.StickerType.Event);
				_showingCounter = true;
			}
		}
		bool showingCounter = _showingCounter;
		((OkButtonHelper)this).OkButtonClicked += (Action)showingCounter;
	}
}
