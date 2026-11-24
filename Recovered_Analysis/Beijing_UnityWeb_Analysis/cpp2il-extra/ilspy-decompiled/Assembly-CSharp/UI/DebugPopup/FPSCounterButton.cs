using Cpp2ILInjected;
using Debugging;
using UnityEngine;

namespace UI.DebugPopup;

public class FPSCounterButton : MonoBehaviour
{
	private UILabel _titleLabel;

	private bool _showCounter;

	private void OnEnable()
	{
		CancelInvoke();
	}

	public void Click()
	{
		//IL_00a6: Expected I, but got Obj
		//IL_00bc: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @83E5");
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
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
			bool showCounter = (byte)(text2 & 1) != 0;
			_showCounter = showCounter;
		}
		bool showCounter2 = _showCounter;
		((FreeMemoryButton)this).SetupButton(showCounter2);
	}

	private void SetupButton(bool enabled)
	{
		//IL_002a: Expected I4, but got Obj
		//IL_0015: Expected I4, but got Obj
		if (enabled)
		{
			_titleLabel.fontSize = (int)"Invincible: ON";
		}
		else
		{
			_titleLabel.fontSize = (int)"Invincible: OFF";
		}
	}

	public FPSCounterButton()
	{
		//IL_01cc: Expected I, but got Obj
		//IL_01e2: Expected Obj, but got I
		//IL_0136: Expected I, but got Obj
		//IL_0037: Expected I, but got Obj
		//IL_0084: Expected I, but got Obj
		//IL_009a: Expected Obj, but got I
		//IL_0266: Expected Obj, but got I
		//IL_00c5: Expected I, but got Obj
		bool showCounter = _showCounter;
		bool showCounter2 = (byte)((showCounter ? 1u : 0u) ^ 1u) != 0;
		_showCounter = showCounter2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @83E5");
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		Object obj2 = default;
		if (~(_showCounter ? 1u : 0u) == 0)
		{
			if (!flag)
			{
				nint num2 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v47 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = obj2 != null;
			bool flag3 = !flag2;
			Object obj3 = obj2;
			if (!flag3)
			{
				nint num3 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v35 (Il2CppClass<UIScreenController>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v43 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag4 = UIScreenController.ShouldShowOnlineScreen();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v40 (System.Boolean)+14]");
				FreeMemoryStatus freeMemoryStatus = FreeMemoryStatus.Create((GameObject)0);
				obj3 = freeMemoryStatus;
			}
			((FreeMemoryStatus)obj3).ToggleVisible(true);
		}
		else
		{
			if (!flag)
			{
				nint num5 = (nint)typeof(Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v23 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)obj2).FindKernel((string)null) != 0)
			{
				((FreeMemoryStatus)obj2).ToggleVisible(false);
			}
		}
		bool showCounter3 = _showCounter;
		((FreeMemoryButton)this).SetupButton(showCounter3);
	}
}
