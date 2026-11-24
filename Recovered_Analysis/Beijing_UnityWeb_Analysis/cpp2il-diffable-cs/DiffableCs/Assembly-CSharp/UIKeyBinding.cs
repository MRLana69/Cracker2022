//Type is in global namespace

public class UIKeyBinding : MonoBehaviour
{
	public enum Action
	{
		PressAndClick = 0,
		Select = 1,
		All = 2,
	}

	public enum Modifier
	{
		Any = 0,
		Shift = 1,
		Control = 2,
		Alt = 3,
		None = 4,
	}

	private static List<UIKeyBinding> mList; //Field offset: 0x0
	public KeyCode keyCode; //Field offset: 0xC
	public Modifier modifier; //Field offset: 0x10
	public Action action; //Field offset: 0x14
	private bool mIgnoreUp; //Field offset: 0x18
	private bool mIsInput; //Field offset: 0x19
	private bool mPress; //Field offset: 0x1A

	public string captionText
	{
		 get { } //Length: 115
	}

	private static UIKeyBinding() { }

	public UIKeyBinding() { }

	public string get_captionText() { }

	public static Modifier GetActiveModifier() { }

	public static bool GetKeyCode(string text, out KeyCode key, out Modifier modifier) { }

	public static string GetString(KeyCode keyCode, Modifier modifier) { }

	public static bool IsBound(KeyCode key) { }

	protected virtual bool IsModifierActive() { }

	public static bool IsModifierActive(Modifier modifier) { }

	protected virtual void OnBindingClick() { }

	protected virtual void OnBindingPress(bool pressed) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	protected virtual void OnSubmit() { }

	protected virtual void Start() { }

	public override string ToString() { }

	protected virtual void Update() { }

}

