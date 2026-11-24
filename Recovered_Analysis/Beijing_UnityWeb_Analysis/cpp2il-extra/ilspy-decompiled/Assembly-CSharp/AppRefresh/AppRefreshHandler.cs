using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Authentication;
using Authentication.Internal;
using Cloud;
using Cpp2ILInjected;
using Kiloo.Common.Extensions;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using Kiloo.Serialization;
using UnityEngine;

namespace AppRefresh;

public static class AppRefreshHandler
{
	private sealed class _003CPerformRefresh_003Ed__15(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public RefreshType restartType;

		public Action callback;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected Obj, but got Unknown
				//IL_0183: Expected Obj, but got I4
				//IL_0197: Expected Obj, but got I4
				//IL_0072: Expected Obj, but got I
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Expected Obj, but got Unknown
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Expected Obj, but got Unknown
				//IL_00c5: Expected Obj, but got I4
				//IL_00c5: Expected Obj, but got I4
				//IL_00da: Expected Obj, but got I4
				//IL_00da: Expected Obj, but got I4
				//IL_0113: Expected Obj, but got I
				//IL_0124: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Expected Obj, but got Unknown
				//IL_0132: Unknown result type (might be due to invalid IL or missing references)
				//IL_0137: Expected Obj, but got Unknown
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						BsonBinaryWriterExtensions.WriteBsonProperty((BinaryWriter)(object)AppRefreshHandler.m_refresh, (string)restartType, (object)2);
						BsonBinaryWriterExtensions.WriteBsonProperty((BinaryWriter)(object)AppRefreshHandler.m_refresh, (string)restartType, (object)1);
						if (AppRefreshHandler.m_hasRefreshed != null)
						{
							nint num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S2_v9 (Il2CppMethodInfo)+18]");
							object obj = 0;
							object obj2 = obj;
							object obj3 = obj2 & 0x3FFF;
							object obj4 = obj3 + 97173;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v125 @ S3_v13 (should have been resolved before IL gen)");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9FA4");
						TransformExtensions.Reset((Transform)(object)callback);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9FA4");
				if (AppRefreshHandler.m_willRefresh != null)
				{
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S2_v3 (Il2CppMethodInfo)+18]");
					object obj5 = 0;
					object obj6 = obj5;
					object obj7 = obj6 & 0x3FFF;
					object obj8 = obj7 + 97173;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S3_v6 (should have been resolved before IL gen)");
				}
				object obj9 = this + 12;
				obj9 = 0;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static bool refreshInProgress__BackingField;

	private static Action<RefreshType> m_willRefresh;

	private static Action<RefreshType> m_refresh;

	private static Action<RefreshType> m_hasRefreshed;

	public static bool refreshInProgress
	{
		get
		{
			//IL_0109: Expected I, but got Obj
			//IL_011f: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00e8: Expected I4, but got Obj
			//IL_00a1: Expected I, but got Obj
			nint num = (nint)typeof(CloudSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Cloud.CloudSave>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(CloudSave);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v27 (Il2CppClass<Cloud.CloudSave>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78FB");
			object obj2 = default;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(Auth);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<Authentication.Auth>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Auth);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v23 (Il2CppClass<Authentication.Auth>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string kilooTag = Auth.kilooTag;
				IEnumerator list = ((Auth)(object)kilooTag).InitNativeAndLoginAsync();
				Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
				return (byte)(int)coroutine != 0;
			}
			return false;
		}
		private set
		{
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Expected Obj, but got Unknown
			//IL_0087: Expected Obj, but got I4
			//IL_00ba: Expected Obj, but got I4
			string dataPath = Application.dataPath;
			object obj = dataPath - 8;
			if ((nint)dataPath != 8)
			{
				if ((nint)obj != 1 && (nint)obj != 2 && (nint)obj == 3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					NativeLogin nativeLogin = default;
					nativeLogin._002Ector();
					object obj2 = (value ? 1 : 0) + 8;
					obj2 = nativeLogin;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				GoogleLogin googleLogin = default;
				googleLogin._002Ector();
				object obj3 = (value ? 1 : 0) + 8;
				obj3 = googleLogin;
			}
		}
	}

	public static event Action<RefreshType> willRefresh
	{
		add
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected I4, but got Unknown
			bool flag = (byte)(value & 1) != 0;
			refreshInProgress__BackingField = flag;
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AppRefreshHandler.m_willRefresh;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AppRefreshHandler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AppRefresh.AppRefreshHandler>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<RefreshType> refresh
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AppRefreshHandler.m_willRefresh;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AppRefreshHandler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AppRefresh.AppRefreshHandler>)+5C]");
				object obj3 = (nint)0 + (nint)4;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AppRefreshHandler.m_refresh;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AppRefreshHandler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AppRefresh.AppRefreshHandler>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static event Action<RefreshType> hasRefreshed
	{
		add
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AppRefreshHandler.m_refresh;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AppRefreshHandler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AppRefresh.AppRefreshHandler>)+5C]");
				object obj3 = (nint)0 + (nint)8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_0081: Expected I, but got Obj
			//IL_0097: Expected Obj, but got I
			Delegate obj = AppRefreshHandler.m_hasRefreshed;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num = (nint)typeof(AppRefreshHandler);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<AppRefresh.AppRefreshHandler>)+5C]");
				object obj3 = (nint)0 + (nint)12;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public static bool HasFlag(RefreshType obj, RefreshType flag)
	{
		//IL_0047: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I
		//IL_0067: Expected Obj, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_002c: Expected I4, but got Obj
		//IL_0012: Expected Obj, but got I4
		//IL_0012: Expected Obj, but got I4
		//IL_001e: Expected I4, but got Obj
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			string text = ((Dictionary<string, string>)obj).get_Item((string)flag);
			return (byte)(int)text != 0;
		}
		return (byte)(int)"0" != 0;
	}

	public static void StartRefresh(RefreshType restartType, Action callback = null)
	{
		string msg = string.ConcatArray((string[])(object)"[NativeLogin] ", (int)restartType);
		SDebug.LogFormat(msg, (object[])(object)callback);
	}

	private static IEnumerator PerformRefresh(RefreshType restartType, Action callback = null)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected Obj, but got Unknown
		//IL_0020: Expected Obj, but got I4
		object obj = callback & restartType;
		bool flag = obj == callback;
		return (IEnumerator)flag;
	}

	private static void InvokeIfFlagged(Action<RefreshType> action, RefreshType requestedType, RefreshType flag)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		GameCenterPlugin.GenerateIdentityVerificationSignatureCompletionHandler completionHandler = (GameCenterPlugin.GenerateIdentityVerificationSignatureCompletionHandler)(action + 8);
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v4 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v9 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin.GenerateIdentityVerificationSignature(completionHandler);
	}
}
