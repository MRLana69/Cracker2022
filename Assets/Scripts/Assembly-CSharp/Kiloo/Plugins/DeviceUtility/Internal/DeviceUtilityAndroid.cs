using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Plugins.DeviceUtility.Internal;

internal class DeviceUtilityAndroid : MonoBehaviour, IDeviceUtilityPlatformBridge
{
	private const char PARAMETER_SEPARATOR = ';';

	private const string OS_IDENTIFIER = "android";

	private AndroidJavaObject _androidBridge;

	private const int ANDROID_BUTTON_POSITIVE = -1;

	private const int ANDROID_BUTTON_NEGATIVE = -2;

	private const int ANDROID_BUTTON_NEUTRAL = -3;

	private const string CALLBACK_RECEIVER_NAME = "DeviceUtility Receiver";

	public bool hasPhysicalBackButton => true;

	public bool isKindleDevice => false;

	public bool isFlexionDevice => false;

	private static void LogError(string msg)
	{
		string text = "[DeviceUtilityAndroid] " + msg;
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}

	private void Awake()
	{
		object[] args = Array.Empty<object>();
		AndroidJavaObject androidJavaObject = default;
		androidJavaObject._002Ector("com.kiloo.unityplugin.deviceutility.DeviceUtilityBridgeAndroid", args);
		_androidBridge = androidJavaObject;
	}

	private void _callback_alertViewDidDismissWithButtonIndex(string message)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ea: Expected Obj, but got Unknown
		//IL_0590: Expected Obj, but got I
		//IL_05bb: Expected Obj, but got I
		//IL_05e0: Expected Obj, but got I
		//IL_031f: Expected F8, but got I4
		//IL_0332: Expected F8, but got I4
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v11+C]");
			if ((nint)0 != 2)
			{
				goto IL_0739;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 32;
					_ = 45;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ S0_v130+C]");
								if ((nint)0 != 1)
								{
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ S0_v140+C]");
								if ((nint)0 != 1)
								{
									return;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											double value = default;
											double num = Math.Abs(value);
											if (!(num < 2147483648.0))
											{
												value = -2147483648.0;
											}
											double num3 = default;
											double num2 = Math.Abs(num3);
											if (!(num2 < 2147483648.0))
											{
												num3 = -2147483648.0;
											}
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj4 = default;
														if (obj4 == null)
														{
															return;
														}
														_ = 0;
														double num4 = 0.0 - num3;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															return;
														}
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag = obj5 != obj6;
		object obj8 = default;
		object obj7 = obj8;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj10 = default;
				object obj9 = obj10;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj11 = default;
					if (obj11 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj12 = (nint)0 << 2;
						object obj13 = obj3 + obj12;
						obj13 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj14 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v8+4]");
						object obj15 = -1;
						goto IL_0739;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj16 = obj10;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag2 = (nint)0 != 1;
					obj7 = obj10;
					if (flag2)
					{
						goto IL_07bd;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag3 = (nint)0 != 1;
			object obj17 = default;
			obj7 = obj17;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				obj7 = obj17;
			}
		}
		goto IL_07bd;
		IL_07bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		return;
		IL_0739:
		LogError("Malformed dialog callback message");
	}

	public string GetBuildIdentifier()
	{
		return ((DeviceUtilityAndroid)null).GetOSIdentifier();
	}

	public void SetKeyboardReturnType(int returnKeyType)
	{
	}

	public void SetDeviceUtilityDebugEnabled(bool val)
	{
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Set>>)+4] (should have been resolved before IL gen)");
	}

	public string GetUserDataPath()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string text = default;
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00bd;
			}
		}
		obj = 1;
		goto IL_00bd;
		IL_00bd:
		bool flag = obj == null;
		string result = text;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector("Could not get user data path");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			result = (string)(object)ex;
		}
		return result;
	}

	public string GetCachePath()
	{
		//IL_002a: Expected Obj, but got I4
		//IL_000e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string text = default;
		object obj;
		if (text != null)
		{
			obj = 0;
			if (text._stringLength != 0)
			{
				goto IL_00bd;
			}
		}
		obj = 1;
		goto IL_00bd;
		IL_00bd:
		bool flag = obj == null;
		string result = text;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			InvalidOperationException ex = default;
			ex._002Ector("Could not get cache path");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			result = (string)(object)ex;
		}
		return result;
	}

	public string GetDeviceIdentifier()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public string GetBundleVersion()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public string GetBundleIdentifier()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public string GetLocale()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public string GetOSVersion()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public string GetOSIdentifier()
	{
		return "android";
	}

	public void ShowNativePopup(string title, string message, string cancelButton, string optionalButton1, string optionalButton2, Action<string> onDismissed)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
		if ((nint)0 != 0)
		{
			throw new ArgumentException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	public void SetDeviceClipBoard(string text)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	public int GetDeviceFreeMemory()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetCurrentMemoryUsage()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetPeakMemoryUsage()
	{
		return 0;
	}

	public int GetMemoryUsageLimit()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetBatteryLevel()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetFreeDiskSpace()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetTotalDiskSpace()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetFreeSDCardSpace()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetTotalSDCardSpace()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public string GetAndroidExternalSavePath()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public int GetAndroidApiLevel()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public int GetAndroidVersionCode()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		int result = default;
		return result;
	}

	public string GetAndroidAdvertisingID()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public bool GetIOSOtherAudioPlaying()
	{
		return false;
	}

	public static DeviceUtilityAndroid CreatePlugin()
	{
		GameObject gameObject = default;
		gameObject._002Ector("DeviceUtility Receiver");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return gameObject.AddComponent<DeviceUtilityAndroid>();
	}
}
