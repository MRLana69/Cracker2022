using System;
using Cpp2ILInjected;
using UnityEngine;

public class AndroidIncomingCallBridge : MonoBehaviour
{
	public delegate void IncomingCallEvent(string state);

	private const string CALLBACK_RECEIVER_NAME = "IncomingCallReceiverBridge";

	private AndroidJavaObject _androidBridge;

	private IncomingCallEvent m_onPhoneStateChanged;

	public event IncomingCallEvent onPhoneStateChanged
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onPhoneStateChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
		remove
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onPhoneStateChanged;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = obj2 == obj;
				if (!flag)
				{
					obj4 = (Delegate)obj;
				}
				obj = obj4;
				Delegate obj5 = obj2;
				if (!flag)
				{
					obj5 = (Delegate)obj;
				}
				flag2 = (object)obj2 != obj5;
				obj2 = obj5;
			}
			while (flag2);
		}
	}

	public static AndroidIncomingCallBridge CreatePlugin()
	{
		GameObject gameObject = default;
		gameObject._002Ector("IncomingCallReceiverBridge");
		UnityEngine.Object.DontDestroyOnLoad(gameObject);
		return gameObject.AddComponent<AndroidIncomingCallBridge>();
	}

	public void Init()
	{
		if (_androidBridge == null)
		{
			RuntimePlatform platform = Application.platform;
			if (platform == RuntimePlatform.Android)
			{
				object[] args = Array.Empty<object>();
				AndroidJavaObject androidJavaObject = default;
				androidJavaObject._002Ector("com.kiloo.unityplugins.IncomingCallReceiver", args);
				_androidBridge = androidJavaObject;
			}
		}
	}

	private void _callback_onAudioStateChanged(string isModeNormal)
	{
		IncomingCallEvent incomingCallEvent = this.m_onPhoneStateChanged;
		if (this.m_onPhoneStateChanged != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v2.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void LogError(string msg, UnityEngine.Object context = null)
	{
		string text = "AndroidIncomingCallBridge: " + msg;
	}

	private static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	private static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
