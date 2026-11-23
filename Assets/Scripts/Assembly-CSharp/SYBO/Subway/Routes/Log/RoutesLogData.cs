using System;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Routes.Log;

[Serializable]
public class RoutesLogData
{
	private float _timeStamp;

	private RoutesLogType _routesLogType;

	private object[] _args;

	protected string _message;

	public float TimeStamp => _timeStamp;

	public RoutesLogType RoutesLogType => _routesLogType;

	public object[] Args => _args;

	public string Message => _message;

	public RoutesLogData(RoutesLogType pickupLogType, object[] args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected Obj, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_message = string.Empty;
		_args = args;
		_routesLogType = pickupLogType;
		float timeSinceLevelLoad = Time.timeSinceLevelLoad;
		_timeStamp = timeSinceLevelLoad;
		_ = _routesLogType;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		_ = _timeStamp;
		object obj4 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		object arg = default;
		object arg2 = default;
		string message = $"[RoutesLogData (RoutesLogType={arg},TimeStamp={arg2})]";
		_message = message;
	}

	public override string ToString()
	{
		return _message;
	}
}
