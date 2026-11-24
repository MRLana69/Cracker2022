using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway;
using UI.Screens.RewardManagement;
using UnityEngine;
using UnityEngine.Networking;

public class InRunAverageFPSCounter : MonoBehaviour
{
	private float _runStartedTime;

	private float _runEndedTime;

	private float _runPausedTime;

	private float _runResumedTime;

	private float _appMinimizedTime;

	private float _appResumedTime;

	private float _amountOfTimePaused;

	private int _frameCount;

	private bool _isInitialized;

	private bool _isInRun = false;

	private bool _isPaused;

	private bool _isSubscribedToOnPause;

	private const int MAX_NUMBER_OF_INTERVALS = 10;

	private static int runAverageFPS__BackingField;

	private static int runLength__BackingField;

	private string _gpuName;

	public static int runAverageFPS
	{
		get
		{
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_0210: Expected I, but got Obj
			//IL_0226: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0202: Expected I4, but got Obj
			//IL_0130: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00ab: Expected I, but got Obj
			//IL_01c6: Expected Obj, but got I
			//IL_00c7: Expected I, but got Obj
			//IL_00f7: Expected I, but got Obj
			//IL_011d: Expected I, but got Obj
			nint num = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<DeviceInfo>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v46 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (DeviceInfo._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				DeviceInfo deviceInfo = default;
				deviceInfo.SetDeviceInfoForUnknownIphone();
				nint num3 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<DeviceInfo>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				bool flag = obj2 == null;
				nint num4 = (nint)typeof(DeviceInfo);
				if (!flag)
				{
					nint num5 = (nint)typeof(DeviceInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v40 (Il2CppClass<DeviceInfo>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(DeviceInfo);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(DeviceInfo);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ L0_v8 (Il2CppClass<DeviceInfo>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				obj3 = deviceInfo;
			}
			nint num6 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<DeviceInfo>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num7 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (int)DeviceInfo._instance;
		}
		private set
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
		}
	}

	public static int runLength
	{
		get
		{
			return runAverageFPS__BackingField;
		}
		private set
		{
			runAverageFPS__BackingField = value;
		}
	}

	public void Initialize()
	{
		//IL_000b: Expected I4, but got Obj
		runLength__BackingField = (int)this;
	}

	private unsafe void SubscribeToGameInstanceEvents()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected Obj, but got Unknown
		//IL_0093: Expected I, but got Obj
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected Obj, but got Unknown
		if (~(_isInitialized ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Action action = default;
		((Delegate)action).method_ptr = method_ptr;
		((Delegate)action).method = (nint)__ldftn(InRunAverageFPSCounter.RunStarted);
		object obj = action + 16;
		obj = this;
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v38 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Game.OnGameStarted -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr2 = 0;
		Action action2 = default;
		((Delegate)action2).method_ptr = method_ptr2;
		((Delegate)action2).method = (nint)__ldftn(InRunAverageFPSCounter.RunEnded);
		object obj3 = action2 + 16;
		obj3 = this;
		Game.OnMenuScreenShown -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr3 = 0;
		Action action3 = default;
		((Delegate)action3).method_ptr = method_ptr3;
		((Delegate)action3).method = (nint)__ldftn(InRunAverageFPSCounter.SubscribeToGameInstanceEvents);
		object obj4 = action3 + 16;
		obj4 = this;
		Game.OnGameAwake -= action3;
		object obj5 = this + 48;
		string graphicsDeviceVersion = SystemInfo.GetGraphicsDeviceVersion();
		obj5 = graphicsDeviceVersion;
		_isInitialized = true;
	}

	private void Update()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_0108: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		if (~(_isSubscribedToOnPause ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v10 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v17 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		_ = 0;
		Action<bool> action = default;
		object obj2 = action + 16;
		obj2 = this;
		((Game)isInstantiated).OnPauseChange -= action;
		_isSubscribedToOnPause = true;
	}

	private void RunStarted()
	{
		if (~(_isInRun ? 1u : 0u) == 0 && ~(_isPaused ? 1u : 0u) != 0)
		{
			int frameCount = _frameCount + 1;
			_frameCount = frameCount;
		}
	}

	private void RunEnded()
	{
		_isInRun = true;
		_amountOfTimePaused = 0f;
		_frameCount = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8988");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8989");
		Update();
		float maxDelay = NetworkServer.maxDelay;
		_runStartedTime = maxDelay;
	}

	private string RoundUpToTargetValue(int total, int factor)
	{
		//IL_000d: Expected Obj, but got I4
		return (string)(total - factor);
	}

	private void PauseChange(bool pause)
	{
		//IL_0075: Expected I, but got Obj
		//IL_008b: Expected Obj, but got I
		//IL_00b4: Expected Obj, but got F4
		//IL_0013: Expected I, but got Obj
		//IL_0061: Expected Obj, but got F4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v10 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)_runStartedTime).FindKernel(null) != 0)
		{
			((UILabel)_runStartedTime).fontSize = (pause ? 1 : 0);
		}
	}

	private void OnApplicationPause(bool paused)
	{
		if (~(_isInRun ? 1u : 0u) == 0)
		{
			_isPaused = paused;
			float maxDelay = NetworkServer.maxDelay;
			if (paused)
			{
				_runPausedTime = maxDelay;
				return;
			}
			_runResumedTime = maxDelay;
			float num = _runResumedTime - _runPausedTime;
			float amountOfTimePaused = _amountOfTimePaused + num;
			_amountOfTimePaused = amountOfTimePaused;
		}
	}

	public InRunAverageFPSCounter()
	{
		//IL_01f0: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_009c: Expected Obj, but got I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected I4, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_0119: Expected Obj, but got I4
		//IL_0144: Expected I, but got Obj
		//IL_015a: Expected Obj, but got I
		//IL_0185: Expected I, but got Obj
		float maxDelay = NetworkServer.maxDelay;
		_runEndedTime = maxDelay;
		nint num = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S3_v2 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v8 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float num3 = _runStartedTime + _amountOfTimePaused;
		float f = _runEndedTime - num3;
		int num4 = Mathf.FloorToInt(f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8989");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF2");
		object obj2 = default;
		if (obj2 != null)
		{
			bool flag = _frameCount == int.MinValue;
			bool flag2 = (nint)obj2 == -1;
			object obj3 = flag & flag2;
			if (obj3 != null)
			{
				int num5 = 0;
			}
			else
			{
				int num5 = _frameCount / obj2;
			}
		}
		else
		{
			int num5 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8988");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF0");
		object obj4 = default;
		if ((nint)obj4 <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7DF0");
		CelebrationReward rewardToDouble = default;
		bool flag3 = ((MysteryBoxDoubleUpButton)null).TryEnable(rewardToDouble, (Dictionary<CelebrationRewardType, Action>)6);
		string text = $"FPS range {(object[])flag3}";
		string text2 = $"GPU name {(object[])(object)_gpuName}";
		nint num6 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v29 (Il2CppClass<Flurry>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v32 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}
}
