namespace UnityEngine;

public class TouchScreenKeyboard
{
	public enum Status
	{
		Visible = 0,
		Done = 1,
		Canceled = 2,
		LostFocus = 3,
	}

	internal nint m_Ptr; //Field offset: 0x8
	private readonly bool <canGetSelection>k__BackingField; //Field offset: 0xC
	private readonly bool <canSetSelection>k__BackingField; //Field offset: 0xD
	private readonly TouchScreenKeyboardType <type>k__BackingField; //Field offset: 0x10

	public bool active
	{
		 get { } //Length: 49
		 set { } //Length: 53
	}

	public bool canGetSelection
	{
		 get { } //Length: 49
	}

	public bool canSetSelection
	{
		 get { } //Length: 9
	}

	public int characterLimit
	{
		 set { } //Length: 53
	}

	public static bool hideInput
	{
		 set { } //Length: 228
	}

	public static bool isInPlaceEditingAllowed
	{
		 get { } //Length: 70
	}

	public static bool isSupported
	{
		 get { } //Length: 47
	}

	public RangeInt selection
	{
		 get { } //Length: 53
		 set { } //Length: 46
	}

	public Status status
	{
		 get { } //Length: 49
	}

	public string text
	{
		 get { } //Length: 49
		 set { } //Length: 11
	}

	public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	private void Destroy() { }

	protected override void Finalize() { }

	public bool get_active() { }

	public bool get_canGetSelection() { }

	public bool get_canSetSelection() { }

	public static bool get_isInPlaceEditingAllowed() { }

	public static bool get_isSupported() { }

	public RangeInt get_selection() { }

	public Status get_status() { }

	public string get_text() { }

	private static void GetSelection(out int start, out int length) { }

	private static void Internal_Destroy(nint ptr) { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure) { }

	public void set_active(bool value) { }

	public void set_characterLimit(int value) { }

	public static void set_hideInput(bool value) { }

	public void set_selection(RangeInt value) { }

	public void set_text(string value) { }

	private static void SetSelection(int start, int length) { }

	private static nint TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

}

