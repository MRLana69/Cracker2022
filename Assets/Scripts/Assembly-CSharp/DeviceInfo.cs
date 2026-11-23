using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kiloo.Common.Performance;
using Kiloo.Plugins.DeviceUtility;
using UnityEngine;

public class DeviceInfo
{
	public enum FormFactor
	{
		iPhone,
		iPad,
		small,
		medium,
		large,
		iPhone5,
		iPhone6,
		iPhone6Plus,
		iPhoneUnknown
	}

	public enum PerformanceLevel
	{
		Low,
		Medium,
		High
	}

	private static readonly string ShaderBackgroundBlendSrcPropName = "_BackgroundBlendSrcMode";

	private static readonly string ShaderBackgroundBlendDstPropName = "_BackgroundBlendDstMode";

	public PerformanceLevel performanceLevel;

	public string deviceModel;

	private static DeviceInfo _instance;

	private float dpi__BackingField;

	private FormFactor formFactor__BackingField;

	private bool isHighres__BackingField;

	public float dpi
	{
		get
		{
			return dpi__BackingField;
		}
		private set
		{
			dpi__BackingField = value;
		}
	}

	public FormFactor formFactor
	{
		get
		{
			return formFactor__BackingField;
		}
		private set
		{
			formFactor__BackingField = value;
		}
	}

	public bool isHighres
	{
		get
		{
			return isHighres__BackingField;
		}
		private set
		{
			isHighres__BackingField = value;
		}
	}

	public int gpuScore
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public GPUCategory gpuCategory
	{
		get
		{
			return field;
		}
		private set
		{
			field = value;
		}
	}

	public static DeviceInfo Instance
	{
		get
		{
			if (_instance == null)
			{
				DeviceInfo deviceInfo = default;
				deviceInfo._002Ector();
				_instance = deviceInfo;
			}
			return _instance;
		}
	}

	private unsafe DeviceInfo()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected Obj, but got Unknown
		//IL_014c: Expected VT, but got F4
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		Shader.SetGlobalInt(ShaderBackgroundBlendSrcPropName, 5);
		Shader.SetGlobalInt(ShaderBackgroundBlendDstPropName, 10);
		deviceModel = SystemInfo.GetDeviceModel();
		isHighres__BackingField = Screen.height > 480;
		object obj3 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		float num;
		switch (Application.platform)
		{
		case RuntimePlatform.Android:
			if (DeviceUtility.isKindleDevice)
			{
				_ = 1147207680;
				num = 900f;
			}
			else
			{
				_ = 1148846080;
				num = 1000f;
			}
			break;
		case RuntimePlatform.WindowsPlayer:
		case RuntimePlatform.MetroPlayerARM:
			_ = 1152319488;
			num = 1400f;
			break;
		default:
			_ = 1325400064;
			num = 2.1474836E+09f;
			break;
		}
		AndroidGPUCategorizer.UknownGPUHandler uknownGPUHandler = default;
		uknownGPUHandler._002Ector(this, (nint)__ldftn(DeviceInfo.LogUnknownGPU));
		AndroidGPUCategorizer.Initialize((CategoryThresholds)num, uknownGPUHandler);
		gpuCategory__BackingField = GPUCategory.Low;
		gpuScore__BackingField = AndroidGPUCategorizer.gpuScore__BackingField;
		int height = Screen.height;
		if (height <= 499)
		{
			formFactor__BackingField = FormFactor.small;
		}
		else if (Screen.height <= 899)
		{
			formFactor__BackingField = FormFactor.medium;
		}
		else
		{
			formFactor__BackingField = FormFactor.large;
		}
		if (isTablet())
		{
			formFactor__BackingField = FormFactor.iPad;
		}
		int height2 = Screen.height;
		bool flag2;
		if (height2 >= 500)
		{
			bool flag = Screen.width > 320;
			flag2 = true;
			if (flag)
			{
				goto IL_0344;
			}
		}
		flag2 = false;
		goto IL_0344;
		IL_0344:
		isHighres__BackingField = flag2;
		float num2 = Screen.dpi;
		performanceLevel = PerformanceLevel.Low;
		bool flag3 = !(num2 > 0f);
		float num3 = 300f;
		if (!flag3)
		{
			num3 = num2;
		}
		dpi__BackingField = num3;
		if (DeviceUtility.isKindleDevice && deviceModel == "Amazon Kindle Fire")
		{
			Shader.SetGlobalInt(ShaderBackgroundBlendSrcPropName, 1);
			Shader.SetGlobalInt(ShaderBackgroundBlendDstPropName, 0);
		}
	}

	private bool isTablet()
	{
		//IL_00b5: Expected Obj, but got I4
		//IL_005f: Expected I4, but got F4
		//IL_00ea: Expected Obj, but got I4
		//IL_010a: Invalid comparison between Obj and F4
		//IL_0084: Expected I4, but got F4
		float num = Screen.dpi;
		int num2 = Screen.width;
		if (num > 0f)
		{
			float num3 = Screen.dpi;
			float num4 = (float)num2 / num3;
			num2 = (int)num4;
		}
		float num5 = Screen.dpi;
		int height = Screen.height;
		object obj = num2 * num2;
		int num8;
		if (num5 > 0f)
		{
			float num6 = Screen.dpi;
			float num7 = (float)height / num6;
			num8 = (int)num7;
		}
		else
		{
			num8 = height;
		}
		object obj2 = num8 * num8;
		object obj3 = obj + obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Sqrt not resolved\"");
		return System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)6f);
	}

	private void SetDeviceInfoForUnknownIphone()
	{
		int height = Screen.height;
		formFactor__BackingField = FormFactor.iPhoneUnknown;
		bool flag = height > 960;
		PerformanceLevel performanceLevel = (PerformanceLevel)((flag ? 1u : 0u) << 1);
		this.performanceLevel = performanceLevel;
		int height2 = Screen.height;
		dpi__BackingField = 300f;
		bool flag2 = height2 > 480;
		isHighres__BackingField = flag2;
	}

	private void SetDeviceInfoForUnknownIpad()
	{
		int height = Screen.height;
		formFactor__BackingField = FormFactor.iPad;
		bool flag = height > 1024;
		PerformanceLevel performanceLevel = (PerformanceLevel)((flag ? 1u : 0u) << 1);
		this.performanceLevel = performanceLevel;
		int height2 = Screen.height;
		dpi__BackingField = 264f;
		bool flag2 = height2 > 480;
		isHighres__BackingField = flag2;
	}

	private void LogUnknownGPU(string gpuName)
	{
		bool flag = AndroidGPUCategorizer.IsSupportedOnPlatform();
	}

	public bool IsDeviceCapablePerformance(PerformanceLevel perfLevel)
	{
		return performanceLevel >= perfLevel;
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "DeviceInfo: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
