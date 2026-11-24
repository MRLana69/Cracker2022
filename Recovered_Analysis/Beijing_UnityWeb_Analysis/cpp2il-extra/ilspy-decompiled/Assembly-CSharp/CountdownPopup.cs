using System;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class CountdownPopup : UIScreen
{
	private UILabel _countdownStartingLabel;

	private UILabel _countdownLabel;

	private Vector3 _cachedCountdownLabelScale;

	private CountdownPopupManager _countdownPopupManager;

	public override void Init()
	{
	}

	public override void Show()
	{
		//IL_0038: Expected I4, but got Obj
		//IL_0048: Expected I4, but got Obj
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		ShowIfInactive();
		_countdownStartingLabel.fontSize = (int)"";
		_countdownLabel.fontSize = (int)"";
		object obj = this + 60;
		DeviceInfo instance = DeviceInfo.Instance;
		obj = instance;
	}

	public unsafe override void Hide()
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected Obj, but got Unknown
		base.Hide();
		CountdownPopupManager countdownPopupManager = _countdownPopupManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(CountdownPopup.OnCountdownEnded);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = _countdownPopupManager + 40;
		Delegate obj4 = ((Delegate)countdownPopupManager.OnCountdownEnded__BackingField).CombineImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
	}

	private unsafe void Update()
	{
		//IL_0025: Expected I4, but got Obj
		//IL_0035: Expected I4, but got Obj
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected Obj, but got Unknown
		base.LoseFocus();
		CountdownPopupManager countdownPopupManager = _countdownPopupManager;
		if (~(countdownPopupManager.IsCountdownActive__BackingField ? 1u : 0u) == 0)
		{
			_countdownPopupManager.CountdownEnded();
		}
		_countdownStartingLabel.fontSize = (int)"";
		_countdownLabel.fontSize = (int)"";
		CountdownPopupManager countdownPopupManager2 = _countdownPopupManager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		Delegate obj = default;
		obj.method_ptr = method_ptr;
		obj.method = (nint)__ldftn(CountdownPopup.OnCountdownEnded);
		object obj2 = obj + 16;
		obj2 = this;
		object obj3 = _countdownPopupManager + 40;
		Delegate obj4 = ((Delegate)countdownPopupManager2.OnCountdownEnded__BackingField).RemoveImpl(obj);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj5 = default;
		obj3 = obj5;
	}

	private unsafe void OnCountdownEnded()
	{
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected VT, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected VT, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected Obj, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected Obj, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected Obj, but got Unknown
		//IL_037c: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_03ed: Expected I4, but got Obj
		//IL_0405: Expected I, but got Obj
		//IL_041b: Expected Obj, but got I
		//IL_0452: Expected Obj, but got I4
		//IL_00e2: Expected I, but got Obj
		//IL_012f: Expected I, but got Obj
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected Obj, but got Unknown
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_0486: Expected F4, but got Obj
		//IL_0481: Expected native int or pointer, but got VT
		//IL_049b: Expected F4, but got I
		//IL_0496: Expected native int or pointer, but got VT
		//IL_04a8: Expected F4, but got Obj
		//IL_04a3: Expected native int or pointer, but got VT
		//IL_04bd: Expected F4, but got I
		//IL_04b8: Expected native int or pointer, but got VT
		//IL_01b1: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I4
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_050e: Expected F4, but got Obj
		//IL_0509: Expected native int or pointer, but got VT
		//IL_0523: Expected F4, but got I
		//IL_051e: Expected native int or pointer, but got VT
		//IL_053b: Expected I, but got Obj
		//IL_0551: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		//IL_057b: Expected Obj, but got F4
		//IL_05cc: Expected F4, but got Obj
		//IL_05c7: Expected native int or pointer, but got VT
		//IL_05e1: Expected F4, but got I
		//IL_05dc: Expected native int or pointer, but got VT
		//IL_05ff: Expected F4, but got Obj
		//IL_05fa: Expected native int or pointer, but got VT
		//IL_0614: Expected F4, but got I
		//IL_060f: Expected native int or pointer, but got VT
		//IL_0621: Expected Obj, but got VT
		//IL_0290: Expected VT, but got Obj
		//IL_0290: Expected Obj, but got VT
		//IL_02ee: Expected I, but got Obj
		//IL_02a2: Expected native int or pointer, but got VT
		//IL_02b4: Expected native int or pointer, but got VT
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected Obj, but got Unknown
		//IL_02d1: Expected Obj, but got F4
		object obj = default;
		Vector3 vector = (Vector3)(obj + 52);
		Vector3 vector2 = (Vector3)(obj + 40);
		object obj2 = obj + 12;
		object obj3 = obj + 28;
		object obj4 = obj + 24;
		obj4 = 0;
		CountdownPopupManager countdownPopupManager = _countdownPopupManager;
		if (~(countdownPopupManager.IsCountdownActive__BackingField ? 1u : 0u) != 0)
		{
			return;
		}
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v24 (Il2CppClass<UIScreenController>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v72 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v29 (System.Boolean)+58]");
		if ((nint)0 == 0)
		{
			return;
		}
		nint num3 = (nint)typeof(Strings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S1_v12 (Il2CppClass<Strings>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num4 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S1_v94 (Il2CppClass<Strings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = Strings.GetDefault("INGAME_UI_COUNTDOWN_STARTING");
		_countdownStartingLabel.fontSize = (int)text;
		CountdownPopupManager countdownPopupManager2 = _countdownPopupManager;
		nint num5 = (nint)typeof(Mathf);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v23 (Il2CppClass<UnityEngine.Mathf>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(Mathf);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v90 (Il2CppClass<UnityEngine.Mathf>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num7 = Mathf.FloorToInt(countdownPopupManager2.CountdownInSeconds__BackingField);
		obj4 = num7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D63B");
		int fontSize = default;
		_countdownLabel.fontSize = fontSize;
		if (!_countdownLabel.isActiveAndEnabled)
		{
			_countdownStartingLabel.tag = (string)1;
			_countdownLabel.tag = (string)1;
		}
		object obj8 = this + 48;
		obj2 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S1_v33+8]");
		_ = 0;
		nint num8 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v43 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num9 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S0_v64 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		((Vector3*)(nint)vector2)->x = (float)obj2;
		Vector3 vector3 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector3)->z = 0f;
		((Vector3*)(nint)vector)->x = (float)obj;
		Vector3 vector4 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((Vector3*)(nint)vector4)->z = 0f;
		if (vector2 != vector)
		{
			Camera anchorCamera = _countdownLabel.anchorCamera;
			((Transform)vector2).localScale = (Vector3)anchorCamera;
			((Vector3*)(nint)vector)->x = vector2.x;
			((Vector3*)(nint)vector)->z = vector2.z;
			object obj10 = this + 48;
			obj10 = vector.x;
			_ = vector.z;
		}
		Camera anchorCamera2 = _countdownLabel.anchorCamera;
		object obj11 = this + 48;
		((Vector3*)(nint)vector2)->x = (float)obj11;
		Vector3 vector5 = vector2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ S2_v15+8]");
		((Vector3*)(nint)vector5)->z = 0f;
		CountdownPopupManager countdownPopupManager3 = _countdownPopupManager;
		nint num10 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v56 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num11 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v72 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = vector2.x;
		_ = vector2.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CE");
		object obj13 = default;
		float num12 = 1f - (float)obj13;
		float num13 = num12 * 0.5f;
		float num14 = num13 + 1f;
		((Vector3*)(nint)vector)->x = (float)obj3;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v15+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		Vector3 vector7 = vector / num14;
		((Vector3*)(nint)vector)->x = (float)obj2;
		Vector3 vector8 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
		((Vector3*)(nint)vector8)->z = 0f;
		((Transform)(object)anchorCamera2).parent = (Transform)vector;
	}

	public CountdownPopup()
	{
		//IL_00af: Expected I4, but got Obj
		//IL_00bf: Expected I4, but got Obj
		//IL_001f: Expected I, but got Obj
		//IL_0035: Expected Obj, but got I
		//IL_00e2: Expected Obj, but got I4
		//IL_0060: Expected I, but got Obj
		_countdownStartingLabel.fontSize = (int)"";
		_countdownLabel.fontSize = (int)"";
		_countdownStartingLabel.tag = null;
		_countdownLabel.tag = null;
		nint num = (nint)typeof(UIScreenController);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14 (Il2CppClass<UIScreenController>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<UIScreenController>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = UIScreenController.ShouldShowOnlineScreen();
		((UIScreenController)flag).DebugCloseAllPopups();
	}
}
