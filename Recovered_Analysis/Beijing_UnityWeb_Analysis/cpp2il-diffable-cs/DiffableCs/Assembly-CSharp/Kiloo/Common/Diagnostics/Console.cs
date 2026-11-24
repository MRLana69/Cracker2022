namespace Kiloo.Common.Diagnostics;

public class Console : MonoBehaviour
{
	private struct Log
	{
		public string message; //Field offset: 0x0
		public string stackTrace; //Field offset: 0x4
		public LogType type; //Field offset: 0x8

	}

	private static readonly Dictionary<LogType, Color> logTypeColors; //Field offset: 0x0
	private const int margin = 20; //Field offset: 0x0
	public KeyCode toggleKey; //Field offset: 0xC
	private List<Log> logs; //Field offset: 0x10
	private Vector2 scrollPosition; //Field offset: 0x14
	public bool show; //Field offset: 0x1C
	private bool collapse; //Field offset: 0x1D
	private Rect windowRect; //Field offset: 0x20
	private Rect titleBarRect; //Field offset: 0x30
	private GUIContent hideLabel; //Field offset: 0x40
	private GUIContent clearLabel; //Field offset: 0x44
	private GUIContent collapseLabel; //Field offset: 0x48

	private static Console() { }

	public Console() { }

	public void ConsoleView(bool showHideButton) { }

	public void ConsoleWindow(int windowID) { }

	private void HandleLog(string message, string stackTrace, LogType type) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGUI() { }

	private void Update() { }

}

