using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend;
using UnityEngine;

namespace Kiloo.Common.Diagnostics;

public class Console : MonoBehaviour
{
	[StructLayout((LayoutKind)0, Size = 12)]
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

	private void OnEnable()
	{
		if ((object)this != null)
		{
			SDebug.LogFormat("Assert failed!", null);
			Console._002Ecctor();
		}
	}

	private unsafe void OnDisable()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Application.LogCallback logCallback = default;
		((Delegate)logCallback).method_ptr = method_ptr;
		((Delegate)logCallback).method = (nint)__ldftn(Console.HandleLog);
		object obj = logCallback + 16;
		obj = this;
		Application.logMessageReceived -= logCallback;
	}

	private void Update()
	{
		//IL_002b: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		Application.InvokeFocusChanged(flag);
	}

	private void OnGUI()
	{
	}

	public void ConsoleWindow(int windowID)
	{
		if ((object)this != null)
		{
			string msg = string.ConcatArray((string[])(object)"Assert failed: ", windowID);
			SDebug.LogFormat(msg, null);
			Console._002Ecctor();
		}
	}

	public unsafe void ConsoleView(bool showHideButton)
	{
		//IL_005d: Expected Obj, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected Obj, but got Unknown
		//IL_008b: Expected I, but got Obj
		//IL_00a1: Expected Obj, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected I4, but got Unknown
		//IL_00d9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		((EventRemoteLogger)(object)this).onPauseOrQuit += (Action)1;
		object obj = this + 48;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v5+8]");
		_ = 0;
		nint num = (nint)typeof(GUI);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v12 (Il2CppClass<UnityEngine.GUI>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(GUI);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v21 (Il2CppClass<UnityEngine.GUI>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = obj2 + 16;
		((int*)num3)->m_value = (int)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		GUI.scrollTroughSide = num3;
	}

	private unsafe void HandleLog(string message, string stackTrace, LogType type)
	{
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected Obj, but got Unknown
		//IL_02a1: Expected Obj, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_02ec: Expected VT, but got Obj
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected Obj, but got Unknown
		//IL_0307: Expected Obj, but got I4
		//IL_0314: Expected Obj, but got I4
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_032b: Expected Obj, but got I4
		//IL_035a: Expected I, but got Obj
		//IL_0370: Expected Obj, but got I
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected VT, but got Unknown
		//IL_03a8: Expected F4, but got Obj
		//IL_03a3: Expected native int or pointer, but got VT
		//IL_03ba: Expected F4, but got I
		//IL_03b5: Expected native int or pointer, but got VT
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected VT, but got Unknown
		//IL_03d5: Expected F4, but got Obj
		//IL_03d0: Expected native int or pointer, but got VT
		//IL_03ea: Expected F4, but got I
		//IL_03e5: Expected native int or pointer, but got VT
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected Obj, but got Unknown
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0446: Expected Obj, but got I4
		//IL_0464: Expected F4, but got Obj
		//IL_045f: Expected native int or pointer, but got VT
		//IL_0479: Expected F4, but got I
		//IL_0474: Expected native int or pointer, but got VT
		//IL_00ed: Expected native int or pointer, but got VT
		//IL_00ff: Expected native int or pointer, but got VT
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected Obj, but got Unknown
		//IL_00a1: Expected I, but got Obj
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_0221: Expected F4, but got Obj
		//IL_021c: Expected native int or pointer, but got VT
		//IL_0236: Expected F4, but got I
		//IL_0231: Expected native int or pointer, but got VT
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected Obj, but got Unknown
		//IL_0262: Expected F4, but got Obj
		//IL_025d: Expected native int or pointer, but got VT
		//IL_0277: Expected F4, but got I
		//IL_0272: Expected native int or pointer, but got VT
		//IL_0280: Expected Obj, but got VT
		object obj2 = default;
		object obj = obj2 + 124;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 112;
		obj3 = 0;
		_ = 0;
		Transform transform = (Transform)(obj2 + 100);
		GameObject gameObject = ((Component)(object)message).gameObject;
		transform.localPosition = (Vector3)gameObject;
		object obj4 = obj2 + 8;
		obj4 = ((LogType*)(int)type)->value__;
		obj2 = ((LogType*)(int)type)->value__;
		object obj5 = obj2 + 88;
		obj5 = 0;
		_ = 0;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		_ = 0;
		_ = 0f;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v30 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v89 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 vector = (Vector3)(obj2 + 136);
		((Vector3*)(nint)vector)->x = (float)transform;
		((Vector3*)(nint)vector)->z = (nint)((UnityEngine.Object)transform).m_CachedPtr;
		Vector3 vector2 = (Vector3)(obj2 + 148);
		((Vector3*)(nint)vector2)->x = (float)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v24+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj7 = obj2 + 76;
		Vector3 vector3 = vector - vector2;
		obj = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v41+8]");
		_ = 0;
		string text = ((Component)(object)message).tag;
		bool activeSelf = ((GameObject)(object)text).activeSelf;
		nint num3 = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v42 (Il2CppClass<NGUITools>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num4 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S1_v94 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string typeName = NGUITools.GetTypeName((UnityEngine.Object)activeSelf);
		GameObject gameObject2 = ((Component)(object)message).gameObject;
		((Vector3*)(nint)vector2)->x = (float)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 vector4 = ((Transform)(object)gameObject2).InverseTransformPoint(vector2);
		((Vector3*)(nint)vector2)->x = vector.x;
		((Vector3*)(nint)vector2)->z = vector.z;
		object obj9 = obj2 - -64;
		Vector3 vector5 = ((Camera)(object)typeName).WorldToViewportPoint(vector2);
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v56+8]");
		_ = 0;
		object obj10 = obj2 + 52;
		obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v56+8]");
		_ = 0;
		object obj11 = obj2 + 40;
		obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
		_ = 0;
		float farClipPlane = ((Camera)(object)stackTrace).farClipPlane;
		float fieldOfView = ((Camera)(object)stackTrace).fieldOfView;
		float farClipPlane2 = ((Camera)(object)stackTrace).farClipPlane;
		object obj12 = obj2 + 28;
		obj12 = 0;
		_ = 0;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ S0_v65+4]");
		_ = 0;
		float num5 = fieldOfView - farClipPlane2;
		float num6 = num5 * 0.5f;
		float num7 = farClipPlane + num6;
		((Vector3*)(nint)vector2)->x = (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S0_v76+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		object obj13 = obj2 + 16;
		Vector3 vector6 = ((Camera)(object)stackTrace).ScreenToViewportPoint(vector2);
		((Vector3*)(nint)vector2)->x = (float)obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ S0_v84+8]");
		((Vector3*)(nint)vector2)->z = 0f;
		Vector3 localPosition = ((Transform)vector2).localPosition;
	}

	public unsafe Console()
	{
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected VT, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0042: Expected Obj, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected Obj, but got Unknown
		//IL_0074: Expected F4, but got Obj
		//IL_006f: Expected native int or pointer, but got VT
		//IL_0089: Expected F4, but got I
		//IL_0084: Expected native int or pointer, but got VT
		//IL_00a8: Expected Obj, but got I4
		//IL_00b5: Expected F4, but got Obj
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00c7: Expected F4, but got Obj
		//IL_00c2: Expected native int or pointer, but got VT
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		//IL_00df: Expected Obj, but got F4
		GUILayout.LayoutedWindow layoutedWindow = default;
		Rect rect = (Rect)(layoutedWindow + 32);
		object obj = layoutedWindow + 16;
		if (~(show ? 1u : 0u) == 0)
		{
			obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			GUIContent gUIContent = default;
			gUIContent.m_Text = (string)0;
			_ = 0;
			object obj2 = gUIContent + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A40");
			((Rect*)(nint)rect)->m_XMin = (float)obj;
			Rect rect2 = rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((Rect*)(nint)rect2)->m_Width = 0f;
			GUIStyle style = default;
			layoutedWindow._002Ector((GUI.WindowFunction)123456, rect, gUIContent, (GUILayoutOption[])(object)"Console", style);
			((Rect*)(nint)rect)->m_XMin = (float)layoutedWindow;
			((Rect*)(nint)rect)->m_Width = (float)layoutedWindow.m_Func;
			object obj3 = this + 32;
			obj3 = rect.m_XMin;
			_ = rect.m_Width;
		}
	}

	static Console()
	{
		//IL_006b: Expected I, but got Obj
		//IL_0081: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug._002Ecctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EventRemoteLogger.Event obj2 = default;
		obj2._002Ector();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}
}
