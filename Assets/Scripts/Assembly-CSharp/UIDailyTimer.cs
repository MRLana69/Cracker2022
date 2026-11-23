using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class UIDailyTimer : MonoBehaviour
{
	private TMP_Text _timerLabel;

	private string prefix = string.Empty;

	private bool doARefresh;

	private int _totalSeconds = -1;

	private void Update()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0021: Invalid comparison between VT and I4
		//IL_0076: Expected F8, but got I4
		//IL_0410: Invalid comparison between F8 and I4
		//IL_0085: Expected I4, but got F8
		object obj2 = default;
		object obj = obj2 - 32;
		PlayerInfo instance = PlayerInfo.Instance;
		TimeSpan dailyWordTimeLeft = instance.dailyWordTimeLeft;
		if (dailyWordTimeLeft <= (object)0)
		{
			PlayerInfo instance2 = PlayerInfo.Instance;
			TimeSpan dailyWordDeviceTiemLeft = instance2.dailyWordDeviceTiemLeft;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		double num = 0.0 * 1E-07;
		double num2 = Math.Abs(num);
		if (!(num2 < 2147483648.0))
		{
			num = -2147483648.0;
		}
		if (num != (double)_totalSeconds)
		{
			_totalSeconds = (int)num;
			TMP_Text timerLabel = _timerLabel;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
			throw new ArrayTypeMismatchException();
		}
	}

	private void OnApplicationPause(bool paused)
	{
		if (!paused)
		{
			doARefresh = true;
		}
	}
}
