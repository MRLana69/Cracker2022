using SYBO.Common.Components.Singleton;
using UnityEngine;

namespace SYBO.Subway.Managers;

public class DemoVideoModeManager
{
	public const string DEMO_VIDEO_MODE_IS_ENABLED = "DEMO_VIDEO_MODE_IS_ENABLED";

	public static bool IsEnabled
	{
		get
		{
			int num = PlayerPrefs.GetInt("DEMO_VIDEO_MODE_IS_ENABLED", 0);
			return num == 1;
		}
		set
		{
			//IL_0063: Expected VT, but got Obj
			//IL_0076: Expected Obj, but got VT
			//IL_0037: Expected VT, but got Obj
			//IL_004a: Expected Obj, but got VT
			if (!Application.isPlaying)
			{
				if (value)
				{
					PlayerPrefs.SetInt("DEMO_VIDEO_MODE_IS_ENABLED", 1);
					_00210 val = (_00210)SingletonMonobehavior<>.Instance;
					((QualitySettingsManager)val).SetQualityType(QualityType.DemoVideoMode);
				}
				else
				{
					PlayerPrefs.SetInt("DEMO_VIDEO_MODE_IS_ENABLED", 0);
					_00210 val2 = (_00210)SingletonMonobehavior<>.Instance;
					((QualitySettingsManager)val2).SetQualityType(QualityType.Default);
				}
			}
		}
	}

	public static void RefreshIsEnabled()
	{
		bool isEnabled = IsEnabled;
		IsEnabled = isEnabled;
	}
}
