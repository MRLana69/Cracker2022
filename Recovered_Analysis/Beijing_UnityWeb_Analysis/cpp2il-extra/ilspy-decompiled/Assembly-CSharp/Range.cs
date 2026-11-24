using Cpp2ILInjected;
using UnityEngine;

public class Range
{
	private float max__BackingField;

	public float max
	{
		get
		{
			//IL_000d: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+30]");
			return 0f;
		}
		set
		{
			//IL_0010: Invalid comparison between I and F4
			//IL_0053: Invalid comparison between I and F4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+2C]");
			if (0f > value)
			{
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+30]");
			if (!(0f < value))
			{
			}
		}
	}

	public float min
	{
		get
		{
			return max__BackingField;
		}
		set
		{
			max__BackingField = value;
		}
	}

	public Range(float min, float max)
	{
		//IL_0104: Invalid comparison between I and F4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_014a: Invalid comparison between F4 and I
		//IL_0054: Expected I, but got Obj
		//IL_00a3: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+3C]");
		if (!(0f > 1f))
		{
			return;
		}
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v19 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+38]");
		float num3 = 0f + max;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+38]");
		if (min < 0f)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Range)+38]");
			float num4 = 0f;
		}
		else if (min > num3)
		{
			float num4 = num3;
		}
		else
		{
			float num4 = min;
		}
	}

	public bool IsValueWithinRange(float value)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		return flag;
	}

	public override string ToString()
	{
		//IL_0148: Expected I, but got Obj
		//IL_015e: Expected Obj, but got I
		//IL_019a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I4
		//IL_0135: Expected Obj, but got F4
		//IL_00ef: Expected Obj, but got I4
		//IL_0128: Expected Obj, but got I4
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v22 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (System.Boolean)+30]");
		float depth = ((Camera)0).depth;
		float num3 = depth * 2f;
		int sleepTimeout = Screen.sleepTimeout;
		int height = Screen.height;
		int num4 = sleepTimeout / height;
		float num5 = num3 * (float)num4;
		float num6 = (float)this * num5;
		if (num6 != num6)
		{
			return (string)int.MinValue;
		}
		if (!(num6 < 2.1474836E+09f))
		{
			return (string)int.MinValue;
		}
		if (!(num6 > -2.1474836E+09f))
		{
			return (string)int.MinValue;
		}
		return (string)num6;
	}
}
