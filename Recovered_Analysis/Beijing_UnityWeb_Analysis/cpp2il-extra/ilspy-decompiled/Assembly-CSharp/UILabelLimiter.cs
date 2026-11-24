using Cpp2ILInjected;
using UnityEngine;

public class UILabelLimiter : MonoBehaviour
{
	private UILabel _label;

	private void Awake()
	{
		CancelInvoke();
	}

	private void Start()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected Obj, but got Unknown
		//IL_008e: Expected I, but got Obj
		//IL_00a4: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		object obj = this + 12;
		UILabel component = GetComponent<UILabel>();
		obj = component;
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v13 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_label != null)
		{
			SDebug.LogFormat("This script is not attached to a game object with an UILabel!", null);
		}
	}

	public void LimitLabel()
	{
		this._002Ector();
	}

	public UILabelLimiter()
	{
		//IL_0138: Expected I, but got Obj
		//IL_014e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_007d: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I4
		//IL_010d: Expected I4, but got Obj
		//IL_0125: Expected I4, but got Obj
		nint num = (nint)typeof(Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_label != null)
		{
			return;
		}
		bool isValid = _label.isValid;
		UILabel label = _label;
		if (string.CompareOrdinal((string)isValid, label.mText) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (System.Boolean)+8]");
			if ((nint)0 > (nint)3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v12 (System.Boolean)+8]");
				int length = (int)(-3);
				string values = ((string)isValid).InternalSubString(0, length);
				string text = string.ConcatArray((string[])(object)values, (int)"...");
				_label.fontSize = (int)text;
			}
		}
	}
}
