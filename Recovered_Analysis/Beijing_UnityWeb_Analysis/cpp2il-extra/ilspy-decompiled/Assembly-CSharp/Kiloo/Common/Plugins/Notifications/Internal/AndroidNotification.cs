using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kiloo.Serialization;

namespace Kiloo.Common.Plugins.Notifications.Internal;

internal class AndroidNotification : INotification
{
	private object _payload;

	public IDictionary<string, object> payload
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A44");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				InvalidProgramException ex = default;
				ex._002Ector();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A44");
			IDictionary<string, object> result = default;
			return result;
		}
	}

	// C# has no syntax for parameterized property 'Item'.
	public object get_Item(string key)
	{
		//IL_0010: Expected Obj, but got I4
		return ((RegisterForRemoteNotificationsCompletedHandler)this).BeginInvoke(key, (AsyncCallback)null, (object)1);
	}

	public string alert
	{
		get
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
			string text = default;
			bool flag = text == null;
			bool flag2 = !flag;
			string result = text;
			if (!flag2)
			{
				object obj = _payload;
				if (_payload != null)
				{
					if ((object)obj.GetType() != typeof(string))
					{
						obj = null;
					}
				}
				else
				{
					obj = null;
				}
				bool flag3 = obj == null;
				result = text;
				if (!flag3)
				{
					object obj2 = this + 8;
					string text2 = KilooJson.Serialize(obj);
					obj2 = text2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
					string text3 = default;
					result = text3;
				}
			}
			return result;
		}
	}

	public int badge
	{
		get
		{
			//IL_006b: Expected I4, but got Obj
			//IL_003f: Expected I4, but got Obj
			INotification notification = ((DummyNotifications)this).get_Item((int)"alert");
			if (notification != null)
			{
				if ((object)notification.GetType() == typeof(string))
				{
					return (int)notification;
				}
				return 0;
			}
			return 0;
		}
	}

	public string sound
	{
		get
		{
			//IL_0078: Expected I4, but got Obj
			INotification notification = ((DummyNotifications)this).get_Item((int)"badge");
			if (notification != null)
			{
				if ((object)notification.GetType() != typeof(long))
				{
					notification = null;
				}
			}
			else
			{
				notification = null;
			}
			if (notification != null)
			{
				throw new NullReferenceException();
			}
			return null;
		}
	}

	public AndroidNotification(string payload)
	{
		throw new InvalidOperationException();
	}
}
