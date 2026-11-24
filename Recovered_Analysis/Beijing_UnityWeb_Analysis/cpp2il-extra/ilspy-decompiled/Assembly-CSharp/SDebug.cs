using System;
using System.Text;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Experimental.Playables;
using UnityEngine.Playables;

public static class SDebug
{
	private const int UNITY_LOG_MAXIMUM_CHAR_LIMIT = 15500;

	public static void Log(object message, UnityEngine.Object context = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = message + 12;
		obj = context;
	}

	private static bool MessageExceedsLimit(string fullLog)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		//IL_0025: Expected Obj, but got I4
		//IL_003c: Expected Obj, but got I4
		//IL_005c: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		obj = fullLog.m_firstChar;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		obj2 = fullLog.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text = default;
		string text2 = default;
		return (byte)(int)(text + " - " + text2) != 0;
	}

	private static void LogExtendedMessage(string fullLog, UnityEngine.Object context = null)
	{
		//IL_0025: Expected I, but got Obj
		//IL_003b: Expected Obj, but got I
		//IL_0066: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Object)+8]");
		if ((nint)0 > (nint)15500)
		{
			object message = default;
			LogWarning(message, context);
			return;
		}
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v16 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogFormat(fullLog, (object[])(object)context);
	}

	public static void LogWarning(object message, UnityEngine.Object context = null)
	{
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected Obj, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected Obj, but got Unknown
		//IL_044b: Expected Obj, but got I4
		//IL_0013: Expected Obj, but got I4
		//IL_009e: Expected Obj, but got I4
		//IL_0068: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I4
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I4
		//IL_00e3: Expected Obj, but got I4
		//IL_01fc: Expected Obj, but got I4
		//IL_01cb: Expected Obj, but got I4
		//IL_04db: Expected Obj, but got I4
		//IL_0255: Expected Obj, but got I
		//IL_012d: Expected Obj, but got I4
		//IL_0155: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I4
		//IL_030a: Expected Obj, but got I4
		//IL_0343: Expected Obj, but got I4
		//IL_0392: Expected I, but got Obj
		//IL_03a8: Expected Obj, but got I
		//IL_04fb: Expected Obj, but got I4
		//IL_0509: Expected Obj, but got I4
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected I4, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected Obj, but got Unknown
		//IL_037f: Expected Obj, but got I4
		//IL_03d3: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 8;
		object obj3 = obj2 + 4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		object obj4 = 0;
		int num = default;
		object obj7 = default;
		object[] args = default;
		object[] args2 = default;
		object[] args3 = default;
		int num10 = default;
		object obj10 = default;
		while (obj4 == null)
		{
			object obj5 = num + 15500;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ L0 (System.Object)+8]");
			int num3;
			object obj6;
			if ((nint)obj5 > 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ L0 (System.Object)+8]");
				int num2 = (int)(-num);
				num3 = num2;
				obj6 = 1;
			}
			else
			{
				string text = ((string)message).InternalSubString(num, 15500);
				PlatformID platform = Environment.Platform;
				bool flag = text.StartsWith((string)platform);
				if ((flag ? 1 : 0) != -1)
				{
					PlatformID platform2 = Environment.Platform;
					bool flag2 = text.StartsWith((string)platform2);
					if ((flag2 ? 1 : 0) >= 5001)
					{
						PlatformID platform3 = Environment.Platform;
						bool flag3 = text.StartsWith((string)platform3);
						int num4 = (flag3 ? 1 : 0) + 1;
						num3 = num4;
						obj6 = 0;
						goto IL_048a;
					}
				}
				int num5 = text.LastIndexOfAny((char[])32);
				int num6;
				if (num5 == -1)
				{
					num6 = 15500;
				}
				else
				{
					PlatformID platform4 = Environment.Platform;
					bool flag4 = text.StartsWith((string)platform4);
					if ((flag4 ? 1 : 0) < 5001)
					{
						num6 = 15500;
					}
					else
					{
						int num7 = text.LastIndexOfAny((char[])32);
						num6 = num7 + 1;
					}
				}
				num3 = num6;
				obj6 = 0;
			}
			goto IL_048a;
			IL_048a:
			stringBuilder.AppendHelper((string)null);
			StringBuilder stringBuilder2 = stringBuilder.AppendLine("<size=9><color=grey><b>(Extended log)</b> Part </color><color=silver><b>");
			object value = obj7 + 1;
			StringBuilder stringBuilder3 = stringBuilder.Append(value);
			StringBuilder stringBuilder4 = stringBuilder.AppendLine("</b></color><color=grey> from index </color><color=olive><b>");
			obj = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string value2 = $"{args:n0}";
			StringBuilder stringBuilder5 = stringBuilder.AppendLine(value2);
			StringBuilder stringBuilder6 = stringBuilder.AppendLine("</b></color><color=grey>/</color><color=silver>");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [message @ L0 (System.Object)+8]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string value3 = $"{args2:n0}";
			StringBuilder stringBuilder7 = stringBuilder.AppendLine(value3);
			StringBuilder stringBuilder8 = stringBuilder.AppendLine("</color><color=grey> with a length of </color><color=silver><b>");
			obj2 = num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string value4 = $"{args3:n0}";
			StringBuilder stringBuilder9 = stringBuilder.AppendLine(value4);
			StringBuilder stringBuilder10 = stringBuilder.AppendLine("</b></color><color=grey> characters:</color></size>");
			PlatformID platform5 = Environment.Platform;
			StringBuilder stringBuilder11 = stringBuilder.AppendLine((string)platform5);
			string value5 = ((string)message).InternalSubString(num, num3);
			StringBuilder stringBuilder12 = stringBuilder.AppendLine(value5);
			string message2 = ((AssertionException)3).Message;
			if (obj6 == null)
			{
				((Application.AdvertisingIdentifierCallback)3).EndInvoke(null);
			}
			nint num8 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ S0_v65 (Il2CppClass<UnityEngine.Debug>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num9 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ S0_v76 (Il2CppClass<UnityEngine.Debug>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Debug.LogFormat((string)(object)stringBuilder, (object[])(object)context);
			((Application.AdvertisingIdentifierCallback)3).EndInvoke((IAsyncResult)(object)message2);
			object obj9 = num3 + 1;
			num = obj9 + num10;
			obj7 = obj10 + 1;
			obj4 = obj6;
		}
	}

	public static void LogError(object message, UnityEngine.Object context = null)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogWarningFormat((string)message, (object[])(object)context);
	}

	public static void LogFormat(UnityEngine.Object context, string msg, object[] args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj = context + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8A8C");
	}

	public static void LogFormat(string msg, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogErrorFormat(msg, args);
	}

	public static void LogWarningFormat(UnityEngine.Object context, string msg, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogErrorFormat(context, msg, args);
	}

	public static void LogWarningFormat(string msg, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError(msg, (UnityEngine.Object)(object)args);
	}

	public static void LogErrorFormat(UnityEngine.Object context, string msg, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a4: Expected VT, but got Obj
		//IL_00a4: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((PlayableBehaviour)(object)context).OnBehaviourPlay((Playable)msg, (FrameData)args);
	}

	public unsafe static void LogErrorFormat(string msg, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		PlayableHandle handle = ((CameraPlayable*)args)->GetHandle();
	}

	public static void LogAssertion(object message)
	{
		_ = 100f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	public static void LogAssertion(object message, UnityEngine.Object context)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)message, context);
	}

	public static void LogAssertionFormat(string format, object[] args)
	{
	}

	public static void LogAssertionFormat(UnityEngine.Object context, string format, object[] args)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogWarningFormat(context, format, args);
	}

	public static void LogException(Exception exception)
	{
	}

	public static void LogException(Exception exception, UnityEngine.Object context)
	{
	}
}
