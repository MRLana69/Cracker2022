using UnityEngine;

namespace SYBO.Components.Logging;

public abstract class LogSettingsProvider : MonoBehaviour
{
	public abstract LogSettings GetSettings();

	public abstract string GetUserData();
}
