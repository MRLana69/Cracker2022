using SYBO.Components.Settings;
using UnityEngine.Events;

namespace SYBO.Components.Logging;

public class LogManagerIntegration : LogSettingsProvider
{
	public LogGUI OnScreenManager;

	public unsafe override LogSettings GetSettings()
	{
		LogSettings log = StaticSettings.Log;
		bool flag = log.Changed == null;
		bool flag2 = !flag;
		UnityEvent changed = log.Changed;
		if (!flag2)
		{
			UnityEvent unityEvent = default;
			unityEvent._002Ector();
			log.Changed = unityEvent;
			changed = log.Changed;
		}
		UnityAction unityAction = default;
		unityAction._002Ector(this, (nint)__ldftn(LogManagerIntegration.OnLogSettingsChanged));
		changed.RemoveListener(unityAction);
		UnityAction unityAction2 = default;
		unityAction2._002Ector(this, (nint)__ldftn(LogManagerIntegration.OnLogSettingsChanged));
		log.Changed.AddListener(unityAction2);
		return log;
	}

	public override string GetUserData()
	{
		return string.Empty;
	}

	private void OnLogSettingsChanged()
	{
	}
}
