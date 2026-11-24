namespace Kiloo.Common.Utility;

public class ApplicationState : MonoBehaviour
{
	private static ApplicationState _instance; //Field offset: 0x0
	private static bool _isQuitting; //Field offset: 0x4
	private Action _resumed; //Field offset: 0xC
	private Action _paused; //Field offset: 0x10
	private Action _focused; //Field offset: 0x14
	private Action _unfocused; //Field offset: 0x18
	private Action _quit; //Field offset: 0x1C
	private bool _isPaused; //Field offset: 0x20
	private bool _hasFocus; //Field offset: 0x21

	private event Action _focused
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	private event Action _paused
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	private event Action _quit
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	private event Action _resumed
	{
		 add { } //Length: 685
		 remove { } //Length: 111
	}

	private event Action _unfocused
	{
		 add { } //Length: 111
		 remove { } //Length: 111
	}

	public static event Action focused
	{
		 add { } //Length: 174
		 remove { } //Length: 174
	}

	public static event Action paused
	{
		 add { } //Length: 68
		 remove { } //Length: 174
	}

	public static event Action quit
	{
		 add { } //Length: 174
		 remove { } //Length: 174
	}

	public static event Action resumed
	{
		 add { } //Length: 174
		 remove { } //Length: 174
	}

	public static event Action unfocused
	{
		 add { } //Length: 174
		 remove { } //Length: 174
	}

	public static bool hasFocus
	{
		 get { } //Length: 175
	}

	private static ApplicationState instance
	{
		 get { } //Length: 121
	}

	public static bool isPaused
	{
		 get { } //Length: 77
	}

	public static bool isQuitting
	{
		 get { } //Length: 175
	}

	private static ApplicationState() { }

	public ApplicationState() { }

	private void add__focused(Action value) { }

	private void add__paused(Action value) { }

	private void add__quit(Action value) { }

	private void add__resumed(Action value) { }

	private void add__unfocused(Action value) { }

	public static void add_focused(Action value) { }

	public static void add_paused(Action value) { }

	public static void add_quit(Action value) { }

	public static void add_resumed(Action value) { }

	public static void add_unfocused(Action value) { }

	public static bool get_hasFocus() { }

	private static ApplicationState get_instance() { }

	public static bool get_isPaused() { }

	public static bool get_isQuitting() { }

	private static void Log(string msg) { }

	private static void LogWarning(string msg) { }

	private void OnApplicationFocus(bool inFocus) { }

	private void OnApplicationPause(bool paused) { }

	private void OnApplicationQuit() { }

	private void remove__focused(Action value) { }

	private void remove__paused(Action value) { }

	private void remove__quit(Action value) { }

	private void remove__resumed(Action value) { }

	private void remove__unfocused(Action value) { }

	public static void remove_focused(Action value) { }

	public static void remove_paused(Action value) { }

	public static void remove_quit(Action value) { }

	public static void remove_resumed(Action value) { }

	public static void remove_unfocused(Action value) { }

}

