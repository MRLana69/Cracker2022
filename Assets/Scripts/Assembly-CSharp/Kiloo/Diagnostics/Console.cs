using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo.Diagnostics;

public class Console : MonoBehaviour
{
	private struct Log
	{
		public string message;

		public string stackTrace;

		public LogType type;
	}

	public KeyCode toggleKey;

	private List<Log> logs;

	private Vector2 scrollPosition;

	public bool show;

	private bool collapse;

	private static readonly Dictionary<LogType, Color> logTypeColors;

	private const int margin = 20;

	private Rect windowRect;

	private Rect titleBarRect;

	private GUIContent hideLabel;

	private GUIContent clearLabel;

	private GUIContent collapseLabel;

	private unsafe void OnEnable()
	{
		Application.LogCallback logCallback = default;
		logCallback._002Ector(this, (nint)__ldftn(Console.HandleLog));
		Application.logMessageReceived += logCallback;
	}

	private unsafe void OnDisable()
	{
		Application.LogCallback logCallback = default;
		logCallback._002Ector(this, (nint)__ldftn(Console.HandleLog));
		Application.logMessageReceived -= logCallback;
	}

	private void Update()
	{
	}

	private unsafe void OnGUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_005a: Expected F4, but got I
		//IL_0055: Expected native int or pointer, but got VT
		//IL_006f: Expected F4, but got I
		//IL_006a: Expected native int or pointer, but got VT
		//IL_00cc: Expected VT, but got I
		object obj = default;
		Rect rect = (Rect)(obj + -64);
		if (~(show ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Diagnostics.Console)+28]");
			_ = 0;
			_ = windowRect;
			GUI.WindowFunction windowFunction = default;
			windowFunction._002Ector(this, (nint)__ldftn(Console.ConsoleWindow));
			GUILayoutOption[] options = Array.Empty<GUILayoutOption>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
			((Rect*)(nint)rect)->m_Width = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
			((Rect*)(nint)rect)->m_XMin = 0f;
			Rect rect2 = GUILayout.Window(123456, rect, windowFunction, "Console", options);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+20]");
			windowRect = (Rect)0;
		}
	}

	public unsafe void ConsoleWindow(int windowID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0048: Expected F4, but got I
		//IL_0043: Expected native int or pointer, but got VT
		//IL_005d: Expected F4, but got I
		//IL_0058: Expected native int or pointer, but got VT
		object obj = default;
		Rect rect = (Rect)(obj - 32);
		ConsoleView(showHideButton: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Diagnostics.Console)+38]");
		_ = 0;
		_ = titleBarRect;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+18]");
		((Rect*)(nint)rect)->m_Width = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Rect)+10]");
		((Rect*)(nint)rect)->m_XMin = 0f;
		GUI.DragWindow(rect);
	}

	public unsafe void ConsoleView(bool showHideButton)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected VT, but got Unknown
		//IL_0303: Expected VT, but got I
		//IL_030c: Expected Obj, but got I4
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected VT, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected Obj, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected Obj, but got Unknown
		//IL_010d: Expected F4, but got I
		//IL_0108: Expected native int or pointer, but got VT
		//IL_0122: Expected F4, but got I
		//IL_011d: Expected native int or pointer, but got VT
		//IL_014e: Expected Obj, but got I
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00a4: Expected Obj, but got I
		//IL_00a4: Expected Obj, but got I
		object obj = default;
		Color color = (Color)(obj - 96);
		GUILayoutOption[] options = Array.Empty<GUILayoutOption>();
		_ = scrollPosition;
		_ = scrollPosition;
		Vector2 vector = (Vector2)(color + 32);
		Vector2 vector2 = GUILayout.BeginScrollView(vector, options);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
		scrollPosition = (Vector2)0;
		object obj2 = 0;
		while (true)
		{
			List<Log> list = logs;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v12 (System.Collections.Generic.List`1<Kiloo.Diagnostics.Console+Log>)+C]");
			if ((nint)obj3 >= 0)
			{
				break;
			}
			object obj4 = color + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF");
			if ((nint)obj2 >= 1 && ~(collapse ? 1u : 0u) == 0)
			{
				object obj5 = color + 72;
				object obj6 = obj2 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
				if ((string)num == (string)0)
				{
					goto IL_0153;
				}
			}
			object obj7 = color + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5CBF");
			object obj8 = color - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+38]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+50]");
			((Color*)(nint)color)->b = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
			((Color*)(nint)color)->r = 0f;
			GUI.contentColor = color;
			GUILayoutOption[] options2 = Array.Empty<GUILayoutOption>();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+48]");
			GUILayout.Label((string)0, options2);
			goto IL_0153;
			IL_0153:
			object obj9 = obj2 + 1;
			obj2 = obj9;
		}
		GUILayout.EndScrollView();
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color contentColor = color + 16;
		GUI.contentColor = contentColor;
		GUILayoutOption[] options3 = Array.Empty<GUILayoutOption>();
		GUILayout.BeginHorizontal(options3);
		GUILayoutOption[] options4 = Array.Empty<GUILayoutOption>();
		if (GUILayout.Button(clearLabel, options4))
		{
			((List<T>)(object)logs).Clear();
		}
		if (showHideButton)
		{
			GUILayoutOption[] options5 = Array.Empty<GUILayoutOption>();
			if (GUILayout.Button(hideLabel, options5))
			{
				show = false;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		GUILayoutOption gUILayoutOption = GUILayout.ExpandWidth(expand: false);
		throw new ArrayTypeMismatchException();
	}

	private unsafe void HandleLog(string message, string stackTrace, LogType type)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		//IL_004e: Expected native int or pointer, but got VT
		//IL_0068: Expected Obj, but got I
		//IL_0063: Expected native int or pointer, but got VT
		object obj = default;
		Log log = (Log)(obj - 32);
		_ = 0;
		_ = 0;
		object obj2 = log + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22E");
		((Log*)(nint)log)->type = type;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (Kiloo.Diagnostics.Console+Log)+10]");
		System.Runtime.CompilerServices.Unsafe.Write(&((Log*)(nint)log)->message, (string)0);
		logs.Add(log);
	}

	public Console()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0036: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0079: Expected VT, but got I
		//IL_0088: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got F4
		//IL_00ba: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		toggleKey = KeyCode.BackQuote;
		List<Log> list = default;
		list._002Ector();
		logs = list;
		int width = Screen.width;
		int height = Screen.height;
		_ = 0;
		_ = 0;
		object obj3 = height - 40;
		object obj4 = width - 40;
		_ = 20f;
		_ = 20f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
		windowRect = (Rect)0;
		_ = 0;
		obj = 0;
		_ = 20f;
		_ = 10000f;
		_ = 0f;
		obj = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		titleBarRect = (Rect)obj;
		GUIContent gUIContent = default;
		gUIContent._002Ector("Hide", "Hide the console window");
		hideLabel = gUIContent;
		GUIContent gUIContent2 = default;
		gUIContent2._002Ector("Clear", "Clear the contents of the console.");
		clearLabel = gUIContent2;
		GUIContent gUIContent3 = default;
		gUIContent3._002Ector("Collapse", "Hide repeated messages.");
		collapseLabel = gUIContent3;
		base._002Ector();
	}

	unsafe static Console()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected VT, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected VT, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected VT, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected VT, but got Unknown
		//IL_00b3: Expected native int or pointer, but got VT
		//IL_00cb: Expected native int or pointer, but got VT
		object obj = default;
		Color color = (Color)(obj - 160);
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v31 @ S4_v4 (Il2CppClass<Il2CppRgctx<System.Collections.Generic.Dictionary`2<UnityEngine.LogType, UnityEngine.Color>>>)+4] (should have been resolved before IL gen)");
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color value = color - -64;
		Dictionary<LogType, Color> dictionary = default;
		dictionary.Add(LogType.Assert, value);
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 1065353216;
		_ = 1065353216;
		Color value2 = color + 48;
		dictionary.Add(LogType.Error, value2);
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		_ = 1065353216;
		_ = 1065353216;
		Color value3 = color + 32;
		dictionary.Add(LogType.Exception, value3);
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		_ = 4575657222473777152L;
		Color value4 = color + 16;
		dictionary.Add(LogType.Log, value4);
		_ = 4575657222423478401L;
		((Color*)(nint)color)->b = 4f / 255f;
		_ = 4570005646807662592L;
		((Color*)(nint)color)->r = 1f;
		dictionary.Add(LogType.Warning, color);
		logTypeColors = dictionary;
	}
}
