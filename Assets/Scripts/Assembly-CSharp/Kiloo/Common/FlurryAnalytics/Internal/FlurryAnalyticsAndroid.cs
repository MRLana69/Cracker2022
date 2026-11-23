using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using MiniJSON;
using UnityEngine;

namespace Kiloo.Common.FlurryAnalytics.Internal;

internal class FlurryAnalyticsAndroid : IFlurryAnalyticsBridge
{
	private static FlurryAnalyticsAndroid _instance;

	private AndroidJavaClass _bridge;

	private static FlurryAnalyticsAndroid instance
	{
		get
		{
			bool flag = _instance == null;
			bool flag2 = !flag;
			FlurryAnalyticsAndroid result = _instance;
			if (!flag2)
			{
				FlurryAnalyticsAndroid flurryAnalyticsAndroid = default;
				flurryAnalyticsAndroid._002Ector();
				_instance = flurryAnalyticsAndroid;
				result = flurryAnalyticsAndroid;
			}
			return result;
		}
	}

	private FlurryAnalyticsAndroid()
	{
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector("com.kiloo.flurryanalytics.FlurryAnalyticsBridge");
		_bridge = androidJavaClass;
	}

	public static FlurryAnalyticsAndroid CreatePlugin()
	{
		return instance;
	}

	public void StartSession(string apiKey)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void EndSession()
	{
		object[] args = Array.Empty<object>();
		_bridge.CallStatic("endSession", args);
	}

	public void LogEvent(string eventName)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void LogEventWithParams(string eventName, Dictionary<string, string> parameters)
	{
		string text = Json.Serialize(parameters);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void LogTimedEvent(string eventName)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void LogTimedEventWithParams(string eventName, Dictionary<string, string> parameters)
	{
		string text = Json.Serialize(parameters);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void EndTimedEvent(string eventName)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void LogPageView()
	{
		object[] args = Array.Empty<object>();
		_bridge.CallStatic("onPageView", args);
	}

	public void LogError(string errorId, string message, string errorClass)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void SetUserId(string userId)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public void SetAge(int age)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public void SetGender(Gender gender)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public void SetContinueSessionMillis(long milliseconds)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public void SetCaptureUncaughtExceptions(bool value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public void SetDebugLogsEnabled(bool value)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}
}
