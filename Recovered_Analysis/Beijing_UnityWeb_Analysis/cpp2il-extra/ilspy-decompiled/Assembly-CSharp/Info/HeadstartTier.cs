using System;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace Info;

public class HeadstartTier
{
	private float speed__BackingField;

	private float landSpeed__BackingField;

	public float speed
	{
		get
		{
			//IL_0027: Expected F4, but got I
			//IL_0052: Expected F4, but got I
			//IL_0052: Expected F4, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.HeadstartTier)+30]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.HeadstartTier)+2C]");
			float result = 0f;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.HeadstartTier)+2C]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Info.HeadstartTier)+34]");
				float num2 = ScrollRect.RubberDelta((float)num, 0f);
				result = num2;
			}
			return result;
		}
		set
		{
		}
	}

	public float landSpeed
	{
		get
		{
			return speed__BackingField;
		}
		set
		{
			speed__BackingField = value;
		}
	}

	public float duration
	{
		get
		{
			return landSpeed__BackingField;
		}
		set
		{
			landSpeed__BackingField = value;
		}
	}

	public HeadstartTier()
	{
		//IL_0a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6f: Expected Obj, but got Unknown
		//IL_0a78: Expected Obj, but got I4
		//IL_0a86: Expected I, but got Obj
		//IL_0a9c: Expected Obj, but got I
		//IL_0e24: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac8: Expected Obj, but got Unknown
		//IL_0af1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = 0;
		nint num = (nint)typeof(EarnCoinsData);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11 (Il2CppClass<Info.EarnCoinsData>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v217 (Il2CppClass<Info.EarnCoinsData>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (FacebookRewardsInfo.ShouldShowConnectPopupOnGameOver((int)this))
		{
			nint num3 = (nint)typeof(EarnCoinsData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v22 (Il2CppClass<Info.EarnCoinsData>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(EarnCoinsData);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v211 (Il2CppClass<Info.EarnCoinsData>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = EarnCoinsData.profiles + 16;
			object obj6 = (object)this << 2;
			object obj7 = obj5 + obj6;
			OnlineSettings._003CDownloadCoroutine_003Ed__36 obj8 = (OnlineSettings._003CDownloadCoroutine_003Ed__36)obj7;
			object obj9 = obj7 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		SDebug.LogFormat("An already trigerred coin earner button has been pressed!", null);
	}
}
