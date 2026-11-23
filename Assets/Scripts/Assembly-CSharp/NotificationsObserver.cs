using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using MiniJSON;
using UnityEngine;

public class NotificationsObserver : MonoBehaviour
{
	public delegate void NotificationHandler(Notification notification);

	private const string TITLE_DICT_KEY = "title";

	private const string MESSAGE_DICT_KEY = "message";

	private const string TYPE_DICT_KEY = "type";

	private const string SOUNDNAME_DICT_KEY = "soundName";

	private const string USERINFO_DICT_KEY = "userInfo";

	private static NotificationsObserver _instance;

	private NotificationHandler m_onNotificationReceived;

	private Action<Notification> m_onNotificationPressed;

	public static NotificationsObserver instance
	{
		get
		{
			if (_instance == null)
			{
				GameObject gameObject = default;
				gameObject._002Ector("NotificationsObserver");
				NotificationsObserver notificationsObserver = gameObject.AddComponent<NotificationsObserver>();
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
			}
			return _instance;
		}
	}

	public event NotificationHandler onNotificationReceived
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 12;
			Delegate obj2 = this.m_onNotificationReceived;
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
			object obj = this + 12;
			Delegate obj2 = this.m_onNotificationReceived;
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

	public event Action<Notification> onNotificationPressed
	{
		add
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected Obj, but got Unknown
			object obj = this + 16;
			Delegate obj2 = this.m_onNotificationPressed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Combine(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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
			Delegate obj2 = this.m_onNotificationPressed;
			Delegate obj4 = default;
			bool flag2;
			do
			{
				Delegate obj3 = Delegate.Remove(obj2, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23D");
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

	private void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			return;
		}
		GameObject obj = gameObject;
		UnityEngine.Object.Destroy(obj);
	}

	private unsafe void OnApplicationPause(bool pause)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected Ref, but got Unknown
		//IL_0120: Expected Obj, but got I
		object obj = default;
		NotificationsObserver notificationsObserver = (NotificationsObserver)(obj - 16);
		if (pause)
		{
			return;
		}
		notificationsObserver.m_onNotificationReceived = null;
		RuntimePlatform platform = Application.platform;
		object obj2 = platform - 8;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			if ((nint)obj2 != 1 && (nint)obj2 != 2 && (nint)obj2 == 3 && notificationsObserver.DidAppStartFromNotificationAndroid(out *(Notification*)(notificationsObserver + 12)) && this.m_onNotificationPressed != null)
			{
				nint num = 0;
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S3_v4 (Il2CppMethodRgctx<Kiloo.Common.Extensions.MiscExtensions::SafeInvoke>)+4]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S3_v5+4] (should have been resolved before IL gen)");
			}
		}
		else
		{
			notificationsObserver.m_onNotificationReceived = null;
		}
	}

	private bool DidAppStartFromNotificationAndroid(out Notification notification)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + -64;
		_ = 0;
		_ = 0;
		_ = 0;
		AndroidJavaClass androidJavaClass = default;
		androidJavaClass._002Ector("com.kiloo.unityutilities.UnityPluginActivity");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v47 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::CallStatic>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num3 = 0;
		nint num4 = 0;
		IntPtr intPtr2 = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v68 @ S4_v7 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private unsafe bool DidAppStartFromNotificationIOS(out Notification notification)
	{
		ref Notification reference = ref *(Notification*)null;
		return false;
	}

	private unsafe void Start()
	{
		RuntimePlatform platform = Application.platform;
		if (platform == RuntimePlatform.Android)
		{
			GCMPlugin.AndroidNotificationReceivedDelegate androidNotificationReceivedDelegate = default;
			androidNotificationReceivedDelegate._002Ector(this, (nint)__ldftn(NotificationsObserver.onAndroidNotificationReceived));
			GCMPlugin.onNotificationReceived += androidNotificationReceivedDelegate;
		}
	}

	private unsafe void onAndroidNotificationReceived(string payload)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Ref, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Ref, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected Ref, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected Ref, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		object obj = default;
		string text = (string)(obj - 16);
		text._firstChar = '\0';
		object obj2 = Json.Deserialize(payload);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		Dictionary<string, object> dictionary = default;
		if (dictionary == null)
		{
			return;
		}
		bool flag = dictionary.TryGetValue("title", out *(object*)(text + 12));
		char firstChar = default;
		string message;
		if (text._firstChar == '\0')
		{
			bool flag2 = dictionary.TryGetValue("message", out *(object*)(text + 12));
			firstChar = text._firstChar;
			bool flag3 = text._firstChar == '\0';
			message = null;
			if (flag3)
			{
				goto IL_017a;
			}
		}
		bool flag4 = (int)((char*)(int)firstChar)->m_value == (nint)typeof(string);
		message = (string)text._firstChar;
		if (!flag4)
		{
			message = null;
		}
		goto IL_017a;
		IL_017a:
		bool flag5 = dictionary.TryGetValue("type", out *(object*)(text + 12));
		char firstChar2 = text._firstChar;
		bool flag6 = text._firstChar == '\0';
		string type = null;
		if (!flag6)
		{
			bool flag7 = (int)((char*)(int)firstChar2)->m_value == (nint)typeof(string);
			type = (string)text._firstChar;
			if (!flag7)
			{
				type = null;
			}
		}
		if (dictionary.TryGetValue("userInfo", out *(object*)(text + 12)))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @238");
		}
		Dictionary<string, object> userInfo = default;
		alertListeners(text, message, type, userInfo, text);
	}

	private void alertListeners(string title, string message, string type, Dictionary<string, object> userInfo, string soundName = "")
	{
		if (userInfo != null)
		{
		}
		NotificationHandler notificationHandler = this.m_onNotificationReceived;
		if (this.m_onNotificationReceived != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v28.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}
}
