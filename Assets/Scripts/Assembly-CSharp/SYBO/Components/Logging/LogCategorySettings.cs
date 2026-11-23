using System;

namespace SYBO.Components.Logging;

[Serializable]
public class LogCategorySettings
{
	public string categoryText;

	public string categoryClassName;

	public bool pauseOnError;

	public bool pauseOnWarning;

	public int logLevel;

	public int hideStackLevel;
}
