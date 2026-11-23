using System;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using UnityEngine;

namespace Kiloo.Common.Utility;

public class ApplicationState : MonoBehaviour
{
	private static ApplicationState _instance;

	private static bool _isQuitting;

	private Action _resumed;

	private Action _paused;

	private Action _focused;

	private Action _unfocused;

	private Action _quit;

	private bool _isPaused;

	private bool _hasFocus = true;

	private static Action m_paused;

	private static Action m_resumed;

	private static Action m_focused;

	private static Action m_unfocused;

	private static Action m_quit;

	public static bool isPaused
	{
		get
		{
			ApplicationState applicationState = instance;
			if (applicationState != null)
			{
				ApplicationState applicationState2 = instance;
				return applicationState2._isPaused;
			}
			return false;
		}
	}

	public static bool hasFocus
	{
		get
		{
			ApplicationState applicationState = instance;
			if (applicationState != null)
			{
				ApplicationState applicationState2 = instance;
				return applicationState2._hasFocus;
			}
			return false;
		}
	}

	public static bool isQuitting
	{
		get
		{
			ApplicationState applicationState = instance;
			return applicationState == null;
		}
	}

	private static ApplicationState instance
	{
		get
		{
			//IL_0050: Expected VT, but got Obj
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			if (Application.isPlaying)
			{
				if (_instance == null && !_isQuitting)
				{
					Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)typeof(ApplicationState));
					object obj = typeFromHandle - -64;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S1_v11+BC] (should have been resolved before IL gen)");
					GameObject gameObject = default;
					string text = default;
					gameObject._002Ector(text);
					ApplicationState applicationState = gameObject.AddComponent<ApplicationState>();
					_instance = applicationState;
					GameObject target = _instance.gameObject;
					UnityEngine.Object.DontDestroyOnLoad(target);
					GameObject gameObject2 = _instance.gameObject;
					gameObject2.hideFlags = HideFlags.DontSave;
					Transform childTransform = _instance.transform;
					HierarchyUtility.ReparentByHierarchyPathType(childTransform, HierarchyPathType.DynamicManagers);
				}
				return _instance;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Exception ex = default;
			ex._002Ector("Can only be used in play mode");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
			return (ApplicationState)(object)ex;
		}
	}

	public static event Action paused
	{
		add
		{
			Delegate obj = ApplicationState.m_paused;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_paused;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_paused;
				}
				ApplicationState.m_paused = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_paused;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = ApplicationState.m_paused;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_paused;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_paused;
				}
				ApplicationState.m_paused = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_paused;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action resumed
	{
		add
		{
			Delegate obj = ApplicationState.m_resumed;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_resumed;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_resumed;
				}
				ApplicationState.m_resumed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_resumed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = ApplicationState.m_resumed;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_resumed;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_resumed;
				}
				ApplicationState.m_resumed = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_resumed;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action focused
	{
		add
		{
			Delegate obj = ApplicationState.m_focused;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_focused;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_focused;
				}
				ApplicationState.m_focused = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_focused;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = ApplicationState.m_focused;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_focused;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_focused;
				}
				ApplicationState.m_focused = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_focused;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action unfocused
	{
		add
		{
			Delegate obj = ApplicationState.m_unfocused;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_unfocused;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_unfocused;
				}
				ApplicationState.m_unfocused = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_unfocused;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = ApplicationState.m_unfocused;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_unfocused;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_unfocused;
				}
				ApplicationState.m_unfocused = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_unfocused;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	public static event Action quit
	{
		add
		{
			Delegate obj = ApplicationState.m_quit;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Combine(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_quit;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_quit;
				}
				ApplicationState.m_quit = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_quit;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
		remove
		{
			Delegate obj = ApplicationState.m_quit;
			Action action2 = default;
			bool flag2;
			do
			{
				Delegate obj2 = Delegate.Remove(obj, value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @241");
				bool flag = (object)obj == ApplicationState.m_quit;
				Action action = action2;
				if (!flag)
				{
					action = ApplicationState.m_quit;
				}
				ApplicationState.m_quit = action;
				Delegate obj3 = obj;
				if (!flag)
				{
					obj3 = ApplicationState.m_quit;
				}
				flag2 = (object)obj != obj3;
				obj = obj3;
			}
			while (flag2);
		}
	}

	private void OnApplicationPause(bool paused)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		object obj = 16;
		if (!_isPaused)
		{
			obj = 12;
		}
		object obj2 = (object)this + obj;
		object obj3 = obj2;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v9 @ S0_v3+C] (should have been resolved before IL gen)");
		}
	}

	private void OnApplicationFocus(bool inFocus)
	{
		//IL_0013: Expected Obj, but got I4
		//IL_002a: Expected Obj, but got I4
		_hasFocus = inFocus;
		object obj = 20;
		if (!inFocus)
		{
			obj = 24;
		}
		object obj2 = (object)this + obj;
		object obj3 = obj2;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v11 @ S0_v4+C] (should have been resolved before IL gen)");
		}
	}

	private void OnApplicationQuit()
	{
		_isQuitting = true;
		Action action = _quit;
		if (_quit != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v16.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	private static void LogWarning(string msg)
	{
	}

	private static void Log(string msg)
	{
	}
}
