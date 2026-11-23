using System;
using Cpp2ILInjected;
using SYBO.Common.Components.Singleton;
using SYBO.Common.Utilities;
using SYBO.Subway.Inputs;
using UnityEngine;

namespace SYBO.Common.Managers;

public class TimeScaleManager : SingletonMonobehavior<TimeScaleManager>
{
	private const float TimeScaleDefault = 1f;

	private float _timeScaleInMenuDefault = 1f;

	private float _timeScaleInGameDefault;

	public float TimeScale
	{
		get
		{
			return Time.timeScale;
		}
		set
		{
			Time.timeScale = value;
		}
	}

	public float TimeScaleInMenuDefault
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

	public float TimeScaleInGameDefault
	{
		get
		{
			return _timeScaleInGameDefault;
		}
		set
		{
			_timeScaleInGameDefault = value;
		}
	}

	protected void OnDestroy()
	{
		//IL_000e: Expected VT, but got Obj
		if (SingletonMonobehavior<>.IsInstantiated)
		{
			_00210 val = (_00210)SingletonMonobehavior<>.Instance;
			throw new ArgumentException();
		}
	}

	protected override void Initialize()
	{
		Transform childTransform = transform;
		HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
	}

	private void InputManager_OnInputEvent(object sender, InputEventArgs inputEventArgs)
	{
		//IL_003e: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputEventArgs @ L2 (System.Object)+8]");
		if ((nint)0 != 7)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputEventArgs @ L2 (System.Object)+10]");
		object obj = -49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [inputEventArgs @ L2 (System.Object)+10]");
		float timeScale = default;
		if ((nint)0 != 49)
		{
			if ((nint)obj != 1)
			{
				if ((nint)obj != 2)
				{
					if ((nint)obj != 3)
					{
						if ((nint)obj != 4)
						{
							if ((nint)obj != 5)
							{
								if ((nint)obj != 6)
								{
									return;
								}
								timeScale = 20f;
							}
							else
							{
								float timeScale2 = Time.timeScale;
								float num = timeScale2 * 1f;
								float num2 = num / 0.9f;
								timeScale = num2;
							}
						}
						else
						{
							float timeScale3 = Time.timeScale;
							float num3 = timeScale3 * 0.9f;
							float num4 = System.Math.Min(num3, 1f);
							bool flag = num3 < 0f;
							float num5 = 0f;
							if (!flag)
							{
								num5 = num4;
							}
							timeScale = num5;
						}
					}
					else
					{
						timeScale = 1f;
					}
				}
				else
				{
					float timeScale4 = Time.timeScale;
					float num6 = timeScale4 + 0.1f;
					timeScale = num6;
				}
			}
			else
			{
				float timeScale5 = Time.timeScale;
				float num7 = timeScale5 - 0.1f;
				float num8 = System.Math.Min(num7, 1f);
				bool flag2 = num7 < 0f;
				float num9 = 0f;
				if (!flag2)
				{
					num9 = num8;
				}
				timeScale = num9;
			}
		}
		((TimeScaleManager)(object)inputEventArgs).TimeScale = timeScale;
	}
}
