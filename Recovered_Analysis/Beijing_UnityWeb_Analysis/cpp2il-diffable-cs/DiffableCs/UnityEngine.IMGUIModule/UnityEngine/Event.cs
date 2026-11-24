namespace UnityEngine;

public sealed class Event
{
	private static Event s_Current; //Field offset: 0x0
	private static Event s_MasterEvent; //Field offset: 0x4
	private static Dictionary<string, int> <>f__switch$map0; //Field offset: 0x8
	internal nint m_Ptr; //Field offset: 0x8

	public bool alt
	{
		 get { } //Length: 15
	}

	public char character
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public int clickCount
	{
		 get { } //Length: 49
	}

	public bool command
	{
		 get { } //Length: 15
	}

	public string commandName
	{
		 get { } //Length: 49
	}

	public bool control
	{
		 get { } //Length: 15
	}

	public static Event current
	{
		 get { } //Length: 628
	}

	public Vector2 delta
	{
		 get { } //Length: 43
	}

	public int displayIndex
	{
		 set { } //Length: 53
	}

	public bool isKey
	{
		 get { } //Length: 15
	}

	public bool isMouse
	{
		 get { } //Length: 15
	}

	public KeyCode keyCode
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public EventModifiers modifiers
	{
		 get { } //Length: 49
		 set { } //Length: 43
	}

	public Vector2 mousePosition
	{
		 get { } //Length: 14
	}

	public EventType rawType
	{
		 get { } //Length: 20
	}

	public bool shift
	{
		 get { } //Length: 49
	}

	public EventType type
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public Event() { }

	public Event(int displayIndex) { }

	public override bool Equals(object obj) { }

	protected override void Finalize() { }

	public bool get_alt() { }

	public char get_character() { }

	public int get_clickCount() { }

	public bool get_command() { }

	public string get_commandName() { }

	public bool get_control() { }

	public static Event get_current() { }

	public Vector2 get_delta() { }

	private void get_delta_Injected(out Vector2 ret) { }

	public bool get_isKey() { }

	public bool get_isMouse() { }

	public KeyCode get_keyCode() { }

	public EventModifiers get_modifiers() { }

	public Vector2 get_mousePosition() { }

	private void get_mousePosition_Injected(out Vector2 ret) { }

	public EventType get_rawType() { }

	public bool get_shift() { }

	public EventType get_type() { }

	public override int GetHashCode() { }

	public EventType GetTypeForControl(int controlID) { }

	private static nint Internal_Create(int displayIndex) { }

	private static void Internal_Destroy(nint ptr) { }

	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	private static void Internal_SetNativeEvent(nint ptr) { }

	private void Internal_Use() { }

	public static Event KeyboardEvent(string key) { }

	public static bool PopEvent(Event outEvent) { }

	public void set_character(char value) { }

	public void set_displayIndex(int value) { }

	public void set_keyCode(KeyCode value) { }

	public void set_modifiers(EventModifiers value) { }

	public void set_type(EventType value) { }

	public override string ToString() { }

	public void Use() { }

}

