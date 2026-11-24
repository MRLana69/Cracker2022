using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Kiloo.Common.HTTP.Internal;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
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

	private static readonly IJsonSerializer _jsonConverter;

	private static FacebookSession _instance;

	private int _id;

	private static StatusChangedHandler m_statusChangedEvent;

	private static string appId__BackingField;

	public static string appId
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00b1: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int nextTicket = PluginUtil._nextTicket + 1;
			PluginUtil._nextTicket = nextTicket;
			return (string)PluginUtil._nextTicket;
		}
		set
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FacebookSession.m_statusChangedEvent;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)(object)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FacebookSession);
				if (!flag)
				{
					nint num5 = (nint)typeof(FacebookSession);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FacebookSession);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FacebookSession);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static bool isSupported
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0099: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)appId__BackingField != 0;
		}
	}

	public static bool dialogsSupported
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return false;
		}
	}

	public static FacebookSession instance => null;

	public static event StatusChangedHandler statusChangedEvent
	{
		add
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Exception);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Exception.ReportUnhandledException((Exception)(object)value);
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = FacebookSession.m_statusChangedEvent;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(FacebookSession);
				if (!flag)
				{
					nint num5 = (nint)typeof(FacebookSession);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(FacebookSession);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(FacebookSession);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public static FacebookSession Create(string permissions, FacebookDefaultAudience defaultAudience)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0360: Expected Obj, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Expected Obj, but got Unknown
		//IL_0377: Expected Obj, but got I4
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_03b9: Expected Obj, but got I4
		//IL_00af: Expected I, but got Obj
		//IL_00c5: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected Obj, but got Unknown
		//IL_00f0: Expected I, but got Obj
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected Obj, but got Unknown
		//IL_0201: Expected Obj, but got I4
		//IL_02a6: Expected Obj, but got I
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		object obj4 = obj2 + 32;
		obj4 = 0;
		object obj5 = obj2 + 8;
		obj5 = 0;
		object obj6 = obj2 + 16;
		obj6 = obj;
		_ = -1;
		if (permissions != null)
		{
			nint num = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v25 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num2 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S0_v120 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			nint num3 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v73 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num4 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v113 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj5 = defaultAudience;
			object obj9 = obj5 + 4;
			obj9 = permissions;
			obj2 = obj5;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			object obj10 = obj6 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj6 + obj12;
			obj13 = 78;
			if (obj4 != null)
			{
				throw new ArgumentNullException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v18+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = obj6 + obj14;
				if ((nint)obj15 == 78)
				{
					object obj16 = obj6 + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					goto IL_0447;
				}
			}
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0447;
		IL_0447:
		FacebookSession result = default;
		return result;
	}

	public static void SetLoggingLevel(FacebookLogLevel level)
	{
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_00d3: Expected Obj, but got I
		//IL_00db: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(FacebookSession);
		if (!flag)
		{
			nint num3 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(FacebookSession);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(FacebookSession);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = level;
	}

	public void OpenForRead()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void Cancel()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void Close(bool clearToken)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Exception);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.Exception>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Exception);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<System.Exception>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Exception)(object)this).SetErrorCode(clearToken ? 1 : 0);
	}

	public State GetState()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected Obj, but got Unknown
		//IL_080e: Expected Obj, but got I4
		//IL_0817: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected Obj, but got Unknown
		//IL_0825: Expected Obj, but got I4
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected Obj, but got Unknown
		//IL_084e: Expected Obj, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected Obj, but got Unknown
		//IL_086b: Expected Obj, but got I4
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected Obj, but got Unknown
		//IL_089b: Expected I, but got Obj
		//IL_08b1: Expected Obj, but got I
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected Obj, but got Unknown
		//IL_0a2a: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_074d: Expected Obj, but got I
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected Obj, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 112;
		object obj3 = obj2 + 104;
		obj3 = 0;
		object obj4 = obj2 + 76;
		obj4 = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		object obj5 = obj2 - -64;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 48;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 40;
		obj7 = obj;
		_ = -1;
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v28 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v353 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj9 = obj2 + 8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj11 = default;
		object obj10 = obj11;
		object obj13 = default;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj14 = default;
		object obj15 = default;
		if (obj12 == obj14)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			object obj16 = default;
			obj15 = obj16;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v25+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj7 + obj17;
			if ((nint)obj18 == 174)
			{
				object obj19 = obj7 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_0a9d;
			}
		}
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0a9d;
		IL_0a9d:
		State result = default;
		return result;
	}

	public unsafe static bool IsOpened(State state)
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected I, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(State);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type enumType = Type.internal_from_handle((IntPtr)num3);
		string value = ((FacebookSession)null)._GetAccessToken();
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v3 (Il2CppClass<System.Enum>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v8 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Enum.GetName(enumType, value);
		throw new NullReferenceException();
	}

	public static bool IsClosed(State state)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = state + -3;
		return (nint)obj < 2;
	}

	public static bool HasOpenInstance()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0099: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (byte)(int)_instance != 0;
	}

	public string GetAccessToken()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_001f: Expected Obj, but got I4
		object obj = this + -5;
		bool flag = (nint)obj < 2;
		return (string)flag;
	}

	public DateTime? GetExpirationDateUTC()
	{
		DateTime? result = default;
		return result;
	}

	public string GetPermissions()
	{
		return ((FacebookSession)null)._GetLoginType();
	}

	public FacebookLoginType GetLoginType()
	{
		return ((FacebookSession)null)._CanShowNativeShareDialog() ? FacebookLoginType.SYSTEM_ACCOUNT : FacebookLoginType.NONE;
	}

	public void RequestNewReadPermissions(string permissions)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		FacebookSession facebookSession = (FacebookSession)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
	}

	public void RequestNewPublishPermissions(string permissions, FacebookDefaultAudience defaultAudience)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public unsafe bool CanShowNativeShareDialog()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected I, but got Unknown
		//IL_0125: Expected I, but got Obj
		//IL_014a: Expected I, but got Obj
		//IL_0160: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(Type);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11 (Il2CppClass<System.Type>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Type);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v23 (Il2CppClass<System.Type>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object typeFromHandle = typeof(FacebookLoginType);
		nint num3 = (nint)(typeFromHandle + 4);
		((IntPtr*)num3)->m_value = (void*)(nint)typeFromHandle;
		Type enumType = Type.internal_from_handle((IntPtr)num3);
		string value = ((FacebookSession)null)._GetPermissions();
		nint num4 = (nint)typeof(Enum);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S2_v3 (Il2CppClass<System.Enum>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num5 = (nint)typeof(Enum);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S2_v8 (Il2CppClass<System.Enum>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Enum.GetName(enumType, value);
		throw new NullReferenceException();
	}

	public void ShowNativeShareDialog(IDictionary<string, object> parameters, DialogCompleteHandler dialogCompleteHandler)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void ShowDialog(string action, IDictionary<string, object> parameters, DialogCompleteHandler dialogCompleteHandler)
	{
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected Obj, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_018b: Expected Obj, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected Obj, but got Unknown
		//IL_01b2: Expected I, but got Obj
		//IL_01c8: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_037b: Expected I, but got Obj
		//IL_0391: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_01f3: Expected I, but got Obj
		//IL_0240: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = dialogCompleteHandler;
		object obj3 = obj2 + 12;
		obj3 = this;
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v21 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v72 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v12 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)GameCenterPlugin._instance).FindKernel((string)null) == 0)
			{
				nint num5 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S0_v62 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v68 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin.LogWarning("LoadLeaderboardForIDs was called before Init");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			Stream stream = default;
			((MarshalByRefObject)stream)._identity = num7;
			_ = 0;
			object obj7 = stream + 16;
			obj7 = obj2;
			nint num8 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v37 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num9 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v55 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num10 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v45 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num11 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v51 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num12 = FileUtil.CopyTo(stream, (Stream)(object)GameCenterPlugin._instance);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
			}
		}
	}

	public void GraphRequest(string graphPath, IDictionary<string, object> parameters, HttpMethod httpMethod, RequestCompleteHandler requestCompleteHandler)
	{
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected Obj, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_035a: Expected I, but got Obj
		//IL_0370: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_01b6: Expected Obj, but got I
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected Obj, but got Unknown
		//IL_01dd: Expected I, but got Obj
		//IL_01f3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_03ab: Expected I, but got Obj
		//IL_03c1: Expected Obj, but got I
		//IL_021e: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_026b: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 16;
		obj = requestCompleteHandler;
		object obj3 = obj2 + 20;
		obj3 = this;
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v22 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v77 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num3 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v34 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)GameCenterPlugin._instance).FindKernel((string)null) == 0)
			{
				nint num5 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v67 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num6 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v73 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				GameCenterPlugin.LogWarning("LoadPhoto was called before Init");
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj8 = default;
			object obj7 = obj8 + 12;
			obj7 = obj2;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			Stream stream = default;
			((MarshalByRefObject)stream)._identity = num7;
			_ = 0;
			object obj9 = stream + 16;
			obj9 = obj8;
			nint num8 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v43 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num9 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v60 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num10 = (nint)typeof(Depository);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v51 (Il2CppClass<Kiloo.Common.Utility.Depository>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num11 = (nint)typeof(Depository);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v56 (Il2CppClass<Kiloo.Common.Utility.Depository>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num12 = FileUtil.CopyTo(stream, (Stream)(object)GameCenterPlugin._instance);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
			}
		}
	}

	public void UploadPhotoRequest(Texture2D image, string graphPath, string caption, RequestCompleteHandler requestCompleteHandler)
	{
		//IL_0151: Expected I, but got Obj
		//IL_0167: Expected Obj, but got I
		//IL_01cf: Expected I4, but got Obj
		//IL_001b: Expected I, but got Obj
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v18 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookSession facebookSession = Create((string)(object)requestCompleteHandler, (FacebookDefaultAudience)this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		throw new NullReferenceException();
	}

	public void UploadPhotoRequest(string file, string graphPath, string caption, RequestCompleteHandler requestCompleteHandler)
	{
		//IL_00fa: Expected I, but got Obj
		//IL_0110: Expected Obj, but got I
		//IL_0178: Expected I4, but got Obj
		//IL_018a: Expected I, but got Obj
		//IL_01a0: Expected Obj, but got I
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookSession context = Create((string)(object)requestCompleteHandler, (FacebookDefaultAudience)this);
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v19 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num5 = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S1_v10 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v15 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<int> enumerable = PluginUtil.RemoveHandlers(context);
	}

	public string GetAndroidKeyHash()
	{
		return null;
	}

	public void Test()
	{
	}

	private void OnFacebookSessionStateChangedWithObject(string state, IDictionary<string, object> error)
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0210: Expected I4, but got Obj
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookSession context = Create((string)(object)error, (FacebookDefaultAudience)this);
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v30 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		nint num5 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v12 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v26 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v22 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<int> enumerable = PluginUtil.RemoveHandlers(context);
	}

	private void OnFacebookSessionStateChanged(string json)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v10 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	private void OnFacebookSessionDialogComplete(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0672: Unknown result type (might be due to invalid IL or missing references)
		//IL_0677: Expected Obj, but got Unknown
		//IL_0680: Expected Obj, but got I4
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected Obj, but got Unknown
		//IL_06aa: Expected I, but got Obj
		//IL_06c0: Expected Obj, but got I
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Expected Obj, but got Unknown
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_04df: Expected Obj, but got I4
		//IL_04e8: Expected Obj, but got I4
		//IL_04c8: Expected Obj, but got I4
		//IL_04d1: Expected Obj, but got I4
		//IL_0211: Expected I, but got Obj
		//IL_0227: Expected Obj, but got I
		//IL_02dd: Expected I, but got Obj
		//IL_02f3: Expected Obj, but got I
		//IL_0252: Expected I, but got Obj
		//IL_031e: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 16;
		obj3 = 0;
		object obj4 = obj2 + 8;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v258 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 20;
		if (FacebookSession.m_statusChangedEvent == null)
		{
			return;
		}
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v29 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v247 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj8 = default;
		object obj23;
		if (obj8 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj9 = default;
			if (_id == (nint)obj9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				object obj10 = default;
				obj3 = obj10;
				nint num5 = (nint)typeof(Type);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ S0_v128 (Il2CppClass<System.Type>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num6 = (nint)typeof(Type);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ S0_v228 (Il2CppClass<System.Type>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				obj2 = typeof(State);
				obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num7 = (nint)typeof(Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ S0_v142 (Il2CppClass<System.Enum>)+BA]");
				object obj12 = (nint)0 & (nint)0x200;
				if (obj12 != null)
				{
					nint num8 = (nint)typeof(Enum);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v215 (Il2CppClass<System.Enum>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj14 = default;
				object obj13 = obj14;
				object obj16 = default;
				object obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj17 = default;
				if (obj13 == obj17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
					object obj19 = default;
					object obj18 = obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
					object obj21 = default;
					object obj20 = obj21;
				}
				else
				{
					object obj20 = obj15;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				return;
			}
			object obj22 = 0;
			obj23 = 0;
		}
		else
		{
			object obj22 = 0;
			obj23 = 0;
		}
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
	}

	private void OnFacebookSessionRequestCompleteWithObject(IDictionary<string, object> result, IDictionary<string, object> error, int cookie)
	{
		//IL_0147: Expected I, but got Obj
		//IL_015d: Expected Obj, but got I
		//IL_0210: Expected I4, but got Obj
		//IL_0210: Expected Obj, but got I4
		//IL_0222: Expected I, but got Obj
		//IL_0238: Expected Obj, but got I
		//IL_0192: Expected I, but got Obj
		//IL_01a8: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_01d3: Expected I, but got Obj
		//IL_01e9: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00fa: Expected I, but got Obj
		nint num = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		FacebookSession context = Create((string)cookie, (FacebookDefaultAudience)this);
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v5 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v30 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		nint num5 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v12 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v26 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num7 = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v17 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S1_v22 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<int> enumerable = PluginUtil.RemoveHandlers(context);
	}

	private void OnFacebookSessionRequestComplete(string json)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected Obj, but got Unknown
		//IL_0396: Expected Obj, but got I4
		//IL_03b2: Expected I, but got Obj
		//IL_03c8: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v133 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj9 = default;
		if (obj7 == obj9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj10 = default;
			string text = (string)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
		}
		else
		{
			object obj11 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private void Start()
	{
	}

	private static bool _IsSupported()
	{
		//IL_0149: Expected I, but got Obj
		//IL_015f: Expected Obj, but got I
		//IL_01fd: Expected I, but got Obj
		//IL_0213: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01cc: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v29 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			nint num5 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v16 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
			State state = default;
			bool flag = IsOpened(state);
			object obj4 = (flag ? 1 : 0) + -3;
			return (nint)obj4 < 2;
		}
		return false;
	}

	private bool _Init(string permissions, string defaultAudience)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = permissions;
		object obj3 = defaultAudience & 1;
		return flag;
	}

	private static void _SetLoggingLevel(FacebookLogLevel level)
	{
		//IL_0189: Expected I, but got Obj
		//IL_019f: Expected Obj, but got I
		//IL_0226: Expected I, but got Obj
		//IL_023c: Expected Obj, but got I
		//IL_0267: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I4
		//IL_01d7: Expected I, but got Obj
		//IL_01ed: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v36 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v32 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)level).FindKernel((string)(object)_instance) == 0)
		{
			return;
		}
		nint num5 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v22 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v28 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string obj4 = ((Component)level).tag;
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S1_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj4);
	}

	private bool _OpenForRead()
	{
		//IL_000a: Expected I4, but got Obj
		return (byte)(int)((FacebookError)null).ToString() != 0;
	}

	private void _Cancel()
	{
	}

	private void _Close(bool clearToken)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected Obj, but got Unknown
		//IL_03c1: Expected Obj, but got I4
		//IL_03dd: Expected I, but got Obj
		//IL_03f3: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v142 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj6 = default;
		object obj5 = obj6;
		object obj8 = default;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj9 = default;
		if (obj7 == obj9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj10 = default;
			string text = (string)obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj12 = default;
			object obj11 = obj12;
		}
		else
		{
			object obj11 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private string _GetState()
	{
		return null;
	}

	private string _GetAccessToken()
	{
		return "CREATED";
	}

	private long _GetExpirationDate()
	{
		//IL_000d: Expected I8, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Plugins.Facebook.FacebookSession)+20]");
		return 0L;
	}

	private string _GetLoginType()
	{
		return "";
	}

	private string _GetPermissions()
	{
		return "NONE";
	}

	private bool _RequestNewReadPermissions(string permissions)
	{
		//IL_0582: Expected I, but got Obj
		//IL_0598: Expected Obj, but got I
		//IL_07d8: Expected I, but got Obj
		//IL_07ee: Expected Obj, but got I
		//IL_001b: Expected I, but got Obj
		//IL_05c3: Expected I, but got Obj
		//IL_05d9: Expected Obj, but got I
		//IL_0068: Expected I, but got Obj
		//IL_0819: Expected I, but got Obj
		//IL_082f: Expected Obj, but got I
		//IL_00b5: Expected I, but got Obj
		//IL_00cb: Expected Obj, but got I
		//IL_026b: Expected I, but got Obj
		//IL_0600: Expected I4, but got Obj
		//IL_0612: Expected Obj, but got I4
		//IL_04f4: Expected I, but got Obj
		//IL_050a: Expected Obj, but got I
		//IL_02b8: Expected I, but got Obj
		//IL_00f6: Expected I, but got Obj
		//IL_0305: Expected I, but got Obj
		//IL_031b: Expected Obj, but got I
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_0535: Expected I, but got Obj
		//IL_06db: Expected I4, but got Obj
		//IL_0648: Expected I, but got Obj
		//IL_065e: Expected Obj, but got I
		//IL_0346: Expected I, but got Obj
		//IL_0876: Expected I, but got Obj
		//IL_088c: Expected Obj, but got I
		//IL_0184: Expected I, but got Obj
		//IL_0692: Expected I, but got Obj
		//IL_06a8: Expected Obj, but got I
		//IL_06b1: Expected Obj, but got I4
		//IL_01d1: Expected I, but got Obj
		//IL_021e: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v129 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v79 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)_instance).FindKernel((string)null) != 0)
		{
			nint num5 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v89 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v123 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = IsOpened((State)_instance);
			object obj4 = (flag ? 1 : 0) + -5;
			if ((nint)obj4 < 2)
			{
				nint num7 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v100 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num8 = (nint)typeof(FacebookSession);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v117 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				nint num9 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v57 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(PluginUtil);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v75 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				State state = _instance.GetState();
				string obj7 = _instance.tag;
				nint num11 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v64 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num12 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ S1_v71 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnityEngine.Object.DestroyImmediate((UnityEngine.Object)(object)obj7);
				nint num13 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ S0_v114 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+5C]");
				object obj9 = (nint)0 + (nint)4;
				obj9 = 0;
			}
		}
		nint num14 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v20 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num15 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v82 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num16 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S1_v14 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num17 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v47 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_instance != null)
		{
			nint num18 = (nint)typeof(PluginUtil);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v40 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+BA]");
			object obj12 = (nint)0 & (nint)0x200;
			if (obj12 != null)
			{
				nint num19 = (nint)typeof(PluginUtil);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v78 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FacebookSession facebookSession = PluginUtil.CreateBridgeObject<FacebookSession>();
			string text = appId;
			facebookSession._id = (int)text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			throw new NullReferenceException();
		}
		nint num20 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S0_v30 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num21 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v35 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return false;
	}

	private bool _RequestNewPublishPermissions(string permissions, string defaultAudience)
	{
		return false;
	}

	private bool _CanShowNativeShareDialog()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)"" != 0;
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
		return false;
	}

	private unsafe bool _GraphRequest(string graphPath, IDictionary<string, object> paramsJSON, string httpMethod, int cookie)
	{
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I4
		//IL_01aa: Expected I, but got Obj
		//IL_01c0: Expected Obj, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected VT, but got Unknown
		//IL_006d: Expected F4, but got Obj
		//IL_0068: Expected native int or pointer, but got VT
		//IL_0082: Expected F4, but got I
		//IL_007d: Expected native int or pointer, but got VT
		//IL_008f: Expected F4, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_00c9: Expected Obj, but got I
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected Obj, but got Unknown
		//IL_0111: Expected F4, but got Obj
		//IL_010c: Expected native int or pointer, but got VT
		//IL_0126: Expected F4, but got I
		//IL_0121: Expected native int or pointer, but got VT
		//IL_0140: Expected I4, but got VT
		//IL_0140: Expected I4, but got Obj
		//IL_0140: Expected I4, but got Obj
		//IL_0140: Expected I4, but got Obj
		//IL_0171: Expected I4, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		Route route = ((RouteManager)this).FindAlternateRoute((Predicate<Route>)(object)graphPath);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v42 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 24;
		Vector3 back = Vector3.back;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		RouteBuilder routeBuilder = default;
		int spawnedLeadingEdgeWorldPositionZ = routeBuilder.SpawnedLeadingEdgeWorldPositionZ;
		Vector3 vector = (Vector3)(obj2 + 48);
		((Vector3*)(nint)vector)->x = (float)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19+8]");
		((Vector3*)(nint)vector)->z = 0f;
		Vector3 vector2 = vector / spawnedLeadingEdgeWorldPositionZ;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S2_v4+14]");
		float sectionMinEndGamePosition = ((RouteBuilder)null).GetSectionMinEndGamePosition((RouteSection)0);
		object obj5 = obj2 + 12;
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		((Vector3*)(nint)vector)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S0_v31+8]");
		((Vector3*)(nint)vector)->z = 0f;
		bool ignoreCertificateErrors = default;
		Connection connection = Connection.Open((string)(object)this, (int)route, (byte)(int)paramsJSON != 0, (int)httpMethod, (int)vector, ignoreCertificateErrors);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		return (byte)(int)connection != 0;
	}

	private bool _UploadPhotoRequest(Texture2D image, string graphPath, string caption, int cookie)
	{
		return false;
	}

	private bool _UploadPhotoRequest(string file, string graphPath, string caption, int cookie)
	{
		return false;
	}

	private string _GetAndroidKeyHash()
	{
		return null;
	}

	private void _Test()
	{
	}

	private void EnableInput(bool enable)
	{
	}

	private static void LogError(string msg)
	{
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	static FacebookSession()
	{
		//IL_002f: Expected Obj, but got I
		//IL_003f: Expected Obj, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected Obj, but got Unknown
		//IL_007b: Expected I, but got Obj
		//IL_0091: Expected Obj, but got I
		PluginUtil._nextTicket = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v32 @ S4_v4 (should have been resolved before IL gen)");
		nint num2 = (nint)typeof(PluginUtil);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v12 (Il2CppClass<Kiloo.Plugins.PluginUtil>)+5C]");
		object obj6 = (nint)0 + (nint)4;
		object obj7 = default;
		obj6 = obj7;
	}
}
