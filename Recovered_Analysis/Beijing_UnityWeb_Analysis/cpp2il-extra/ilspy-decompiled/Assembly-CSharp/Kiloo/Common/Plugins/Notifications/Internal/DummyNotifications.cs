using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Common.Plugins.Notifications.Internal;

internal class DummyNotifications : INotifications, IEnumerable<INotification>, IEnumerable
{
	private sealed class _003CGetEnumerator_003Ed__23 : IEnumerator<INotification>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private INotification _003C_003E2__current;

		INotification IEnumerator<INotification>.Current
		{
			get
			{
				if (_003C_003E1__state == 0)
				{
					_003C_003E1__state = -1;
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetEnumerator_003Ed__23(int _003C_003E1__state)
		{
			int num = _003C_003E1__state & 1;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0023: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			_ = 0;
			bool flag = default;
			object obj = (flag ? 1 : 0) + 16;
			obj = this;
			return flag;
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

	private bool _enabledLocalNotificationLogs;

	private Action m_notificationReceived;

	public int count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public INotification get_Item(int index)
	{
		//IL_005c: Expected Obj, but got I4
		object obj = 0;
		string alert = ((AndroidNotification)this).alert;
		INotification result;
		if (alert != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			object obj2 = default;
			bool flag = obj2 == null;
			bool flag2 = !flag;
			result = (INotification)obj;
			if (!flag2)
			{
				result = null;
			}
		}
		else
		{
			result = null;
		}
		return result;
	}

	public string registrationId => null;

	public string oldRegistrationId => "";

	public string errorMessage => "";

	public bool isErrorUserRecoverable
	{
		get
		{
			//IL_000b: Expected I4, but got Obj
			return (byte)(int)"Remote notifications not supported on this platform" != 0;
		}
	}

	public event Action notificationReceived
	{
		add
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = value;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_notificationReceived;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 12;
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

	public void ClearNotifications()
	{
	}

	public void ScheduleLocalNotification(DateTime date, string title, string message, string soundName)
	{
	}

	public void ClearAllLocalNotifications()
	{
	}

	public void EnableLocalNotificationLogs()
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		if (~(_enabledLocalNotificationLogs ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogError("Cancelled all local notifications");
	}

	public Coroutine RegisterForRemoteNotifications(RegisterForRemoteNotificationsCompletedHandler onComplete = null)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InvalidCastException ex = default;
		ex._002Ector();
		((DummyNotifications)(object)ex).get_Item(0);
		return null;
	}

	public Coroutine UnregisterForRemoteNotifications(UnregisterForRemoteNotificationsCompletedHandler onComplete = null)
	{
		if (onComplete != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
		}
		return null;
	}

	public void HandleUserRecoverableError()
	{
		_enabledLocalNotificationLogs = true;
	}

	public IEnumerator<INotification> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	protected virtual void OnNotificationReceived()
	{
	}

	public DummyNotifications()
	{
		if (this.m_notificationReceived != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
