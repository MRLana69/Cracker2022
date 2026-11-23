using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public class NGUIDebug : MonoBehaviour
{
	private static bool mRayDebug = false;

	private static List<string> mLines;

	private static NGUIDebug mInstance;

	public static bool debugRaycast
	{
		get
		{
			return mRayDebug;
		}
		set
		{
			mRayDebug = value;
			if (value && Application.isPlaying)
			{
				CreateInstance();
			}
		}
	}

	public static void CreateInstance()
	{
		if (mInstance == null)
		{
			GameObject gameObject = default;
			gameObject._002Ector("_NGUI Debug");
			NGUIDebug nGUIDebug = gameObject.AddComponent<NGUIDebug>();
			mInstance = nGUIDebug;
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
		}
	}

	private static void LogString(string text)
	{
		if (Application.isPlaying)
		{
			List<string> list = mLines;
			if (list._size >= 21)
			{
				mLines.RemoveAt(0);
			}
			mLines.Add(text);
			CreateInstance();
		}
	}

	public static void Log(object[] objs)
	{
		//IL_0116: Expected Obj, but got I4
		//IL_00a0: Expected Obj, but got I
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected Obj, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected Obj, but got Unknown
		//IL_0047: Expected I, but got Obj
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected Obj, but got Unknown
		object obj = 0;
		string text = string.Empty;
		string text3 = default;
		string text4 = default;
		while (objs.Length > (nint)obj)
		{
			string text2;
			if (obj == null)
			{
				object obj2 = objs[0];
				nint num = (nint)obj2;
				object obj3 = obj2 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v53 @ S2_v9 (Il2CppClass<System.Object>)+D4] (should have been resolved before IL gen)");
				text2 = text + text3;
			}
			else
			{
				object obj4 = obj << 2;
				object obj5 = (object)objs + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S0_v23+10]");
				object obj6 = 0;
				object obj7 = obj6;
				object obj8 = obj6 + 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S1_v10+D4] (should have been resolved before IL gen)");
				text2 = text + ", " + text4;
			}
			object obj9 = obj + 1;
			obj = obj9;
			text = text2;
		}
		LogString(text);
	}

	public static void Clear()
	{
		((List<T>)(object)mLines).Clear();
	}

	public unsafe static void DrawBounds(Bounds b)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_01f3: Expected Obj, but got I
		//IL_0210: Expected Obj, but got I
		//IL_025b: Expected Obj, but got I
		//IL_0278: Expected Obj, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected VT, but got Unknown
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected VT, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected VT, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected VT, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected VT, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected VT, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected VT, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected VT, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected VT, but got Unknown
		//IL_00fd: Expected native int or pointer, but got VT
		//IL_013f: Expected native int or pointer, but got VT
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected VT, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected VT, but got Unknown
		object obj = default;
		Color color = (Color)(obj - 400);
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = b.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+180]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+180]");
		object obj2 = num - 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+184]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+184]");
		object obj3 = num2 - 0;
		_ = b.m_Center;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+8]");
		_ = 0;
		_ = b.m_Extents;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [b @ L0 (UnityEngine.Bounds)+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+180]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+180]");
		object obj4 = num3 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+184]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+184]");
		object obj5 = num4 + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+178]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+168]");
		_ = 0;
		_ = 1065353216;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+170]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+160]");
		_ = 0;
		Vector3 start = (Vector3)(color + 176);
		Vector3 end = (Vector3)(color + 160);
		Color color2 = color + 144;
		Debug.DrawLine(start, end, color2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+148]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+138]");
		_ = 0;
		_ = 1065353216;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+140]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+130]");
		_ = 0;
		Vector3 start2 = (Vector3)(color + 128);
		Vector3 end2 = (Vector3)(color + 112);
		Color color3 = color + 96;
		Debug.DrawLine(start2, end2, color3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		_ = 4575657221408423936L;
		_ = 4575657221408423936L;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+118]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+108]");
		_ = 0;
		_ = 1065353216;
		_ = 1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+110]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+100]");
		_ = 0;
		Vector3 start3 = (Vector3)(color + 80);
		Vector3 end3 = (Vector3)(color - -64);
		Color color4 = color + 48;
		Debug.DrawLine(start3, end3, color4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+188]");
		_ = 0;
		_ = 4575657221408423936L;
		((Color*)(nint)color)->b = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D8]");
		_ = 0;
		_ = 1065353216;
		((Color*)(nint)color)->r = 1f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+E0]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Color)+D0]");
		_ = 0;
		Vector3 start4 = (Vector3)(color + 32);
		Vector3 end4 = (Vector3)(color + 16);
		Debug.DrawLine(start4, end4, color);
	}

	private unsafe void OnGUI()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected Obj, but got Unknown
		//IL_0895: Expected Obj, but got I8
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected VT, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected VT, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected VT, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected VT, but got Unknown
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected VT, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0993: Expected VT, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected VT, but got Unknown
		//IL_09f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f5: Expected VT, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected VT, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected VT, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected VT, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected VT, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected VT, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected VT, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected VT, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected VT, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected VT, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected VT, but got Unknown
		//IL_064f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0654: Expected VT, but got Unknown
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected VT, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ed: Expected I4, but got Unknown
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected VT, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected VT, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected VT, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected VT, but got Unknown
		object obj2 = default;
		object obj = obj2 - 640;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 18f;
		_ = 1000f;
		_ = 5f;
		_ = 5f;
		if (~(mRayDebug ? 1u : 0u) == 0)
		{
			UICamera.ControlScheme currentScheme = UICamera.currentScheme;
			Enum obj3 = (Enum)(obj + 424);
			_ = -1;
			obj3 = (Enum)(object)typeof(UICamera.ControlScheme);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+26C]");
			_ = 0;
			string text = obj3.ToString();
			string text2 = "Scheme: " + text;
			_ = 4575657221408423936L;
			_ = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color color = (Color)(obj + 376);
			GUI.color = color;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position = (Rect)(obj + 360);
			GUI.Label(position, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num = 0f - 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num2 = 0f - 1f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color2 = (Color)(obj + 344);
			GUI.color = color2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position2 = (Rect)(obj + 328);
			GUI.Label(position2, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num3 = 0f + 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num4 = 0f + 1f;
			GameObject hoveredObject = UICamera.hoveredObject;
			string hierarchy = NGUITools.GetHierarchy(hoveredObject);
			string text3 = hierarchy.Replace("\"", string.Empty);
			string text4 = "Hover: " + text3;
			_ = 4575657221408423936L;
			_ = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color color3 = (Color)(obj + 312);
			GUI.color = color3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position3 = (Rect)(obj + 296);
			GUI.Label(position3, text4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num5 = 0f - 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num6 = 0f - 1f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color4 = (Color)(obj + 280);
			GUI.color = color4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position4 = (Rect)(obj + 264);
			GUI.Label(position4, text4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num7 = 0f + 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num8 = 0f + 1f;
			GameObject selectedObject = UICamera.selectedObject;
			string hierarchy2 = NGUITools.GetHierarchy(selectedObject);
			string text5 = hierarchy2.Replace("\"", string.Empty);
			string text6 = "Selection: " + text5;
			_ = 4575657221408423936L;
			_ = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color color5 = (Color)(obj + 248);
			GUI.color = color5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position5 = (Rect)(obj + 232);
			GUI.Label(position5, text6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num9 = 0f - 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num10 = 0f - 1f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color6 = (Color)(obj + 216);
			GUI.color = color6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position6 = (Rect)(obj + 200);
			GUI.Label(position6, text6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num11 = 0f + 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num12 = 0f + 1f;
			GameObject controllerNavigationObject = UICamera.controllerNavigationObject;
			string hierarchy3 = NGUITools.GetHierarchy(controllerNavigationObject);
			string text7 = hierarchy3.Replace("\"", string.Empty);
			string text8 = "Controller: " + text7;
			_ = 4575657221408423936L;
			_ = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color color7 = (Color)(obj + 184);
			GUI.color = color7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position7 = (Rect)(obj + 168);
			GUI.Label(position7, text8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num13 = 0f - 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num14 = 0f - 1f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color8 = (Color)(obj + 152);
			GUI.color = color8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position8 = (Rect)(obj + 136);
			GUI.Label(position8, text8);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num15 = 0f + 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num16 = 0f + 1f;
			int num17 = UICamera.CountInputSources();
			int num18 = obj + 616;
			string text9 = ((int*)num18)->ToString();
			string text10 = "Active events: " + text9;
			bool disableController = UICamera.disableController;
			bool flag = !disableController;
			string text11 = text10;
			if (!flag)
			{
				string text12 = text10 + ", disabled controller";
				text11 = text12;
			}
			if (UICamera.inputHasFocus)
			{
				string text13 = text11 + ", input focus";
				text11 = text13;
			}
			_ = 4575657221408423936L;
			_ = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color color9 = (Color)(obj + 120);
			GUI.color = color9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position9 = (Rect)(obj + 104);
			GUI.Label(position9, text11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num19 = 0f - 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num20 = 0f - 1f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color10 = (Color)(obj + 88);
			GUI.color = color10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			Rect position10 = (Rect)(obj + 72);
			GUI.Label(position10, text11);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num21 = 0f + 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num22 = 0f + 1f;
		}
		List<string> list = mLines;
		int num23 = 0;
		while (num23 < list._size)
		{
			_ = 4575657221408423936L;
			object obj4 = obj - -64;
			obj4 = 4575657221408423936L;
			_ = 0;
			_ = 0;
			Color color11 = (Color)(obj + 56);
			GUI.color = color11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			string text14 = mLines.get_Item(num23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1B0]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+1A8]");
			_ = 0;
			Rect position11 = (Rect)(obj + 40);
			GUI.Label(position11, text14);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num24 = 0f - 1f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num25 = 0f - 1f;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			_ = 4575657222473777152L;
			Color color12 = (Color)(obj + 24);
			GUI.color = color12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+278]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			_ = 0;
			string text15 = mLines.get_Item(num23);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+190]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+188]");
			_ = 0;
			Rect position12 = (Rect)(obj + 8);
			GUI.Label(position12, text15);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+274]");
			float num26 = 0f + 18f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+270]");
			float num27 = 0f + 1f;
			int num28 = num23 + 1;
			num23 = num28;
		}
	}

	static NGUIDebug()
	{
		List<string> list = default;
		list._002Ector();
		mLines = list;
		mInstance = null;
	}
}
