using Cpp2ILInjected;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class IncomingCallManager : MonoBehaviour
{
	private static AndroidIncomingCallBridge _platformBridge;

	private static bool _gameSfxEnabledBeforeCall;

	private static bool _gameMusicEnabledBeforeCall;

	private static bool _hasMutedSound;

	private static bool _isInCall;

	private static AndroidIncomingCallBridge.IncomingCallEvent _003C_003Ef__mg_0024cache0;

	public static bool IsInCall => _isInCall;

	public unsafe static void Init()
	{
		if (!(_platformBridge == null))
		{
			return;
		}
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android && !DeviceUtility.isKindleDevice)
		{
			AndroidIncomingCallBridge platformBridge = AndroidIncomingCallBridge.CreatePlugin();
			_platformBridge = platformBridge;
			if (_platformBridge != null)
			{
				AndroidIncomingCallBridge.IncomingCallEvent incomingCallEvent = default;
				incomingCallEvent._002Ector(null, (nint)(delegate*<string, void>)(&PhoneStateChanged));
				_platformBridge.onPhoneStateChanged += incomingCallEvent;
				_platformBridge.Init();
			}
		}
	}

	private unsafe static void PhoneStateChanged(string state)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected Ref, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		bool flag = bool.TryParse(state, out *(bool*)(obj + 15));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F]");
		if ((nint)0 != 0)
		{
			RestoreSound();
		}
		else
		{
			MuteSound();
		}
	}

	private static void RestoreSound()
	{
		Settings.optionSfx = _gameSfxEnabledBeforeCall;
		Settings.optionMusic = _gameMusicEnabledBeforeCall;
		HouseKeeper.DeleteSoundOptionBeforeVideoAds();
		_isInCall = false;
		_hasMutedSound = false;
	}

	private static void MuteSound()
	{
		_isInCall = true;
		if (~(_hasMutedSound ? 1u : 0u) != 0)
		{
			_hasMutedSound = true;
			bool optionSfx = Settings.optionSfx;
			_gameSfxEnabledBeforeCall = optionSfx;
			bool optionMusic = Settings.optionMusic;
			_gameMusicEnabledBeforeCall = optionMusic;
			HouseKeeper.SaveAudioOptionsBeforeVideoAds(_gameSfxEnabledBeforeCall, _gameMusicEnabledBeforeCall);
		}
		Settings.DisableAllSoundOptions();
	}

	private static void LogError(string msg, Object context = null)
	{
		string text = "IncomingCallManager: " + msg;
	}

	private static void LogWarning(string msg, Object context = null)
	{
	}

	private static void Log(string msg, Object context = null)
	{
	}
}
