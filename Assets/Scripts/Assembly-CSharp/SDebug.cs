using System;
using UnityEngine;

public static class SDebug
{
	private const int UNITY_LOG_MAXIMUM_CHAR_LIMIT = 15500;

	public static void Log(object message, UnityEngine.Object context = null)
	{
	}

	private static bool MessageExceedsLimit(string fullLog)
	{
		return fullLog._stringLength > 15500;
	}

	private static void LogExtendedMessage(string fullLog, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(object message, UnityEngine.Object context = null)
	{
	}

	public static void LogError(object message, UnityEngine.Object context = null)
	{
	}

	public static void LogFormat(UnityEngine.Object context, string msg, object[] args)
	{
	}

	public static void LogFormat(string msg, object[] args)
	{
	}

	public static void LogWarningFormat(UnityEngine.Object context, string msg, object[] args)
	{
	}

	public static void LogWarningFormat(string msg, object[] args)
	{
	}

	public static void LogErrorFormat(UnityEngine.Object context, string msg, object[] args)
	{
	}

	public static void LogErrorFormat(string msg, object[] args)
	{
	}

	public static void LogAssertion(object message)
	{
	}

	public static void LogAssertion(object message, UnityEngine.Object context)
	{
	}

	public static void LogAssertionFormat(string format, object[] args)
	{
	}

	public static void LogAssertionFormat(UnityEngine.Object context, string format, object[] args)
	{
	}

	public static void LogException(Exception exception)
	{
	}

	public static void LogException(Exception exception, UnityEngine.Object context)
	{
	}
}
