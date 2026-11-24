using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Experimental.Playables;
using UnityEngine.Playables;

namespace SYBO.Components.Logging;

public class LogPlatformUnityLean : ILogPlatform
{
	void ILogPlatform.LogFormat(LogCategory logCategory, int logLevel, UnityEngine.Object context, string format, object[] args)
	{
	}

	void ILogPlatform.LogWarningFormat(LogCategory logCategory, int logLevel, UnityEngine.Object context, string format, object[] args)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0109: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0060: Expected I4, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_01ea: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		if (logCategory.Level < logLevel)
		{
			return;
		}
		object obj = logCategory.Level - logCategory.HideStackLevel;
		if ((nint)obj < logLevel)
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			string format2 = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v31 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogErrorFormat(context, format2, args);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		string format3 = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v17 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogErrorFormat(context, format3, args);
	}

	void ILogPlatform.LogErrorFormat(LogCategory logCategory, int logLevel, UnityEngine.Object context, string format, object[] args)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0109: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_0200: Expected VT, but got Obj
		//IL_0200: Expected VT, but got Obj
		//IL_004e: Expected Obj, but got I4
		//IL_0060: Expected I4, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_01db: Expected VT, but got Obj
		//IL_01db: Expected VT, but got Obj
		//IL_01ea: Expected Obj, but got I4
		//IL_01ea: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		if (logCategory.Level < logLevel)
		{
			return;
		}
		object obj = logCategory.Level - logCategory.HideStackLevel;
		if ((nint)obj < logLevel)
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			string text = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v31 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v37 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((PlayableBehaviour)(object)context).OnBehaviourPlay((Playable)text, (FrameData)args);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		string text2 = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v17 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v22 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((PlayableBehaviour)(object)context).OnBehaviourPlay((Playable)text2, (FrameData)args);
	}

	void ILogPlatform.LogFormat(LogCategory logCategory, int logLevel, string format, object[] args)
	{
	}

	void ILogPlatform.LogWarningFormat(LogCategory logCategory, int logLevel, string format, object[] args)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0109: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0060: Expected I4, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		if (logCategory.Level < logLevel)
		{
			return;
		}
		object obj = logCategory.Level - logCategory.HideStackLevel;
		if ((nint)obj < logLevel)
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			string message = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S1_v21 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S1_v27 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogError(message, (UnityEngine.Object)(object)args);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		string message2 = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S1_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message2, (UnityEngine.Object)(object)args);
	}

	unsafe void ILogPlatform.LogErrorFormat(LogCategory logCategory, int logLevel, string format, object[] args)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0109: Expected I4, but got Obj
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_0060: Expected I4, but got Obj
		//IL_015c: Expected I, but got Obj
		//IL_0077: Expected I, but got Obj
		//IL_008d: Expected Obj, but got I
		//IL_01e6: Expected Obj, but got I4
		//IL_01e6: Expected Obj, but got I4
		//IL_00b8: Expected I, but got Obj
		if (logCategory.Level < logLevel)
		{
			return;
		}
		object obj = logCategory.Level - logCategory.HideStackLevel;
		if ((nint)obj < logLevel)
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			string text = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
			nint num = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v21 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v27 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PlayableHandle handle = ((CameraPlayable*)args)->GetHandle();
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
			return;
		}
		string text2 = string.ConcatArray((string[])(object)logCategory.MessagePrefix, (int)format);
		nint num3 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v14 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PlayableHandle handle2 = ((CameraPlayable*)args)->GetHandle();
	}

	void ILogPlatform.LogLongString(LogCategory logCategory, int level, string data)
	{
	}

	void ILogPlatform.LogException(LogCategory logCategory, int logLevel, Exception exception)
	{
		//IL_001c: Expected Obj, but got I4
		//IL_0224: Expected I, but got Obj
		//IL_023a: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I4
		//IL_02ce: Expected Obj, but got I4
		//IL_0194: Expected I, but got Obj
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected I4, but got Unknown
		//IL_01e2: Expected Obj, but got I4
		//IL_01e2: Expected Obj, but got I4
		//IL_009f: Expected Obj, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected I4, but got Unknown
		//IL_00de: Expected I4, but got Obj
		//IL_00f0: Expected I, but got Obj
		//IL_0106: Expected Obj, but got I
		//IL_026e: Expected Obj, but got I4
		//IL_0131: Expected I, but got Obj
		if (logCategory.Level < logLevel)
		{
			return;
		}
		object obj = logCategory.Level - logCategory.HideStackLevel;
		if ((nint)obj < logLevel)
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
		}
		Exception ex = default;
		string message2 = default;
		if ((nint)ex._className >= 769)
		{
			char[] array = null;
			while (true)
			{
				int num = array + 768;
				if (num >= (nint)ex._className)
				{
					break;
				}
				int num2 = ((string)(object)ex).LastIndexOfAny((char[])10, num);
				if (num2 < 0)
				{
					break;
				}
				int length = num2 - array;
				string message = ((string)(object)ex).InternalSubString((int)array, length);
				nint num3 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ S1_v26 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S1_v32 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogError(message);
				char[] array2 = (char[])(num2 + 1);
				array = array2;
			}
			message2 = ((string)(object)ex).Trim(array);
		}
		nint num5 = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v19 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v29 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(message2);
		object obj4 = logCategory.Level - logCategory.HideStackLevel;
		if ((nint)obj4 < logLevel)
		{
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)1);
		}
	}

	public LogPlatformUnityLean()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}
}
