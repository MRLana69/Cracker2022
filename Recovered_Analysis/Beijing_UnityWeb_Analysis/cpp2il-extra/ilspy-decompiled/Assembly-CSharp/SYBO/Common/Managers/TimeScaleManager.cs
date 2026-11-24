using Cpp2ILInjected;
using SYBO.Common.Data;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Inputs;
using UnityEngine;

namespace SYBO.Common.Managers;

public class TimeScaleManager : SingletonMonoBehaviour<TimeScaleManager>
{
	private const float TimeScaleDefault = 1f;

	private float _timeScaleInMenuDefault;

	private float _timeScaleInGameDefault;

	public float TimeScale
	{
		get
		{
			return Time.time;
		}
		set
		{
			//IL_00f3: Expected I, but got Obj
			//IL_0109: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_016b: Expected Obj, but got I4
			nint num = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Mathf>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Mathf);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<UnityEngine.Mathf>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num3 = Mathf.RoundToInt(value);
			float timeScaleInMenuDefault = _timeScaleInMenuDefault;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v13 (System.Single)+C]");
			int num4 = (int)(-2);
			int num5 = ((num3 >= 0) ? ((num3 <= num4) ? num3 : num4) : 0);
			float num6 = value - (float)num5;
			if (num6 < 0f)
			{
				num6 = 0f;
			}
			else if (num6 > 1f)
			{
				num6 = 1f;
			}
			float[] multiplierArray = (float[])(num5 + 1);
			((ScoreMultiplier)(object)this)._002Ector(num5, multiplierArray, num6);
		}
	}

	public float TimeScaleInMenuDefault
	{
		get
		{
			return Time.realtimeSinceStartup;
		}
		set
		{
			Time.captureDeltaTime = value;
		}
	}

	public float TimeScaleInGameDefault
	{
		get
		{
			return _timeScaleInMenuDefault;
		}
		set
		{
			_timeScaleInMenuDefault = value;
		}
	}

	protected override void SubclassInitialize()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Managers.TimeScaleManager)+C]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	protected override void OnDestroy()
	{
		//IL_001d: Expected VT, but got I4
		GameObject childTransform = gameObject;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)(object)childTransform, HierarchyPathType.DynamicManagers, (Vector3)0);
	}

	private void InputManager_OnInputEvent(object sender, InputEventArgs inputEventArgs)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_0128: Expected F4, but got Obj
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected Obj, but got Unknown
		//IL_015b: Expected Obj, but got I
		//IL_0164: Expected Obj, but got I4
		//IL_016f: Expected F4, but got I4
		//IL_017f: Invalid comparison between F4 and I4
		//IL_0036: Expected Obj, but got I
		//IL_0046: Expected Obj, but got F4
		//IL_0063: Expected Obj, but got F4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected Obj, but got Unknown
		//IL_00fb: Expected F4, but got Obj
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = ((obj2 == null) ? ((object)1337) : obj2);
		_timeScaleInGameDefault = (float)obj;
		object obj3 = this + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Managers.TimeScaleManager)+C]");
		object obj5 = (nint)0 + (nint)16;
		obj5 = 1337;
		_timeScaleInMenuDefault = 1f;
		while (!(_timeScaleInMenuDefault > 623f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Managers.TimeScaleManager)+C]");
			object obj6 = (nint)0 + (nint)16;
			object obj7 = _timeScaleInMenuDefault << 2;
			object obj8 = obj6 + obj7;
			object obj9 = _timeScaleInMenuDefault << 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Common.Managers.TimeScaleManager)+C]");
			object obj10 = 0 + obj9;
			object obj11 = obj10 + 12;
			object obj12 = obj11 * 69069;
			obj8 = obj12;
			float timeScaleInMenuDefault = _timeScaleInMenuDefault + 1f;
			_timeScaleInMenuDefault = timeScaleInMenuDefault;
		}
		((UnsyncedMTRandomGen)(object)this)._002Ector();
		InputEventArgs e = inputEventArgs;
		while ((nint)e >= 624)
		{
			((UnsyncedMTRandomGen)(object)this)._002Ector();
			InputEventArgs e2 = (InputEventArgs)(e - 624);
			e = e2;
		}
		_timeScaleInMenuDefault = (float)e;
	}

	public TimeScaleManager()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00c5: Expected VT, but got Obj
		//IL_00eb: Expected Obj, but got I4
		//IL_00fd: Expected Obj, but got VT
		//IL_0054: Expected I, but got Obj
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
		if (!SingletonMonoBehaviour<>.HasExecuteInEditModeAttribute())
		{
			return;
		}
		nint num = (nint)typeof(SingletonMonoBehaviour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v11 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v18 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		((InputManager)val).IsEnabled = flag;
	}
}
