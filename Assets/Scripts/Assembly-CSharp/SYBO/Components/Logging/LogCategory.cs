using System;
using UnityEngine;

namespace SYBO.Components.Logging;

public abstract class LogCategory
{
	public readonly int CategoryId;

	public string CategoryText;

	public int Level;

	public int HideStackLevel;

	public LogCategory(int categoryId)
	{
		CategoryId = categoryId;
	}

	public abstract string[] GetCallstackPrefixes();

	public bool IsLoggingLevel(int logLevel)
	{
		return Level >= logLevel;
	}

	public void LogFormat(UnityEngine.Object context, string format, object[] args)
	{
	}

	public void LogFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
		LogManager.LogFormat((UnityEngine.Object)(object)this, this, level, (string)(object)this, (object[])(object)this);
	}

	public void LogFormat(string format, object[] args)
	{
	}

	public void LogFormat(int level, string format, object[] args)
	{
		LogManager.LogFormat(this, level, format, args);
	}

	public void LogWarningFormat(UnityEngine.Object context, string format, object[] args)
	{
	}

	public void LogWarningFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
		LogManager.LogWarningFormat((UnityEngine.Object)(object)this, this, level, (string)(object)this, (object[])(object)this);
	}

	public void LogWarningFormat(string format, object[] args)
	{
		LogManager.LogWarningFormat((LogCategory)(object)format, format, args);
	}

	public void LogWarningFormat(int level, string format, object[] args)
	{
		LogManager.LogWarningFormat(this, level, (string)(object)this, (object[])(object)this);
	}

	public void LogErrorFormat(UnityEngine.Object context, string format, object[] args)
	{
	}

	public void LogErrorFormat(UnityEngine.Object context, int level, string format, object[] args)
	{
		LogManager.LogErrorFormat((UnityEngine.Object)(object)this, this, level, (string)(object)this, (object[])(object)this);
	}

	public void LogErrorFormat(string format, object[] args)
	{
	}

	public void LogErrorFormat(int level, string format, object[] args)
	{
		LogManager.LogErrorFormat(this, level, (string)(object)this, (object[])(object)this);
	}

	public void LogException(Exception exception)
	{
	}

	public void LogException(int level, Exception exception)
	{
		LogManager.LogException(this, level, (Exception)(object)this);
	}
}
