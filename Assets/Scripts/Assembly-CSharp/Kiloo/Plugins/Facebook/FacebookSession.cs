using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using MiniJSON;
using UnityEngine;

namespace Kiloo.Plugins.Facebook;

public class FacebookSession : MonoBehaviour
{
	public enum State
	{
		CREATED,
		CREATED_TOKEN_LOADED,
		OPENING,
		OPENED,
		OPENED_TOKEN_UPDATED,
		CLOSED_LOGIN_FAILED,
		CLOSED
	}

	public delegate void StatusChangedHandler(State status, FacebookError error);

	public delegate void DialogCompleteHandler(IDictionary<string, object> result, FacebookError error);

	public delegate void RequestCompleteHandler(IDictionary<string, object> result, FacebookError error, bool isFromCache);

	private static FacebookSession _instance;

	private int _id;

	private AndroidJavaObject _facebookSessionJavaObject;

	private static FacebookLogLevel _loggingLevel = FacebookLogLevel.WARN;

	private static StatusChangedHandler m_statusChangedEvent;

	public static string appId
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public static bool isSupported => true;

	public static bool dialogsSupported => true;

	public static FacebookSession instance => _instance;

	public Action<bool> inputEnabledControl
	{
		get
		{
			return field;
		}
		set
		{
			field = value;
		}
	}

	public static event StatusChangedHandler statusChangedEvent
	{
		add
		{
			Delegate obj = FacebookSession.m_statusChangedEvent;
			StatusChangedHandler statusChangedHandler2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FacebookSession.m_statusChangedEvent;
				StatusChangedHandler statusChangedHandler = statusChangedHandler2;
				if (!flag)
				{
					statusChangedHandler = FacebookSession.m_statusChangedEvent;
				}
				FacebookSession.m_statusChangedEvent = statusChangedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookSession.m_statusChangedEvent;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = FacebookSession.m_statusChangedEvent;
			StatusChangedHandler statusChangedHandler2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == FacebookSession.m_statusChangedEvent;
				StatusChangedHandler statusChangedHandler = statusChangedHandler2;
				if (!flag)
				{
					statusChangedHandler = FacebookSession.m_statusChangedEvent;
				}
				FacebookSession.m_statusChangedEvent = statusChangedHandler;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = FacebookSession.m_statusChangedEvent;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static FacebookSession Create(string permissions, FacebookDefaultAudience defaultAudience)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Expected Obj, but got I4
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		if (_instance != null)
		{
			State state = _instance.GetState();
			object obj3 = state - 5;
			if ((nint)obj3 < 2)
			{
				IEnumerable<int> enumerable = PluginUtil.RemoveHandlers(_instance);
				GameObject obj4 = _instance.gameObject;
				UnityEngine.Object.Destroy(obj4);
				_instance = null;
			}
		}
		if (_instance == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A23C");
			int nextTicket = PluginUtil.GetNextTicket();
			FacebookSession facebookSession = default;
			facebookSession._id = nextTicket;
			_ = -1;
			obj = (Enum)(object)typeof(FacebookDefaultAudience);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
			_ = 0;
			string defaultAudience2 = obj.ToString();
			if (!facebookSession._Init(permissions, defaultAudience2))
			{
				GameObject obj5 = facebookSession.gameObject;
				UnityEngine.Object.Destroy(obj5);
			}
			_instance = facebookSession;
			return _instance;
		}
		return null;
	}

	public static void SetLoggingLevel(FacebookLogLevel level)
	{
		_SetLoggingLevel(level);
	}

	public void OpenForRead()
	{
		bool flag = _OpenForRead();
	}

	public void OpenForReadSilent(Action<bool> onFinished)
	{
	}

	public void Cancel()
	{
	}

	public void Close(bool clearToken)
	{
		_Close(clearToken);
	}

	public State GetState()
	{
		//IL_0035: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(State));
		string value = _GetState();
		object obj = Enum.Parse(typeFromHandle, value);
		throw new NullReferenceException();
	}

	public static bool IsOpened(State state)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = state - 3;
		return (nint)obj < 2;
	}

	public static bool IsClosed(State state)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = state - 5;
		return (nint)obj < 2;
	}

	public static bool HasOpenInstance()
	{
		//IL_0066: Expected Obj, but got I4
		if (!(_instance != null))
		{
			return false;
		}
		State state = _instance.GetState();
		object obj = state - 3;
		return (nint)obj < 2;
	}

	public string GetAccessToken()
	{
		return _GetAccessToken();
	}

	public unsafe DateTime? GetExpirationDateUTC()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_00d2: Expected VT, but got I
		//IL_0021: Expected I8, but got I4
		//IL_001c: Expected native int or pointer, but got VT
		//IL_0048: Expected native int or pointer, but got VT
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected VT, but got Unknown
		//IL_0077: Expected F8, but got I8
		//IL_0077: Expected Ref, but got VT
		//IL_008a: Expected VT, but got I4
		//IL_0093: Expected VT, but got I4
		object obj = default;
		DateTime dateTime = (DateTime)(obj - 32);
		_ = 0;
		_ = 0;
		_ = 0;
		long num = _GetExpirationDate();
		if (num != -1)
		{
			((DateTime*)(nint)dateTime)->_dateData = 0uL;
			*(DateTime*)(nint)dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			_ = dateTime._dateData;
			DateTime dateTime2 = dateTime + 24;
			DateTime dateTime3 = ((DateTime*)dateTime2)->AddSeconds(num);
			_ = 0;
			DateTime? dateTime4 = (DateTime?)(object)0;
			return (DateTime?)(object)1;
		}
		object obj2 = dateTime + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.DateTime)+8]");
		return (DateTime?)(object)0;
	}

	public string GetPermissions()
	{
		return _GetPermissions();
	}

	public FacebookLoginType GetLoginType()
	{
		//IL_0035: Expected VT, but got Obj
		Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(FacebookLoginType));
		string value = ((FacebookSession)(object)typeFromHandle)._GetLoginType();
		object obj = Enum.Parse(typeFromHandle, value);
		throw new NullReferenceException();
	}

	public void RequestNewReadPermissions(string permissions)
	{
		bool flag = _RequestNewReadPermissions(permissions);
	}

	public void RequestNewPublishPermissions(string permissions, FacebookDefaultAudience defaultAudience)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		_ = -1;
		obj = (Enum)(object)typeof(FacebookDefaultAudience);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string defaultAudience2 = obj.ToString();
		bool flag = _RequestNewPublishPermissions(permissions, defaultAudience2);
	}

	public bool CanShowNativeShareDialog()
	{
		return false;
	}

	public void ShowNativeShareDialog(IDictionary<string, object> parameters, DialogCompleteHandler dialogCompleteHandler)
	{
		int ticket = PluginUtil.CheckInHandler(dialogCompleteHandler, this);
		string text = Json.Serialize(parameters);
		Delegate obj = PluginUtil.CheckOutHandler(ticket);
	}

	public void ShowDialog(string action, IDictionary<string, object> parameters, DialogCompleteHandler dialogCompleteHandler)
	{
		int num = PluginUtil.CheckInHandler(dialogCompleteHandler, this);
		string paramsJSON = Json.Serialize(parameters);
		if (!_ShowDialog(action, paramsJSON, num))
		{
			Delegate obj = PluginUtil.CheckOutHandler(num);
		}
	}

	public void GraphRequest(string graphPath, IDictionary<string, object> parameters, HttpMethod httpMethod, RequestCompleteHandler requestCompleteHandler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		Enum obj = (Enum)(obj2 - 16);
		int num = PluginUtil.CheckInHandler(requestCompleteHandler, this);
		_ = -1;
		obj = (Enum)(object)typeof(HttpMethod);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (System.Enum)+C]");
		_ = 0;
		string httpMethod2 = obj.ToString();
		if (!_GraphRequest(graphPath, parameters, httpMethod2, num))
		{
			Delegate obj3 = PluginUtil.CheckOutHandler(num);
		}
	}

	public void UploadPhotoRequest(Texture2D image, string graphPath, string caption, RequestCompleteHandler requestCompleteHandler)
	{
		int num = PluginUtil.CheckInHandler(requestCompleteHandler, this);
		string graphPath2 = graphPath;
		if (graphPath == null)
		{
			graphPath2 = "me/photos";
		}
		if (!_UploadPhotoRequest(image, graphPath2, caption, num))
		{
			Delegate obj = PluginUtil.CheckOutHandler(num);
		}
	}

	public void UploadPhotoRequest(string file, string graphPath, string caption, RequestCompleteHandler requestCompleteHandler)
	{
		int num = PluginUtil.CheckInHandler(requestCompleteHandler, this);
		if (!_UploadPhotoRequest(file, graphPath, caption, num))
		{
			Delegate obj = PluginUtil.CheckOutHandler(num);
		}
	}

	public string GetAndroidKeyHash()
	{
		return _GetAndroidKeyHash();
	}

	public void Test()
	{
		_Test();
	}

	private void OnFacebookSessionStateChangedWithObject(string state, IDictionary<string, object> error)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected Obj, but got Unknown
		//IL_010f: Expected Obj, but got I
		//IL_03cb: Expected Obj, but got I
		//IL_03e3: Expected Obj, but got I
		//IL_015a: Expected Obj, but got I
		//IL_02b9: Expected Obj, but got I
		//IL_02e4: Expected Obj, but got I
		//IL_0309: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		object obj3 = obj + 8;
		_ = 0;
		StatusChangedHandler statusChangedHandler = FacebookSession.m_statusChangedEvent;
		if (FacebookSession.m_statusChangedEvent == null)
		{
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		string text = default;
		string text2;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag = (nint)0 == 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					text = (string)0;
					if (!flag)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag2 = (nint)0 == 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						text = (string)0;
						if (!flag2)
						{
							object obj4 = default;
							text2 = (string)obj4;
							goto IL_047e;
						}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj5 = default;
		object obj6 = default;
		bool flag3 = obj5 == obj6;
		bool flag4 = !flag3;
		object obj8 = default;
		object obj7 = obj8;
		if (!flag4)
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
						text2 = null;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
						string text3 = (string)obj10;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						bool flag5 = (nint)0 != 1;
						text2 = text3;
						if (!flag5)
						{
							goto IL_0375;
						}
					}
					goto IL_047e;
				}
			}
			goto IL_0375;
		}
		goto IL_03f1;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		bool flag6 = (nint)0 == 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		text = (string)0;
		object obj16 = default;
		obj7 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		text2 = (string)0;
		if (!flag6)
		{
			goto IL_03f1;
		}
		goto IL_04a6;
		IL_047e:
		if (error == null)
		{
			FacebookError facebookError = null;
		}
		else
		{
			FacebookError facebookError2 = default;
			facebookError2._002Ector(error);
			FacebookError facebookError = facebookError2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		return;
		IL_03f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		text2 = text;
		goto IL_04a6;
		IL_04a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
		goto IL_047e;
	}

	private void OnFacebookSessionStateChanged(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_081f: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_0868: Expected Obj, but got I
		//IL_076b: Expected I, but got Obj
		//IL_0161: Expected I, but got Obj
		//IL_07b0: Expected Obj, but got I
		//IL_0680: Expected Obj, but got I
		//IL_06ab: Expected Obj, but got I
		//IL_06d0: Expected Obj, but got I
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected Obj, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected Obj, but got Unknown
		//IL_074f: Expected Obj, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected Obj, but got Unknown
		//IL_0567: Expected Obj, but got I
		//IL_03c1: Expected I, but got Obj
		//IL_0426: Expected I, but got Obj
		//IL_04bd: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
		StatusChangedHandler statusChangedHandler = FacebookSession.m_statusChangedEvent;
		if (FacebookSession.m_statusChangedEvent == null)
		{
			return;
		}
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
		nint num;
		if ((nint)0 != 1)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj3 = default;
				if (obj3 == null)
				{
					FacebookSession facebookSession = null;
					num = unchecked((nint)null);
					goto IL_08af;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
						if (_id != (nint)obj4)
						{
							FacebookSession facebookSession = null;
							num = unchecked((nint)null);
							goto IL_08af;
						}
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						FacebookSession facebookSession6 = default;
						if ((nint)0 != 1)
						{
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
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										bool flag = (nint)0 == 1;
										FacebookSession facebookSession2 = default;
										FacebookSession facebookSession = facebookSession2;
										if (!flag)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											bool flag2 = (nint)0 == 1;
											FacebookSession facebookSession3 = default;
											facebookSession = facebookSession3;
											if (!flag2)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												bool flag3 = (nint)0 == 1;
												FacebookSession facebookSession4 = default;
												facebookSession = facebookSession4;
												if (!flag3)
												{
													_ = 0;
													object obj5 = obj + 12;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @12");
													_ = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
													if ((nint)0 != 1)
													{
														object obj6 = default;
														bool flag4 = obj6 == null;
														facebookSession = null;
														num = (nint)facebookSession4;
														if (flag4)
														{
															goto IL_08af;
														}
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
														_ = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														if ((nint)0 != 1)
														{
															object obj7 = default;
															bool flag5 = obj7 == null;
															facebookSession = null;
															num = (nint)facebookSession4;
															if (flag5)
															{
																goto IL_08af;
															}
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
															_ = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
															FacebookSession facebookSession5 = default;
															if ((nint)0 != 1)
															{
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
																_ = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
																bool flag6 = (nint)0 != 1;
																facebookSession = facebookSession5;
																num = (nint)facebookSession4;
																if (flag6)
																{
																	goto IL_08af;
																}
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															facebookSession = facebookSession5;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
															facebookSession = null;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
														facebookSession = (FacebookSession)0;
													}
													goto IL_0580;
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										FacebookSession facebookSession = facebookSession6;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									FacebookSession facebookSession = facebookSession6;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
								FacebookSession facebookSession = facebookSession6;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
							FacebookSession facebookSession = facebookSession6;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						FacebookSession facebookSession = (FacebookSession)0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0580;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0580;
		IL_08be:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
		goto IL_08af;
		IL_0580:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj8 = default;
		object obj9 = default;
		bool flag7 = obj8 != obj9;
		IntPtr intPtr = default;
		num = intPtr;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			FacebookSession facebookSession;
			if ((nint)0 != 1)
			{
				object obj11 = default;
				object obj10 = obj11;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj12 = default;
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj13 = (nint)0 << 2;
						object obj14 = obj + obj13;
						obj14 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj15 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj16 = (nint)0 << 2;
						object obj17 = obj16 + obj;
						object obj18 = obj17 - 4;
						object obj19 = obj18;
						object obj20 = obj19;
						object obj21 = obj19 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v409 @ S1_v47+E4] (should have been resolved before IL gen)");
						string text2 = default;
						string text = "FacebookSession.OnFacebookSessionStateChanged: Invalid json: " + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj22 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					nint num2 = (nint)obj11;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					bool flag8 = (nint)0 != 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					facebookSession = (FacebookSession)0;
					num = num2;
					if (flag8)
					{
						goto IL_08be;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			facebookSession = (FacebookSession)0;
			IntPtr intPtr2 = default;
			num = intPtr2;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				facebookSession = (FacebookSession)0;
				num = intPtr2;
			}
		}
		goto IL_08be;
		IL_08af:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
	}

	private void OnFacebookSessionDialogComplete(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ed: Expected I4, but got Obj
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_033d: Expected Obj, but got I
		//IL_0368: Expected Obj, but got I
		//IL_038d: Expected Obj, but got I
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected Obj, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_041e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
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
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
						Delegate obj3 = PluginUtil.CheckOutHandler((int)obj4);
						bool flag = (object)obj3 == null;
						Delegate obj5 = null;
						if (!flag)
						{
							bool flag2 = (object)obj3.GetType() == typeof(DialogCompleteHandler);
							obj5 = obj3;
							if (!flag2)
							{
								obj5 = null;
							}
						}
						if ((object)obj5 == null)
						{
							return;
						}
						object obj6 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
						object obj7 = default;
						bool flag3 = obj7 == null;
						FacebookError facebookError = null;
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
							IDictionary<string, object> dictionary = default;
							bool flag4 = dictionary == null;
							facebookError = null;
							if (!flag4)
							{
								FacebookError facebookError2 = default;
								facebookError2._002Ector(dictionary);
								facebookError = facebookError2;
							}
						}
						object obj8 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
						object obj9 = default;
						bool flag5 = obj9 == null;
						object obj10 = 0;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
							object obj11 = default;
							obj10 = obj11;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v282.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_0235;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_0235;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj12 = default;
		object obj13 = default;
		bool flag6 = obj12 == obj13;
		bool flag7 = !flag6;
		object obj15 = default;
		object obj14 = obj15;
		if (!flag7)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj17 = default;
				object obj16 = obj17;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj19 = (nint)0 << 2;
						object obj20 = obj + obj19;
						obj20 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj21 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj22 = (nint)0 << 2;
						object obj23 = obj22 + obj;
						object obj24 = obj23 - 4;
						object obj25 = obj24;
						bool flag8 = obj24 == null;
						string text = "FacebookSession.OnFacebookSessionDialogComplete: Invalid json: ";
						string text2 = null;
						if (!flag8)
						{
							object obj26 = obj25;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v408 @ S1_v52+D4] (should have been resolved before IL gen)");
							text = "FacebookSession.OnFacebookSessionDialogComplete: Invalid json: ";
							string text3 = default;
							text2 = text3;
						}
						string text4 = text + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj27 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj28 = obj17;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag9 = (nint)0 == 1;
			object obj29 = default;
			obj14 = obj29;
			if (flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void OnFacebookSessionRequestCompleteWithObject(IDictionary<string, object> result, IDictionary<string, object> error, int cookie)
	{
		Delegate obj = PluginUtil.CheckOutHandler(cookie);
		bool flag = (object)obj == null;
		Delegate obj2 = null;
		if (!flag)
		{
			bool flag2 = (object)obj.GetType() == typeof(RequestCompleteHandler);
			obj2 = obj;
			if (!flag2)
			{
				obj2 = null;
			}
		}
		if ((object)obj2 != null)
		{
			bool flag3 = error == null;
			FacebookError facebookError = null;
			if (!flag3)
			{
				FacebookError facebookError2 = default;
				facebookError2._002Ector(error);
				facebookError = facebookError2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private void OnFacebookSessionRequestComplete(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_00ed: Expected I4, but got Obj
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected Obj, but got Unknown
		//IL_0366: Expected Obj, but got I
		//IL_0391: Expected Obj, but got I
		//IL_03b6: Expected Obj, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected Obj, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_022a: Expected Obj, but got I4
		//IL_0447: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		_ = 0;
		_ = 0;
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
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10");
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
						Delegate obj3 = PluginUtil.CheckOutHandler((int)obj4);
						bool flag = (object)obj3 == null;
						Delegate obj5 = null;
						if (!flag)
						{
							bool flag2 = (object)obj3.GetType() == typeof(RequestCompleteHandler);
							obj5 = obj3;
							if (!flag2)
							{
								obj5 = null;
							}
						}
						if ((object)obj5 == null)
						{
							return;
						}
						object obj6 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
						object obj7 = default;
						bool flag3 = obj7 == null;
						bool flag4 = false;
						if (!flag3)
						{
							throw new NullReferenceException();
						}
						object obj8 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
						object obj9 = default;
						bool flag5 = obj9 == null;
						FacebookError facebookError = null;
						if (!flag5)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
							IDictionary<string, object> dictionary = default;
							bool flag6 = dictionary == null;
							facebookError = null;
							if (!flag6)
							{
								FacebookError facebookError2 = default;
								facebookError2._002Ector(dictionary);
								facebookError = facebookError2;
							}
						}
						object obj10 = obj + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28A");
						object obj11 = default;
						bool flag7 = obj11 == null;
						object obj12 = 0;
						if (!flag7)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @23B");
							object obj13 = default;
							obj12 = obj13;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v284.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						return;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				goto IL_025e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
		goto IL_025e;
		IL_025e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
		object obj14 = default;
		object obj15 = default;
		bool flag8 = obj14 == obj15;
		bool flag9 = !flag8;
		object obj17 = default;
		object obj16 = obj17;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				object obj19 = default;
				object obj18 = obj19;
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					object obj20 = default;
					if (obj20 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj21 = (nint)0 << 2;
						object obj22 = obj + obj21;
						obj22 = obj19;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj23 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj24 = (nint)0 << 2;
						object obj25 = obj24 + obj;
						object obj26 = obj25 - 4;
						object obj27 = obj26;
						bool flag10 = obj26 == null;
						string text = "FacebookSession.OnFacebookSessionGraphRequestComplete: Invalid json: ";
						string text2 = null;
						if (!flag10)
						{
							object obj28 = obj27;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v423 @ S1_v52+D4] (should have been resolved before IL gen)");
							text = "FacebookSession.OnFacebookSessionGraphRequestComplete: Invalid json: ";
							string text3 = default;
							text2 = text3;
						}
						string text4 = text + text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+4]");
						object obj29 = -1;
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F");
					object obj30 = obj19;
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						return;
					}
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			bool flag11 = (nint)0 == 1;
			object obj31 = default;
			obj16 = obj31;
			if (flag11)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
	}

	private void Start()
	{
		if (this != _instance)
		{
			GameObject obj = gameObject;
			UnityEngine.Object.Destroy(obj);
		}
	}

	private static bool _IsSupported()
	{
		return true;
	}

	private bool _Init(string permissions, string defaultAudience)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		if (_facebookSessionJavaObject != null)
		{
			_facebookSessionJavaObject.Dispose();
		}
		object[] args = Array.Empty<object>();
		AndroidJavaObject androidJavaObject = default;
		androidJavaObject._002Ector("com.kiloo.unityplugins.FacebookSession", args);
		_facebookSessionJavaObject = androidJavaObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		_ = _loggingLevel;
		object obj3 = obj + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	private static void _SetLoggingLevel(FacebookLogLevel level)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		_loggingLevel = level;
		if (_instance != null)
		{
			FacebookSession facebookSession = _instance;
			if (facebookSession._facebookSessionJavaObject != null)
			{
				FacebookSession facebookSession2 = _instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
				object obj3 = obj + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
				throw new ArrayTypeMismatchException();
			}
		}
	}

	private bool _OpenForRead()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		bool result = default;
		return result;
	}

	private void _Cancel()
	{
	}

	private void _Close(bool clearToken)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		object obj3 = obj + 15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
		throw new ArrayTypeMismatchException();
	}

	private string _GetState()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private string _GetAccessToken()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private long _GetExpirationDate()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		long result = default;
		return result;
	}

	private string _GetLoginType()
	{
		return "NONE";
	}

	private string _GetPermissions()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	public bool _RequestNewReadPermissions(string permissions)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private bool _RequestNewPublishPermissions(string permissions, string defaultAudience)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private bool _CanShowNativeShareDialog()
	{
		return false;
	}

	private bool _ShowNativeShareDialog(string paramsJSON, int cookie)
	{
		return false;
	}

	private bool _ShowNativeShareDialogWithOpenGraphAction(string paramsJSON, int cookie)
	{
		return false;
	}

	private bool _ShowDialog(string action, string paramsJSON, int cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private bool _GraphRequest(string graphPath, IDictionary<string, object> parameters, string httpMethod, int cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		string text = Json.Serialize(parameters);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private bool _UploadPhotoRequest(Texture2D image, string graphPath, string caption, int cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		byte[] array = ImageConversion.EncodeToPNG(image);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private bool _UploadPhotoRequest(string file, string graphPath, string caption, int cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		throw new ArrayTypeMismatchException();
	}

	private string _GetAndroidKeyHash()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.AndroidJavaObject::Call>>)+4] (should have been resolved before IL gen)");
		string result = default;
		return result;
	}

	private void _Test()
	{
		object[] args = Array.Empty<object>();
		_facebookSessionJavaObject.Call("test", args);
	}

	private bool _OpenForReadSilent(Action<bool> onFinished)
	{
		return false;
	}

	private void EnableInput(bool enable)
	{
		UIScreenController uIScreenController = UIScreenController.Instance;
		if (enable)
		{
			uIScreenController.HideAdsOverlay();
		}
		else
		{
			uIScreenController.ShowAdsOverlay();
		}
	}

	private static void LogError(string msg)
	{
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}
}
