using System;
using Cpp2ILInjected;
using UnityEngine;

namespace UI.ButtonHelpers;

public class OkButtonHelper : MonoBehaviour
{
	private UILabel _okButtonLabel;

	private Action m_OkButtonClicked;

	public event Action OkButtonClicked
	{
		add
		{
			//IL_002a: Expected I4, but got Obj
			//IL_0015: Expected I4, but got Obj
			if (value != null)
			{
				_okButtonLabel.fontSize = (int)"Free Memory Status: ON";
			}
			else
			{
				_okButtonLabel.fontSize = (int)"Free Memory Status: OFF";
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OkButtonClicked;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 16;
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
	}

	private void OnEnable()
	{
	}

	private void OnClick()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00b0: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Strings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("OK");
		_okButtonLabel.fontSize = (int)text;
	}

	public OkButtonHelper()
	{
		if (this.m_OkButtonClicked != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
